using System;
using System.Drawing;
using System.Windows.Forms;

namespace Aplicatie_educationala_pentru_invatarea_geografiei
{
    public partial class FormUnitatea1 : Form
    {
        private int index = 1;
        public FormUnitatea1()
        {
            InitializeComponent();
            pictureBoxText.BackgroundImage = Image.FromFile("C:/Terra/Unitatea1/Unitatea1.1.png");
            PersonalizareButoane.SetButtonImageRegion(buttonAnteriorul, "C:/Terra/butonAnteriorul.png");
            PersonalizareButoane.SetButtonImageRegion(buttonUrmatorul, "C:/Terra/butonUrmatorul.png");
            PersonalizareButoane.SetButtonImageRegion(buttonBack, "C:/Terra/Back.png");

            PersonalizareButoane.SetButtonImageRegion(buttonMercur, "C:/Terra/Unitatea1/butonMercur.png");
            PersonalizareButoane.SetButtonImageRegion(buttonVenus, "C:/Terra/Unitatea1/butonVenus.png");
            PersonalizareButoane.SetButtonImageRegion(buttonTerra, "C:/Terra/Unitatea1/butonTerra.png");
            PersonalizareButoane.SetButtonImageRegion(buttonMarte, "C:/Terra/Unitatea1/butonMarte.png");
            PersonalizareButoane.SetButtonImageRegion(buttonJupiter, "C:/Terra/Unitatea1/butonJupiter.png");
            PersonalizareButoane.SetButtonImageRegion(buttonSaturn, "C:/Terra/Unitatea1/butonSaturn.png");
            PersonalizareButoane.SetButtonImageRegion(buttonUranus, "C:/Terra/Unitatea1/butonUranus.png");
            PersonalizareButoane.SetButtonImageRegion(buttonNeptun, "C:/Terra/Unitatea1/butonNeptun.png");
            PersonalizareButoane.SetButtonImageRegion(buttonPluto, "C:/Terra/Unitatea1/butonPluto.png");

            pictureBoxBackground.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void FormUnitatea1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.Owner.Hide();
        }

