using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_of_live
{

    public partial class Form1 : Form
    {
        const int mapSize = 50;
        Cell[,] cells = new Cell[mapSize, mapSize];
        Cell[,] cellssec = new Cell[mapSize, mapSize];
        bool playgame = false;
        int glifecounter = 0;
        int delayUI = 0;
        public Form1()
        {
            InitializeComponent();
            initialize();
        }


        public void initialize()
        {
            for (int j = 0; j < mapSize; j++)
            {
                for (int i = 0; i < mapSize; i++)
                {
                    Cell myCell = new Cell();
                    Cell myseccell = new Cell();
                    cells[j, i] = myCell;
                    cellssec[j, i] = myseccell;
                    myCell.myButton.Location = new System.Drawing.Point(i * 21, 21 * j);
                    myCell.myButton.Text = Convert.ToString(cells[j, i]);
                    myCell.myButton.Tag = cells[j, i];
                    Controls.Add(myCell.myButton);
                }
            }
        }

        public async void cellupdate()
        {

            do
            {

                for (int y = 0; y < mapSize; y++)
                {
                    for (int x = 0; x < mapSize; x++)
                    {

                        int lifeCounter = 0;

                        Cell nextstep = cellssec[y, x];

                        for (int i = -1; i <= 1; i++)
                        {
                            for (int j = -1; j <= 1; j++)
                            {
                                if (!(i == 0 && j == 0))
                                {

                                    int neigborY = y + i;
                                    int neigborX = x + j;
                                    if (neigborY >= 0 && neigborY <= mapSize - 1 && neigborX >= 0 && neigborX <= mapSize - 1)
                                    {
                                        Cell neightborcell = cells[neigborY, neigborX];
                                        if (neightborcell.life || neightborcell.slife)                  //Wenn normale mode spielen dann neightborcell.slife entfernen
                                        {
                                            lifeCounter += 1;
                                        }
                                    }
                                }
                            }
                        }

                        if (lifeCounter > 3 || lifeCounter < 2)                                 //1) 2Leben
                        {
                            if (cells[y, x].slife)
                            {
                                nextstep.slife = false;
                            }
                            else
                            {
                                nextstep.slife = false;
                                nextstep.life = false;
                            }
                        }
                        else if (lifeCounter == 2 && cells[y, x].slife)
                        {
                            nextstep.slife = true;
                        }

                        else if (lifeCounter == 2 && cells[y, x].life)
                        {
                            nextstep.slife = true;
                            nextstep.life = true;
                        }
                        else if (lifeCounter == 3)
                        {
                            nextstep.slife = true;
                            nextstep.life = true;
                        }





                        //if (lifeCounter > 3 || lifeCounter < 2)    //2) Normale regeln
                        //{
                        //        nextstep.life = false;  
                        //}
                        //else if (lifeCounter == 2 && cells[y, x].life)
                        //{
                        //   nextstep.life = true;
                        //}
                        //else if (lifeCounter == 3)
                        //{
                        //    nextstep.life = true;
                        //}






                    }

                }

                for (int l = 0; l < mapSize; l++)
                {
                    for (int c = 0; c < mapSize; c++)
                    {
                        cells[l, c].life = cellssec[l, c].life;
                        cells[l, c].slife = cellssec[l, c].slife;                       // Wenn normale mode spielen diese column entfernen
                        cells[l, c].colorchange();
                        if (cells[l, c].life)
                        {
                            label1.Text = "LIfe: " + Convert.ToString(glifecounter += 1);
                        }
                    }

                }
                glifecounter = 0;


                await Task.Delay(delayUI);
            }
            while (playgame);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            cellupdate();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!playgame)
            {
                playgame = true;
                cellupdate();
            }
            else
            {
                playgame = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            delayUI = trackBar1.Value;
        }
    }
}
