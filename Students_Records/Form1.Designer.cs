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
            button1 = new Button();
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
            studentTable = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)studentTable).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(button1);
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
            panel1.Size = new Size(1220, 454);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkOrange;
            button1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(511, 399);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 13;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dateOfBirthPicker
            // 
            dateOfBirthPicker.CustomFormat = "MM-dd-yyyy";
            dateOfBirthPicker.Format = DateTimePickerFormat.Custom;
            dateOfBirthPicker.Location = new Point(777, 323);
            dateOfBirthPicker.Name = "dateOfBirthPicker";
            dateOfBirthPicker.Size = new Size(371, 31);
            dateOfBirthPicker.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Showcard Gothic", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.SaddleBrown;
            label7.Location = new Point(484, 35);
            label7.Name = "label7";
            label7.Size = new Size(341, 40);
            label7.TabIndex = 12;
            label7.Text = "Registration Form";
            label7.Click += label7_Click;
            // 
            // registerButton
            // 
            registerButton.BackColor = Color.DodgerBlue;
            registerButton.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            registerButton.ForeColor = SystemColors.ButtonHighlight;
            registerButton.Location = new Point(648, 399);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(112, 34);
            registerButton.TabIndex = 0;
            registerButton.Text = "Regist";
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += registerButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(623, 328);
            label6.Name = "label6";
            label6.Size = new Size(121, 25);
            label6.TabIndex = 10;
            label6.Text = "DateOfBirth";
            // 
            // sectionBox
            // 
            sectionBox.Location = new Point(191, 325);
            sectionBox.Name = "sectionBox";
            sectionBox.Size = new Size(371, 31);
            sectionBox.TabIndex = 9;
            sectionBox.TextChanged += sectionBox_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(26, 325);
            label5.Name = "label5";
            label5.Size = new Size(77, 25);
            label5.TabIndex = 8;
            label5.Text = "Section";
            // 
            // gradeBox
            // 
            gradeBox.Location = new Point(777, 235);
            gradeBox.Name = "gradeBox";
            gradeBox.Size = new Size(371, 31);
            gradeBox.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(623, 235);
            label4.Name = "label4";
            label4.Size = new Size(65, 25);
            label4.TabIndex = 6;
            label4.Text = "Grade";
            // 
            // emailBox
            // 
            emailBox.Location = new Point(191, 235);
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(371, 31);
            emailBox.TabIndex = 5;
            emailBox.TextChanged += emailBox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(26, 241);
            label3.Name = "label3";
            label3.Size = new Size(61, 25);
            label3.TabIndex = 4;
            label3.Text = "Email";
            label3.Click += label3_Click;
            // 
            // lNameBox
            // 
            lNameBox.Location = new Point(777, 148);
            lNameBox.Name = "lNameBox";
            lNameBox.Size = new Size(371, 31);
            lNameBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(623, 148);
            label2.Name = "label2";
            label2.Size = new Size(106, 25);
            label2.TabIndex = 2;
            label2.Text = "Last Name";
            // 
            // fNameBox
            // 
            fNameBox.Location = new Point(191, 148);
            fNameBox.Name = "fNameBox";
            fNameBox.Size = new Size(371, 31);
            fNameBox.TabIndex = 1;
            fNameBox.TextChanged += fNameBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(26, 148);
            label1.Name = "label1";
            label1.Size = new Size(110, 25);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(studentTable);
            panel2.Location = new Point(-2, 456);
            panel2.Name = "panel2";
            panel2.Size = new Size(1220, 746);
            panel2.TabIndex = 1;
            // 
            // button4
            // 
            button4.BackColor = Color.SpringGreen;
            button4.Location = new Point(511, 377);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 13;
            button4.Text = "Edit";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.OrangeRed;
            button3.Location = new Point(648, 377);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 13;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // studentTable
            // 
            studentTable.BackgroundColor = SystemColors.ControlLightLight;
            studentTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentTable.GridColor = SystemColors.ActiveCaptionText;
            studentTable.Location = new Point(0, 3);
            studentTable.Name = "studentTable";
            studentTable.RowHeadersWidth = 62;
            studentTable.RowTemplate.Height = 33;
            studentTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            studentTable.Size = new Size(1217, 368);
            studentTable.TabIndex = 14;
            studentTable.CellContentClick += studentTable_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1210, 889);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Student Form";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)studentTable).EndInit();
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
        private DataGridView studentTable;
        private Button button4;
        private Button button3;
        private Button button1;
    }
}
