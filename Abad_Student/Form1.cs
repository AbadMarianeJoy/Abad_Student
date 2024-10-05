using System;
using System.Windows.Forms;

namespace Abad_Student
{
    public partial class STUDENT_FORM : Form
    {
        public STUDENT_FORM()
        {
            InitializeComponent();
            PopulateComboBoxes();
        }

        private void PopulateComboBoxes()
        {
            // Populate day ComboBox
            for (int i = 1; i <= 31; i++)
            {
                comboBox_Day.Items.Add(i);
            }

            // Populate month ComboBox
            comboBox_Month.Items.AddRange(new string[]
            {
                "January", "February", "March", "April", "May", "June",
                "July", "August", "September", "October", "November", "December"
            });

            // Populate year ComboBox
            for (int i = DateTime.Now.Year; i >= 1990; i--)
            {
                comboBox_Year.Items.Add(i);
            }

            // Populate program ComboBox
            comboBox_Program.Items.AddRange(new string[]
            {
           
            "Bachelor of Science in Information Technology",
            "Bachelor of Science in Computer Science",
            "Associate in Computer Science",
            "Bachelor of Science in Business Administration",
            "Bachelor of Science in Accountancy",
            "Bachelor of Science in Marketing Management"
        });
        }

        private void button_Register_Click(object sender, EventArgs e)
        {
            // Collecting input values
            string firstName = text_Firstname.Text.Trim();
            string middleName = text_Middlename.Text.Trim();
            string lastName = text_Lastname.Text.Trim();
            string gender = radioButton_Male.Checked ? "MALE" : radioButton_Female.Checked ? "FEMALE" : null;

            // Validate inputs
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
            {
                MessageBox.Show("First name and last name are required.");
                return;
            }

            // Validate birthday selection
            string day = comboBox_Day.SelectedItem?.ToString();
            string month = comboBox_Month.SelectedItem?.ToString();
            string year = comboBox_Year.SelectedItem?.ToString();

            if (day == null || month == null || year == null)
            {
                MessageBox.Show("Please select a valid birthday.");
                return;
            }

            string birthday = $"{day} {month} {year}";
            string program = comboBox_Program.SelectedItem?.ToString();

            // Call overloaded Register method
            Register(firstName, middleName, lastName, gender, birthday, program);
        }

        // Method overloads for Register
        private void Register(string firstName, string lastName)
        {
            MessageBox.Show($"Full Name: {firstName} {lastName}");
        }

        private void Register(string firstName, string middleName, string lastName, string gender, string birthday, string program)
        {
            string message = BuildRegistrationMessage(firstName, middleName, lastName, gender, birthday, program);

            if (string.IsNullOrWhiteSpace(message))
            {
                MessageBox.Show("Please enter your information.");
            }
            else
            {
                MessageBox.Show(message.ToUpper());
            }
        }

        private string BuildRegistrationMessage(string firstName, string middleName, string lastName, string gender, string birthday, string program)
        {
            string message = "";

            if (!string.IsNullOrWhiteSpace(firstName) && !string.IsNullOrWhiteSpace(lastName))
            {
                message += $"Full Name: {firstName} {middleName} {lastName}\n";
            }

            if (!string.IsNullOrWhiteSpace(gender))
            {
                message += $"Gender: {gender}\n";
            }

            if (!string.IsNullOrWhiteSpace(birthday))
            {
                message += $"Birthday: {birthday}\n";
            }

            if (!string.IsNullOrWhiteSpace(program))
            {
                message += $"Program: {program}\n";
            }

            return message;
        }
    }
}
