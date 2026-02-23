using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Forms;

namespace Game_of_live
{
    public class Cell
    {
        public PictureBox myButton;
        public bool life;
        public bool slife; // 2 Leben
        bool first = true;

        public Cell()
        {
            this.myButton = new PictureBox();
            this.life = false;
            this.myButton.Size = new System.Drawing.Size(20, 20);
            this.myButton.Click += clickn;
            this.myButton.BackColor = System.Drawing.Color.Black;
        }
        public void clickn(object sender, EventArgs e)
        {

            life = true;
            slife = true;

            if (life && first)
            {
                this.myButton.BackColor = System.Drawing.Color.White;
                first = false;
            }
            else if (life && !first)
            {
                this.myButton.BackColor = System.Drawing.Color.Black;
                life = false;
                slife = false;
                first = true;
            }
        }

        public void colorchange()
        {
            if (!life)
            {
                slife = false;
            }

            if (life && slife)
            {
                this.myButton.BackColor = System.Drawing.Color.White;
            }else if(life)
            {
                this.myButton.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                this.myButton.BackColor = System.Drawing.Color.Black;
            }
        }

    }
}