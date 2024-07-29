using System;
using System.Drawing;
using System.Windows.Forms;

namespace Aplicatie_educationala_pentru_invatarea_geografiei
{
    public partial class FormUnitatea2 : Form
    {
        private int index = 1;
        public FormUnitatea2()
        {
            InitializeComponent();

            pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea2/Unitatea2.1.png");

            PersonalizareButoane.SetButtonImageRegion(buttonBack, "C:/Terra/Back.png");
            PersonalizareButoane.SetButtonImageRegion(buttonAnteriorul, "C:/Terra/butonAnteriorul.png");
            PersonalizareButoane.SetButtonImageRegion(buttonUrmatorul, "C:/Terra/butonUrmatorul.png");
            pictureBoxBackground.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void FormUnitatea2_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.Owner.Hide();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void buttonUrmatorul_Click(object sender, EventArgs e)
        {
            index++;
            if(index == 2)
            {
                buttonAnteriorul.Visible = true;
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea2/Unitatea2.2.png");
            }
            if(index == 3)
            {
                pictureBoxLatitudine.Visible = true;
                pictureBoxLongitudine.Visible = true;

                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea2/Unitatea2.3.png");

            }
            if (index == 4)
            {
                pictureBoxLatitudine.Visible = false;
                pictureBoxLongitudine.Visible = false;

                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea2/Unitatea2.6.png");
            }
            if(index == 5)
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea2/Unitatea2.7.png");


            if(index == 6)
            {
                //pictureBoxMiscarePamant.Visible = false;
                pictureBoxMiscareRevolutie.Visible = true;

                pictureBoxBackground.Image = Image.FromFile("C:/Terra/Space.png");
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea2/Unitatea2.8.png");

            }
            if (index == 7)
            {
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea2/Unitatea2.9.png");
            }
            if (index == 8)
            {
                pictureBoxMiscarePamant.Visible = true;
                pictureBoxMiscareRevolutie.Visible = false;

                pictureBoxBackground.Image = Image.FromFile("C:/Terra/Unitatea2/WallpaperMiscarilePamantului.png");
                pictureBoxMiscarePamant.Image = Image.FromFile("C:/Terra/Unitatea2/Gif-MiscarilePamantului.gif");
                pictureBoxMiscarePamant.SizeMode = PictureBoxSizeMode.StretchImage;

                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea2/Unitatea2.10.png");
            }
            if (index == 9)
            {
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea2/Unitatea2.11.png");
            }
            if (index == 10)
            {
                pictureBoxBackground.Image = Image.FromFile("C:/Terra/Space.png");

                pictureBoxMiscarePamant.Visible = false;
                pictureBoxGMT.Visible = true;

                pictureBoxGMT.Location = new System.Drawing.Point(302, 225);

                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea2/Unitatea2.12.png");
            }
            if (index == 11)
            {
                pictureBoxGMT.Visible = false;

                pictureBoxOrientareZiua.Visible = true;
                pictureBoxOrientareNoaptea.Visible = true;

                pictureBoxOrientareZiua.Location = new System.Drawing.Point(289, 33);
                pictureBoxOrientareNoaptea.Location = new System.Drawing.Point(360, 491);

                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea2/Unitatea2.13.png");
            }
            if (index == 12)
            {
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea2/Unitatea2.14.png");
            }
            if (index == 13)
            {
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea2/Unitatea2.15.png");

                buttonUrmatorul.Visible = false;
            }
        }

        private void buttonAnteriorul_Click(object sender, EventArgs e)
        {
            index--;
            if (index == 1)
            {
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea2/Unitatea2.1.png");
                buttonAnteriorul.Visible = false;
            }

            if (index == 2)
            {
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea2/Unitatea2.2.png");

                pictureBoxLatitudine.Visible = false;
                pictureBoxLongitudine.Visible = false;
            }
            if(index == 3)
            {
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea2/Unitatea2.3.png");
                pictureBoxLatitudine.Visible = true;
                pictureBoxLongitudine.Visible = true;
            }
            if (index == 4)
            {
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea2/Unitatea2.6.png");

            }
            if (index == 5)
            {
                pictureBoxBackground.Image = Image.FromFile("C:/Terra/O planeta in miscare.jpg");
                pictureBoxMiscareRevolutie.Visible = false;
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea2/Unitatea2.7.png");

            }
            if (index == 6)
            {
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea2/Unitatea2.8.png");

            }
            if (index == 7)
            {
                pictureBoxMiscarePamant.Visible = false;

                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea2/Unitatea2.9.png");
                pictureBoxMiscareRevolutie.Visible = true;

                pictureBoxBackground.Image = Image.FromFile("C:/Terra/Space.png");


            }
            if (index == 8)
            {
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea2/Unitatea2.10.png");

            }
            if (index == 9)
            {
                pictureBoxGMT.Visible = false;
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea2/Unitatea2.11.png");

                pictureBoxMiscarePamant.Visible = true;
                pictureBoxBackground.Image = Image.FromFile("C:/Terra/Unitatea2/WallpaperMiscarilePamantului.png");

            }
            if (index == 10)
            {
                pictureBoxOrientareZiua.Visible = false;
                pictureBoxOrientareNoaptea.Visible = false;
                pictureBoxGMT.Visible = true;

                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea2/Unitatea2.12.png");

            }
            if (index == 11)
            {
                pictureBoxOrientareZiua.Visible = true;
                pictureBoxOrientareNoaptea.Visible = true;

                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea2/Unitatea2.13.png");

            }
            if (index == 12)
            {
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea2/Unitatea2.14.png");

                buttonUrmatorul.Visible = true;
            }
        }

        private void pictureBoxLatitudine_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea2/Unitatea2.4.png");
        }

        private void pictureBoxLongitudine_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea2/Unitatea2.5.png");
        }

        private void pictureBoxLatitudine_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea2/Unitatea2.3.png");

        }

        private void pictureBoxLongitudine_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea2/Unitatea2.3.png");

        }
    }
}
