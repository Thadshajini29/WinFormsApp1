namespace WinFormsApp1
{
    partial class Frmmaster
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
            lbl_master = new Label();
            btnfullname = new Button();
            SuspendLayout();
            // 
            // lbl_master
            // 
            lbl_master.BackColor = SystemColors.MenuHighlight;
            lbl_master.Dock = DockStyle.Top;
            lbl_master.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_master.Location = new Point(0, 0);
            lbl_master.Name = "lbl_master";
            lbl_master.Size = new Size(468, 38);
            lbl_master.TabIndex = 0;
            lbl_master.Text = "Master Page";
            lbl_master.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnfullname
            // 
            btnfullname.BackColor = SystemColors.ControlDark;
            btnfullname.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnfullname.Location = new Point(37, 73);
            btnfullname.Name = "btnfullname";
            btnfullname.Size = new Size(168, 51);
            btnfullname.TabIndex = 1;
            btnfullname.Text = "Full Name";
            btnfullname.UseVisualStyleBackColor = false;
            btnfullname.Click += btnfullname_Click;
            // 
            // Frmmaster
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 514);
            Controls.Add(btnfullname);
            Controls.Add(lbl_master);
            Name = "Frmmaster";
            Text = "Frmmaster";
            ResumeLayout(false);
        }

        #endregion

        private Label lbl_master;
        private Button btnfullname;
    }
}