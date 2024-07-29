using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace Aplicatie_educationala_pentru_invatarea_geografiei
{
    public partial class FormIntrebariAll : Form
    {
        private RadioButton[] radioButtons;
        private List<string> listaRaspunsuriPrimite = new List<string>();
        private List<string> listaRaspunsuriCorecte = new List<string>();
        private List<Intrebari> listaIntrebari = new List<Intrebari>();
        private List<Raspunsuri> listaRaspunsuri = new List<Raspunsuri>();
        private int index = 0;
        private List<Intrebari> listaIntrebariRaspunse = new List<Intrebari>();
        private int j = 0;
        private List<int> listaPozitiiRB = new List<int>();
        private int Unitate1 = 0;
        private int Unitate2 = 0;
        private int Unitate3 = 0;
        private int Unitate4 = 0;
        private int Unitate5 = 0;
        private int Unitate6 = 0;
        private int Unitate7 = 0;
        List<Intrebari> listaIntrebariC = new List<Intrebari>();
        public FormIntrebariAll()
        {
            InitializeComponent();

            PersonalizareButoane.SetButtonImageRegion(buttonBack, "C:/Terra/Back.png");

            List<Unitate> listaUnitati = DataBase.ExtractUnitatiId();
            listaIntrebari = DataBase.ExtractIntrebari(listaUnitati);


            Random random = new Random();
            Shuffle(listaIntrebari, random);

            

            List<int> listaIntrebari_id = new List<int>();
            foreach (var intrebare in listaIntrebari)
            {
                listaIntrebari_id.Add(intrebare.Intrebare_id);
            }
            listaRaspunsuri = DataBase.ExtractRaspunsuri(listaIntrebari_id);

            radioButtons = new RadioButton[] { radioButton1, radioButton2, radioButton3, radioButton4 };

            labelIntrebare.Text = listaIntrebari[0].Intrebare_text;
            int i = 0;
            foreach (var raspuns in listaRaspunsuri)
            {
                if (raspuns.Raspuns_Intrebare_id == listaIntrebari[0].Intrebare_id)
                {
                    radioButtons[i].Text = raspuns.Raspuns_text;
                    radioButtons[i].Checked = false;
                   i++;
                }
            }
           
            foreach (var intrebare in listaIntrebari)
            {
                listaIntrebariC.Add(intrebare);
            } 
    

        }
        public static void Shuffle(List<Intrebari> listaIntrebari, Random random)
        {
            int n = listaIntrebari.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                Intrebari value = listaIntrebari[k];
                listaIntrebari[k] = listaIntrebari[n];
                listaIntrebari[n] = value;
            }
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormUnitatea8 formUnitatea8 = new FormUnitatea8();
            this.Hide();
            formUnitatea8.ShowDialog();

        }

        private void FormIntrebariAll_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

                
        private string VerificareRBSelectat(GroupBox groupBox)
        {
            foreach (Control control in groupBox.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked == true)
                {
                    return radioButton.Text;
                }
            }
            return "";
        }
        private void buttonUrmatorul_Click(object sender, EventArgs e)
        {
            if (AlertaRaspuns())
            {
                return;
            }
            
            int i = 0;
     
            if (index == 34) // modificare
            {
                buttonAmanare.Visible = false;
                buttonUrmatorul.Visible = false;
                buttonTrimite.Visible = true;

            }
            else
            {
                listaIntrebariRaspunse.Add(listaIntrebari[0]);
                index++;

                listaIntrebari.RemoveAt(0);

                listaRaspunsuriPrimite.Add(VerificareRBSelectat(groupBox1));

                for (int j = 0; j < 4; j++) 
                {
                    if (radioButtons[j].Checked)
                        listaPozitiiRB.Add(j);
                }
               
                i = 0;
                labelIntrebare.Text = listaIntrebari[0].Intrebare_text;
                foreach (var raspuns in listaRaspunsuri)
                {
                    if (raspuns.Raspuns_Intrebare_id == listaIntrebari[0].Intrebare_id)
                    {
                        radioButtons[i].Text = raspuns.Raspuns_text;
                        i++;
                    }
                }
            }
               
            for (i = 0; i < listaIntrebariC.Count; i++)
                if (labelIntrebare.Text == listaIntrebariC[i].Intrebare_text)
                {
                    groupBox1.Text = Convert.ToString(i + 1) + ".";
                  
                }
            foreach(Control c in groupBox1.Controls)
            {
                if(c is RadioButton)
                {
                    RadioButton rb = c as RadioButton;
                    rb.Checked = false;
                }
            }
        }
        private bool AlertaRaspuns()
        {
            int i = 0;
            foreach (Control c in groupBox1.Controls)
            {
                if (c is RadioButton)
                {
                    RadioButton rb = c as RadioButton;
                    if(rb.Checked == true)
                    {
                        i = 1;
                        labelNota.Visible = false;
                    }
                        
                }
            }
            if (i == 0)
            {
                labelNota.Visible = true;
                labelNota.Text = "Selecteaza un raspuns";
                labelNota.ForeColor = Color.Red;
                return true;
            }
            return false;
        }
        private void buttonAmanare_Click(object sender, EventArgs e)
        {
            labelNota.Visible = false;
            int i = 0;
          
            i = 0;
            listaIntrebari.Add(listaIntrebari[0]);
            listaIntrebari.RemoveAt(0);

            labelIntrebare.Text = listaIntrebari[0].Intrebare_text;
            foreach (var raspuns in listaRaspunsuri)
            {
                if (raspuns.Raspuns_Intrebare_id == listaIntrebari[0].Intrebare_id)
                {
                    radioButtons[i].Text = raspuns.Raspuns_text;
                    i++;
                }
            }  
            for(i = 0; i<listaIntrebariC.Count; i++)
            if (labelIntrebare.Text == listaIntrebariC[i].Intrebare_text)
                groupBox1.Text = Convert.ToString(i + 1) + ".";
        }

        private void buttonTrimite_Click(object sender, EventArgs e)
        {
            labelNota.ForeColor = Color.Black;
            for (int j = 0; j < 4; j++)
            {
                if (radioButtons[j].Checked)
                    listaPozitiiRB.Add(j);
            }
            int[] Unitati = { Unitate1, Unitate2, Unitate3, Unitate4, Unitate5, Unitate6, Unitate7 };
            int raspCorecte = 0;
            listaIntrebariRaspunse.Add(listaIntrebari[0]);
            listaRaspunsuriPrimite.Add(VerificareRBSelectat(groupBox1));

            for (int i = 0; i < listaIntrebariRaspunse.Count; i++)
                foreach (var raspuns in listaRaspunsuri)
                {
                    if (raspuns.Raspuns_Intrebare_id == listaIntrebariRaspunse[i].Intrebare_id)
                    {
                        if (raspuns.Raspuns_status == "Corect")
                        {
                          
                            listaRaspunsuriCorecte.Add(raspuns.Raspuns_text); 
                            
                         
                        }
                    }
                }
            for (int i = 0; i < listaRaspunsuriCorecte.Count; i++)
                if (listaRaspunsuriCorecte[i] == listaRaspunsuriPrimite[i])
                {
                    raspCorecte++; 
                    Unitati[listaIntrebariRaspunse[i].Unitate_id - 1]++;
                }
            groupBox1.Visible = false;
            buttonTrimite.Visible = false;
            labelNota.Visible = true;
            if (raspCorecte == 0)
            {
                labelNota.Text = "Nu ai raspuns corect la nicio intrebare";
                labelNota.Location = new System.Drawing.Point(160, 450);
            }
            else
            {
                string nota = (raspCorecte * 0.2857142857).ToString("F1");
                labelNota.Text = "Ai luat nota " + Convert.ToString(nota) + "!";
                labelNota.Location = new System.Drawing.Point(650, 450);
            }
            labelNota.Font = new Font("UD Digi Kyokasho NK-B", 46, FontStyle.Bold);

            buttonGreseli.Visible = true;
            buttonGreseli.Location = new System.Drawing.Point(952, 827);

            if (raspCorecte < 35) 
            {
                int NumarMinim = Unitati.Min();
                labelRecapitulat.Visible = true;
                string Unitate_denumire = "";
                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < Unitati.Length; i++)
                {
                    if (Unitati[i] == NumarMinim)
                    {
                        Unitate_denumire = DataBase.ExtractUnitate(i + 1);
                        sb.Append(Unitate_denumire + ", ");
                    }
                }
                if (sb.Length > 0)
                {
                    sb.Length = sb.Length - 2;
                }
                labelRecapitulat.Text = labelRecapitulat.Text + sb.ToString();
            }
        }

        private void buttonGreseli_Click(object sender, EventArgs e)
        {
            int i = 0;
         
            foreach (Control control in Controls)
            {
                control.ForeColor = Color.Black;
            }
            groupBox1.Visible = true;
            labelNota.Location = new Point(labelNota.Location.X, 250);
            buttonGreseli.Visible = false;
            buttonUrmatorul.Visible = false;
            buttonNext.Visible = true;
            buttonAnteriorul.Visible = true;

            buttonNext.Location = new System.Drawing.Point(1287, 827);
            buttonAnteriorul.Location = new System.Drawing.Point(649, 827);

            groupBox1.Text = "1.";
            labelIntrebare.Text = listaIntrebariRaspunse[0].Intrebare_text;
            radioButtons[listaPozitiiRB[j]].Checked = true;

            foreach (var raspuns in listaRaspunsuri)
            {
                if (raspuns.Raspuns_Intrebare_id == listaIntrebariRaspunse[0].Intrebare_id)
                {
                    radioButtons[i].Text = raspuns.Raspuns_text;

                        if (radioButtons[i].Text == listaRaspunsuriCorecte[0])
                            radioButtons[i].ForeColor = Color.Green;
                    if (VerificareRBSelectat(groupBox1) == radioButtons[i].Text)
                    {
                        if (radioButtons[i].Text != listaRaspunsuriCorecte[0])
                            radioButtons[i].ForeColor = Color.Red;
                    }

                    i++;
                }
                
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            radioButton1.ForeColor = Color.Black;
            radioButton2.ForeColor = Color.Black;
            radioButton3.ForeColor = Color.Black;
            radioButton4.ForeColor = Color.Black;

            j++;
            groupBox1.Text = Convert.ToString(j+1) + ".";
            int i = 0;
           
            if (j > 0)
            {
                buttonAnteriorul.Visible = true;
            }
            if (j == listaIntrebariRaspunse.Count-1)
            {
                buttonNext.Visible = false;
            }
            
                labelIntrebare.Text = listaIntrebariRaspunse[j].Intrebare_text;
                radioButtons[listaPozitiiRB[j]].Checked = true;

                foreach (var raspuns in listaRaspunsuri)
                {
                    if (raspuns.Raspuns_Intrebare_id == listaIntrebariRaspunse[j].Intrebare_id)
                    {
                        radioButtons[i].Text = raspuns.Raspuns_text;
                       
                            if (radioButtons[i].Text == listaRaspunsuriCorecte[j])
                                radioButtons[i].ForeColor = Color.Green;
                        if (VerificareRBSelectat(groupBox1) == radioButtons[i].Text)
                        {
                            if (radioButtons[i].Text != listaRaspunsuriCorecte[j])
                                radioButtons[i].ForeColor = Color.Red;
                        }
                        i++;
                    }
                }
                i = 0;
        }

        private void buttonAnteriorul_Click(object sender, EventArgs e)
        {
            radioButton1.ForeColor = Color.Black;
            radioButton2.ForeColor = Color.Black;
            radioButton3.ForeColor = Color.Black;
            radioButton4.ForeColor = Color.Black;

            foreach (Control control in Controls)
            {
                control.ForeColor = Color.Black;
            }
            j--;
            groupBox1.Text = Convert.ToString(j + 1);

            int i = 0;
            if (j < listaIntrebariRaspunse.Count)
            {
                buttonNext.Visible = true;
            }
            if (j == 0)
            {
                buttonAnteriorul.Visible = false;
            }

                labelIntrebare.Text = listaIntrebariRaspunse[j].Intrebare_text;
                radioButtons[listaPozitiiRB[j]].Checked = true;

                foreach (var raspuns in listaRaspunsuri)
                {
                    if (raspuns.Raspuns_Intrebare_id == listaIntrebariRaspunse[j].Intrebare_id)
                    {
                        radioButtons[i].Text = raspuns.Raspuns_text;

                            if (radioButtons[i].Text == listaRaspunsuriCorecte[j])
                                radioButtons[i].ForeColor = Color.Green;
                        if (VerificareRBSelectat(groupBox1) == radioButtons[i].Text)
                        {
                            if (radioButtons[i].Text != listaRaspunsuriCorecte[j])
                                radioButtons[i].ForeColor = Color.Red;
                        }

                        
                        i++;
                    }
                }
                i = 0;
        }
    }
}
