namespace WinFormsApp1
{
    partial class Frm_connect
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
            btnConnect = new Button();
            dgvStudents = new DataGridView();
            btn_AllStudents = new Button();
            btn_show = new Button();
            lbl_firstname = new Label();
            lbl_lastname = new Label();
            lbl_address = new Label();
            txt_fname = new TextBox();
            txt_lname = new TextBox();
            txt_address = new TextBox();
            cmb_grade = new ComboBox();
            lblgrade = new Label();
            btngrade = new Button();
            btn_button1 = new Button();
            btn_button2 = new Button();
            lblgender = new Label();
            rdoMale = new RadioButton();
            rdoFemale = new RadioButton();
            btngender = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(12, 22);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(154, 63);
            btnConnect.TabIndex = 0;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // dgvStudents
            // 
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(12, 125);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.RowHeadersWidth = 62;
            dgvStudents.Size = new Size(661, 480);
            dgvStudents.TabIndex = 1;
            // 
            // btn_AllStudents
            // 
            btn_AllStudents.Location = new Point(172, 22);
            btn_AllStudents.Name = "btn_AllStudents";
            btn_AllStudents.Size = new Size(152, 63);
            btn_AllStudents.TabIndex = 2;
            btn_AllStudents.Text = "All Students";
            btn_AllStudents.UseVisualStyleBackColor = true;
            btn_AllStudents.Click += btn_AllStudents_Click;
            // 
            // btn_show
            // 
            btn_show.Location = new Point(347, 25);
            btn_show.Name = "btn_show";
            btn_show.Size = new Size(132, 56);
            btn_show.TabIndex = 3;
            btn_show.Text = "Show";
            btn_show.UseVisualStyleBackColor = true;
            btn_show.Click += btn_show_Click;
            // 
            // lbl_firstname
            // 
            lbl_firstname.AutoSize = true;
            lbl_firstname.Location = new Point(701, 125);
            lbl_firstname.Name = "lbl_firstname";
            lbl_firstname.Size = new Size(97, 25);
            lbl_firstname.TabIndex = 4;
            lbl_firstname.Text = "First Name";
            // 
            // lbl_lastname
            // 
            lbl_lastname.AutoSize = true;
            lbl_lastname.Location = new Point(703, 166);
            lbl_lastname.Name = "lbl_lastname";
            lbl_lastname.Size = new Size(95, 25);
            lbl_lastname.TabIndex = 4;
            lbl_lastname.Text = "Last Name";
            // 
            // lbl_address
            // 
            lbl_address.AutoSize = true;
            lbl_address.Location = new Point(705, 210);
            lbl_address.Name = "lbl_address";
            lbl_address.Size = new Size(77, 25);
            lbl_address.TabIndex = 4;
            lbl_address.Text = "Address";
            // 
            // txt_fname
            // 
            txt_fname.Location = new Point(826, 125);
            txt_fname.Name = "txt_fname";
            txt_fname.Size = new Size(228, 31);
            txt_fname.TabIndex = 5;
            // 
            // txt_lname
            // 
            txt_lname.Location = new Point(826, 166);
            txt_lname.Name = "txt_lname";
            txt_lname.Size = new Size(228, 31);
            txt_lname.TabIndex = 5;
            // 
            // txt_address
            // 
            txt_address.Location = new Point(826, 210);
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(228, 31);
            txt_address.TabIndex = 5;
            // 
            // cmb_grade
            // 
            cmb_grade.FormattingEnabled = true;
            cmb_grade.Location = new Point(826, 270);
            cmb_grade.Name = "cmb_grade";
            cmb_grade.Size = new Size(228, 33);
            cmb_grade.TabIndex = 6;
            // 
            // lblgrade
            // 
            lblgrade.AutoSize = true;
            lblgrade.Location = new Point(705, 278);
            lblgrade.Name = "lblgrade";
            lblgrade.Size = new Size(59, 25);
            lblgrade.TabIndex = 4;
            lblgrade.Text = "Grade";
            // 
            // btngrade
            // 
            btngrade.Location = new Point(501, 25);
            btngrade.Name = "btngrade";
            btngrade.Size = new Size(132, 56);
            btngrade.TabIndex = 3;
            btngrade.Text = "GradeClick";
            btngrade.UseVisualStyleBackColor = true;
            btngrade.Click += btngrade_Click;
            // 
            // btn_button1
            // 
            btn_button1.Location = new Point(705, 344);
            btn_button1.Name = "btn_button1";
            btn_button1.Size = new Size(112, 34);
            btn_button1.TabIndex = 7;
            btn_button1.Text = "button1";
            btn_button1.UseVisualStyleBackColor = true;
            btn_button1.Click += btn_button1_Click;
            // 
            // btn_button2
            // 
            btn_button2.Location = new Point(880, 344);
            btn_button2.Name = "btn_button2";
            btn_button2.Size = new Size(112, 34);
            btn_button2.TabIndex = 7;
            btn_button2.Text = "button2";
            btn_button2.UseVisualStyleBackColor = true;
            btn_button2.Click += btn_button2_Click;
            // 
            // lblgender
            // 
            lblgender.AutoSize = true;
            lblgender.Location = new Point(705, 413);
            lblgender.Name = "lblgender";
            lblgender.Size = new Size(69, 25);
            lblgender.TabIndex = 4;
            lblgender.Text = "Gender";
            // 
            // rdoMale
            // 
            rdoMale.AutoSize = true;
            rdoMale.Location = new Point(826, 413);
            rdoMale.Name = "rdoMale";
            rdoMale.Size = new Size(75, 29);
            rdoMale.TabIndex = 8;
            rdoMale.TabStop = true;
            rdoMale.Text = "Male";
            rdoMale.UseVisualStyleBackColor = true;
            // 
            // rdoFemale
            // 
            rdoFemale.AutoSize = true;
            rdoFemale.Location = new Point(907, 411);
            rdoFemale.Name = "rdoFemale";
            rdoFemale.Size = new Size(93, 29);
            rdoFemale.TabIndex = 8;
            rdoFemale.TabStop = true;
            rdoFemale.Text = "Female";
            rdoFemale.UseVisualStyleBackColor = true;
            // 
            // btngender
            // 
            btngender.Location = new Point(666, 25);
            btngender.Name = "btngender";
            btngender.Size = new Size(132, 56);
            btngender.TabIndex = 3;
            btngender.Text = "Gender";
            btngender.UseVisualStyleBackColor = true;
            btngender.Click += btngender_Click;
            // 
            // Frm_connect
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1114, 634);
            Controls.Add(rdoFemale);
            Controls.Add(rdoMale);
            Controls.Add(btn_button2);
            Controls.Add(btn_button1);
            Controls.Add(cmb_grade);
            Controls.Add(txt_address);
            Controls.Add(txt_lname);
            Controls.Add(txt_fname);
            Controls.Add(lblgender);
            Controls.Add(lblgrade);
            Controls.Add(lbl_address);
            Controls.Add(lbl_lastname);
            Controls.Add(lbl_firstname);
            Controls.Add(btngender);
            Controls.Add(btngrade);
            Controls.Add(btn_show);
            Controls.Add(btn_AllStudents);
            Controls.Add(dgvStudents);
            Controls.Add(btnConnect);
            Name = "Frm_connect";
            Text = "Frm_connect";
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConnect;
        private DataGridView dgvStudents;
        private Button btn_AllStudents;
        private Button btn_show;
        private Label lbl_firstname;
        private Label lbl_lastname;
        private Label lbl_address;
        private TextBox txt_fname;
        private TextBox txt_lname;
        private TextBox txt_address;
        private ComboBox cmb_grade;
        private Label lblgrade;
        private Button btngrade;
        private Button btn_button1;
        private Button btn_button2;
        private Label lblgender;
        private RadioButton rdoMale;
        private RadioButton rdoFemale;
        private Button btngender;
    }
}