using System;
using System.Drawing;

using System.Windows.Forms;

namespace Aplicatie_educationala_pentru_invatarea_geografiei
{
    public partial class FormLectii : Form
    { 
        private int index = 0; 
        int screenWidth = Screen.PrimaryScreen.Bounds.Width;
        int screenHeight = Screen.PrimaryScreen.Bounds.Height;
        public FormLectii()
        {
            InitializeComponent();

            PersonalizareButoane.SetButtonImageRegion(buttonSistemSolar, "C:/Terra/butonSistemSolar.png");
            PersonalizareButoane.SetButtonImageRegion(buttonMiscarePamant, "C:/Terra/butonMiscarilePamantului.png");
            PersonalizareButoane.SetButtonImageRegion(buttonInapoi, "C:/Terra/Back.png");
            PersonalizareButoane.SetButtonImageRegion(buttonTest, "C:/Terra/butonTest.png");
            PersonalizareButoane.SetButtonImageRegion(buttonZoneNaturale, "C:/Terra/butonZoneleNaturale.png");
            PersonalizareButoane.SetButtonImageRegion(buttonHidrosfera, "C:/Terra/butonHidrosfera.png");
            PersonalizareButoane.SetButtonImageRegion(buttonLitosfera, "C:/Terra/butonLitosfera.png");
            PersonalizareButoane.SetButtonImageRegion(buttonBiosfera, "C:/Terra/butonBiosfera.png");
            PersonalizareButoane.SetButtonImageRegion(buttonAtmosfera, "C:/Terra/butonAtmosfera.png");


            AlignLabel(label);
            pictureBoxBackground.SizeMode = PictureBoxSizeMode.StretchImage;
    
        }

        private void AlignLabel(Label label)
        {
            int pictureboxHeight = pictureBoxText.Height;
            int labelWidth = label.Width; 
            int labelHeight = label.Height; 

            int labelX = (screenWidth / 2) - labelWidth / 2;
            int labelY = screenHeight - pictureboxHeight / 2 - labelHeight / 2;

            label.Location = new System.Drawing.Point(labelX, labelY);

        }
  
        private void FormLectii_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.Owner.Hide();
        }

        private void buttonInapoi_Click(object sender, EventArgs e)
        {
            FormPaginaDeStart FormPaginaDeStart = new FormPaginaDeStart();
            this.Hide();
            FormPaginaDeStart.ShowDialog();
           
        }

        #region EventMouseMove
        private void buttonSistemSolar_MouseMove(object sender, MouseEventArgs e)
        {
            if (index != 1)
            {
                pictureBoxBackground.Image = Image.FromFile("C:/Terra/Solar Sistem.png");
                index = 1;
                label.Text = "Unitatea 1. Terra - O planeta a universului";
                AlignLabel(label);
            }
            buttonSistemSolar.Image = Image.FromFile("C:/Terra/butonSistemSolar - MouseMove.png");

        }

        private void buttonMiscarePamant_MouseMove(object sender, MouseEventArgs e)
        {

            if (index != 2)
            {
                pictureBoxBackground.Image = Image.FromFile("C:/Terra/O planeta in miscare.jpg");
                index = 2;
                label.Text = "Unitatea 2. Terra - O planeta in miscare";
                AlignLabel(label);

            }
            buttonMiscarePamant.Image = Image.FromFile("C:/Terra/butonMiscarilePamantului - MouseMove.png");

        }
        private void buttonTest_MouseMove(object sender, MouseEventArgs e)
        {
            if (index != 3)
            {
                pictureBoxBackground.Image = Image.FromFile("C:/Terra/TestGeografie.png");
                index = 3;
                label.Text = "Unitatea 8. Terra - Test";
                AlignLabel(label);

            }
            buttonTest.Image = Image.FromFile("C:/Terra/butonTest - MouseMove.png");

        }
        private void buttonZoneNaturale_MouseMove(object sender, MouseEventArgs e)
        {
            if (index != 4)
            {
                pictureBoxBackground.Image = Image.FromFile("C:/Terra/ZoneleNaturale.png");
                index = 4;
                label.Text = "Unitatea 7. Terra - Zonele naturale ale Terrei";
                AlignLabel(label);

            }
            buttonZoneNaturale.Image = Image.FromFile("C:/Terra/butonZoneleNaturale - MouseMove.png");
        }

