namespace task_manager
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idUlohy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazovUlohy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.terminDokoncenia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotova = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1_TaskDone = new System.Windows.Forms.CheckBox();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUlohy,
            this.nazovUlohy,
            this.terminDokoncenia,
            this.hotova});
            this.dataGridView1.Location = new System.Drawing.Point(9, 152);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(0, 10, 10, 10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(700, 526);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // idUlohy
            // 
            this.idUlohy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idUlohy.DataPropertyName = "idUlohy";
            this.idUlohy.HeaderText = "ID";
            this.idUlohy.MinimumWidth = 8;
            this.idUlohy.Name = "idUlohy";
            this.idUlohy.ReadOnly = true;
            this.idUlohy.Width = 62;
            // 
            // nazovUlohy
            // 
            this.nazovUlohy.DataPropertyName = "nazovUlohy";
            this.nazovUlohy.HeaderText = "Názov úlohy";
            this.nazovUlohy.MinimumWidth = 8;
            this.nazovUlohy.Name = "nazovUlohy";
            this.nazovUlohy.ReadOnly = true;
            // 
            // terminDokoncenia
            // 
            this.terminDokoncenia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.terminDokoncenia.DataPropertyName = "terminDokoncenia";
            this.terminDokoncenia.HeaderText = "Termín dokončenia";
            this.terminDokoncenia.MinimumWidth = 8;
            this.terminDokoncenia.Name = "terminDokoncenia";
            this.terminDokoncenia.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.terminDokoncenia.Width = 164;
            // 
            // hotova
            // 
            this.hotova.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.hotova.DataPropertyName = "hotova";
            this.hotova.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.hotova.HeaderText = "Hotová";
            this.hotova.MinimumWidth = 8;
            this.hotova.Name = "hotova";
            this.hotova.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.hotova.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.hotova.Width = 96;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("ISOCPEUR", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker1.Location = new System.Drawing.Point(310, 95);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(399, 37);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.Value = new System.DateTime(2024, 7, 21, 2, 22, 5, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("ISOCPEUR", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.ForeColor = System.Drawing.Color.Gray;
            this.textBox1.Location = new System.Drawing.Point(80, 14);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(629, 37);
            this.textBox1.TabIndex = 6;
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("ISOCPEUR", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ImageIndex = 0;
            this.button2.ImageList = this.imageList1;
            this.button2.Location = new System.Drawing.Point(9, 69);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(289, 68);
            this.button2.TabIndex = 7;
            this.button2.Text = "Pridať úlohu";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "plus.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("ISOCPEUR", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(313, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nastaviť termín dokončenia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("ISOCPEUR", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(316, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "Úlohu je potrebné pomenovať";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Visible = false;
            // 
            // checkBox1_TaskDone
            // 
            this.checkBox1_TaskDone.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox1_TaskDone.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1_TaskDone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkBox1_TaskDone.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox1_TaskDone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox1_TaskDone.FlatAppearance.BorderSize = 0;
            this.checkBox1_TaskDone.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.checkBox1_TaskDone.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.checkBox1_TaskDone.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.checkBox1_TaskDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1_TaskDone.Font = new System.Drawing.Font("ISOCPEUR", 8.25F);
            this.checkBox1_TaskDone.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBox1_TaskDone.ImageIndex = 0;
            this.checkBox1_TaskDone.ImageList = this.imageList2;
            this.checkBox1_TaskDone.Location = new System.Drawing.Point(9, 14);
            this.checkBox1_TaskDone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox1_TaskDone.Name = "checkBox1_TaskDone";
            this.checkBox1_TaskDone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBox1_TaskDone.Size = new System.Drawing.Size(63, 37);
            this.checkBox1_TaskDone.TabIndex = 15;
            this.checkBox1_TaskDone.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.checkBox1_TaskDone.UseVisualStyleBackColor = false;
            this.checkBox1_TaskDone.CheckedChanged += new System.EventHandler(this.checkBox1_TaskDone_CheckedChanged);
            this.checkBox1_TaskDone.MouseLeave += new System.EventHandler(this.checkBox1_TaskDone_MouseLeave);
            this.checkBox1_TaskDone.MouseMove += new System.Windows.Forms.MouseEventHandler(this.checkBox1_TaskDone_MouseMove);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "check (2).png");
            this.imageList2.Images.SetKeyName(1, "check.png");
            this.imageList2.Images.SetKeyName(2, "check (1).png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(766, 1062);
            this.Controls.Add(this.checkBox1_TaskDone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manažér úloh";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Enter += new System.EventHandler(this.Form1_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1_TaskDone;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUlohy;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazovUlohy;
        private System.Windows.Forms.DataGridViewTextBoxColumn terminDokoncenia;
        private System.Windows.Forms.DataGridViewCheckBoxColumn hotova;
    }
}

