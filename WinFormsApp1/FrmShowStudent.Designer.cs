namespace WinFormsApp1
{
    partial class FrmShowStudent
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
            txt_address = new TextBox();
            txt_lname = new TextBox();
            txt_fname = new TextBox();
            lbl_address = new Label();
            lbl_lastname = new Label();
            lbl_firstname = new Label();
            rdoFemale = new RadioButton();
            rdoMale = new RadioButton();
            lblgender = new Label();
            SuspendLayout();
            // 
            // txt_address
            // 
            txt_address.Location = new Point(160, 121);
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(193, 31);
            txt_address.TabIndex = 9;
            // 
            // txt_lname
            // 
            txt_lname.Location = new Point(160, 77);
            txt_lname.Name = "txt_lname";
            txt_lname.Size = new Size(193, 31);
            txt_lname.TabIndex = 10;
            // 
            // txt_fname
            // 
            txt_fname.Location = new Point(160, 36);
            txt_fname.Name = "txt_fname";
            txt_fname.Size = new Size(193, 31);
            txt_fname.TabIndex = 11;
            // 
            // lbl_address
            // 
            lbl_address.AutoSize = true;
            lbl_address.Location = new Point(39, 121);
            lbl_address.Name = "lbl_address";
            lbl_address.Size = new Size(77, 25);
            lbl_address.TabIndex = 6;
            lbl_address.Text = "Address";
            // 
            // lbl_lastname
            // 
            lbl_lastname.AutoSize = true;
            lbl_lastname.Location = new Point(37, 77);
            lbl_lastname.Name = "lbl_lastname";
            lbl_lastname.Size = new Size(95, 25);
            lbl_lastname.TabIndex = 7;
            lbl_lastname.Text = "Last Name";
            // 
            // lbl_firstname
            // 
            lbl_firstname.AutoSize = true;
            lbl_firstname.Location = new Point(35, 36);
            lbl_firstname.Name = "lbl_firstname";
            lbl_firstname.Size = new Size(97, 25);
            lbl_firstname.TabIndex = 8;
            lbl_firstname.Text = "First Name";
            // 
            // rdoFemale
            // 
            rdoFemale.AutoSize = true;
            rdoFemale.Location = new Point(272, 173);
            rdoFemale.Name = "rdoFemale";
            rdoFemale.Size = new Size(93, 29);
            rdoFemale.TabIndex = 14;
            rdoFemale.TabStop = true;
            rdoFemale.Text = "Female";
            rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            rdoMale.AutoSize = true;
            rdoMale.Location = new Point(171, 173);
            rdoMale.Name = "rdoMale";
            rdoMale.Size = new Size(75, 29);
            rdoMale.TabIndex = 13;
            rdoMale.TabStop = true;
            rdoMale.Text = "Male";
            rdoMale.UseVisualStyleBackColor = true;
            // 
            // lblgender
            // 
            lblgender.AutoSize = true;
            lblgender.Location = new Point(39, 177);
            lblgender.Name = "lblgender";
            lblgender.Size = new Size(69, 25);
            lblgender.TabIndex = 12;
            lblgender.Text = "Gender";
            // 
            // FrmShowStudent
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 330);
            Controls.Add(rdoFemale);
            Controls.Add(rdoMale);
            Controls.Add(lblgender);
            Controls.Add(txt_address);
            Controls.Add(txt_lname);
            Controls.Add(txt_fname);
            Controls.Add(lbl_address);
            Controls.Add(lbl_lastname);
            Controls.Add(lbl_firstname);
            Name = "FrmShowStudent";
            Text = "FrmShowStudent";
            Load += FrmShowStudent_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_address;
        private TextBox txt_lname;
        private TextBox txt_fname;
        private Label lbl_address;
        private Label lbl_lastname;
        private Label lbl_firstname;
        private RadioButton rdoFemale;
        private RadioButton rdoMale;
        private Label lblgender;
    }
}