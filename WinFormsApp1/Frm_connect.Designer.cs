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
            btn_dbshow = new Button();
            cmb_medium = new ComboBox();
            cmb_familyid = new ComboBox();
            cmbhouse = new ComboBox();
            lbl_addmission = new Label();
            txtaddmission = new TextBox();
            txt_phone = new TextBox();
            txt_nic = new TextBox();
            lbl_familyid = new Label();
            lblmedium = new Label();
            lbl_house = new Label();
            lbl_phone = new Label();
            lblnic = new Label();
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
            dgvStudents.Location = new Point(12, 112);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.RowHeadersWidth = 62;
            dgvStudents.Size = new Size(661, 533);
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
            lblgender.Location = new Point(713, 415);
            lblgender.Name = "lblgender";
            lblgender.Size = new Size(69, 25);
            lblgender.TabIndex = 4;
            lblgender.Text = "Gender";
            lblgender.Click += lblgender_Click;
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
            rdoFemale.Location = new Point(943, 413);
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
            // btn_dbshow
            // 
            btn_dbshow.Location = new Point(826, 29);
            btn_dbshow.Name = "btn_dbshow";
            btn_dbshow.Size = new Size(132, 56);
            btn_dbshow.TabIndex = 3;
            btn_dbshow.Text = "DB-Show";
            btn_dbshow.UseVisualStyleBackColor = true;
            btn_dbshow.Click += btn_dbshow_Click;
            // 
            // cmb_medium
            // 
            cmb_medium.FormattingEnabled = true;
            cmb_medium.Items.AddRange(new object[] { "Tamil", "English" });
            cmb_medium.Location = new Point(927, 624);
            cmb_medium.Name = "cmb_medium";
            cmb_medium.Size = new Size(182, 33);
            cmb_medium.TabIndex = 57;
            // 
            // cmb_familyid
            // 
            cmb_familyid.FormattingEnabled = true;
            cmb_familyid.Location = new Point(930, 679);
            cmb_familyid.Name = "cmb_familyid";
            cmb_familyid.Size = new Size(182, 33);
            cmb_familyid.TabIndex = 56;
            // 
            // cmbhouse
            // 
            cmbhouse.FormattingEnabled = true;
            cmbhouse.Location = new Point(927, 565);
            cmbhouse.Name = "cmbhouse";
            cmbhouse.Size = new Size(182, 33);
            cmbhouse.TabIndex = 55;
            // 
            // lbl_addmission
            // 
            lbl_addmission.AutoSize = true;
            lbl_addmission.Location = new Point(729, 744);
            lbl_addmission.Name = "lbl_addmission";
            lbl_addmission.Size = new Size(177, 25);
            lbl_addmission.TabIndex = 54;
            lbl_addmission.Text = "Addmission Number";
            // 
            // txtaddmission
            // 
            txtaddmission.Location = new Point(930, 744);
            txtaddmission.Name = "txtaddmission";
            txtaddmission.Size = new Size(193, 31);
            txtaddmission.TabIndex = 51;
            // 
            // txt_phone
            // 
            txt_phone.Location = new Point(916, 512);
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new Size(193, 31);
            txt_phone.TabIndex = 52;
            // 
            // txt_nic
            // 
            txt_nic.Location = new Point(907, 448);
            txt_nic.Name = "txt_nic";
            txt_nic.Size = new Size(193, 31);
            txt_nic.TabIndex = 53;
            // 
            // lbl_familyid
            // 
            lbl_familyid.AutoSize = true;
            lbl_familyid.Location = new Point(729, 687);
            lbl_familyid.Name = "lbl_familyid";
            lbl_familyid.Size = new Size(83, 25);
            lbl_familyid.TabIndex = 49;
            lbl_familyid.Text = "Family Id";
            // 
            // lblmedium
            // 
            lblmedium.AutoSize = true;
            lblmedium.Location = new Point(729, 632);
            lblmedium.Name = "lblmedium";
            lblmedium.Size = new Size(78, 25);
            lblmedium.TabIndex = 48;
            lblmedium.Text = "Medium";
            // 
            // lbl_house
            // 
            lbl_house.AutoSize = true;
            lbl_house.Location = new Point(724, 573);
            lbl_house.Name = "lbl_house";
            lbl_house.Size = new Size(83, 25);
            lbl_house.TabIndex = 47;
            lbl_house.Text = "House id";
            // 
            // lbl_phone
            // 
            lbl_phone.AutoSize = true;
            lbl_phone.Location = new Point(704, 518);
            lbl_phone.Name = "lbl_phone";
            lbl_phone.Size = new Size(132, 25);
            lbl_phone.TabIndex = 46;
            lbl_phone.Text = "Phone Number";
            // 
            // lblnic
            // 
            lblnic.AutoSize = true;
            lblnic.Location = new Point(705, 454);
            lblnic.Name = "lblnic";
            lblnic.Size = new Size(107, 25);
            lblnic.TabIndex = 50;
            lblnic.Text = "Nic Number";
            // 
            // Frm_connect
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1175, 854);
            Controls.Add(cmb_medium);
            Controls.Add(cmb_familyid);
            Controls.Add(cmbhouse);
            Controls.Add(lbl_addmission);
            Controls.Add(txtaddmission);
            Controls.Add(txt_phone);
            Controls.Add(txt_nic);
            Controls.Add(lbl_familyid);
            Controls.Add(lblmedium);
            Controls.Add(lbl_house);
            Controls.Add(lbl_phone);
            Controls.Add(lblnic);
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
            Controls.Add(btn_dbshow);
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
        private Button btn_dbshow;
        private ComboBox cmb_medium;
        private ComboBox cmb_familyid;
        private ComboBox cmbhouse;
        private Label lbl_addmission;
        private TextBox txtaddmission;
        private TextBox txt_phone;
        private TextBox txt_nic;
        private Label lbl_familyid;
        private Label lblmedium;
        private Label lbl_house;
        private Label lbl_phone;
        private Label lblnic;
    }
}