namespace Students_Records
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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            Student newStudent = new Student();
            newStudent.FirstName = fNameBox.Text.ToString();
            newStudent.lastName = lNameBox.Text.ToString();
            newStudent.Email = emailBox.Text.ToString();
            newStudent.Grade = gradeBox.Text.ToString();
            newStudent.Section = sectionBox.Text.ToString();
            newStudent.DateOfBirth = dateOfBirthPicker.Text.ToString();

            if (fNameBox.Text.Equals(String.Empty) ||
                lNameBox.Text.Equals(String.Empty) ||
                emailBox.Text.Equals(String.Empty) ||
                sectionBox.Text.Equals(String.Empty) ||
                dateOfBirthPicker.Text.Equals(String.Empty))
            {
                MessageBox.Show("All fields are required!");
            }
            else {

                if (newStudent.insert())
                {
                    MessageBox.Show("Registed Successfully");
                    fNameBox.Text = "";
                    lNameBox.Text = "";
                    emailBox.Text = "";
                    gradeBox.Text = "";
                    sectionBox.Text = "";

                }
                else
                {
                    MessageBox.Show("Registration Failed");
                }

            }
        }

        private void dateOfBirthPicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
