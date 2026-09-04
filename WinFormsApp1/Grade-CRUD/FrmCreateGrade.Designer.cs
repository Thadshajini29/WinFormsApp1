namespace WinFormsApp1.Grade_CRUD
{
    partial class FrmCreateGrade
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
            lbl_gradeName = new Label();
            txt_gradeName = new TextBox();
            btn_save = new Button();
            lbl_gradegroup = new Label();
            txt_gradegroup = new TextBox();
            lbl_gradeorder = new Label();
            txt_gradeorder = new TextBox();
            lbl_gradecolour = new Label();
            btn_colour = new Button();
            lbl_gradecreate = new Label();
            colorDialog1 = new ColorDialog();
            SuspendLayout();
            // 
            // lbl_gradeName
            // 
            lbl_gradeName.AutoSize = true;
            lbl_gradeName.Location = new Point(45, 53);
            lbl_gradeName.Name = "lbl_gradeName";
            lbl_gradeName.Size = new Size(111, 25);
            lbl_gradeName.TabIndex = 0;
            lbl_gradeName.Text = "Grade Name";
            // 
            // txt_gradeName
            // 
            txt_gradeName.Location = new Point(45, 90);
            txt_gradeName.Name = "txt_gradeName";
            txt_gradeName.Size = new Size(350, 31);
            txt_gradeName.TabIndex = 1;
            // 
            // btn_save
            // 
            btn_save.Location = new Point(275, 389);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(120, 40);
            btn_save.TabIndex = 2;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // lbl_gradegroup
            // 
            lbl_gradegroup.AutoSize = true;
            lbl_gradegroup.Location = new Point(45, 140);
            lbl_gradegroup.Name = "lbl_gradegroup";
            lbl_gradegroup.Size = new Size(114, 25);
            lbl_gradegroup.TabIndex = 0;
            lbl_gradegroup.Text = "Grade Group";
            // 
            // txt_gradegroup
            // 
            txt_gradegroup.Location = new Point(45, 177);
            txt_gradegroup.Name = "txt_gradegroup";
            txt_gradegroup.Size = new Size(350, 31);
            txt_gradegroup.TabIndex = 1;
            // 
            // lbl_gradeorder
            // 
            lbl_gradeorder.AutoSize = true;
            lbl_gradeorder.Location = new Point(45, 227);
            lbl_gradeorder.Name = "lbl_gradeorder";
            lbl_gradeorder.Size = new Size(110, 25);
            lbl_gradeorder.TabIndex = 0;
            lbl_gradeorder.Text = "Grade Order";
            // 
            // txt_gradeorder
            // 
            txt_gradeorder.Location = new Point(45, 264);
            txt_gradeorder.Name = "txt_gradeorder";
            txt_gradeorder.Size = new Size(350, 31);
            txt_gradeorder.TabIndex = 1;
            // 
            // lbl_gradecolour
            // 
            lbl_gradecolour.AutoSize = true;
            lbl_gradecolour.Location = new Point(45, 325);
            lbl_gradecolour.Name = "lbl_gradecolour";
            lbl_gradecolour.Size = new Size(65, 25);
            lbl_gradecolour.TabIndex = 0;
            lbl_gradecolour.Text = "Colour";
            // 
            // btn_colour
            // 
            btn_colour.Location = new Point(147, 325);
            btn_colour.Name = "btn_colour";
            btn_colour.Size = new Size(191, 32);
            btn_colour.TabIndex = 5;
            btn_colour.Text = "Choose Colour";
            btn_colour.UseVisualStyleBackColor = true;
            btn_colour.Click += btn_colour_Click;
            // 
            // lbl_gradecreate
            // 
            lbl_gradecreate.BackColor = SystemColors.Highlight;
            lbl_gradecreate.Dock = DockStyle.Top;
            lbl_gradecreate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_gradecreate.Location = new Point(0, 0);
            lbl_gradecreate.Name = "lbl_gradecreate";
            lbl_gradecreate.Size = new Size(415, 38);
            lbl_gradecreate.TabIndex = 6;
            lbl_gradecreate.Text = "Grade Create";
            lbl_gradecreate.TextAlign = ContentAlignment.TopCenter;
            // 
            // FrmCreateGrade
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 443);
            Controls.Add(lbl_gradecreate);
            Controls.Add(btn_save);
            Controls.Add(btn_colour);
            Controls.Add(txt_gradeorder);
            Controls.Add(txt_gradegroup);
            Controls.Add(txt_gradeName);
            Controls.Add(lbl_gradecolour);
            Controls.Add(lbl_gradeorder);
            Controls.Add(lbl_gradegroup);
            Controls.Add(lbl_gradeName);
            Name = "FrmCreateGrade";
            Text = "FrmCreateGrade";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_gradeName;
        private TextBox txt_gradeName;
        private Button btn_save;
        private Label lbl_gradegroup;
        private TextBox txt_gradegroup;
        private Label lbl_gradeorder;
        private TextBox txt_gradeorder;
        private Label lbl_gradecolour;
        private Button btn_colour;
        private Label lbl_gradecreate;
        private ColorDialog colorDialog1;
    }
}
