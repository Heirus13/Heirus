namespace Personal_Information
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string details = "", gender = "", hobbies = "";
           
            int age = DateTime.Now.Year - btnBirthday.Value.Year;
            if (btnBirthday.Value.AddYears(age) > DateTime.Now) age--;

            if (btnMale.Checked)
            {
                gender = btnMale.Text;
            }
            else
            {
                gender = btnFemale.Text;
            }

            if (btnDancing.Checked)
                hobbies = hobbies + "Dancing";
            if (btnPainting.Checked)
                hobbies = hobbies + "\n                 Painting";
            if (btnCycling.Checked)
                hobbies = hobbies + "\n                 Cycling";
            if (btnSinging.Checked)
                hobbies = hobbies + "\n                 Singing";
            if (btnCooking.Checked)
                hobbies = hobbies + "\n                 Cooking";
            if (btnPlaying.Checked)
                hobbies = hobbies + "\n                 Playing";



            details = "Name: " + btnName.Text +
                      "\nBirthdate: " + btnBirthday.Value +
                      "\nAge: " + age +
                      "\nGender: " + gender +
                      "\nHobbies: " + hobbies;

            MessageBox.Show(details, "Personal Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
 
        }

        private void btnName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files (*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                btnImage.Image = new Bitmap(open.FileName);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
       
        }
    }
}