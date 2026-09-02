namespace WinFormsApp1
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
            components = new System.ComponentModel.Container();
            lbl_firstname = new Label();
            textBox1 = new TextBox();
            lbl_lastname = new Label();
            txt_firstname = new TextBox();
            txt_lastname = new TextBox();
            btn_save = new Button();
            lbl_fullname = new Label();
            txt_fullname = new TextBox();
            label2 = new Label();
            lblfullname = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            btn_Back = new Button();
            SuspendLayout();
            // 
            // lbl_firstname
            // 
            lbl_firstname.AutoSize = true;
            lbl_firstname.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_firstname.Location = new Point(12, 80);
            lbl_firstname.Name = "lbl_firstname";
            lbl_firstname.Size = new Size(151, 38);
            lbl_firstname.TabIndex = 0;
            lbl_firstname.Text = "First Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(199, 87);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(307, 31);
            textBox1.TabIndex = 1;
            // 
            // lbl_lastname
            // 
            lbl_lastname.AutoSize = true;
            lbl_lastname.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_lastname.Location = new Point(16, 142);
            lbl_lastname.Name = "lbl_lastname";
            lbl_lastname.Size = new Size(147, 38);
            lbl_lastname.TabIndex = 0;
            lbl_lastname.Text = "Last Name";
            // 
            // txt_firstname
            // 
            txt_firstname.Location = new Point(199, 87);
            txt_firstname.Name = "txt_firstname";
            txt_firstname.Size = new Size(307, 31);
            txt_firstname.TabIndex = 1;
            // 
            // txt_lastname
            // 
            txt_lastname.Location = new Point(199, 150);
            txt_lastname.Name = "txt_lastname";
            txt_lastname.Size = new Size(307, 31);
            txt_lastname.TabIndex = 1;
            // 
            // btn_save
            // 
            btn_save.BackColor = SystemColors.ButtonShadow;
            btn_save.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_save.Location = new Point(355, 283);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(151, 48);
            btn_save.TabIndex = 2;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
            // 
            // lbl_fullname
            // 
            lbl_fullname.BackColor = SystemColors.Highlight;
            lbl_fullname.Dock = DockStyle.Top;
            lbl_fullname.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_fullname.ForeColor = SystemColors.ButtonHighlight;
            lbl_fullname.Location = new Point(0, 0);
            lbl_fullname.Name = "lbl_fullname";
            lbl_fullname.Size = new Size(532, 70);
            lbl_fullname.TabIndex = 0;
            lbl_fullname.Text = "Full Name";
            lbl_fullname.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_fullname
            // 
            txt_fullname.Location = new Point(199, 214);
            txt_fullname.Name = "txt_fullname";
            txt_fullname.ReadOnly = true;
            txt_fullname.Size = new Size(307, 31);
            txt_fullname.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(16, 206);
            label2.Name = "label2";
            label2.Size = new Size(138, 38);
            label2.TabIndex = 0;
            label2.Text = "full Name";
            // 
            // lblfullname
            // 
            lblfullname.AutoSize = true;
            lblfullname.Location = new Point(199, 283);
            lblfullname.Name = "lblfullname";
            lblfullname.Size = new Size(40, 25);
            lblfullname.TabIndex = 3;
            lblfullname.Text = "----";
            // 
            // btn_Back
            // 
            btn_Back.BackColor = SystemColors.ButtonShadow;
            btn_Back.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Back.Location = new Point(283, 356);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(223, 48);
            btn_Back.TabIndex = 2;
            btn_Back.Text = "Back to Master";
            btn_Back.UseVisualStyleBackColor = false;
            btn_Back.Click += btn_Back_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(532, 436);
            Controls.Add(lblfullname);
            Controls.Add(btn_Back);
            Controls.Add(btn_save);
            Controls.Add(txt_fullname);
            Controls.Add(txt_lastname);
            Controls.Add(txt_firstname);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(lbl_lastname);
            Controls.Add(lbl_fullname);
            Controls.Add(lbl_firstname);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_firstname;
        private TextBox textBox1;
        private Label lbl_lastname;
        private TextBox txt_firstname;
        private TextBox txt_lastname;
        private Button btn_save;
        private Label lbl_fullname;
        private TextBox txt_fullname;
        private Label label2;
        private Label lblfullname;
        private System.Windows.Forms.Timer timer1;
        private Button btn_Back;
    }
}
