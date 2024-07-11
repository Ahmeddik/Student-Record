using System.Data;

namespace Students_Records
{
    public partial class Form1 : Form
    {
        int currentID = 0;
        public Form1()
        {
            InitializeComponent();
            LoadStudent();
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

        private void LoadStudent()
        {
            //studentTable
            DataTable table = Student.getAll();
            studentTable.DataSource = table;
        }
        //regist button
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
            else
            {

                if (newStudent.insert())
                {
                    MessageBox.Show("Registed Successfully");
                    fNameBox.Text = "";
                    lNameBox.Text = "";
                    emailBox.Text = "";
                    gradeBox.Text = "";
                    sectionBox.Text = "";

                    LoadStudent();

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

        private void fNameBox_TextChanged(object sender, EventArgs e)
        {

        }
        //edit button 
        private void button4_Click(object sender, EventArgs e)
        {
            if (studentTable.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = studentTable.SelectedRows[0];

                string fName = selectedRow.Cells["FirstName"].Value.ToString();
                string lName = selectedRow.Cells["LastName"].Value.ToString();
                string email = selectedRow.Cells["Email"].Value.ToString();
                string grade = selectedRow.Cells["Grade"].Value.ToString();
                string section = selectedRow.Cells["Section"].Value.ToString();
                string dateOfBirth = selectedRow.Cells["DateOfBirth"].Value.ToString();
                string _ID = selectedRow.Cells["StudentID"].Value.ToString();

                fNameBox.Text = fName;
                lNameBox.Text = lName;
                emailBox.Text = email;
                gradeBox.Text = grade;
                sectionBox.Text = section;
                dateOfBirthPicker.Text = dateOfBirth;
                currentID = Convert.ToInt32(_ID);


            }
        }

        //update button
        private void button1_Click(object sender, EventArgs e)
        {
            if (currentID != 0)
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
                else
                {

                    if (newStudent.update(currentID))
                    {
                        MessageBox.Show("Updated Successfully");
                        fNameBox.Text = "";
                        lNameBox.Text = "";
                        emailBox.Text = "";
                        gradeBox.Text = "";
                        sectionBox.Text = "";
                        currentID = 0;

                        LoadStudent();

                    }
                    else
                    {
                        MessageBox.Show("Update Failed");
                    }

                }

            }
        }
        //delete button
        private void button3_Click(object sender, EventArgs e)
        {
            if (studentTable.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = studentTable.SelectedRows[0];

                if (selectedRow != null)
                {
                    string _ID = selectedRow.Cells["StudentID"].Value.ToString();

                    if (Student.Delete(Convert.ToInt32(_ID)))
                    {
                        MessageBox.Show("Student with ID " + _ID + " has been deleted successfuly");
                        LoadStudent();
                    }
                    else
                    {
                        MessageBox.Show("Error Happened");
                    }
                }

            }
        }

        private void sectionBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void studentTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
