using System;
using System.Drawing;
using System.Windows.Forms;

namespace Aplicatie_educationala_pentru_invatarea_geografiei
{
    public partial class FormUnitatea7 : Form
    {
        private int index = 1;
        public FormUnitatea7()
        {
            InitializeComponent();
            pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea7/Unitatea7.1.png");

            PersonalizareButoane.SetButtonImageRegion(buttonBack, "C:/Terra/Back.png");
            PersonalizareButoane.SetButtonImageRegion(buttonAnteriorul, "C:/Terra/butonAnteriorul.png");
            PersonalizareButoane.SetButtonImageRegion(buttonUrmatorul, "C:/Terra/butonUrmatorul.png");
        }

        private void FormUnitatea7_Load(object sender, EventArgs e)
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
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea7/Unitatea7.2.png");
                buttonAnteriorul.Visible = true;
               
            }
            if(index == 3)
            {
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea7/Unitatea7.3.png");

                buttonDesert.Visible = true;
                buttonSavana.Visible = true;
                buttonPaduri.Visible = true;
                buttonStepa.Visible = true;
                buttonTundraGheturi.Visible = true;

                pictureBoxPeisaje.Visible = true;
                pictureBoxPeisaje.SizeMode = PictureBoxSizeMode.StretchImage;

                buttonUrmatorul.Visible = false;
            }
        }

        private void buttonAnteriorul_Click(object sender, EventArgs e)
        {
            index--;
            if(index == 1)
            {
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea7/Unitatea7.1.png");
                buttonAnteriorul.Visible = false;
               
            }
            if(index == 2)
            {
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea7/Unitatea7.2.png");

                buttonDesert.Visible = false;
                buttonSavana.Visible = false;
                buttonPaduri.Visible = false;
                buttonStepa.Visible = false;
                buttonTundraGheturi.Visible = false;

                pictureBoxPeisaje.Visible = false;
                buttonUrmatorul.Visible = true;
            }
        }

        private void buttonStepa_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea7/Unitatea7.4.png");
            pictureBoxPeisaje.Image = Image.FromFile("C:/Terra/Unitatea7/Stepa.png");
        }

        private void buttonSavana_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea7/Unitatea7.5.png");
            pictureBoxPeisaje.Image = Image.FromFile("C:/Terra/Unitatea7/Savana.png");
        }

        private void buttonPaduri_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea7/Unitatea7.6.png");
            pictureBoxPeisaje.Image = Image.FromFile("C:/Terra/Unitatea7/Paduri.png");
        }

        private void buttonDesert_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea7/Unitatea7.7.png");
            pictureBoxPeisaje.Image = Image.FromFile("C:/Terra/Unitatea7/Desert.png");
        }

        private void buttonTundraGheturi_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea7/Unitatea7.8.png");
            pictureBoxPeisaje.Image = Image.FromFile("C:/Terra/Unitatea7/TundraGheturi.png");
        }
    }
}