        private void buttonUrmatorul_Click(object sender, EventArgs e)
        {
            buttonAnteriorul.Visible = true;
            index++;

            if (index == 2)
            {
                pictureBoxText.BackgroundImage = Image.FromFile("C:/Terra/Unitatea1/Unitatea1.2.png");
                
            }

            if (index == 3)
            {pictureBoxBackground.Image = Image.FromFile("C:/Terra/Unitatea1/Solar Sistem - Distante.png");
                pictureBoxDistantePlanete.Visible = true;
                label1.Visible = true;
                pictureBoxText.Visible = false;

                buttonAnteriorul.Location = new System.Drawing.Point(873, 975);
                buttonUrmatorul.Location = new System.Drawing.Point(978, 975);

                pictureBoxDistantaMercur.BackgroundImage = Image.FromFile("C:/Terra/Unitatea1/DistantaMercur.png");
                buttonMercur.Visible = true;
                pictureBoxDistantaVenus.BackgroundImage = Image.FromFile("C:/Terra/Unitatea1/DistantaVenus.png");
                buttonVenus.Visible = true;
                pictureBoxDistantaTerra.BackgroundImage = Image.FromFile("C:/Terra/Unitatea1/DistantaTerra.png");
                buttonTerra.Visible = true;
                pictureBoxDistantaMarte.BackgroundImage = Image.FromFile("C:/Terra/Unitatea1/DistantaMarte.png");
                buttonMarte.Visible = true;
                pictureBoxDistantaJupiter.BackgroundImage = Image.FromFile("C:/Terra/Unitatea1/DistantaJupiter.png");
                buttonJupiter.Visible = true;
                pictureBoxDistantaSaturn.BackgroundImage = Image.FromFile("C:/Terra/Unitatea1/DistantaSaturn.png");
                buttonSaturn.Visible = true;
                pictureBoxDistantaUranus.BackgroundImage = Image.FromFile("C:/Terra/Unitatea1/DistantaUranus.png");
                buttonUranus.Visible = true;
                pictureBoxDistantaNeptun.BackgroundImage = Image.FromFile("C:/Terra/Unitatea1/DistantaNeptun.png");
                buttonNeptun.Visible = true;
                pictureBoxDistantaPluto.BackgroundImage = Image.FromFile("C:/Terra/Unitatea1/DistantaPluto.png");
                buttonPluto.Visible = true;
            }

            if (index == 4)
            {
                pictureBoxBackground.Image = Image.FromFile("C:/Terra/Space.png");

                buttonMercur.Visible = false;
                buttonVenus.Visible = false;
                buttonTerra.Visible = false;
                buttonMarte.Visible = false;
                buttonJupiter.Visible = false;
                buttonSaturn.Visible = false;
                buttonUranus.Visible = false;
                buttonNeptun.Visible = false;
                buttonPluto.Visible = false;

                pictureBoxDistantePlanete.Visible = false;
                label1.Visible = false;

                pictureBoxText.Visible = true;
                pictureBoxText.BackgroundImage = Image.FromFile("C:/Terra/Unitatea1/Unitatea1.3.png");
                buttonAnteriorul.Location = new System.Drawing.Point(1237, 975);
                buttonUrmatorul.Location = new System.Drawing.Point(1815, 975);

            }
            if(index == 5)
            {
                buttonLuna.Visible = true;
                buttonGalaxie.Visible = true;
                buttonGauraNeagra.Visible = true;
                buttonNebuloasa.Visible = true;
                
                pictureBoxText.BackgroundImage = Image.FromFile("C:/Terra/Unitatea1/Unitatea1.8.png");
            }
   
            if (index == 6)
            {
                buttonLuna.Visible = false;
                buttonGalaxie.Visible = false;
                buttonGauraNeagra.Visible = false;
                buttonNebuloasa.Visible = false;

                pictureBoxBackground.Image = Image.FromFile("C:/Terra/Unitatea1/WallpaperTerra.png");
                pictureBoxText.BackgroundImage = Image.FromFile("C:/Terra/Unitatea1/Unitatea1.9.png");
            }
           if(index == 7)
                pictureBoxText.BackgroundImage = Image.FromFile("C:/Terra/Unitatea1/Unitatea1.10.png");

            if (index == 8)
            {
                pictureBoxBackground.Image = Image.FromFile("C:/Terra/Unitatea1/WallpaperBigBang.png");
                pictureBoxText.BackgroundImage = Image.FromFile("C:/Terra/Unitatea1/Unitatea1.11.png");

                pictureBoxBigBang.Location = new System.Drawing.Point(400, 680);
                pictureBoxBigBang.Visible = true;
                pictureBoxBigBang.Image = Image.FromFile("C:/Terra/Unitatea1/BigBang.gif");
            }
            if (index == 9)
                pictureBoxText.BackgroundImage = Image.FromFile("C:/Terra/Unitatea1/Unitatea1.12.png");

            if(index == 10)
            {
                pictureBoxText.BackgroundImage = Image.FromFile("C:/Terra/Unitatea1/Unitatea1.13.png");

                buttonUrmatorul.Visible = false;
            }
        }
        private void buttonAnteriorul_Click(object sender, EventArgs e)
        {
            index--;

            if (index == 1)
            {
                pictureBoxText.BackgroundImage = Image.FromFile("C:/Terra/Unitatea1/Unitatea1.1.png");
                buttonAnteriorul.Visible = false;
            }

            if (index == 2)
            {
                pictureBoxText.Visible = true;
                pictureBoxText.BackgroundImage = Image.FromFile("C:/Terra/Unitatea1/Unitatea1.2.png");
                pictureBoxBackground.Image = Image.FromFile("C:/Terra/Unitatea1/SistemSolar.png");
                pictureBoxDistantePlanete.Visible = false;
                label1.Visible = false;
                buttonAnteriorul.Location = new System.Drawing.Point(1237, 975);
                buttonUrmatorul.Location = new System.Drawing.Point(1815, 975);
                buttonUrmatorul.Visible = true;

                buttonMercur.Visible = false;
                buttonVenus.Visible = false;
                buttonTerra.Visible = false;
                buttonMarte.Visible = false;
                buttonJupiter.Visible = false;
                buttonSaturn.Visible = false;
                buttonUranus.Visible = false;
                buttonNeptun.Visible = false;
                buttonPluto.Visible = false;
            }

            if (index == 3)
            {
                pictureBoxBackground.Image = Image.FromFile("C:/Terra/Unitatea1/Solar Sistem - Distante.png");
                pictureBoxDistantePlanete.Visible = true;
                label1.Visible = true;
                pictureBoxText.Visible = false;

                buttonAnteriorul.Location = new System.Drawing.Point(873, 975);
                buttonUrmatorul.Location = new System.Drawing.Point(978, 975);

                pictureBoxDistantaMercur.BackgroundImage = Image.FromFile("C:/Terra/Unitatea1/DistantaMercur.png");
                buttonMercur.Visible = true;
                pictureBoxDistantaVenus.BackgroundImage = Image.FromFile("C:/Terra/Unitatea1/DistantaVenus.png");
                buttonVenus.Visible = true;
                pictureBoxDistantaTerra.BackgroundImage = Image.FromFile("C:/Terra/Unitatea1/DistantaTerra.png");
                buttonTerra.Visible = true;
                pictureBoxDistantaMarte.BackgroundImage = Image.FromFile("C:/Terra/Unitatea1/DistantaMarte.png");
                buttonMarte.Visible = true;
                pictureBoxDistantaJupiter.BackgroundImage = Image.FromFile("C:/Terra/Unitatea1/DistantaJupiter.png");
                buttonJupiter.Visible = true;
                pictureBoxDistantaSaturn.BackgroundImage = Image.FromFile("C:/Terra/Unitatea1/DistantaSaturn.png");
                buttonSaturn.Visible = true;
                pictureBoxDistantaUranus.BackgroundImage = Image.FromFile("C:/Terra/Unitatea1/DistantaUranus.png");
                buttonUranus.Visible = true;
                pictureBoxDistantaNeptun.BackgroundImage = Image.FromFile("C:/Terra/Unitatea1/DistantaNeptun.png");
                buttonNeptun.Visible = true;
                pictureBoxDistantaPluto.BackgroundImage = Image.FromFile("C:/Terra/Unitatea1/DistantaPluto.png");
                buttonPluto.Visible = true;

              
            }
            if (index == 4)
            {
                pictureBoxBackground.Image = Image.FromFile("C:/Terra/Space.png");
                pictureBoxText.BackgroundImage = Image.FromFile("C:/Terra/Unitatea1/Unitatea1.3.png");

                buttonLuna.Visible = false;
                buttonGalaxie.Visible = false;
                buttonGauraNeagra.Visible = false;
                buttonNebuloasa.Visible = false; 
            }
            if (index == 5)
            {
                pictureBoxBackground.Image = Image.FromFile("C:/Terra/Space.png");
                pictureBoxText.BackgroundImage = Image.FromFile("C:/Terra/Unitatea1/Unitatea1.8.png");

                buttonLuna.Visible = true;
                buttonGalaxie.Visible = true;
                buttonGauraNeagra.Visible = true;
                buttonNebuloasa.Visible = true;
            }

            if(index == 6)
                pictureBoxText.BackgroundImage = Image.FromFile("C:/Terra/Unitatea1/Unitatea1.9.png");

            if (index == 7)
            {
                pictureBoxBackground.Image = Image.FromFile("C:/Terra/Unitatea1/WallpaperTerra.png");
                pictureBoxText.BackgroundImage = Image.FromFile("C:/Terra/Unitatea1/Unitatea1.10.png");

                pictureBoxBigBang.Visible = false;
            }

            if (index == 8)
                pictureBoxText.BackgroundImage = Image.FromFile("C:/Terra/Unitatea1/Unitatea1.11.png");

            if (index == 9)
            {
                pictureBoxText.BackgroundImage = Image.FromFile("C:/Terra/Unitatea1/Unitatea1.12.png");

                buttonUrmatorul.Visible = true;
            }
        }
      
