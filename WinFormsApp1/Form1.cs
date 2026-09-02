namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            //string fname = txt_firstname.Text;
            //string lname = txt_lastname.Text;
            //string fullname = $"{fname} {lname}";
            //txt_fullname.Text = fullname;
            //MessageBox.Show($"Full Name: {fullname}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            string fname = txt_firstname.Text.Trim();
            string lname = txt_lastname.Text.Trim();
            string fullname = $"{fname} {lname}";
            

            lblfullname.Text = "";

            if (string.IsNullOrEmpty(fname))
            {
                lblfullname.Text = "Please enter your first name.";
                txt_firstname.Focus();
                return;
            }

            else if (string.IsNullOrEmpty(lname))
            {
                lblfullname.Text = "Please enter your last name.";
                txt_lastname.Focus();
                return;
            }
            else
            {
                txt_fullname.Text = fullname;
                lblfullname.Text = $"Full Name: {fullname}";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Frmmaster frmmaster = new Frmmaster();
            frmmaster.Show();

            this.Close();
        }
    }
}
