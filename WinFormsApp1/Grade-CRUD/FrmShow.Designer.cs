namespace WinFormsApp1.Grade_CRUD
{
    partial class FrmShow
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lbl_title = new Label();
            lbl_gradeName = new Label();
            lbl_gradegroup = new Label();
            lbl_gradeorder = new Label();
            lbl_colour = new Label();
            txt_gradeName = new TextBox();
            txt_gradegroup = new TextBox();
            txt_gradeorder = new TextBox();
            txt_colour = new TextBox();
            pnl_colour = new Panel();
            SuspendLayout();
            lbl_title.BackColor = SystemColors.Highlight;
            lbl_title.Dock = DockStyle.Top;
            lbl_title.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_title.Location = new Point(0, 0);
            lbl_title.Size = new Size(415, 38);
            lbl_title.Text = "Grade Details";
            lbl_title.TextAlign = ContentAlignment.TopCenter;
            lbl_gradeName.AutoSize = true;
            lbl_gradeName.Location = new Point(45, 63);
            lbl_gradeName.Text = "Grade Name";
            lbl_gradegroup.AutoSize = true;
            lbl_gradegroup.Location = new Point(45, 138);
            lbl_gradegroup.Text = "Grade Group";
            lbl_gradeorder.AutoSize = true;
            lbl_gradeorder.Location = new Point(45, 213);
            lbl_gradeorder.Text = "Grade Order";
            lbl_colour.AutoSize = true;
            lbl_colour.Location = new Point(45, 288);
            lbl_colour.Text = "Colour";
            txt_gradeName.Location = new Point(45, 95);
            txt_gradeName.ReadOnly = true;
            txt_gradeName.Size = new Size(300, 31);
            txt_gradegroup.Location = new Point(45, 170);
            txt_gradegroup.ReadOnly = true;
            txt_gradegroup.Size = new Size(300, 31);
            txt_gradeorder.Location = new Point(45, 245);
            txt_gradeorder.ReadOnly = true;
            txt_gradeorder.Size = new Size(300, 31);
            txt_colour.Location = new Point(45, 320);
            txt_colour.ReadOnly = true;
            txt_colour.Size = new Size(200, 31);
            pnl_colour.BorderStyle = BorderStyle.FixedSingle;
            pnl_colour.Location = new Point(265, 320);
            pnl_colour.Size = new Size(80, 31);
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 385);
            Controls.Add(pnl_colour);
            Controls.Add(txt_colour);
            Controls.Add(txt_gradeorder);
            Controls.Add(txt_gradegroup);
            Controls.Add(txt_gradeName);
            Controls.Add(lbl_colour);
            Controls.Add(lbl_gradeorder);
            Controls.Add(lbl_gradegroup);
            Controls.Add(lbl_gradeName);
            Controls.Add(lbl_title);
            Name = "FrmShow";
            Text = "Grade Details";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lbl_title;
        private Label lbl_gradeName;
        private Label lbl_gradegroup;
        private Label lbl_gradeorder;
        private Label lbl_colour;
        private TextBox txt_gradeName;
        private TextBox txt_gradegroup;
        private TextBox txt_gradeorder;
        private TextBox txt_colour;
        private Panel pnl_colour;
    }
}
