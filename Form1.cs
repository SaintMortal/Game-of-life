using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_of_live
{

    public partial class Form1 : Form
    {
        private Cell[,] cells = new Cell[Constants.MAP_SIZE, Constants.MAP_SIZE];
        private Cell[,] buffer = new Cell[Constants.MAP_SIZE, Constants.MAP_SIZE];
        bool isPlayingGame = false;
        int glifecounter = 0;

        public Form1()
        {
            InitializeComponent();
            Initialize();
        }


        public void Initialize()
        {
            for (int i = 0; i < Constants.MAP_SIZE; i++)
            {
                for (int j = 0; j < Constants.MAP_SIZE; j++)
                {
                    Cell cell = new Cell();
                    Cell bufferCell = new Cell();
                    cells[i, j] = cell;
                    buffer[i, j] = bufferCell;
                    cell.PicturesBox.Location = new System.Drawing.Point(j * Constants.CELL_SPACING, Constants.CELL_SPACING * i);
                    Controls.Add(cell.PicturesBox);
                }
            }
        }

        public async void HandleCellUpdate()
        {

            do
            {
                UpdateCells();
                await Task.Delay(SpeedSlider.Value);
            }
            while (isPlayingGame);
        }

        private void UpdateCells()
        {
            for (int x = 0; x < Constants.MAP_SIZE; x++)
            {
                for (int y = 0; y < Constants.MAP_SIZE; y++)
                {

                    int lifeCounter = 0;
                    Cell currentBufferCell = buffer[x, y];
                    Cell currentCell = cells[x, y];

                    for (int i = -1; i <= 1; i++)
                    {
                        for (int j = -1; j <= 1; j++)
                        {
                            if (!(i == 0 && j == 0))
                            {

                                int neighborX = x + i;
                                int neighborY = y + j;
                                if (neighborX >= 0 && neighborX <= Constants.MAP_SIZE - 1 && neighborY >= 0 && neighborY <= Constants.MAP_SIZE - 1)
                                {
                                    Cell neighborCell = cells[neighborX, neighborY];
                                    if (neighborCell.life)
                                    {
                                        lifeCounter += 1;
                                    }
                                }
                            }
                        }
                    }

                    if (lifeCounter > Constants.MAX_NEIGHBORS_TO_SURVIVE || lifeCounter < Constants.MIN_NEIGHBORS_TO_SURVIVE)
                    {
                        currentBufferCell.life = false;
                    }
                    else if (lifeCounter == Constants.MIN_NEIGHBORS_TO_SURVIVE && currentCell.life)
                    {
                        currentBufferCell.life = true;
                    }
                    else if (lifeCounter == Constants.NEIGHBORS_TO_BIRTH)
                    {
                        currentBufferCell.life = true;
                    }
                }

            }

            bool hasActiveCell = false;

            for (int l = 0; l < Constants.MAP_SIZE; l++)
            {
                for (int c = 0; c < Constants.MAP_SIZE; c++)
                {
                    cells[l, c].life = buffer[l, c].life;
                    bool isInLife = cells[l, c].life;
                    cells[l, c].Colorchange();
                    if (isInLife)
                    {
                        hasActiveCell = true;
                        ScoreLabel.Text = "LIfe: " + Convert.ToString(glifecounter += 1);
                    }
                }
            }

            if (!hasActiveCell)
            {
                ScoreLabel.Text = "Has no life!";
            }

            glifecounter = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateCells();
        }
        private void ResetHandle_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Constants.MAP_SIZE; i++)
            {
                for (int j = 0; j < Constants.MAP_SIZE; j++)
                {
                    cells[i, j].life = false;
                    cells[i, j].Colorchange();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!isPlayingGame)
            {
                isPlayingGame = true;
                HandleCellUpdate();
                LoopTriger.Text = "Stop";
            }
            else
            {
                isPlayingGame = false;
                LoopTriger.Text = "Start";
            }
        }

        private void CloseOpenPanelHandle_Click(object sender, EventArgs e)
        {
            UiConteiner.Visible = !UiConteiner.Visible;
        }
    }
}