using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Aplicatie_educationala_pentru_invatarea_geografiei
{
    public partial class FormUnitatea5 : Form
    {
        private int index = 1; 
        public FormUnitatea5()
        {
            InitializeComponent();

            pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea5/Unitatea5.1.png");

            PersonalizareButoane.SetButtonImageRegion(buttonBack, "C:/Terra/Back.png");
            PersonalizareButoane.SetButtonImageRegion(buttonAnteriorul, "C:/Terra/butonAnteriorul.png");
            PersonalizareButoane.SetButtonImageRegion(buttonUrmatorul, "C:/Terra/butonUrmatorul.png");
        }

        private void FormUnitatea5_Load(object sender, EventArgs e)
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
            if (index == 2)
            {
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea5/Unitatea5.2.png");

                buttonAnteriorul.Visible = true;

                pictureBoxApa.Visible = true;

            }
            if(index == 3)
            {
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea5/Unitatea5.3.png");
            }
            if(index == 4)
            {
                pictureBoxApa.Image = Image.FromFile("C:/Terra/Unitatea5/Oceane.png");

                buttonAntarctic.Visible = true;
                buttonPacific.Visible = true;
                buttonIndian.Visible = true;
                buttonAtlantic.Visible = true;
                buttonArctic.Visible = true;

                buttonAntarctic.BringToFront();
                buttonPacific.BringToFront();
                buttonIndian.BringToFront();
                buttonAtlantic.BringToFront();
                buttonArctic.BringToFront();

                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea5/Unitatea5.4.png");
            }
            if(index == 5)
            {
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea5/Unitatea5.10.png");
                pictureBoxApa.Visible = false;

                buttonAntarctic.Visible = false;
                buttonPacific.Visible = false;
                buttonIndian.Visible = false;
                buttonAtlantic.Visible = false;
                buttonArctic.Visible = false;

            }
            if(index == 6)
            {
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea5/Unitatea5.11.png");
            }
            if(index == 7)
            {
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea5/Unitatea5.12.png");
            }
            if(index == 8)
            {
                pictureBoxBackground.Image = Image.FromFile("C:/Terra/Unitatea5/Rau.png");
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea5/Unitatea5.13.png");
            }
            if(index == 9)
            {
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea5/Unitatea5.14.png");

            }
            if(index == 10)
            {
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea5/Unitatea5.15.png");
            }
            if(index == 11)
            {
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea5/Unitatea5.16.png");
                pictureBoxApa.Image = Image.FromFile("C:/Terra/Unitatea5/ElementeRau.png");
                pictureBoxApa.Visible = true;

                buttonInferior.BringToFront();
                buttonSuperior.BringToFront();
                buttonMijlociu.BringToFront();
                buttonIzvor.BringToFront();
                buttonVarsare.BringToFront();
                buttonUrmatorul.BringToFront();

                buttonInferior.Visible = true;
                buttonSuperior.Visible = true;
                buttonMijlociu.Visible = true;
                buttonIzvor.Visible = true;
                buttonVarsare.Visible = true;
            }
            if(index == 12)
            {
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea5/Unitatea5.22.png");
                pictureBoxApa.Visible = true;
                pictureBoxApa.Image = Image.FromFile("C:/Terra/Unitatea5/Fluvii.png");

                buttonInferior.Visible = false;
                buttonSuperior.Visible = false;
                buttonMijlociu.Visible = false;
                buttonIzvor.Visible = false;
                buttonVarsare.Visible = false;

                buttonAlbastru.Visible = true;
                buttonGalben.Visible = true;
                buttonVolga.Visible = true;
                buttonDunarea.Visible = true;
                buttonAmazon.Visible = true;
                buttonNil.Visible = true;
                buttonMississippi.Visible = true;

                buttonAlbastru.BringToFront();
                buttonGalben.BringToFront();
                buttonVolga.BringToFront();
                buttonDunarea.BringToFront();
                buttonAmazon.BringToFront();
                buttonNil.BringToFront();
                buttonMississippi.BringToFront();
            }
            if(index == 13)
            {
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea5/Unitatea5.30.png");
                pictureBoxBackground.Image = Image.FromFile("C:/Terra/Unitatea5/Ghetari.png");
                pictureBoxApa.Visible = false;

                buttonAlbastru.Visible = false;
                buttonGalben.Visible = false;
                buttonVolga.Visible = false;
                buttonDunarea.Visible = false;
                buttonAmazon.Visible = false;
                buttonNil.Visible = false;
                buttonMississippi.Visible = false;
            }
            if(index == 14)
            {
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea5/Unitatea5.31.png");
            }
            if(index == 15)
            {
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea5/Unitatea5.32.png");
            }
            if(index == 16)
            {
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea5/Unitatea5.33.png");
                pictureBoxAisberg.Visible = true;

                buttonUrmatorul.Visible = false;
            }
        }

        private void buttonAnteriorul_Click(object sender, EventArgs e)
        {
            index--;
            if (index == 1)
            {
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea5/Unitatea5.1.png");
                buttonAnteriorul.Visible = false;
                pictureBoxApa.Visible = false;
            }
            if(index == 2)
            {
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea5/Unitatea5.2.png");
            }
            if(index == 3)
            {
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea5/Unitatea5.3.png");

                buttonAntarctic.Visible = false;
                buttonPacific.Visible = false;
                buttonIndian.Visible = false;
                buttonAtlantic.Visible = false;
                buttonArctic.Visible = false;

                pictureBoxApa.Image = Image.FromFile("C:/Terra/Unitatea5/DistributiaApei.png");
            }
            if (index == 4)
            {
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea5/Unitatea5.4.png");
                pictureBoxApa.Image = Image.FromFile("C:/Terra/Unitatea5/Oceane.png");

                pictureBoxApa.Visible = true;

                buttonAntarctic.Visible = true;
                buttonPacific.Visible = true;
                buttonIndian.Visible = true;
                buttonAtlantic.Visible = true;
                buttonArctic.Visible = true;
            }
            if(index == 5)
            {
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea5/Unitatea5.10.png");
            }
            if(index == 6)
            {
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea5/Unitatea5.11.png");
            }
            if(index == 7)
            {
                pictureBoxBackground.Image = Image.FromFile("C:/Terra/Unitatea5/PamantOcean.png");
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea5/Unitatea5.12.png");
            }
            if(index == 8)
            {
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea5/Unitatea5.13.png");
            }
            if(index == 9)
            {
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea5/Unitatea5.14.png");
            }
            if(index == 10)
            {
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea5/Unitatea5.15.png");

                buttonInferior.Visible = false;
                buttonSuperior.Visible = false;
                buttonMijlociu.Visible = false;
                buttonIzvor.Visible = false;
                buttonVarsare.Visible = false;

                pictureBoxApa.Visible = false;


            }
            if(index == 11)
            {
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea5/Unitatea5.16.png");
                pictureBoxApa.Image = Image.FromFile("C:/Terra/Unitatea5/ElementeRau.png");
                pictureBoxApa.Visible = true;

                buttonInferior.Visible = true;
                buttonSuperior.Visible = true;
                buttonMijlociu.Visible = true;
                buttonIzvor.Visible = true;
                buttonVarsare.Visible = true;

                buttonAlbastru.Visible = false;
                buttonGalben.Visible = false;
                buttonVolga.Visible = false;
                buttonDunarea.Visible = false;
                buttonAmazon.Visible = false;
                buttonNil.Visible = false;
                buttonMississippi.Visible = false;
            }
            if(index == 12)
            {
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea5/Unitatea5.22.png");
                pictureBoxApa.Visible = true;
                pictureBoxApa.Image = Image.FromFile("C:/Terra/Unitatea5/Fluvii.png");
                pictureBoxBackground.Image = Image.FromFile("C:/Terra/Unitatea5/Rau.png");

                buttonAlbastru.Visible = true;
                buttonGalben.Visible = true;
                buttonVolga.Visible = true;
                buttonDunarea.Visible = true;
                buttonAmazon.Visible = true;
                buttonNil.Visible = true;
                buttonMississippi.Visible = true;
            }
            if(index == 13)
            {
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea5/Unitatea5.30.png");
            }
            if(index == 14)
            {
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea5/Unitatea5.31.png");
            }
            if(index == 15)
            {
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea5/Unitatea5.32.png");
                pictureBoxAisberg.Visible = false;
                buttonUrmatorul.Visible = true;
            }
        }

        #region EventMouseMove
        private void buttonArctic_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea5/Unitatea5.8.png");
        }
        private void buttonIndian_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea5/Unitatea5.7.png");
        }
        private void buttonAtlantic_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea5/Unitatea5.6.png");
        }
        private void buttonAntarctic_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea5/Unitatea5.9.png");
        }
        private void buttonPacific_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea5/Unitatea5.5.png");
        }

        private void buttonIzvor_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea5/Unitatea5.17.png");
        }
        private void buttonSuperior_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea5/Unitatea5.18.png");
        }
        private void buttonMijlociu_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea5/Unitatea5.19.png");
        }
        private void buttonInferior_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea5/Unitatea5.20.png");
        }
        private void buttonVarsare_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea5/Unitatea5.21.png");
        }

        private void buttonDunarea_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea5/Unitatea5.25.png");
        }
        private void buttonVolga_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea5/Unitatea5.24.png");
        }
        private void buttonGalben_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea5/Unitatea5.29.png");
        }
        private void buttonAlbastru_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea5/Unitatea5.23.png");
        }
        private void buttonNil_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea5/Unitatea5.26.png");
        }
        private void buttonAmazon_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea5/Unitatea5.27.png");
        }
        private void buttonMississippi_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea5/Unitatea5.28.png");
        }
        #endregion
        #region EventMouseLeave
        private void buttonArctic_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea5/Unitatea5.4.png");
        }
        private void buttonIndian_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea5/Unitatea5.4.png");
        }
        private void buttonAtlantic_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea5/Unitatea5.4.png");
        }
        private void buttonAntarctic_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea5/Unitatea5.4.png");
        }
        private void buttonPacific_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea5/Unitatea5.4.png");
        }



        #endregion


    }
}
