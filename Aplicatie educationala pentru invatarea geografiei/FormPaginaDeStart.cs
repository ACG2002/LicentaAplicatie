using System;
using System.Drawing;
using System.Windows.Forms;

namespace Aplicatie_educationala_pentru_invatarea_geografiei
{
    public partial class FormPaginaDeStart : Form
    {
        public FormPaginaDeStart()
        {
            InitializeComponent();

            pictureBoxG.Image = Image.FromFile("C:/Terra/GeoLearn.gif");
            pictureBoxG.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBoxG.Visible = true;

            PersonalizareButoane.SetButtonImageRegion(buttonExit, "C:/Terra/Exit.png");
            PersonalizareButoane.SetButtonImageRegion(buttonStart, "C:/Terra/Start.png");
   

        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region EventMouseMove
        private void buttonExit_MouseMove(object sender, MouseEventArgs e)
        {
            buttonExit.Image = Image.FromFile("C:/Terra/Exit - MouseMove.png");
        }
        private void buttonStart_MouseMove(object sender, MouseEventArgs e)
        {
            buttonStart.Image = Image.FromFile("C:/Terra/Start - MouseMove.png");
        }

        #endregion
        #region EventMouseLeave
        private void buttonExit_MouseLeave(object sender, EventArgs e)
        {
            buttonExit.Image = Image.FromFile("C:/Terra/Exit.png");
        }
        private void buttonStart_MouseLeave(object sender, EventArgs e)
        {
            buttonStart.Image = Image.FromFile("C:/Terra/Start.png");
        }
        #endregion
        #region EventMouseDown
        private void buttonExit_MouseDown(object sender, MouseEventArgs e)
        {
            buttonExit.Image = Image.FromFile("C:/Terra/Exit - MouseDown.png");
        }
        private void buttonStart_MouseDown(object sender, MouseEventArgs e)
        {
            buttonStart.Image = Image.FromFile("C:/Terra/Start - MouseDown.png");
        }
        #endregion


        private int timpTrecut = 0;
        private void buttonStart_Click(object sender, EventArgs e)
        {
            BackgroundImage = Image.FromFile("C:/Terra/Loading.png");
            buttonStart.Visible = false;
            pictureBoxG.Visible = false;
            buttonExit.Visible = false;
            timerLoading.Start(); 

        }

        private void timerLoading_Tick(object sender, EventArgs e)
        { FormLectii formLectii = new FormLectii();
            timpTrecut = timpTrecut + timerLoading.Interval;

            if (timpTrecut >= 10)
            {
                timerLoading.Stop();
                formLectii.Owner = this;
                formLectii.ShowDialog();

            }
            
        }
    }
}
