namespace Zadaca_3 {
    partial class FrmPregledZahtjeva {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPregledZahtjeva));
            this.label1 = new System.Windows.Forms.Label();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.zahtjeviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iPS23_pjuros21DataSet = new Zadaca_3.IPS23_pjuros21DataSet();
            this.zahtjeviTableAdapter = new Zadaca_3.IPS23_pjuros21DataSetTableAdapters.ZahtjeviTableAdapter();
            this.dgvZahtjevi = new System.Windows.Forms.DataGridView();
            this.dBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnStvoriNoviZahtjev = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zahtjeviBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPS23_pjuros21DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZahtjevi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Povijest zahtjeva";
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // zahtjeviBindingSource
            // 
            this.zahtjeviBindingSource.DataMember = "Zahtjevi";
            this.zahtjeviBindingSource.DataSource = this.iPS23_pjuros21DataSet;
            // 
            // iPS23_pjuros21DataSet
            // 
            this.iPS23_pjuros21DataSet.DataSetName = "IPS23_pjuros21DataSet";
            this.iPS23_pjuros21DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zahtjeviTableAdapter
            // 
            this.zahtjeviTableAdapter.ClearBeforeFill = true;
            // 
            // dgvZahtjevi
            // 
            this.dgvZahtjevi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZahtjevi.Location = new System.Drawing.Point(69, 136);
            this.dgvZahtjevi.Margin = new System.Windows.Forms.Padding(4);
            this.dgvZahtjevi.Name = "dgvZahtjevi";
            this.dgvZahtjevi.RowHeadersWidth = 62;
            this.dgvZahtjevi.RowTemplate.Height = 28;
            this.dgvZahtjevi.Size = new System.Drawing.Size(962, 310);
            this.dgvZahtjevi.TabIndex = 1;
            // 
            // dBBindingSource
            // 
            this.dBBindingSource.DataSource = typeof(DBLayer.DB);
            // 
            // dBBindingSource1
            // 
            this.dBBindingSource1.DataSource = typeof(DBLayer.DB);
            // 
            // btnStvoriNoviZahtjev
            // 
            this.btnStvoriNoviZahtjev.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnStvoriNoviZahtjev.Location = new System.Drawing.Point(839, 537);
            this.btnStvoriNoviZahtjev.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStvoriNoviZahtjev.Name = "btnStvoriNoviZahtjev";
            this.btnStvoriNoviZahtjev.Size = new System.Drawing.Size(192, 62);
            this.btnStvoriNoviZahtjev.TabIndex = 2;
            this.btnStvoriNoviZahtjev.Text = "Stvori novi zahtjev";
            this.btnStvoriNoviZahtjev.UseVisualStyleBackColor = true;
            this.btnStvoriNoviZahtjev.Click += new System.EventHandler(this.btnStvoriNoviZahtjev_Click);
            // 
            // FrmPregledZahtjeva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1098, 699);
            this.Controls.Add(this.btnStvoriNoviZahtjev);
            this.Controls.Add(this.dgvZahtjevi);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Neue Haas Grotesk Text Pro", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPregledZahtjeva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "S";
            this.Load += new System.EventHandler(this.FrmPregledZahtjeva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zahtjeviBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPS23_pjuros21DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZahtjevi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.BindingSource dBBindingSource1;
        private System.Windows.Forms.BindingSource dBBindingSource;
        private IPS23_pjuros21DataSet iPS23_pjuros21DataSet;
        private System.Windows.Forms.BindingSource zahtjeviBindingSource;
        private IPS23_pjuros21DataSetTableAdapters.ZahtjeviTableAdapter zahtjeviTableAdapter;
        private System.Windows.Forms.DataGridView dgvZahtjevi;
        private System.Windows.Forms.Button btnStvoriNoviZahtjev;
    }
}