        private void buttonBiosfera_MouseMove(object sender, MouseEventArgs e)
        {
            if (index != 5)
            {
                pictureBoxBackground.Image = Image.FromFile("C:/Terra/Biosfera.png");
                index = 5;
                label.Text = "Unitatea 6. Terra - Biosfera si solurile";
                AlignLabel(label);

            }
            buttonBiosfera.Image = Image.FromFile("C:/Terra/butonBiosfera - MouseMove.png");
        }

        private void buttonAtmosfera_MouseMove(object sender, MouseEventArgs e)
        {
            if (index != 6)
            {
                pictureBoxBackground.Image = Image.FromFile("C:/Terra/Atmosfera.png");
                index = 6;
                label.Text = "Unitatea 4. Terra - Atmosfera";
                AlignLabel(label);

            }
            buttonAtmosfera.Image = Image.FromFile("C:/Terra/butonAtmosfera - MouseMove.png");
        }
        private void buttonLitosfera_MouseMove(object sender, MouseEventArgs e)
        {
            if (index != 7)
            {
                pictureBoxBackground.Image = Image.FromFile("C:/Terra/Litosfera.png");
                index = 7;
                label.Text = "Unitatea 3. Terra - Litosfera";
                AlignLabel(label);

            }
            buttonLitosfera.Image = Image.FromFile("C:/Terra/butonLitosfera - MouseMove.png");
        }
        private void buttonHidrosfera_MouseMove(object sender, MouseEventArgs e)
        {
            if (index != 8)
            {
                pictureBoxBackground.Image = Image.FromFile("C:/Terra/Hidrosfera.png");
                index = 8;
                label.Text = "Unitatea 5. Terra - Hidrosfera";
                AlignLabel(label);

            }
            buttonHidrosfera.Image = Image.FromFile("C:/Terra/butonHidrosfera - MouseMove.png");
        }
        private void buttonInapoi_MouseMove(object sender, MouseEventArgs e)
        {
            buttonInapoi.Image = Image.FromFile("C:/Terra/Back - MouseMove.png");
        }
        #endregion
        #region EventMouseDown
        private void buttonMiscarePamant_MouseDown(object sender, MouseEventArgs e)
        {
            buttonMiscarePamant.Image = Image.FromFile("C:/Terra/butonMiscarilePamantului - MouseDown.png");

        }

        private void buttonSistemSolar_MouseDown(object sender, MouseEventArgs e)
        {
            buttonSistemSolar.Image = Image.FromFile("C:/Terra/butonSistemSolar - MouseDown.png");

        }
        private void buttonTest_MouseDown(object sender, MouseEventArgs e)
        {
            buttonTest.Image = Image.FromFile("C:/Terra/butonTest - MouseDown.png");

        }
        private void buttonZoneNaturale_MouseDown(object sender, MouseEventArgs e)
        {
            buttonZoneNaturale.Image = Image.FromFile("C:/Terra/butonZoneleNaturale - MouseDown.png");

        }

        private void buttonBiosfera_MouseDown(object sender, MouseEventArgs e)
        {
            buttonBiosfera.Image = Image.FromFile("C:/Terra/butonBiosfera - MouseDown.png");

        }
        private void buttonAtmosfera_MouseDown(object sender, MouseEventArgs e)
        {
            buttonAtmosfera.Image = Image.FromFile("C:/Terra/butonAtmosfera - MouseDown.png");

        }
        private void buttonLitosfera_MouseDown(object sender, MouseEventArgs e)
        {
            buttonLitosfera.Image = Image.FromFile("C:/Terra/butonLitosfera - MouseDown.png");

        }
        private void buttonHidrosfera_MouseDown(object sender, MouseEventArgs e)
        {
            buttonHidrosfera.Image = Image.FromFile("C:/Terra/butonHidrosfera - MouseDown.png");

        }
        private void buttonInapoi_MouseDown(object sender, MouseEventArgs e)
        {
            buttonInapoi.Image = Image.FromFile("C:/Terra/Back - MouseDown.png");

        }
        #endregion
        #region EventMouseLeave
        private void buttonSistemSolar_MouseLeave(object sender, EventArgs e)
        {
            buttonSistemSolar.Image = Image.FromFile("C:/Terra/butonSistemSolar.png");

        }

