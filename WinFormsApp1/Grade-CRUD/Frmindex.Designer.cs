namespace WinFormsApp1.Grade_CRUD
{
    partial class Frmindex
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
            dgv_Grades = new DataGridView();
            btn_grades = new Button();
            lbl_Grade = new Label();
            btn_create = new Button();
            btn_Edit = new Button();
            btn_show = new Button();
            btn_delete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_Grades).BeginInit();
            SuspendLayout();
            // 
            // dgv_Grades
            // 
            dgv_Grades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Grades.Location = new Point(12, 183);
            dgv_Grades.Name = "dgv_Grades";
            dgv_Grades.RowHeadersWidth = 62;
            dgv_Grades.Size = new Size(854, 364);
            dgv_Grades.TabIndex = 0;
            dgv_Grades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Grades.MultiSelect = false;
            dgv_Grades.AllowUserToAddRows = false;
            // 
            // btn_grades
            // 
            btn_grades.BackColor = SystemColors.InactiveCaption;
            btn_grades.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_grades.Location = new Point(12, 105);
            btn_grades.Name = "btn_grades";
            btn_grades.Size = new Size(120, 42);
            btn_grades.TabIndex = 1;
            btn_grades.Text = "All Grades";
            btn_grades.UseVisualStyleBackColor = false;
            btn_grades.Click += btn_grades_Click;
            // 
            // lbl_Grade
            // 
            lbl_Grade.BackColor = Color.DodgerBlue;
            lbl_Grade.Dock = DockStyle.Top;
            lbl_Grade.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Grade.Location = new Point(0, 0);
            lbl_Grade.Name = "lbl_Grade";
            lbl_Grade.Size = new Size(892, 62);
            lbl_Grade.TabIndex = 2;
            lbl_Grade.Text = "Grade";
            lbl_Grade.TextAlign = ContentAlignment.TopCenter;
            // 
            // btn_create
            // 
            btn_create.BackColor = SystemColors.InactiveCaption;
            btn_create.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_create.Location = new Point(300, 105);
            btn_create.Name = "btn_create";
            btn_create.Size = new Size(120, 42);
            btn_create.TabIndex = 1;
            btn_create.Text = "Insert";
            btn_create.UseVisualStyleBackColor = false;
            btn_create.Click += btn_create_Click;
            // 
            // btn_Edit
            // 
            btn_Edit.BackColor = SystemColors.InactiveCaption;
            btn_Edit.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Edit.Location = new Point(448, 105);
            btn_Edit.Name = "btn_Edit";
            btn_Edit.Size = new Size(120, 42);
            btn_Edit.TabIndex = 1;
            btn_Edit.Text = "Edit";
            btn_Edit.UseVisualStyleBackColor = false;
            btn_Edit.Click += btn_Edit_Click;
            // 
            // btn_show
            // 
            btn_show.BackColor = SystemColors.InactiveCaption;
            btn_show.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_show.Location = new Point(152, 105);
            btn_show.Name = "btn_show";
            btn_show.Size = new Size(120, 42);
            btn_show.TabIndex = 3;
            btn_show.Text = "Show";
            btn_show.UseVisualStyleBackColor = false;
            btn_show.Click += btn_show_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = SystemColors.InactiveCaption;
            btn_delete.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_delete.Location = new Point(596, 105);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(120, 42);
            btn_delete.TabIndex = 4;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // Frmindex
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(892, 559);
            Controls.Add(lbl_Grade);
            Controls.Add(btn_delete);
            Controls.Add(btn_show);
            Controls.Add(btn_Edit);
            Controls.Add(btn_create);
            Controls.Add(btn_grades);
            Controls.Add(dgv_Grades);
            Name = "Frmindex";
            Text = "Frmindex";
            Load += Frmindex_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Grades).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_Grades;
        private Button btn_grades;
        private Label lbl_Grade;
        private Button btn_create;
        private Button btn_Edit;
        private Button btn_show;
        private Button btn_delete;
    }
}
