using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace HomeworkTwentySeven
{
    public partial class Dashboard : Form
    {
        BindingList<string> names = new BindingList<string>();

        public Dashboard()
        {
            InitializeComponent();
            namesListBox.DataSource = names;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            bool firstNameFilled = (string.IsNullOrEmpty(firstNameText.Text) == false);
            bool lastNameFilled = (string.IsNullOrEmpty(lastNameText.Text) == false);
            bool validInput = firstNameFilled && lastNameFilled;

            if (validInput)
            {
                names.Add($"{firstNameText.Text} {lastNameText.Text}");
                firstNameText.Text = "";
                lastNameText.Text = "";

                firstNameText.Focus();
            }
            else
            {
                if (firstNameFilled == false)
                {
                    MessageBox.Show("First name is required", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    firstNameText.Focus();
                }
                else
                {
                    MessageBox.Show("Last name is required", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lastNameText.Focus();
                }
            }            
        }
    }
}
