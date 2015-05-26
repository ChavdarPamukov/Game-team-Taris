using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BStest1
{
    public partial class GameWindow : Form
    {
        Random Location = new Random();
        List<Point> pointimage = new List<Point>();

        public GameWindow()
        {
            InitializeComponent();
        }

        private void GameWindow_Load(object sender, EventArgs e)
        {
            foreach (PictureBox picture in PlayerAMap.Controls)
            {
                pointimage.Add(picture.Location);
            }

            foreach (PictureBox picture in PlayerAMap.Controls)
            {
                int next = Location.Next(pointimage.Count);
                Point p = pointimage[next];
                picture.Location = p;
                pointimage.Remove(p);
            }
            // Основни картинки за играч А
            #region BasedImageForPlayeA

            PABox1.Image = Properties.Resources.ship;
            PABox2.Image = Properties.Resources.ws;
            PABox3.Image = Properties.Resources.ship;
            PABox4.Image = Properties.Resources.ws;
            PABox5.Image = Properties.Resources.ship;
            PABox6.Image = Properties.Resources.ws;
            PABox7.Image = Properties.Resources.ws;
            PABox8.Image = Properties.Resources.ws;
            PABox9.Image = Properties.Resources.ws;
            PABox10.Image = Properties.Resources.ws;
            PABox11.Image = Properties.Resources.ws;
            PABox12.Image = Properties.Resources.ws;
            PABox13.Image = Properties.Resources.ws;
            PABox14.Image = Properties.Resources.ws;
            PABox15.Image = Properties.Resources.ws;
            PABox16.Image = Properties.Resources.ws;
            PABox17.Image = Properties.Resources.ws;
            PABox18.Image = Properties.Resources.ws;
            PABox19.Image = Properties.Resources.ws;
            PABox20.Image = Properties.Resources.ws;
            PABox21.Image = Properties.Resources.ws;
            PABox22.Image = Properties.Resources.ws;
            PABox23.Image = Properties.Resources.ws;
            PABox24.Image = Properties.Resources.ws;
            PABox25.Image = Properties.Resources.ws;

            #endregion

            foreach (PictureBox picture in PlayerBMap.Controls)
            {
                pointimage.Add(picture.Location);
            }

            foreach (PictureBox picture in PlayerBMap.Controls)
            {
                int next = Location.Next(pointimage.Count);
                Point p = pointimage[next];
                picture.Location = p;
                pointimage.Remove(p);
            }

            // Основни картинки за играч А
            #region BasedImageForPlayerB

            PBBox1.Image = Properties.Resources.ship;
            PBBox2.Image = Properties.Resources.ws;
            PBBox3.Image = Properties.Resources.ship;
            PBBox4.Image = Properties.Resources.ws;
            PBBox5.Image = Properties.Resources.ship;
            PBBox6.Image = Properties.Resources.ws;
            PBBox7.Image = Properties.Resources.ws;
            PBBox8.Image = Properties.Resources.ws;
            PBBox9.Image = Properties.Resources.ws;
            PBBox10.Image = Properties.Resources.ws;
            PBBox11.Image = Properties.Resources.ws;
            PBBox12.Image = Properties.Resources.ws;
            PBBox13.Image = Properties.Resources.ws;
            PBBox14.Image = Properties.Resources.ws;
            PBBox15.Image = Properties.Resources.ws;
            PBBox16.Image = Properties.Resources.ws;
            PBBox17.Image = Properties.Resources.ws;
            PBBox18.Image = Properties.Resources.ws;
            PBBox19.Image = Properties.Resources.ws;
            PBBox20.Image = Properties.Resources.ws;
            PBBox21.Image = Properties.Resources.ws;
            PBBox22.Image = Properties.Resources.ws;
            PBBox23.Image = Properties.Resources.ws;
            PBBox24.Image = Properties.Resources.ws;
            PBBox25.Image = Properties.Resources.ws;

            #endregion

            //Първоначални къртинки за играч А
            foreach (PictureBox picture in PlayerAMap.Controls)
            {
                picture.Image = Properties.Resources.cover;
            }

            //Първоначални къртинки за играч В
            foreach (PictureBox picture in PlayerBMap.Controls)
            {
                picture.Image = Properties.Resources.cover;
            }
        }

        //Смяна на картинките за играч А
        #region PlayerABox
        private void PABox1_Click(object sender, EventArgs e)
        {
            PABox1.Image = Properties.Resources.ship;
        }

        private void PABox2_Click(object sender, EventArgs e)
        {
            PABox2.Image = Properties.Resources.ws;
        }

        private void PABox3_Click(object sender, EventArgs e)
        {
            PABox3.Image = Properties.Resources.ship;
        }

        private void PABox4_Click(object sender, EventArgs e)
        {
            PABox4.Image = Properties.Resources.ws;
        }

        private void PABox5_Click(object sender, EventArgs e)
        {
            PABox5.Image = Properties.Resources.ship;
        }

        private void PABox6_Click(object sender, EventArgs e)
        {
            PABox6.Image = Properties.Resources.ws;
        }

        private void PABox7_Click(object sender, EventArgs e)
        {
            PABox7.Image = Properties.Resources.ws;
        }

        private void PABox8_Click(object sender, EventArgs e)
        {
            PABox8.Image = Properties.Resources.ws;
        }

        private void PABox9_Click(object sender, EventArgs e)
        {
            PABox9.Image = Properties.Resources.ws;
        }

        private void PABox10_Click(object sender, EventArgs e)
        {
            PABox10.Image = Properties.Resources.ws;
        }

        private void PABox11_Click(object sender, EventArgs e)
        {
            PABox11.Image = Properties.Resources.ws;
        }

        private void PABox12_Click(object sender, EventArgs e)
        {
            PABox12.Image = Properties.Resources.ws;
        }

        private void PABox13_Click(object sender, EventArgs e)
        {
            PABox13.Image = Properties.Resources.ws;
        }

        private void PABox14_Click(object sender, EventArgs e)
        {
            PABox14.Image = Properties.Resources.ws;
        }

        private void PABox15_Click(object sender, EventArgs e)
        {
            PABox15.Image = Properties.Resources.ws;
        }

        private void PABox16_Click(object sender, EventArgs e)
        {
            PABox16.Image = Properties.Resources.ws;
        }

        private void PABox17_Click(object sender, EventArgs e)
        {
            PABox17.Image = Properties.Resources.ws;
        }

        private void PABox18_Click(object sender, EventArgs e)
        {
            PABox18.Image = Properties.Resources.ws;
        }

        private void PABox19_Click(object sender, EventArgs e)
        {
            PABox19.Image = Properties.Resources.ws;
        }

        private void PABox20_Click(object sender, EventArgs e)
        {
            PABox20.Image = Properties.Resources.ws;
        }

        private void PABox21_Click(object sender, EventArgs e)
        {
            PABox21.Image = Properties.Resources.ws;
        }

        private void PABox22_Click(object sender, EventArgs e)
        {
            PABox22.Image = Properties.Resources.ws;
        }

        private void PABox23_Click(object sender, EventArgs e)
        {
            PABox23.Image = Properties.Resources.ws;
        }

        private void PABox24_Click(object sender, EventArgs e)
        {
            PABox24.Image = Properties.Resources.ws;
        }

        private void PABox25_Click(object sender, EventArgs e)
        {
            PABox25.Image = Properties.Resources.ws;
        }

        #endregion

        //Смяна на картинките за играч В
        #region PlayerBBox

        private void PBBox1_Click(object sender, EventArgs e)
        {
            PBBox1.Image = Properties.Resources.ship;
        }

        private void PBBox2_Click(object sender, EventArgs e)
        {
            PBBox2.Image = Properties.Resources.ws;
        }

        private void PBBox3_Click(object sender, EventArgs e)
        {
            PBBox3.Image = Properties.Resources.ship;
        }

        private void PBBox4_Click(object sender, EventArgs e)
        {
            PBBox4.Image = Properties.Resources.ws;
        }

        private void PBBox5_Click(object sender, EventArgs e)
        {
            PBBox5.Image = Properties.Resources.ship;
        }

        private void PBBox6_Click(object sender, EventArgs e)
        {
            PBBox6.Image = Properties.Resources.ws;
        }

        private void PBBox7_Click(object sender, EventArgs e)
        {
            PBBox7.Image = Properties.Resources.ws;
        }

        private void PBBox8_Click(object sender, EventArgs e)
        {
            PBBox8.Image = Properties.Resources.ws;
        }

        private void PBBox9_Click(object sender, EventArgs e)
        {
            PBBox9.Image = Properties.Resources.ws;
        }

        private void PBBox10_Click(object sender, EventArgs e)
        {
            PBBox10.Image = Properties.Resources.ws;
        }

        private void PBBox11_Click(object sender, EventArgs e)
        {
            PBBox11.Image = Properties.Resources.ws;
        }

        private void PBBox12_Click(object sender, EventArgs e)
        {
            PBBox12.Image = Properties.Resources.ws;
        }

        private void PBBox13_Click(object sender, EventArgs e)
        {
            PBBox13.Image = Properties.Resources.ws;
        }

        private void PBBox14_Click(object sender, EventArgs e)
        {
            PBBox14.Image = Properties.Resources.ws;
        }

        private void PBBox15_Click(object sender, EventArgs e)
        {
            PBBox15.Image = Properties.Resources.ws;
        }

        private void PBBox16_Click(object sender, EventArgs e)
        {
            PBBox16.Image = Properties.Resources.ws;
        }

        private void PBBox17_Click(object sender, EventArgs e)
        {
            PBBox17.Image = Properties.Resources.ws;
        }

        private void PBBox18_Click(object sender, EventArgs e)
        {
            PBBox18.Image = Properties.Resources.ws;
        }

        private void PBBox19_Click(object sender, EventArgs e)
        {
            PBBox19.Image = Properties.Resources.ws;
        }

        private void PBBox20_Click(object sender, EventArgs e)
        {
            PBBox20.Image = Properties.Resources.ws;
        }

        private void PBBox21_Click(object sender, EventArgs e)
        {
            PBBox21.Image = Properties.Resources.ws;
        }

        private void PBBox22_Click(object sender, EventArgs e)
        {
            PBBox22.Image = Properties.Resources.ws;
        }

        private void PBBox23_Click(object sender, EventArgs e)
        {
            PBBox23.Image = Properties.Resources.ws;
        }

        private void PBBox24_Click(object sender, EventArgs e)
        {
            PBBox24.Image = Properties.Resources.ws;
        }

        private void PBBox25_Click(object sender, EventArgs e)
        {
            PBBox25.Image = Properties.Resources.ws;
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            GameWindow_Load(sender, e);
        }
    }
}
