using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TaskManager;


namespace task_manager
{
    public partial class Form1 : Form
    {
        private List<Uloha> ulohy;

        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "Zadajte názov úlohy * (povinné)";
            textBox1.Font = new Font("ISOCPEUR", 12f, FontStyle.Regular);
            textBox1.ForeColor = Color.Gray;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            dataGridView1.CurrentCellDirtyStateChanged += dataGridView1_CurrentCellDirtyStateChanged;
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            ulohy = UlohaManager.NacitajZXml();
            AktualizujZoznamUloh();

            // Skontrolovanie, či sú nejaké úlohy
            if (ulohy.Count == 0)
            {
                //MessageBox.Show("Žiadne úlohy neboli načítané.");
            }
            else
            {
                MessageBox.Show("Úlohy boli úspešne načítané.");
            }
        }

        private void AktualizujZoznamUloh()
        {
            ulohy = UlohaManager.NacitajZXml();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ulohy;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || textBox1.Text == "Zadajte názov úlohy * (povinné)")
            {
                label2.Visible = true;
                textBox1.Focus();
            }
            else
            {
                Uloha novaUloha = new Uloha
                {
                    idUlohy = GenerujId(),
                    nazovUlohy = textBox1.Text,
                    hotova = checkBox1_TaskDone.Checked,
                    kontajner = "",
                    priebeh = "",
                    priorita = "",
                    opakovat = "",
                    poznamka = "",
                    pociatocnyDatum = DateTime.Now,
                    terminDokoncenia = dateTimePicker1.Checked ? dateTimePicker1.Value : DateTime.Now.AddDays(7) // predvolené od teraz o 7 dní
                };

                ulohy.Add(novaUloha);
                bool uspech = UlohaManager.UlozDoXml(ulohy);

                if (uspech)
                {
                    AktualizujZoznamUloh();
                    // Reset vstupných polí
                    textBox1.Text = "Zadajte názov úlohy * (povinné)";
                    textBox1.Font = new Font("ISOCPEUR", 12f, FontStyle.Regular);
                    textBox1.ForeColor = Color.Gray;
                    label1.BringToFront();
                    label2.Visible = false;
                    checkBox1_TaskDone.ImageIndex = 0;
                    dateTimePicker1.Checked = false;
                };
            }
        }

        // Funkcia na generovanie ID úlohy
        private int GenerujId()
        {
            int maxId = ulohy.Count > 0 ? ulohy.Max(u => u.idUlohy) : 0;
            return maxId + 1;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label1.SendToBack();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Zadajte názov úlohy * (povinné)")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "Zadajte názov úlohy * (povinné)";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                Uloha vybranaUloha = ulohy[e.RowIndex];
                if (e.ColumnIndex == dataGridView1.Columns["idUlohy"].Index || e.ColumnIndex == dataGridView1.Columns["nazovUlohy"].Index)
                {
                    Form2 upravitUlohuForm = new Form2(vybranaUloha);
                    if (upravitUlohuForm.ShowDialog() == DialogResult.OK)
                    {
                        ulohy[e.RowIndex] = upravitUlohuForm.NovaUloha;
                        UlohaManager.UlozDoXml(ulohy);
                        AktualizujZoznamUloh();
                    }
                }
            }
        }

        private void Form1_Enter(object sender, EventArgs e)
        {
            AktualizujZoznamUloh();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            AktualizujZoznamUloh();
        }

        private void checkBox1_TaskDone_CheckedChanged(object sender, EventArgs e)
        {
            //zmena ikoniek checkboxu
            if (checkBox1_TaskDone.Checked)
            {
                checkBox1_TaskDone.ImageIndex = 2;
                textBox1.Font = new Font("ISOCPEUR", 12, FontStyle.Regular | FontStyle.Strikeout);
            }
            else
            {
                checkBox1_TaskDone.ImageIndex = 0;
                textBox1.Font = new Font("ISOCPEUR", 12, FontStyle.Regular);
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

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "nazovUlohy")
            {
                if ((bool)dataGridView1.Rows[e.RowIndex].Cells["hotova"].Value)
                {
                    e.CellStyle.Font = new Font(dataGridView1.DefaultCellStyle.Font, FontStyle.Strikeout);
                }
                else
                {
                    e.CellStyle.Font = new Font(dataGridView1.DefaultCellStyle.Font, FontStyle.Regular);
                }
            }             

            if (dataGridView1.Columns[e.ColumnIndex].Name == "terminDokoncenia")
            {
                DateTime terminDokoncenia = (DateTime)e.Value;
                var uloha = ulohy[e.RowIndex];
                DateTime pociatocnyDatum = uloha.pociatocnyDatum;

                if (terminDokoncenia < pociatocnyDatum)
                {
                    e.CellStyle.ForeColor = Color.Red;
                }
                else
                {
                    e.CellStyle.ForeColor = dataGridView1.DefaultCellStyle.ForeColor;
                }
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int idUlohy = (int)dataGridView1.Rows[e.RowIndex].Cells["idUlohy"].Value;
            var uloha = ulohy.FirstOrDefault(u => u.idUlohy == idUlohy);

            if (uloha != null)
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "hotova")
                {
                    bool isChecked = (bool)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                    uloha.hotova = isChecked;
                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "terminDokoncenia")
                {
                    DateTime terminDokoncenia;
                    if (DateTime.TryParse(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), out terminDokoncenia))
                    {
                        uloha.terminDokoncenia = terminDokoncenia;
                    }
                }
                UlohaManager.UlozDoXml(ulohy);
                dataGridView1.InvalidateRow(e.RowIndex);
            }
        }

        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell is DataGridViewCheckBoxCell || dataGridView1.CurrentCell is DataGridViewTextBoxCell)
            {
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
    }
}