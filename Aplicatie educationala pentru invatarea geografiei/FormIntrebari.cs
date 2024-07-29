using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Aplicatie_educationala_pentru_invatarea_geografiei
{
  
    public partial class FormIntrebari : Form
    {   
        private List<string> listaRaspunsuriCorecte = new List<string>();
        private Label[] labels;
        private RadioButton[] radioButtons;
        private GroupBox[] groupBox;
        private DateTime startTime;
        public FormIntrebari(string label)
        {
            InitializeComponent();
           
            PersonalizareButoane.SetButtonImageRegion(buttonBack, "C:/Terra/Back.png");
            string Unitate = Convert.ToString(label);
            int Unitate_id = DataBase.ExtractUnitate_id(label);
            List<int> listaIntrebare_id = new List<int>();
            int intrebare_id;
            List<Intrebari> listaIntrebari = DataBase.ExtractIntrebari(DataBase.ExtractUnitate_id(Unitate));

           foreach(var intrebare in listaIntrebari) 
            {
                listaIntrebare_id.Add(intrebare.Intrebare_id);
            }
            List<Raspunsuri> listaRaspunsuri = DataBase.ExtractRaspunsuriPeUnitate(Unitate_id, listaIntrebare_id);
           
            labels = new Label[] { label1, label2, label3, label4, label5, label6, label7, label8, label9, label10 };
            radioButtons = new RadioButton[] { radioButton1, radioButton2, radioButton3, radioButton4, radioButton5, radioButton6, radioButton7, radioButton8, radioButton9 , radioButton10 , radioButton11 , radioButton12, radioButton13, radioButton14, radioButton15, radioButton16, radioButton17, radioButton18, radioButton19, radioButton20, radioButton21, radioButton22, radioButton23, radioButton24, radioButton25, radioButton26, radioButton27, radioButton28, radioButton29, radioButton30, radioButton31, radioButton32, radioButton33, radioButton34, radioButton35, radioButton36, radioButton37, radioButton38, radioButton39, radioButton40 };
            groupBox = new GroupBox[] { groupBox1, groupBox2 , groupBox3 , groupBox4 , groupBox5 , groupBox6 , groupBox7 , groupBox8 , groupBox9 , groupBox10 };

            for (int k = 0; k < 40; k++) //modificat
            {
                for (int j = 0; j < 10; j++)
                {
                    labels[j].Text = Convert.ToString(listaIntrebari[j].Intrebare_text);
                    intrebare_id = listaIntrebari[j].Intrebare_id;
                    for (int i = 0; i < 40; i++)
                    {
                        if (listaRaspunsuri[i].Raspuns_Intrebare_id == intrebare_id)
                        {
                            if (listaRaspunsuri[i].Raspuns_status == "Corect")
                                listaRaspunsuriCorecte.Add(listaRaspunsuri[i].Raspuns_text);
                            radioButtons[k].Text = Convert.ToString(listaRaspunsuri[i].Raspuns_text);
                            if (k < 39)
                                k++;

                        }

                    }
                }
            }

        }

      
        private List<string> RaspunsuriPrimite()
        {
            List<string> raspunsuriSelectate = new List<string>();

            foreach (Control control in Controls)
            {
                if (control is GroupBox groupBox)
                {
                    var (isSelected, selectedText) = VerificareRBSelectat(groupBox);
                    if (isSelected)
                    {
                        raspunsuriSelectate.Add(selectedText);
                    }
                    else
                    {
                        control.ForeColor = Color.Red;
                    }
                        
                }
                
            }
            raspunsuriSelectate.Reverse();
            return raspunsuriSelectate;
        }
        private void FormIntrebari_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormUnitatea8 formUnitatea8 = new FormUnitatea8();
            this.Hide();
            formUnitatea8.ShowDialog();

         
        }

        private void buttonTrimite_Click(object sender, EventArgs e)
        {
            
            List<string> listaRaspunsuriPrimite = RaspunsuriPrimite();
            int k = listaRaspunsuriPrimite.Count;

            if (k == 0)
            {
                labelInfo.Visible = true;
                labelInfo.Text = "Nu ai raspuns la nicio intrebare!";
                startTime = DateTime.Now;
                timer1.Start();
                labelInfo.ForeColor = Color.Red;


            }
            else if (k > 0 && k < 10)
            {
                startTime = DateTime.Now;
                timer1.Start();
                labelInfo.Visible = true;
                foreach (Control control in Controls)
                {
                    if (control is GroupBox groupBox)
                    {
                        var (isSelected, selectedText) = VerificareRBSelectat(groupBox);
                        if (isSelected)
                            control.ForeColor = Color.Black;
                        else
                            control.ForeColor = Color.Red;
                    }

                }

                labelInfo.Text = "Ai lasat cateva intrebari nerezolvate!";
                labelInfo.ForeColor = Color.Red;
            }
            else if (k == 10)
            {
                buttonTrimite.Visible = false;
                labelInfo.ForeColor = Color.Black;
                int raspCorecte = 0;
                groupBox = new GroupBox[] { groupBox1, groupBox2, groupBox3, groupBox4, groupBox5, groupBox6, groupBox7, groupBox8, groupBox9, groupBox10 };

                for (int i = 0; i < listaRaspunsuriPrimite.Count; i++)
                {
                    RadioButton radioButton = RBSelectat(groupBox[i]);
                    if (listaRaspunsuriCorecte[i] == listaRaspunsuriPrimite[i])
                    {
                        raspCorecte++;
                        radioButton.ForeColor = Color.Green;

                    }
                    else
                        if (radioButton.Text != listaRaspunsuriCorecte[i])
                        radioButton.ForeColor = Color.Red;

                    for (int l = 0; l < listaRaspunsuriCorecte.Count; l++)
                        for (int j = l * 4; j < l * 4 + 4; j++)
                        {
                            if (radioButtons[j].Text == listaRaspunsuriCorecte[l])
                                radioButtons[j].ForeColor = Color.Green;
                        }
                }
                if (raspCorecte == 0)
                {
                    labelInfo.Text = "Nu ai raspuns corect la nicio intrebare";
                    labelInfo.Location = new System.Drawing.Point(160, 450);
                }
                else
                {
                    labelInfo.Text = "Ai luat nota " + Convert.ToString(raspCorecte) + "!";
                    labelInfo.Location = new System.Drawing.Point(650, 450);

                }

                foreach (Control control in Controls)
                {
                    control.Visible = false;
                    control.ForeColor = Color.Black;
                }
                labelInfo.Visible = true;
                pictureBoxBackground.Visible = true;
                buttonBack.Visible = true;
                buttonIntrebariGresite.Visible = true;
                labelInfo.Font = new Font("UD Digi Kyokasho NK-B", 46, FontStyle.Bold);

              
            }
        }

        private (bool, string) VerificareRBSelectat(GroupBox groupBox)
        {
            foreach (Control control in groupBox.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked == true)
                {
                    return (true, radioButton.Text);
                }
            }
            return (false, "");
        }
        private RadioButton RBSelectat(GroupBox groupBox)
        {
            foreach (Control control in groupBox.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked == true)
                {
                     return radioButton;
                }
            }
            return null;
           
  
        }
         private void buttonIntrebariGresite_Click(object sender, EventArgs e)
         {
            foreach (Control control in Controls)
            {
                control.Visible = true;

            }
            buttonTrimite.Visible = false;
            buttonIntrebariGresite.Visible = false;
            labelInfo.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if ((DateTime.Now - startTime).TotalMilliseconds > 3000)
            {
                timer1.Stop();
                foreach (Control control in Controls)
                {
                    control.ForeColor = Color.Black;
                }
            }
            labelInfo.ForeColor = Color.Red;
        }
    }
}