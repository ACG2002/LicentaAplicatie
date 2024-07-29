using System;
using System.Drawing;
using System.Windows.Forms;

namespace Aplicatie_educationala_pentru_invatarea_geografiei
{
    public partial class FormUnitatea3 : Form
    {
        private int index = 1;

        public FormUnitatea3()
        {
            InitializeComponent();

            pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea3/Unitatea3.1.png");

            PersonalizareButoane.SetButtonImageRegion(buttonBack, "C:/Terra/Back.png");
            PersonalizareButoane.SetButtonImageRegion(buttonAnteriorul, "C:/Terra/butonAnteriorul.png");
            PersonalizareButoane.SetButtonImageRegion(buttonUrmatorul, "C:/Terra/butonUrmatorul.png");
            pictureBoxBackground.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void FormUnitatea3_Load(object sender, EventArgs e)
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
                buttonAnteriorul.Visible = true;
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea3/Unitatea3.2.png");

            }
            if(index == 3)
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea3/Unitatea3.3.png");

            if(index == 4)
            {
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea3/Unitatea3.4.png");
                pictureBoxBackground.Image = Image.FromFile("C:/Terra/Unitatea3/WallpaperStructura2.png");
            }
            if (index == 5)
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea3/Unitatea3.5.png");

            if (index == 6)
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea3/Unitatea3.6.png");

            if(index == 7)
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea3/Unitatea3.7.png");

            if(index == 8)
            {
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea3/Unitatea3.8.png");
                pictureBoxBackground.Image = Image.FromFile("C:/Terra/Unitatea3/Relief.png");
            }
            if(index == 9)
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea3/Unitatea3.9.png");

            if(index == 10)
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea3/Unitatea3.10.png");

            if(index == 11)
            {
                pictureBoxBackground.Image = Image.FromFile("C:/Terra/Unitatea3/Vulcan.png");
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea3/Unitatea3.11.png");

                buttonCamera.Visible = true;
                buttonCosVulcanic.Visible = true;
                buttonConVulcanic.Visible = true;
                buttonCrater.Visible = true;
                buttonCenusa.Visible = true;
                buttonLava.Visible = true;
                pictureBoxVulcan.Visible = true;


            }
            if (index == 12)
            {
                pictureBoxVulcan.Visible = false;
                buttonCamera.Visible = false;
                buttonCosVulcanic.Visible = false;
                buttonConVulcanic.Visible = false;
                buttonCrater.Visible = false;
                buttonCenusa.Visible = false;
                buttonLava.Visible = false;

                pictureBoxCutremure.Visible = true;
                pictureBoxCutremure.Image = Image.FromFile("C:/Terra/Unitatea3/PlaciTectonice.gif");
                pictureBoxCutremure.SizeMode = PictureBoxSizeMode.StretchImage;

                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea3/Unitatea3.12.png");
               
            }
            if(index == 13)
            { pictureBoxCutremure.Visible = false;
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea3/Unitatea3.13.png");
                buttonUrmatorul.Visible = false;
            }
        }

        private void buttonAnteriorul_Click(object sender, EventArgs e)
        {
            index--;
            if(index == 1)
            {
                buttonAnteriorul.Visible = false;
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea3/Unitatea3.1.png");
            }
            if(index == 2)
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea3/Unitatea3.2.png");

            if(index == 3)
            {
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea3/Unitatea3.3.png");
                pictureBoxCutremure.Visible = false;
                pictureBoxBackground.Image = Image.FromFile("C:/Terra/Unitatea3/WallpaperStructura.png");
            }
            if(index == 4)
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea3/Unitatea3.4.png");

            if (index == 5)
            {
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea3/Unitatea3.5.png");
            }
            if(index == 6)
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea3/Unitatea3.6.png");

            if(index == 7)
            {
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea3/Unitatea3.7.png");
                pictureBoxBackground.Image = Image.FromFile("C:/Terra/Unitatea3/WallpaperStructura2.png");
            }
            if(index == 8)
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea3/Unitatea3.8.png");

            if(index == 9)
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea3/Unitatea3.9.png");

            if(index == 10)
            { 
                pictureBoxBackground.Image = Image.FromFile("C:/Terra/Unitatea3/Relief.png");
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea3/Unitatea3.10.png");

                pictureBoxVulcan.Visible = false;
                buttonCamera.Visible = false;
                buttonCosVulcanic.Visible = false;
                buttonConVulcanic.Visible = false;
                buttonCrater.Visible = false;
                buttonCenusa.Visible = false;
                buttonLava.Visible = false;
            }
            if(index == 11)
            {
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea3/Unitatea3.11.png");

                buttonCamera.Visible = true;
                buttonCosVulcanic.Visible = true;
                buttonConVulcanic.Visible = true;
                buttonCrater.Visible = true;
                buttonCenusa.Visible = true;
                buttonLava.Visible = true;
                pictureBoxVulcan.Visible = true;

                pictureBoxCutremure.Visible = false;
            }
            if (index == 12)
            {
                pictureBoxCutremure.Visible = true;

                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea3/Unitatea3.12.png");
                buttonUrmatorul.Visible = true;
            }
        }
        #region EventMouseMove
        private void buttonCenusa_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea3/Unitatea3.19.png");
        }
        private void buttonLava_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea3/Unitatea3.14.png");
        }
        private void buttonConVulcanic_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea3/Unitatea3.17.png");
        }
        private void buttonCrater_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea3/Unitatea3.16.png");
        }
        private void buttonCosVulcanic_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea3/Unitatea3.18.png");
        }
        private void buttonCamera_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea3/Unitatea3.15.png");
        }
        #endregion
        #region EventMouseLeave
        private void buttonLava_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea3/Unitatea3.11.png");
        }
        private void buttonConVulcanic_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea3/Unitatea3.11.png");
        }
        private void buttonCrater_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea3/Unitatea3.11.png");
        }
        private void buttonCosVulcanic_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea3/Unitatea3.11.png");
        }
        private void buttonCamera_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea3/Unitatea3.11.png");
        }
        private void buttonCenusa_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea3/Unitatea3.11.png");
        }
        #endregion

    }
}
