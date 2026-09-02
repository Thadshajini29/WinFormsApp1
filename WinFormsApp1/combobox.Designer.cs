namespace WinFormsApp1
{
    partial class Frm_combobox
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
            cmb_subject = new ComboBox();
            btn_submit = new Button();
            lst_subject = new ListBox();
            cmb_selectedsubject = new ComboBox();
            btn_Back = new Button();
            SuspendLayout();
            // 
            // cmb_subject
            // 
            cmb_subject.FormattingEnabled = true;
            cmb_subject.Items.AddRange(new object[] { "Science", "Maths", "English", "History", "Tamil" });
            cmb_subject.Location = new Point(155, 33);
            cmb_subject.Name = "cmb_subject";
            cmb_subject.Size = new Size(182, 33);
            cmb_subject.TabIndex = 0;
            // 
            // btn_submit
            // 
            btn_submit.Location = new Point(155, 118);
            btn_submit.Name = "btn_submit";
            btn_submit.Size = new Size(112, 34);
            btn_submit.TabIndex = 1;
            btn_submit.Text = "Submit";
            btn_submit.UseVisualStyleBackColor = true;
            btn_submit.Click += button1_Click;
            // 
            // lst_subject
            // 
            lst_subject.FormattingEnabled = true;
            lst_subject.Items.AddRange(new object[] { "Science", "English", "Maths", "ICT", "History" });
            lst_subject.Location = new Point(157, 190);
            lst_subject.Name = "lst_subject";
            lst_subject.Size = new Size(180, 154);
            lst_subject.TabIndex = 2;
            // 
            // cmb_selectedsubject
            // 
            cmb_selectedsubject.FormattingEnabled = true;
            cmb_selectedsubject.Items.AddRange(new object[] { "Science", "Maths", "English", "History", "Tamil" });
            cmb_selectedsubject.Location = new Point(419, 33);
            cmb_selectedsubject.Name = "cmb_selectedsubject";
            cmb_selectedsubject.Size = new Size(182, 33);
            cmb_selectedsubject.TabIndex = 0;
            // 
            // btn_Back
            // 
            btn_Back.Location = new Point(486, 358);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(193, 34);
            btn_Back.TabIndex = 3;
            btn_Back.Text = "Back to Master";
            btn_Back.UseVisualStyleBackColor = true;
            btn_Back.Click += btn_Back_Click;
            // 
            // Frm_combobox
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Back);
            Controls.Add(lst_subject);
            Controls.Add(btn_submit);
            Controls.Add(cmb_selectedsubject);
            Controls.Add(cmb_subject);
            Name = "Frm_combobox";
            Text = "Frm_combobox";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmb_subject;
        private Button btn_submit;
        private ListBox lst_subject;
        private ComboBox cmb_selectedsubject;
        private Button btn_Back;
    }
}
