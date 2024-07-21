using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using TaskManager;


namespace task_manager
{
    public partial class Form2 : Form
    {
        public Uloha NovaUloha { get; private set; }

        public Form2()
        {
            InitializeComponent();
            comboBox2.Text = "Nezačaté";
            comboBox3.Text = "Stredná";
            comboBox4.Text = "Neopakuje sa";
            NovaUloha = new Uloha();
        }

        public Form2(Uloha uloha) : this()
        {
            NovaUloha = uloha;
            textBox1_NázovÚlohy.Text = uloha.nazovUlohy;
            checkBox1_TaskDone.Checked = uloha.hotova;
            comboBox1.Text = uloha.kontajner;
            comboBox2.Text = uloha.priebeh;
            comboBox3.Text = uloha.priorita;
            comboBox4.Text = uloha.opakovat;
            richTextBox1.Text = uloha.poznamka;
            dateTimePicker1.Value = uloha.pociatocnyDatum;
            dateTimePicker2.Value = uloha.terminDokoncenia;
        }

        private void checkBox1_TaskDone_CheckedChanged(object sender, EventArgs e)
        {
            //zmena ikoniek checkboxu
            if (checkBox1_TaskDone.Checked)
            {
                checkBox1_TaskDone.ImageIndex = 2;
                textBox1_NázovÚlohy.Font = new Font("ISOCPEUR", 14.25f, FontStyle.Bold | FontStyle.Strikeout);
            }
            else
            {
                checkBox1_TaskDone.ImageIndex = 0;
                textBox1_NázovÚlohy.Font = new Font("ISOCPEUR", 14.25f, FontStyle.Bold | FontStyle.Regular);
            }
        }

        private void checkBox1_TaskDone_MouseMove(object sender, MouseEventArgs e)
        {
            //zmena ikoniek checkboxu
            if (checkBox1_TaskDone.Checked)
                checkBox1_TaskDone.ImageIndex = 2;
            else
                checkBox1_TaskDone.ImageIndex = 1;
        }

        private void checkBox1_TaskDone_MouseLeave(object sender, EventArgs e)
        {
            //zmena ikoniek checkboxu
            if (checkBox1_TaskDone.Checked)
                checkBox1_TaskDone.ImageIndex = 2;
            else
                checkBox1_TaskDone.ImageIndex = 0;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            NovaUloha.nazovUlohy = textBox1_NázovÚlohy.Text;
            NovaUloha.hotova = checkBox1_TaskDone.Checked;
            NovaUloha.kontajner = comboBox1.Text;
            NovaUloha.priebeh = comboBox2.Text;
            NovaUloha.priorita = comboBox3.Text;
            NovaUloha.opakovat = comboBox4.Text;
            NovaUloha.poznamka = richTextBox1.Text;
            NovaUloha.pociatocnyDatum = dateTimePicker1.Value;
            NovaUloha.terminDokoncenia = dateTimePicker2.Value;
            UlohaManager.AktualizujUlohu(NovaUloha);
        }

        private void comboBox2_Click(object sender, EventArgs e)
        {
            comboBox2.DroppedDown = true;
        }

        private void comboBox3_Click(object sender, EventArgs e)
        {
            comboBox3.DroppedDown = true;
        }

        private void comboBox4_Click(object sender, EventArgs e)
        {
            comboBox4.DroppedDown = true;
        }
    }
}
