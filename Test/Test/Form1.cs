namespace Test
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                listBox1.Visible = true;
            else
                listBox1.Visible = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                comboBox1.Visible = true;
            else
                comboBox1.Visible = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            comboBox1.Items.Clear();
            for (int i = int.Parse(textBox1.Text); i <= int.Parse(textBox2.Text); i++)
                if (i % 2 != 0)
                {
                    comboBox1.Items.Add(i.ToString());
                    listBox1.Items.Add(i.ToString());
                }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            comboBox1.Items.Clear();
            for (int i = int.Parse(textBox1.Text); i <= int.Parse(textBox2.Text); i++)
                if (i % 2 == 0)
                {
                    comboBox1.Items.Add(i.ToString());
                    listBox1.Items.Add(i.ToString());
                }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            comboBox1.Items.Clear();
            for (int i = int.Parse(textBox1.Text); i <= int.Parse(textBox2.Text); i++)
                if (i % 5 == 0)

                {
                    comboBox1.Items.Add(i.ToString());
                    listBox1.Items.Add(i.ToString());
                }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            comboBox1.Items.Clear();
            for (int i = int.Parse(textBox1.Text); i <= int.Parse(textBox2.Text); i++)
            {
                comboBox1.Items.Add(i.ToString());
                listBox1.Items.Add(i.ToString());
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}