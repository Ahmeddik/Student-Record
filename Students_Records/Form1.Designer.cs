namespace Students_Records
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            dateOfBirthPicker = new DateTimePicker();
            label7 = new Label();
            registerButton = new Button();
            label6 = new Label();
            sectionBox = new TextBox();
            label5 = new Label();
            gradeBox = new TextBox();
            label4 = new Label();
            emailBox = new TextBox();
            label3 = new Label();
            lNameBox = new TextBox();
            label2 = new Label();
            fNameBox = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            button4 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            FirstName = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Grade = new DataGridViewTextBoxColumn();
            Section = new DataGridViewTextBoxColumn();
            DateOfBirth = new DataGridViewTextBoxColumn();
            button2 = new Button();
            textBox6 = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(dateOfBirthPicker);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(registerButton);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(sectionBox);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(gradeBox);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(emailBox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lNameBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(fNameBox);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-2, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(634, 715);
            panel1.TabIndex = 0;
            // 
            // dateOfBirthPicker
            // 
            dateOfBirthPicker.Location = new Point(191, 554);
            dateOfBirthPicker.Name = "dateOfBirthPicker";
            dateOfBirthPicker.Size = new Size(371, 31);
            dateOfBirthPicker.TabIndex = 12;
            dateOfBirthPicker.Format = DateTimePickerFormat.Custom;
            dateOfBirthPicker.CustomFormat = "MM-dd-yyyy";
            //dateOfBirthPicker.ValueChanged += dateOfBirthPicker_ValueChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Showcard Gothic", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Blue;
            label7.Location = new Point(121, 52);
            label7.Name = "label7";
            label7.Size = new Size(393, 40);
            label7.TabIndex = 12;
            label7.Text = "Student Registration";
            label7.Click += label7_Click;
            // 
            // registerButton
            // 
            registerButton.BackColor = Color.Cyan;
            registerButton.Location = new Point(450, 638);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(112, 34);
            registerButton.TabIndex = 0;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += registerButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(61, 560);
            label6.Name = "label6";
            label6.Size = new Size(112, 25);
            label6.TabIndex = 10;
            label6.Text = "Date of Birth";
            // 
            // sectionBox
            // 
            sectionBox.Location = new Point(191, 476);
            sectionBox.Name = "sectionBox";
            sectionBox.Size = new Size(371, 31);
            sectionBox.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(61, 476);
            label5.Name = "label5";
            label5.Size = new Size(70, 25);
            label5.TabIndex = 8;
            label5.Text = "Section";
            // 
            // gradeBox
            // 
            gradeBox.Location = new Point(191, 403);
            gradeBox.Name = "gradeBox";
            gradeBox.Size = new Size(371, 31);
            gradeBox.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(61, 403);
            label4.Name = "label4";
            label4.Size = new Size(59, 25);
            label4.TabIndex = 6;
            label4.Text = "Grade";
            // 
            // emailBox
            // 
            emailBox.Location = new Point(191, 316);
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(371, 31);
            emailBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 316);
            label3.Name = "label3";
            label3.Size = new Size(54, 25);
            label3.TabIndex = 4;
            label3.Text = "Email";
            // 
            // lNameBox
            // 
            lNameBox.Location = new Point(191, 233);
            lNameBox.Name = "lNameBox";
            lNameBox.Size = new Size(371, 31);
            lNameBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 233);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 2;
            label2.Text = "Last Name";
            // 
            // fNameBox
            // 
            fNameBox.Location = new Point(191, 148);
            fNameBox.Name = "fNameBox";
            fNameBox.Size = new Size(371, 31);
            fNameBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 148);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(textBox6);
            panel2.Location = new Point(638, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(621, 706);
            panel2.TabIndex = 1;
            // 
            // button4
            // 
            button4.BackColor = Color.SpringGreen;
            button4.Location = new Point(350, 649);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 13;
            button4.Text = "Edit";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.OrangeRed;
            button3.Location = new Point(487, 649);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 13;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { FirstName, LastName, Email, Grade, Section, DateOfBirth });
            dataGridView1.Location = new Point(3, 155);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(615, 477);
            dataGridView1.TabIndex = 14;
            // 
            // FirstName
            // 
            FirstName.HeaderText = "First Name";
            FirstName.MinimumWidth = 8;
            FirstName.Name = "FirstName";
            FirstName.Width = 150;
            // 
            // LastName
            // 
            LastName.HeaderText = "Last Name";
            LastName.MinimumWidth = 8;
            LastName.Name = "LastName";
            LastName.Width = 150;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.MinimumWidth = 8;
            Email.Name = "Email";
            Email.Width = 150;
            // 
            // Grade
            // 
            Grade.HeaderText = "Grade";
            Grade.MinimumWidth = 8;
            Grade.Name = "Grade";
            Grade.Width = 150;
            // 
            // Section
            // 
            Section.HeaderText = "Section";
            Section.MinimumWidth = 8;
            Section.Name = "Section";
            Section.Width = 150;
            // 
            // DateOfBirth
            // 
            DateOfBirth.HeaderText = "Date Of Birth";
            DateOfBirth.MinimumWidth = 8;
            DateOfBirth.Name = "DateOfBirth";
            DateOfBirth.Width = 150;
            //DateOfBirth.Format = DateTimePickerFormat.Custom;
            //DateOfBirth.CustomFormat = "MM-dd-yyyy";
            // 
            // button2
            // 
            button2.Location = new Point(442, 58);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 13;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(32, 58);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(371, 31);
            textBox6.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1260, 705);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Student Records";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private TextBox lNameBox;
        private Label label2;
        private TextBox fNameBox;
        private TextBox sectionBox;
        private Label label5;
        private TextBox gradeBox;
        private Label label4;
        private TextBox emailBox;
        private Label label3;
        private Label label7;
        private Button registerButton;
        private Label label6;
        private DateTimePicker dateOfBirthPicker;
        private Button button2;
        private TextBox textBox6;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Grade;
        private DataGridViewTextBoxColumn Section;
        private DataGridViewTextBoxColumn DateOfBirth;
        private Button button4;
        private Button button3;
    }
}
