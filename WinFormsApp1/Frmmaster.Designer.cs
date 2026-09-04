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
            btn_calculate = new Button();
            btn_combobox = new Button();
            btn_filldata = new Button();
            btn_connect = new Button();
            btn_edit = new Button();
            SuspendLayout();
            // 
            // lbl_master
            // 
            lbl_master.BackColor = SystemColors.MenuHighlight;
            lbl_master.Dock = DockStyle.Top;
            lbl_master.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_master.Location = new Point(0, 0);
            lbl_master.Name = "lbl_master";
            lbl_master.Size = new Size(408, 38);
            lbl_master.TabIndex = 0;
            lbl_master.Text = "Master Page";
            lbl_master.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnfullname
            // 
            btnfullname.BackColor = SystemColors.ControlDark;
            btnfullname.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnfullname.Location = new Point(12, 50);
            btnfullname.Name = "btnfullname";
            btnfullname.Size = new Size(168, 51);
            btnfullname.TabIndex = 1;
            btnfullname.Text = "Full Name";
            btnfullname.UseVisualStyleBackColor = false;
            btnfullname.Click += btnfullname_Click;
            // 
            // btn_calculate
            // 
            btn_calculate.BackColor = SystemColors.ControlDark;
            btn_calculate.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_calculate.Location = new Point(207, 50);
            btn_calculate.Name = "btn_calculate";
            btn_calculate.Size = new Size(168, 51);
            btn_calculate.TabIndex = 1;
            btn_calculate.Text = "Calculate";
            btn_calculate.UseVisualStyleBackColor = false;
            btn_calculate.Click += btn_calculate_Click;
            // 
            // btn_combobox
            // 
            btn_combobox.BackColor = SystemColors.ControlDark;
            btn_combobox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_combobox.Location = new Point(12, 145);
            btn_combobox.Name = "btn_combobox";
            btn_combobox.Size = new Size(168, 51);
            btn_combobox.TabIndex = 1;
            btn_combobox.Text = "ComboBox";
            btn_combobox.UseVisualStyleBackColor = false;
            btn_combobox.Click += btn_combobox_Click;
            // 
            // btn_filldata
            // 
            btn_filldata.BackColor = SystemColors.ControlDark;
            btn_filldata.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_filldata.Location = new Point(207, 145);
            btn_filldata.Name = "btn_filldata";
            btn_filldata.Size = new Size(168, 51);
            btn_filldata.TabIndex = 1;
            btn_filldata.Text = "Fill Data";
            btn_filldata.UseVisualStyleBackColor = false;
            btn_filldata.Click += btn_filldata_Click;
            // 
            // btn_connect
            // 
            btn_connect.BackColor = SystemColors.ControlDark;
            btn_connect.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_connect.Location = new Point(12, 243);
            btn_connect.Name = "btn_connect";
            btn_connect.Size = new Size(168, 51);
            btn_connect.TabIndex = 1;
            btn_connect.Text = "Database Connect";
            btn_connect.UseVisualStyleBackColor = false;
            btn_connect.Click += btn_connect_Click;
            // 
            // btn_edit
            // 
            btn_edit.BackColor = SystemColors.ControlDark;
            btn_edit.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_edit.Location = new Point(207, 243);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(168, 51);
            btn_edit.TabIndex = 1;
            btn_edit.Text = "Edit";
            btn_edit.UseVisualStyleBackColor = false;
            btn_edit.Click += btn_edit_Click;
            // 
            // Frmmaster
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 341);
            Controls.Add(btn_calculate);
            Controls.Add(btn_edit);
            Controls.Add(btn_filldata);
            Controls.Add(btn_connect);
            Controls.Add(btn_combobox);
            Controls.Add(btnfullname);
            Controls.Add(lbl_master);
            Name = "Frmmaster";
            Text = "Frmmaster";
            ResumeLayout(false);
        }

        #endregion

        private Label lbl_master;
        private Button btnfullname;
        private Button btn_calculate;
        private Button btn_combobox;
        private Button btn_filldata;
        private Button btn_connect;
        private Button btn_dbshow;
        private Button btn_edit;
    }
}
