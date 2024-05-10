namespace AS2324._3G.Russo.Antonio.PSDBPCTO
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvDati = new DataGridView();
            btnPiloti = new Button();
            btnGare = new Button();
            cmbSeleziona = new ComboBox();
            btnSeleziona = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDati).BeginInit();
            SuspendLayout();
            // 
            // dgvDati
            // 
            dgvDati.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDati.Location = new Point(4, 192);
            dgvDati.Name = "dgvDati";
            dgvDati.RowHeadersWidth = 51;
            dgvDati.RowTemplate.Height = 29;
            dgvDati.Size = new Size(798, 261);
            dgvDati.TabIndex = 0;
            // 
            // btnPiloti
            // 
            btnPiloti.Location = new Point(564, 28);
            btnPiloti.Name = "btnPiloti";
            btnPiloti.Size = new Size(113, 45);
            btnPiloti.TabIndex = 1;
            btnPiloti.Text = "Elenco Piloti";
            btnPiloti.UseVisualStyleBackColor = true;
            btnPiloti.Click += btnPiloti_Click;
            // 
            // btnGare
            // 
            btnGare.Location = new Point(116, 28);
            btnGare.Name = "btnGare";
            btnGare.Size = new Size(113, 45);
            btnGare.TabIndex = 1;
            btnGare.Text = "Elenco Gare";
            btnGare.UseVisualStyleBackColor = true;
            btnGare.Click += btnGare_Click;
            // 
            // cmbSeleziona
            // 
            cmbSeleziona.FormattingEnabled = true;
            cmbSeleziona.Items.AddRange(new object[] { "Elenco squadre non italiane ordinate per nome", "Elenco piloti Ducati ordinati per cognome e nome", "Elenco circuiti ordinati per nome" });
            cmbSeleziona.Location = new Point(64, 120);
            cmbSeleziona.Name = "cmbSeleziona";
            cmbSeleziona.Size = new Size(374, 28);
            cmbSeleziona.TabIndex = 2;
            // 
            // btnSeleziona
            // 
            btnSeleziona.Location = new Point(473, 120);
            btnSeleziona.Name = "btnSeleziona";
            btnSeleziona.Size = new Size(96, 30);
            btnSeleziona.TabIndex = 3;
            btnSeleziona.Text = "Seleziona";
            btnSeleziona.UseVisualStyleBackColor = true;
            btnSeleziona.Click += btnSeleziona_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSeleziona);
            Controls.Add(cmbSeleziona);
            Controls.Add(btnGare);
            Controls.Add(btnPiloti);
            Controls.Add(dgvDati);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvDati).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDati;
        private Button btnPiloti;
        private Button btnGare;
        private ComboBox cmbSeleziona;
        private Button btnSeleziona;
    }
}