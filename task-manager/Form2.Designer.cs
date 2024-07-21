namespace task_manager
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1_NázovÚlohy = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.checkBox1_TaskDone = new System.Windows.Forms.CheckBox();
            this.Checkbox_image_list = new System.Windows.Forms.ImageList(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("ISOCPEUR", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(5, 134);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kontajner";
            // 
            // textBox1_NázovÚlohy
            // 
            this.textBox1_NázovÚlohy.Font = new System.Drawing.Font("ISOCPEUR", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1_NázovÚlohy.Location = new System.Drawing.Point(89, 14);
            this.textBox1_NázovÚlohy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1_NázovÚlohy.Name = "textBox1_NázovÚlohy";
            this.textBox1_NázovÚlohy.Size = new System.Drawing.Size(835, 44);
            this.textBox1_NázovÚlohy.TabIndex = 1;
            this.textBox1_NázovÚlohy.Text = "TEST";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("ISOCPEUR", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(319, 134);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Priebeh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("ISOCPEUR", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(635, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Priorita";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("ISOCPEUR", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(5, 257);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Počiatočný dátum";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("ISOCPEUR", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Doma",
            "Škola",
            "Práca",
            "Iné"});
            this.comboBox1.Location = new System.Drawing.Point(11, 171);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(15, 8, 15, 15);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(283, 37);
            this.comboBox1.TabIndex = 6;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("ISOCPEUR", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Nezačaté",
            "Prebieha",
            "Dokončené"});
            this.comboBox2.Location = new System.Drawing.Point(325, 171);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(15, 8, 15, 15);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(283, 37);
            this.comboBox2.TabIndex = 7;
            this.comboBox2.Click += new System.EventHandler(this.comboBox2_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("ISOCPEUR", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Naliehavé",
            "Dôležité",
            "Stredná",
            "Nízka"});
            this.comboBox3.Location = new System.Drawing.Point(641, 171);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(15, 8, 15, 15);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(283, 37);
            this.comboBox3.TabIndex = 8;
            this.comboBox3.Click += new System.EventHandler(this.comboBox3_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("ISOCPEUR", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(11, 294);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(15, 8, 15, 15);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(283, 35);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("ISOCPEUR", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(325, 294);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(15, 8, 15, 15);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(283, 35);
            this.dateTimePicker2.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("ISOCPEUR", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(319, 258);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Termín dokončenia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("ISOCPEUR", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(636, 258);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 29);
            this.label6.TabIndex = 12;
            this.label6.Text = "Opakovať";
            // 
            // comboBox4
            // 
            this.comboBox4.Font = new System.Drawing.Font("ISOCPEUR", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Neopakuje sa",
            "Každý deň",
            "Pracovné dni",
            "Každý týždeň",
            "Mesačne",
            "Každý rok",
            "Vlastné"});
            this.comboBox4.Location = new System.Drawing.Point(641, 294);
            this.comboBox4.Margin = new System.Windows.Forms.Padding(15, 8, 15, 15);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(283, 37);
            this.comboBox4.TabIndex = 13;
            this.comboBox4.Click += new System.EventHandler(this.comboBox4_Click);
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
            this.checkBox1_TaskDone.ImageList = this.Checkbox_image_list;
            this.checkBox1_TaskDone.Location = new System.Drawing.Point(11, 14);
            this.checkBox1_TaskDone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox1_TaskDone.Name = "checkBox1_TaskDone";
            this.checkBox1_TaskDone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBox1_TaskDone.Size = new System.Drawing.Size(63, 65);
            this.checkBox1_TaskDone.TabIndex = 14;
            this.checkBox1_TaskDone.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.checkBox1_TaskDone.UseVisualStyleBackColor = false;
            this.checkBox1_TaskDone.CheckedChanged += new System.EventHandler(this.checkBox1_TaskDone_CheckedChanged);
            this.checkBox1_TaskDone.MouseLeave += new System.EventHandler(this.checkBox1_TaskDone_MouseLeave);
            this.checkBox1_TaskDone.MouseMove += new System.Windows.Forms.MouseEventHandler(this.checkBox1_TaskDone_MouseMove);
            // 
            // Checkbox_image_list
            // 
            this.Checkbox_image_list.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Checkbox_image_list.ImageStream")));
            this.Checkbox_image_list.TransparentColor = System.Drawing.Color.Transparent;
            this.Checkbox_image_list.Images.SetKeyName(0, "check (2).png");
            this.Checkbox_image_list.Images.SetKeyName(1, "check.png");
            this.Checkbox_image_list.Images.SetKeyName(2, "check (1).png");
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(10, 397);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(913, 144);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("ISOCPEUR", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(6, 360);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 29);
            this.label7.TabIndex = 16;
            this.label7.Text = "Poznámky";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1047, 635);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.checkBox1_TaskDone);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1_NázovÚlohy);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detail úlohy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1_NázovÚlohy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.CheckBox checkBox1_TaskDone;
        private System.Windows.Forms.ImageList Checkbox_image_list;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label7;
    }
}