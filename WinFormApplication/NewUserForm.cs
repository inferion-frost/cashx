using Infrastructure.Facades;
using Infrastructure.Models.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormApplication.Utils;

namespace WinFormApplication
{
    public partial class NewUserForm : Form
    {
        public NewUserForm()
        {
            InitializeComponent();
        }

        private void enter_Button_Click(object sender, EventArgs e)
        {
            var personService = ServiceProvider.GetPersonService();
            var newPerson = new CreatePersonDTO()
            {
                FullName = userFullName_TextBox.Text,
                Email = userEmail_TextBox.Text,
                BirthDate = userBirthDate_DateTimePicker.Value,
                Phone = userPhoneNumber_MaskTextBox.Text
            };
            try
            {
                personService.CreatePerson(newPerson);
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Попробуйте заполнить все поля");
            }
        }

        private void UserFullName_TextBox_Validating(object sender, CancelEventArgs e)
        {
            var source = sender as TextBox;
            e.Cancel = string.IsNullOrWhiteSpace(source.Text);
        }

        private void UserEmail_TextBox_Validating(object sender, CancelEventArgs e)
        {
            var source = sender as TextBox;
            e.Cancel = !source.Text.IsEmail() || string.IsNullOrWhiteSpace(source.Text);
        }
    }
}