        private void buttonMiscarePamant_MouseLeave(object sender, EventArgs e)
        {
            buttonMiscarePamant.Image = Image.FromFile("C:/Terra/butonMiscarilePamantului.png");

        }

        private void buttonTest_MouseLeave(object sender, EventArgs e)
        {
            buttonTest.Image = Image.FromFile("C:/Terra/butonTest.png");
        }

        private void buttonZoneNaturale_MouseLeave(object sender, EventArgs e)
        {
            buttonZoneNaturale.Image = Image.FromFile("C:/Terra/butonZoneleNaturale.png");

        }
        private void buttonBiosfera_MouseLeave(object sender, EventArgs e)
        {
            buttonBiosfera.Image = Image.FromFile("C:/Terra/butonBiosfera.png");

        }
        private void buttonAtmosfera_MouseLeave(object sender, EventArgs e)
        {
            buttonAtmosfera.Image = Image.FromFile("C:/Terra/butonAtmosfera.png");

        }
        private void buttonLitosfera_MouseLeave(object sender, EventArgs e)
        {
            buttonLitosfera.Image = Image.FromFile("C:/Terra/butonLitosfera.png");

        }
        private void buttonHidrosfera_MouseLeave(object sender, EventArgs e)
        {
            buttonHidrosfera.Image = Image.FromFile("C:/Terra/butonHidrosfera.png");

        }
        private void buttonInapoi_MouseLeave(object sender, EventArgs e)
        {
            buttonInapoi.Image = Image.FromFile("C:/Terra/Back.png");

        }
        #endregion

        private void buttonSistemSolar_Click(object sender, EventArgs e)
        {
            FormUnitatea1 formUnitatea1 = new FormUnitatea1();
            formUnitatea1.Owner = this;
            formUnitatea1.ShowDialog();
        }

        private void buttonMiscarePamant_Click(object sender, EventArgs e)
        {
            FormUnitatea2 formUnitatea2 = new FormUnitatea2();
            formUnitatea2.Owner = this;
            formUnitatea2.ShowDialog();
        }

        private void buttonLitosfera_Click(object sender, EventArgs e)
        {
            FormUnitatea3 formUnitatea3 = new FormUnitatea3();
            formUnitatea3.Owner = this;
            formUnitatea3.ShowDialog();
        }

        private void buttonAtmosfera_Click(object sender, EventArgs e)
        {
            FormUnitatea4 formUnitatea4 = new FormUnitatea4();
            formUnitatea4.Owner = this;
            formUnitatea4.ShowDialog();
        }

        private void buttonHidrosfera_Click(object sender, EventArgs e)
        {
            FormUnitatea5 formUnitatea5 = new FormUnitatea5();
            formUnitatea5.Owner = this;
            formUnitatea5.ShowDialog();
        }

        private void buttonBiosfera_Click(object sender, EventArgs e)
        {
            FormUnitatea6 formUnitatea6 = new FormUnitatea6();
            formUnitatea6.Owner = this;  
            formUnitatea6.ShowDialog();
        }

        private void buttonZoneNaturale_Click(object sender, EventArgs e)
        {
            FormUnitatea7 formUnitatea7 = new FormUnitatea7();
            formUnitatea7.Owner = this;
            formUnitatea7.ShowDialog();
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            FormUnitatea8 formUnitatea8 = new FormUnitatea8();
            formUnitatea8.Owner = this;
            this.Hide();
            formUnitatea8.ShowDialog();
            this.Show();
        }
    }
}
