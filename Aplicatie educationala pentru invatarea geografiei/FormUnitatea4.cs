using System;
using System.Drawing;
using System.Windows.Forms;

namespace Aplicatie_educationala_pentru_invatarea_geografiei
{
    public partial class FormUnitatea4 : Form
    {
        private int index = 1;
        public FormUnitatea4()
        {
            InitializeComponent();

            pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea4/Unitatea4.1.png");

            PersonalizareButoane.SetButtonImageRegion(buttonBack, "C:/Terra/Back.png");
            PersonalizareButoane.SetButtonImageRegion(buttonAnteriorul, "C:/Terra/butonAnteriorul.png");
            PersonalizareButoane.SetButtonImageRegion(buttonUrmatorul, "C:/Terra/butonUrmatorul.png");
            pictureBoxBackground.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void FormUnitatea4_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.Owner.Hide();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Owner.Show();
        }

        private void buttonUrmatorul_Click(object sender, EventArgs e)
        {
            index++;
            if(index == 2)
            {
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea4/Unitatea4.2.png");
                buttonAnteriorul.Visible = true;

            }
            if(index == 3)
            {
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea4/Unitatea4.3.png");
                pictureBoxBackground.Image = Image.FromFile("C:/Terra/Unitatea4/Meteo.png");

            }
            if(index == 4)
            {
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea4/Unitatea4.4.png");
                pictureBoxBackground.Image = Image.FromFile("C:/Terra/Unitatea4/Atmosfera2.png");


            }
            if(index == 5)
            {
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea4/Unitatea4.5.png");
                pictureBoxBackground.Image = Image.FromFile("C:/Terra/Unitatea4/vant.png");

            }
            if(index == 6)
            {
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea4/Unitatea4.6.png");
                pictureBoxBackground.Image = Image.FromFile("C:/Terra/Unitatea4/Vreme.png");

            }
            if(index == 7)
            {
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea4/Unitatea4.7.png");

            }
            if(index == 8)
            {
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea4/Unitatea4.8.png");
                pictureBoxBackground.Image = Image.FromFile("C:/Terra/Unitatea4/Clima.png");
            }
            if(index == 9)
            {
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea4/Unitatea4.9.png");

            }
            if(index == 10)
            {
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea4/Unitatea4.10.png");

            }
            if(index == 11)
            {
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea4/Unitatea4.11.png");
            }
            if(index == 12)
            {
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea4/Unitatea4.12.png");

                buttonAlpin.Visible = true;
                buttonJungla.Visible = true;
                buttonTaiga.Visible = true;
                buttonPrerie.Visible = true;
                buttonDesert.Visible = true;

                buttonUrmatorul.Visible = false;
            }
        }

        private void buttonAnteriorul_Click(object sender, EventArgs e)
        {
            index--;
            if(index == 1)
            {
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea4/Unitatea4.1.png");


                buttonAnteriorul.Visible = false;
            }
            if(index == 2)
            {
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea4/Unitatea4.2.png");
                pictureBoxBackground.Image = Image.FromFile("C:/Terra/Unitatea4/Atmosfera.png");
            }
            if (index == 3)
            {
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea4/Unitatea4.3.png");
                pictureBoxBackground.Image = Image.FromFile("C:/Terra/Unitatea4/Meteo.png");

            }
            if (index == 4)
            {
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea4/Unitatea4.4.png");
                pictureBoxBackground.Image = Image.FromFile("C:/Terra/Unitatea4/Atmosfera2.png");

            }
            if(index == 5)
            {
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea4/Unitatea4.5.png");
                pictureBoxBackground.Image = Image.FromFile("C:/Terra/Unitatea4/vant.png");

            }
            if(index == 6)
            {
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea4/Unitatea4.6.png");

            }
            if(index == 7)
            {
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea4/Unitatea4.7.png");
                pictureBoxBackground.Image = Image.FromFile("C:/Terra/Unitatea4/Vreme.png");

            }
            if(index == 8)
            {
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea4/Unitatea4.8.png");

            }
            if(index == 9)
            {
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea4/Unitatea4.9.png");

            }
            if(index == 10)
            {
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea4/Unitatea4.10.png");
            }
            if(index == 11)
            {
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea4/Unitatea4.11.png");

                buttonAlpin.Visible = false;
                buttonJungla.Visible = false;
                buttonTaiga.Visible = false;
                buttonPrerie.Visible = false;
                buttonDesert.Visible = false;

                buttonUrmatorul.Visible = true;
            }
        }
        #region EventMouseMove
        private void buttonTaiga_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea4/Unitatea4.13.png");
        }
        private void buttonAlpin_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea4/Unitatea4.15.png");
        }
        private void buttonPrerie_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea4/Unitatea4.14.png");
        }
        private void buttonJungla_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea4/Unitatea4.17.png");
        }
        private void buttonDesert_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea4/Unitatea4.16.png");
        }
        #endregion
    }
}
