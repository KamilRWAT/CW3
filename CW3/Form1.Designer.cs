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
            ((System.ComponentModel.ISupportInitialize)dgvPojazdy).BeginInit();
            SuspendLayout();
            // 
            // btnWyswietl
            // 
            btnWyswietl.Location = new Point(12, 41);
            btnWyswietl.Name = "btnWyswietl";
            btnWyswietl.Size = new Size(121, 23);
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
            cbGaraze.Size = new Size(121, 23);
            cbGaraze.TabIndex = 1;
            cbGaraze.SelectedIndexChanged += cbGaraze_SelectedIndexChanged;
            // 
            // dgvPojazdy
            // 
            dgvPojazdy.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPojazdy.Location = new Point(139, 12);
            dgvPojazdy.Name = "dgvPojazdy";
            dgvPojazdy.Size = new Size(649, 426);
            dgvPojazdy.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvPojazdy);
            Controls.Add(cbGaraze);
            Controls.Add(btnWyswietl);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPojazdy).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnWyswietl;
        private ComboBox cbGaraze;
        private DataGridView dgvPojazdy;
    }
}
