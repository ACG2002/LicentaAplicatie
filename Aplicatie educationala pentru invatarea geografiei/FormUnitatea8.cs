using System;
using System.Windows.Forms;

namespace Aplicatie_educationala_pentru_invatarea_geografiei
{
    public partial class FormUnitatea8 : Form
    {
        int screenWidth = Screen.PrimaryScreen.Bounds.Width;
        int screenHeight = Screen.PrimaryScreen.Bounds.Height;
        public FormUnitatea8()
        {
            InitializeComponent();

            PersonalizareButoane.SetButtonImageRegion(buttonBack, "C:/Terra/Back.png");
            AlignLabel(label);
          
        }
        private void FormUnitatea8_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            //this.Owner.Show();
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
        private void buttonSistemSolar_Click(object sender, EventArgs e)
        {
            FormIntrebari formIntrebari = new FormIntrebari(label.Text);
            this.Hide();
            formIntrebari.ShowDialog();
            
        }

        private void buttonSistemSolar_MouseMove(object sender, MouseEventArgs e)
        {
            label.Text = "Terra - o planeta a Universului";
            AlignLabel(label);
        }

        private void buttonMiscarePamant_Click(object sender, EventArgs e)
        {
            FormIntrebari formIntrebari = new FormIntrebari(label.Text);
            this.Hide();
            formIntrebari.ShowDialog();

        }

        private void buttonMiscarePamant_MouseMove(object sender, MouseEventArgs e)
        {
            label.Text = "Terra - o planeta in miscare";
            AlignLabel(label);
        }

        private void buttonLitosfera_Click(object sender, EventArgs e)
        {
            FormIntrebari formIntrebari = new FormIntrebari(label.Text);
            this.Hide();
            formIntrebari.ShowDialog();
        }

        private void buttonLitosfera_MouseMove(object sender, MouseEventArgs e)
        {
            label.Text = "Terra - Litosfera";
            AlignLabel(label);
        }

        private void buttonAtmosfera_Click(object sender, EventArgs e)
        {
            FormIntrebari formIntrebari = new FormIntrebari(label.Text);
            this.Hide();
            formIntrebari.ShowDialog();
        }

        private void buttonAtmosfera_MouseMove(object sender, MouseEventArgs e)
        {
            label.Text = "Terra - Atmosfera";
            AlignLabel(label);
        }

        private void buttonHidrosfera_Click(object sender, EventArgs e)
        {
            FormIntrebari formIntrebari = new FormIntrebari(label.Text);
            this.Hide();
            formIntrebari.ShowDialog();
        }

        private void buttonHidrosfera_MouseMove(object sender, MouseEventArgs e)
        {
            label.Text = "Terra - Hidrosfera";
            AlignLabel(label);
        }

        private void buttonBiosfera_Click(object sender, EventArgs e)
        {
            FormIntrebari formIntrebari = new FormIntrebari(label.Text);
            this.Hide();
            formIntrebari.ShowDialog();
        }

        private void buttonBiosfera_MouseMove(object sender, MouseEventArgs e)
        {
            label.Text = "Terra - Biosfera";
            AlignLabel(label);
        }

        private void buttonZoneNaturale_Click(object sender, EventArgs e)
        {
            FormIntrebari formIntrebari = new FormIntrebari(label.Text);
            this.Hide();
            formIntrebari.ShowDialog();
        }

        private void buttonZoneNaturale_MouseMove(object sender, MouseEventArgs e)
        {
            label.Text = "Terra - Zonele naturale ale Terrei";
            AlignLabel(label);
        }

        private void buttonGeoLearn_Click(object sender, EventArgs e)
        {
            FormIntrebariAll formIntrebariAll = new FormIntrebariAll();
            this.Hide();
            formIntrebariAll.ShowDialog();
        }
    }
}
