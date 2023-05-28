namespace Zadaca_3 {
    partial class FrmNoviZahtjev {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNoviZahtjev));
            this.cbMenadzer = new System.Windows.Forms.ComboBox();
            this.cbVrstaOdsutnosti = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnStvori = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbMenadzer
            // 
            this.cbMenadzer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMenadzer.FormattingEnabled = true;
            this.cbMenadzer.Location = new System.Drawing.Point(97, 131);
            this.cbMenadzer.Name = "cbMenadzer";
            this.cbMenadzer.Size = new System.Drawing.Size(234, 28);
            this.cbMenadzer.TabIndex = 0;
            this.cbMenadzer.SelectedIndexChanged += new System.EventHandler(this.cbMenadzer_SelectedIndexChanged);
            // 
            // cbVrstaOdsutnosti
            // 
            this.cbVrstaOdsutnosti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVrstaOdsutnosti.FormattingEnabled = true;
            this.cbVrstaOdsutnosti.Location = new System.Drawing.Point(97, 231);
            this.cbVrstaOdsutnosti.Name = "cbVrstaOdsutnosti";
            this.cbVrstaOdsutnosti.Size = new System.Drawing.Size(234, 28);
            this.cbVrstaOdsutnosti.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(97, 361);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(601, 26);
            this.textBox1.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(490, 133);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(203, 26);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(490, 231);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(208, 26);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Odaberite Vašeg menadžera:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Odaberite vrstu odsutnosti:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(491, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Početak odsutnosti:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(491, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Završetak odsutnosti:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Dodatni opis:";
            // 
            // btnStvori
            // 
            this.btnStvori.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnStvori.Location = new System.Drawing.Point(333, 438);
            this.btnStvori.Name = "btnStvori";
            this.btnStvori.Size = new System.Drawing.Size(142, 35);
            this.btnStvori.TabIndex = 10;
            this.btnStvori.Text = "Stvori";
            this.btnStvori.UseVisualStyleBackColor = true;
            // 
            // FrmNoviZahtjev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(817, 516);
            this.Controls.Add(this.btnStvori);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cbVrstaOdsutnosti);
            this.Controls.Add(this.cbMenadzer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmNoviZahtjev";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novi zahtjev za odsutnost";
            this.Load += new System.EventHandler(this.frmNoviZahtjev_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMenadzer;
        private System.Windows.Forms.ComboBox cbVrstaOdsutnosti;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnStvori;
    }
}