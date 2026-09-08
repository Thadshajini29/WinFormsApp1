namespace WinFormsApp1.Grade_CRUD
{
    partial class FrmEditGrade
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
            btn_update = new Button();
            btn_colour = new Button();
            txt_gradeorder = new TextBox();
            txt_gradegroup = new TextBox();
            txt_gradeName = new TextBox();
            lbl_gradecolour = new Label();
            lbl_gradeorder = new Label();
            lbl_gradegroup = new Label();
            lbl_gradeName = new Label();
            lbl_gradecreate = new Label();
            colorDialog1 = new ColorDialog();
            SuspendLayout();
            // 
            // btn_update
            // 
            btn_update.Location = new Point(275, 398);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(120, 40);
            btn_update.TabIndex = 14;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_colour
            // 
            btn_colour.Location = new Point(147, 336);
            btn_colour.Name = "btn_colour";
            btn_colour.Size = new Size(191, 32);
            btn_colour.TabIndex = 15;
            btn_colour.Text = "Choose Colour";
            btn_colour.UseVisualStyleBackColor = true;
            btn_colour.Click += btn_colour_Click;
            // 
            // txt_gradeorder
            // 
            txt_gradeorder.Location = new Point(45, 275);
            txt_gradeorder.Name = "txt_gradeorder";
            txt_gradeorder.Size = new Size(350, 31);
            txt_gradeorder.TabIndex = 11;
            // 
            // txt_gradegroup
            // 
            txt_gradegroup.Location = new Point(45, 188);
            txt_gradegroup.Name = "txt_gradegroup";
            txt_gradegroup.Size = new Size(350, 31);
            txt_gradegroup.TabIndex = 12;
            // 
            // txt_gradeName
            // 
            txt_gradeName.Location = new Point(45, 101);
            txt_gradeName.Name = "txt_gradeName";
            txt_gradeName.Size = new Size(350, 31);
            txt_gradeName.TabIndex = 13;
            // 
            // lbl_gradecolour
            // 
            lbl_gradecolour.AutoSize = true;
            lbl_gradecolour.Location = new Point(45, 336);
            lbl_gradecolour.Name = "lbl_gradecolour";
            lbl_gradecolour.Size = new Size(65, 25);
            lbl_gradecolour.TabIndex = 7;
            lbl_gradecolour.Text = "Colour";
            // 
            // lbl_gradeorder
            // 
            lbl_gradeorder.AutoSize = true;
            lbl_gradeorder.Location = new Point(45, 238);
            lbl_gradeorder.Name = "lbl_gradeorder";
            lbl_gradeorder.Size = new Size(110, 25);
            lbl_gradeorder.TabIndex = 8;
            lbl_gradeorder.Text = "Grade Order";
            // 
            // lbl_gradegroup
            // 
            lbl_gradegroup.AutoSize = true;
            lbl_gradegroup.Location = new Point(45, 151);
            lbl_gradegroup.Name = "lbl_gradegroup";
            lbl_gradegroup.Size = new Size(114, 25);
            lbl_gradegroup.TabIndex = 9;
            lbl_gradegroup.Text = "Grade Group";
            // 
            // lbl_gradeName
            // 
            lbl_gradeName.AutoSize = true;
            lbl_gradeName.Location = new Point(45, 64);
            lbl_gradeName.Name = "lbl_gradeName";
            lbl_gradeName.Size = new Size(111, 25);
            lbl_gradeName.TabIndex = 10;
            lbl_gradeName.Text = "Grade Name";
            // 
            // lbl_gradecreate
            // 
            lbl_gradecreate.BackColor = SystemColors.Highlight;
            lbl_gradecreate.Dock = DockStyle.Top;
            lbl_gradecreate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_gradecreate.Location = new Point(0, 0);
            lbl_gradecreate.Name = "lbl_gradecreate";
            lbl_gradecreate.Size = new Size(424, 38);
            lbl_gradecreate.TabIndex = 16;
            lbl_gradecreate.Text = "Edit Grade";
            lbl_gradecreate.TextAlign = ContentAlignment.TopCenter;
            // 
            // FrmEditGrade
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 450);
            Controls.Add(btn_update);
            Controls.Add(btn_colour);
            Controls.Add(txt_gradeorder);
            Controls.Add(txt_gradegroup);
            Controls.Add(txt_gradeName);
            Controls.Add(lbl_gradecolour);
            Controls.Add(lbl_gradeorder);
            Controls.Add(lbl_gradegroup);
            Controls.Add(lbl_gradeName);
            Controls.Add(lbl_gradecreate);
            Name = "FrmEditGrade";
            Text = "Edit Grade";
            Load += FrmEditGrade_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_update;
        private Button btn_colour;
        private TextBox txt_gradeorder;
        private TextBox txt_gradegroup;
        private TextBox txt_gradeName;
        private Label lbl_gradecolour;
        private Label lbl_gradeorder;
        private Label lbl_gradegroup;
        private Label lbl_gradeName;
        private Label lbl_gradecreate;
        private ColorDialog colorDialog1;
    }
}
