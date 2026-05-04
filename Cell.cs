using System;
using System.Windows.Forms;

namespace Game_of_live
{
    public class Cell
    {
        public PictureBox PicturesBox;
        public bool life;
        bool first = true;

        public Cell()
        {
            PicturesBox = new PictureBox();
            life = false;
            PicturesBox.Size = new System.Drawing.Size(20, 20);
            PicturesBox.Click += Clickn;
            PicturesBox.BackColor = System.Drawing.Color.Black;
        }
        public void Clickn(object sender, EventArgs e)
        {

            life = true;

            if (life && first)
            {
                PicturesBox.BackColor = System.Drawing.Color.White;
                first = false;
            }
            else if (life && !first)
            {
                PicturesBox.BackColor = System.Drawing.Color.Black;
                life = false;
                first = true;
            }
        }

        public void Colorchange()
        {
            if (!life)
            {
            }

            if (life)
            {
                PicturesBox.BackColor = System.Drawing.Color.White;
            }
            else
            {
                PicturesBox.BackColor = System.Drawing.Color.Black;
            }
        }

    }
}