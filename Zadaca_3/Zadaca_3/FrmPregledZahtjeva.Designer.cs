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
            this.dBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.zahtjeviTableAdapter = new Zadaca_3.IPS23_pjuros21DataSetTableAdapters.ZahtjeviTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zahtjeviBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPS23_pjuros21DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
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
            // dBBindingSource
            // 
            this.dBBindingSource.DataSource = typeof(DBLayer.DB);
            // 
            // dBBindingSource1
            // 
            this.dBBindingSource1.DataSource = typeof(DBLayer.DB);
            // 
            // zahtjeviTableAdapter
            // 
            this.zahtjeviTableAdapter.ClearBeforeFill = true;
            // 
            // FrmPregledZahtjeva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 735);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPregledZahtjeva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregled zahtjeva za odsustvo";
            this.Load += new System.EventHandler(this.FrmPregledZahtjeva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zahtjeviBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPS23_pjuros21DataSet)).EndInit();
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
    }
}