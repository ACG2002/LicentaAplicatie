using System;
using System.Drawing;
using System.Windows.Forms;

namespace Aplicatie_educationala_pentru_invatarea_geografiei
{
    public partial class FormUnitatea6 : Form
    {
        private int index = 1;
        public FormUnitatea6()
        {
            InitializeComponent();

            pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea6/Unitatea6.1.png");

            PersonalizareButoane.SetButtonImageRegion(buttonBack, "C:/Terra/Back.png");
            PersonalizareButoane.SetButtonImageRegion(buttonAnteriorul, "C:/Terra/butonAnteriorul.png");
            PersonalizareButoane.SetButtonImageRegion(buttonUrmatorul, "C:/Terra/butonUrmatorul.png");
        }

        private void FormUnitatea6_Load(object sender, EventArgs e)
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
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea6/Unitatea6.2.png");

                buttonAnteriorul.Visible = true;
            }
            if(index == 3)
            {
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea6/Unitatea6.3.png");

            }
            if(index == 4)
            {
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea6/Unitatea6.4.png");

            }
            if(index == 5)
            {
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea6/Unitatea6.5.png");

                pictureBoxZoneBiogeografice.Visible = true;
            }
            if(index == 6)
            {
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea6/Unitatea6.6.png");

            }
            if(index == 7)
            {
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea6/Unitatea6.7.png");
            }
            if(index == 8)
            {
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea6/Unitatea6.8.png");
            }
            if(index == 9)
            {
                pictureBoxZoneBiogeografice.Visible = false;

                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea6/Unitatea6.9.png");
                pictureBoxBackground.Image = Image.FromFile("C:/Terra/Unitatea6/sol.png");
                pictureBoxBackground.SizeMode = PictureBoxSizeMode.StretchImage;


            }
            if(index == 10)
            {
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea6/Unitatea6.10.png");

            }
            if(index == 11)
            {
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea6/Unitatea6.11.png");
            }
            if(index == 12)
            {
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea6/Unitatea6.12.png");
            }
            if(index == 13)
            {
                pictureBoxText.Visible = false;
                pictureBoxBackground.Image = Image.FromFile("C:/Terra/Unitatea6/schimbarile-climatice.png");

                buttonDesert.Visible = true;
                buttonEroziune.Visible = true;
                buttonGhetari.Visible = true;
                buttonTundra.Visible = true;
                buttonVegetatie.Visible = true;

                pictureBoxSchimbareClima.Visible = true;
                pictureBoxSchimbareClima.SizeMode = PictureBoxSizeMode.StretchImage;

                labelPrincipal.Visible = true;

                buttonAnteriorul.Location = new System.Drawing.Point(873, 975);
                buttonUrmatorul.Location = new System.Drawing.Point(978, 975);


            }
            if(index == 14)
            {
                labelPrincipal.Text = "Protectia animalelor";
                labelPrincipal.Location = new System.Drawing.Point(805, 42);

                buttonCod.Visible = true;
                buttonUrs.Visible = true;
                buttonVulpe.Visible = true;
                buttonFluture.Visible = true;
                buttonKoala.Visible = true;

                buttonDinozaur.Visible = true;
                buttonMamut.Visible = true;
                buttonDodo.Visible = true;
                buttonTigru.Visible = true;
                buttonIbex.Visible = true;

                labelPeCaleDisparitie.Visible = true;
                labelDisparute.Visible = true;

                buttonDesert.Visible = false;
                buttonEroziune.Visible = false;
                buttonGhetari.Visible = false;
                buttonTundra.Visible = false;
                buttonVegetatie.Visible = false;

                pictureBoxSchimbareClima.Image = null;

                buttonUrmatorul.Visible = false;
            }
        }

        private void buttonAnteriorul_Click(object sender, EventArgs e)
        {
            index--;
            if (index == 1)
            {
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea6/Unitatea6.1.png");
                buttonAnteriorul.Visible = false;
            }
            if (index == 2)
            {
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea6/Unitatea6.2.png");

            }
            if (index == 3)
            {
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea6/Unitatea6.3.png");

            }
            if (index == 4)
            {
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea6/Unitatea6.4.png");
                pictureBoxZoneBiogeografice.Visible = false;
            }
            if (index == 5)
            {
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea6/Unitatea6.5.png");
            }
            if (index == 6)
            {
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea6/Unitatea6.6.png");

            }
            if (index == 7)
            {
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea6/Unitatea6.7.png");
            }
            if (index == 8)
            {
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea6/Unitatea6.8.png");
                pictureBoxBackground.Image = Image.FromFile("C:/Terra/Unitatea6/Biosfera.png");
                pictureBoxZoneBiogeografice.Visible = true;


            }
            if (index == 9)
            {
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea6/Unitatea6.9.png");

            }
            if (index == 10)
            {
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea6/Unitatea6.10.png");
            }
            if (index == 11)
            {
                pictureBoxText.Image = Image.FromFile("C:/Terra/Unitatea6/Unitatea6.11.png");
            }
            if (index == 12)
            {
                pictureBoxBackground.Image = Image.FromFile("C:/Terra/Unitatea6/sol.png");
                pictureBoxText.Visible = true;
                buttonAnteriorul.Location = new System.Drawing.Point(1237, 975);
                buttonUrmatorul.Location = new System.Drawing.Point(1815, 975);

                buttonDesert.Visible = false;
                buttonEroziune.Visible = false;
                buttonGhetari.Visible = false;
                buttonTundra.Visible = false;
                buttonVegetatie.Visible = false;

                pictureBoxSchimbareClima.Visible = false;
                labelPrincipal.Visible = false;
            }
            if (index == 13)
            {
                labelPrincipal.Text = "Modificari generate de schimbarile climatice globale";

                buttonCod.Visible = false;
                buttonUrs.Visible = false;
                buttonVulpe.Visible = false;
                buttonFluture.Visible = false;
                buttonKoala.Visible = false;

                buttonDinozaur.Visible = false;
                buttonMamut.Visible = false;
                buttonDodo.Visible = false;
                buttonTigru.Visible = false;
                buttonIbex.Visible = false;

                labelPeCaleDisparitie.Visible = false;
                labelDisparute.Visible = false;

                buttonDesert.Visible = true;
                buttonEroziune.Visible = true;
                buttonGhetari.Visible = true;
                buttonTundra.Visible = true;
                buttonVegetatie.Visible = true;

                pictureBoxSchimbareClima.Image = null;

                buttonUrmatorul.Visible = true;
            }
        }
        #region EventMouseMove
        private void buttonGhetari_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxSchimbareClima.Image = Image.FromFile("C:/Terra/Unitatea6/Ghetari.png");
        }
        private void buttonTundra_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxSchimbareClima.Image = Image.FromFile("C:/Terra/Unitatea6/Tundra.png");

        }
        private void buttonVegetatie_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxSchimbareClima.Image = Image.FromFile("C:/Terra/Unitatea6/Vegetatie.png");

        }
        private void buttonDesert_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxSchimbareClima.Image = Image.FromFile("C:/Terra/Unitatea6/Desert.png");

        }
        private void buttonEroziune_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxSchimbareClima.Image = Image.FromFile("C:/Terra/Unitatea6/Eroziune.png");
        }

        private void buttonDinozaur_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxSchimbareClima.Image = Image.FromFile("C:/Terra/Unitatea6/Dinozaur.png");
        }

        private void buttonMamut_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxSchimbareClima.Image = Image.FromFile("C:/Terra/Unitatea6/Mamut.png");
        }

        private void buttonDodo_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxSchimbareClima.Image = Image.FromFile("C:/Terra/Unitatea6/Dodo.png");
        }

        private void buttonTigru_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxSchimbareClima.Image = Image.FromFile("C:/Terra/Unitatea6/Tigru.png");
        }

        private void buttonIbex_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxSchimbareClima.Image = Image.FromFile("C:/Terra/Unitatea6/Ibex.png");
        }

        private void buttonUrs_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxSchimbareClima.Image = Image.FromFile("C:/Terra/Unitatea6/Urs.png");
        }

        private void buttonFluture_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxSchimbareClima.Image = Image.FromFile("C:/Terra/Unitatea6/Fluture.png");
        }

        private void buttonVulpe_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxSchimbareClima.Image = Image.FromFile("C:/Terra/Unitatea6/Vulpe.png");
        }

        private void buttonCod_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxSchimbareClima.Image = Image.FromFile("C:/Terra/Unitatea6/Cod.png");
        }

        private void buttonKoala_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxSchimbareClima.Image = Image.FromFile("C:/Terra/Unitatea6/Koala.png");
        }
        #endregion

    }
}
