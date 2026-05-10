using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Dynamic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;

namespace GameOfLife
{

    public partial class Form1 : Form
    {
        private Cell[,] cells = new Cell[Constants.MAP_SIZE, Constants.MAP_SIZE];
        private Cell[,] buffer = new Cell[Constants.MAP_SIZE, Constants.MAP_SIZE];
        List<Pattern> patterns = new List<Pattern>();
        private int GlobalId = 0;

        bool isPlayingGame = false;
        int glifecounter = 0;

        public Form1()
        {
            InitializeComponent();
            Initialize();
            try
            {
                if (!File.Exists(Constants.PATTERNS_JSON_FILE))
                {
                    var emptyPatternList = new JsonObject
                    {
                        ["patterns"] = new JsonArray()
                    };

                    string emptyPatternsListJson = JsonSerializer.Serialize(
                    emptyPatternList,
                    new JsonSerializerOptions
                    {
                        WriteIndented = true
                    });
                    File.WriteAllText(Constants.PATTERNS_JSON_FILE, emptyPatternsListJson);
                }
                else
                {
                    var patternJsonBytes = File.ReadAllBytes(Constants.PATTERNS_JSON_FILE);
                    var reader = new Utf8JsonReader(patternJsonBytes);
                    string json = File.ReadAllText(Constants.PATTERNS_JSON_FILE);

                    JsonObject jsonObject = JsonNode.Parse(json).AsObject();

                    patterns = jsonObject["patterns"]
                        .Deserialize<List<Pattern>>() ?? new List<Pattern>();
                    foreach (Pattern pattern in patterns)
                    {
                        if(GlobalId < pattern.id)
                        {
                        GlobalId = pattern.id;
                        }
                    comboBox1.Items.Add(pattern.name);
                    }
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error accessing patterns JSON file" + ex.Message);
            }
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
                    cell.PicturesBox.Location = new Point(j * Constants.CELL_SPACING, Constants.CELL_SPACING * i);
                    Controls.Add(cell.PicturesBox);
                }
            }
        }

        public void InitializeThePattern(Pattern initThePattern)
        {
            for (int i = 0; i < Constants.MAP_SIZE; i++)
            {
                for (int j = 0; j < Constants.MAP_SIZE; j++)
                {
                    if (initThePattern.Cells.Exists(cellLife => cellLife.x == i && cellLife.y == j))
                    {
                        cells[i, j].life = true;
                        cells[i, j].Colorchange();
                    }
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
            if (isPlayingGame)
            {
                isPlayingGame = false;
                LoopTriger.Text = "Start";
            }
            if(checkLifeCells() == 0)
            {
                MessageBox.Show("There are no life cells to update, please create a pattern with at least one life cell to be able to update it");
                return;
            }
            UpdateCells();
        }
        private void ResetHandle_Click(object sender, EventArgs e)
        {
            if (isPlayingGame)
            {
                isPlayingGame = false;
                LoopTriger.Text = "Start";
            }
            if (checkLifeCells() == 0)
            {
                MessageBox.Show("There are no life cells to reset, please create a pattern with at least one life cell to be able to reset it");
            }
            else
            {
                ResetThePlayground();
            }
        }

        private void ResetThePlayground()
        {
            glifecounter = 0;
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

            if (UiConteiner.Visible)
            {

                var bitmapCloseMenu = new Bitmap(Resources.close);

                var bitmapCloseMenuResized = new Bitmap(bitmapCloseMenu, new Size(16, 16));
                CloseOpenPanelHandle.Image = bitmapCloseMenuResized;
            }
            else
            {
                var bitmapHamburgerMenu = new Bitmap(Resources.hamburger_menu);

                var bitmapHamburgerMenuResized = new Bitmap(bitmapHamburgerMenu, new Size(20, 20));
                CloseOpenPanelHandle.Image = bitmapHamburgerMenuResized;
            }
        }
        private void Save_Click(object sender, EventArgs e)
        {
            if (InputFormForNaming.Text.Contains(" "))
            {
                MessageBox.Show("The pattern name cannot contain spaces, please change the name of your pattern to be able to save it");
                return;
            }
            if (checkLifeCells() == 0)
            {
                MessageBox.Show("There are no life cells to save, please create a pattern with at least one life cell to be able to save it");
            }
            else
            {
                if (InputFormForNaming.Text != "")
                {
                    int doublepatternCounter = 0;
                    foreach (Pattern pattern in patterns)
                    {
                        if (String.Compare(pattern.name, InputFormForNaming.Text) == 0)
                        {
                            doublepatternCounter++;
                        }
                    }

                    if (doublepatternCounter > 0)
                    {
                        MessageBox.Show("There are multiple patterns with the same name, please change the name of one of them to avoid confusion");
                        return;
                    }

                    patterns.Add(new Pattern
                    {
                        id = ++GlobalId,
                        name = InputFormForNaming.Text,
                        Cells = new List<Cell>()
                    });

                    Pattern lastPattern = patterns.FindLast(p => true);

                    comboBox1.Items.Add(lastPattern.name);

                    for (int x = 0; x < Constants.MAP_SIZE; x++)
                    {
                        for (int y = 0; y < Constants.MAP_SIZE; y++)
                        {
                            if (cells[x, y].life)
                            {
                                lastPattern.Cells.Add(new Cell
                                {
                                    x = x,
                                    y = y,
                                    life = true
                                });
                            }
                        }
                    }

                    var options = new JsonSerializerOptions
                    {
                        WriteIndented = true
                    };

                    JsonObject jsonObject = new JsonObject
                    {
                        ["patterns"] = JsonSerializer.SerializeToNode(patterns)
                    };

                    string jsonString = jsonObject.ToJsonString(options);

                    try
                    {
                        File.WriteAllText(Constants.PATTERNS_JSON_FILE, jsonString);

                        MessageBox.Show("The pattern is saved!");
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine("Error saving a pattern: " + ex.Message);

                        MessageBox.Show("Error saving a pattern!");
                    }
                    InputFormForNaming.Text = "Pattern Name";
                    InputFormForNaming.ForeColor = Color.Gray;
                }
                else
                {
                    MessageBox.Show("Before saving your pattern, it needs a name");
                }
            }
        }

        private void LoadHandle_Click(object sender, EventArgs e)
        {
            

            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a pattern to load");
                return;
            }
            else
            {


                ResetThePlayground();
                foreach (Pattern pattern in patterns)
                {
                    if (pattern.name == comboBox1.SelectedItem.ToString())
                    {
                        InitializeThePattern(pattern);
                    }
                }
                try
                {
                    var fileBytes = File.ReadAllBytes(Constants.PATTERNS_JSON_FILE);
                    var reader = new Utf8JsonReader(fileBytes);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load the saved pattern");
                }
            }

        }

        private void InputFormForNaming_TextChanged(object sender, EventArgs e)
        {
        }

        private void InputFormForNaming_MouseClick(object sender, MouseEventArgs e)
        {
            if (InputFormForNaming.Text == "Pattern Name")
            {
                InputFormForNaming.Text = "";
                InputFormForNaming.ForeColor = Color.Black;
            }
        }

        private int checkLifeCells()
        {
            int count = 0;
            for (int x = 0; x < Constants.MAP_SIZE; x++)
            {
                for (int y = 0; y < Constants.MAP_SIZE; y++)
                {
                    if (cells[x, y].life)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}