        #region EventMouseMove
        private void buttonAnteriorul_MouseMove(object sender, MouseEventArgs e)
        {
            buttonAnteriorul.Image = Image.FromFile("C:/Terra/butonAnteriorul - MouseMove.png");
        }
        private void buttonUrmatorul_MouseMove(object sender, MouseEventArgs e)
        {
            buttonUrmatorul.Image = Image.FromFile("C:/Terra/butonUrmatorul - MouseMove.png");

        }
        private void buttonBack_MouseMove(object sender, MouseEventArgs e)
        {
            buttonBack.Image = Image.FromFile("C:/Terra/Back - MouseMove.png");

        }
        private void buttonMercur_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxDistantaMercur.Visible = true;
        }
        private void buttonVenus_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxDistantaVenus.Visible = true;
        }
        private void buttonTerra_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxDistantaTerra.Visible = true;
        }
        private void buttonMarte_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxDistantaMarte.Visible = true;
        }
        private void buttonJupiter_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxDistantaJupiter.Visible = true;
        }
        private void buttonSaturn_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxDistantaSaturn.Visible = true;
        }
        private void buttonUranus_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxDistantaUranus.Visible = true;
        }
        private void buttonNeptun_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxDistantaNeptun.Visible = true;
        }
        private void buttonPluto_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxDistantaPluto.Visible = true;
        }
        private void buttonGalaxie_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxText.BackgroundImage = Image.FromFile("C:/Terra/Unitatea1/Unitatea1.4.png");
        }

        private void buttonGauraNeagra_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxText.BackgroundImage = Image.FromFile("C:/Terra/Unitatea1/Unitatea1.5.png");
        }

        private void buttonNebuloasa_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxText.BackgroundImage = Image.FromFile("C:/Terra/Unitatea1/Unitatea1.7.png");
        }

        private void buttonLuna_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxText.BackgroundImage = Image.FromFile("C:/Terra/Unitatea1/Unitatea1.6.png");
        }
        #endregion
        #region EventMouseDown
        private void buttonAnteriorul_MouseDown(object sender, MouseEventArgs e)
        {
            buttonAnteriorul.Image = Image.FromFile("C:/Terra/butonAnteriorul - MouseDown.png");

        }
        private void buttonUrmatorul_MouseDown(object sender, MouseEventArgs e)
        {
            buttonUrmatorul.Image = Image.FromFile("C:/Terra/butonUrmatorul - MouseDown.png");

        }
        private void buttonBack_MouseDown(object sender, MouseEventArgs e)
        {
            buttonBack.Image = Image.FromFile("C:/Terra/Back - MouseDown.png");

        }
        #endregion
        #region EventMouseLeave
        private void buttonAnteriorul_MouseLeave(object sender, EventArgs e)
        {
            buttonAnteriorul.Image = Image.FromFile("C:/Terra/butonAnteriorul.png");
        }
        private void buttonUrmatorul_MouseLeave(object sender, EventArgs e)
        {
            buttonUrmatorul.Image = Image.FromFile("C:/Terra/butonUrmatorul.png");
        }
        private void buttonBack_MouseLeave(object sender, EventArgs e)
        {
            buttonBack.Image = Image.FromFile("C:/Terra/Back.png");
        }


        private void buttonMercur_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxDistantaMercur.Visible = false;
        }
        private void buttonVenus_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxDistantaVenus.Visible = false;
        }
        private void buttonTerra_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxDistantaTerra.Visible = false;
        }
        private void buttonMarte_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxDistantaMarte.Visible = false;
        }
        private void buttonJupiter_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxDistantaJupiter.Visible = false;
        }
        private void buttonSaturn_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxDistantaSaturn.Visible = false;
        }
        private void buttonUranus_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxDistantaUranus.Visible = false;
        }
        private void buttonNeptun_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxDistantaNeptun.Visible = false;
        }
        private void buttonPluto_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxDistantaPluto.Visible = false;
        }
        #endregion

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

  
    }
}
