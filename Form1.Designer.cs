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
            btnPiloti.Location = new Point(490, 59);
            btnPiloti.Name = "btnPiloti";
            btnPiloti.Size = new Size(113, 45);
            btnPiloti.TabIndex = 1;
            btnPiloti.Text = "Elenco Piloti";
            btnPiloti.UseVisualStyleBackColor = true;
            btnPiloti.Click += btnPiloti_Click;
            // 
            // btnGare
            // 
            btnGare.Location = new Point(168, 59);
            btnGare.Name = "btnGare";
            btnGare.Size = new Size(113, 45);
            btnGare.TabIndex = 1;
            btnGare.Text = "Elenco Gare";
            btnGare.UseVisualStyleBackColor = true;
            btnGare.Click += btnGare_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}