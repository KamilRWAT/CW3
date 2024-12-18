namespace CW3
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
            btnWyswietl = new Button();
            cbGaraze = new ComboBox();
            dgvPojazdy = new DataGridView();
            txtPaliwo = new TextBox();
            lblPaliwo = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPojazdy).BeginInit();
            SuspendLayout();
            // 
            // btnWyswietl
            // 
            btnWyswietl.Location = new Point(12, 147);
            btnWyswietl.Name = "btnWyswietl";
            btnWyswietl.Size = new Size(142, 23);
            btnWyswietl.TabIndex = 0;
            btnWyswietl.Text = "Wyswietl";
            btnWyswietl.UseVisualStyleBackColor = true;
            btnWyswietl.Click += btnWyswietl_Click;
            // 
            // cbGaraze
            // 
            cbGaraze.FormattingEnabled = true;
            cbGaraze.Location = new Point(12, 12);
            cbGaraze.Name = "cbGaraze";
            cbGaraze.Size = new Size(142, 23);
            cbGaraze.TabIndex = 1;
            cbGaraze.SelectedIndexChanged += cbGaraze_SelectedIndexChanged;
            // 
            // dgvPojazdy
            // 
            dgvPojazdy.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPojazdy.Location = new Point(160, 12);
            dgvPojazdy.Name = "dgvPojazdy";
            dgvPojazdy.Size = new Size(628, 426);
            dgvPojazdy.TabIndex = 2;
            // 
            // txtPaliwo
            // 
            txtPaliwo.Location = new Point(12, 118);
            txtPaliwo.Name = "txtPaliwo";
            txtPaliwo.Size = new Size(142, 23);
            txtPaliwo.TabIndex = 3;
            // 
            // lblPaliwo
            // 
            lblPaliwo.Location = new Point(12, 83);
            lblPaliwo.Name = "lblPaliwo";
            lblPaliwo.Size = new Size(142, 32);
            lblPaliwo.TabIndex = 4;
            lblPaliwo.Text = "Ile przejedzie kilometrów na podanym paliwie (litry)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblPaliwo);
            Controls.Add(txtPaliwo);
            Controls.Add(dgvPojazdy);
            Controls.Add(cbGaraze);
            Controls.Add(btnWyswietl);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPojazdy).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnWyswietl;
        private ComboBox cbGaraze;
        private DataGridView dgvPojazdy;
        private TextBox txtPaliwo;
        private Label lblPaliwo;
    }
}
