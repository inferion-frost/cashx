using Infrastructure.Facades;
using Infrastructure.Models.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormApplication.Utils;

namespace WinFormApplication
{
    public partial class MainForm : Form
    {
        private static readonly string _connectionString = 
            ConfigurationManager.ConnectionStrings["SqlServerCe"].ConnectionString;

        private static readonly IServiceFacadeFactory serviceFacadeFactory =
            new ServiceFacadeFactory(_connectionString);

        private GetPersonDTO _currentUser;

        public MainForm()
        {
            var personService = serviceFacadeFactory.GetPersonServiceFacade();
            if (!personService.HasPeopleInDatabase())
            {
                new NewUserForm().ShowDialog();
            }
            InitializeComponent();
            _currentUser = personService.GetFirstPerson();
            fullName_TextBox.Text = _currentUser.FullName;
            email_TextBox.Text = _currentUser.Email;
            birthDate_TextBox.Text = _currentUser.BirthDate?.ToShortDateString();
        }

        private void beginTransaction_Button_Click(object sender, EventArgs e)
        {

        }

        private void добавитьПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
