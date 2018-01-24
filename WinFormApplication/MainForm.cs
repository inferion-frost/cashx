using Infrastructure.Facades;
using Infrastructure.Models.Constants;
using Infrastructure.Models.DTO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WinFormApplication.Utils;

namespace WinFormApplication
{
    public partial class MainForm : Form
    {
        private long _currentUserId;
        private long _currentAccountId;
        private IPersonServiceFacade personService = ServiceProvider.GetPersonService();
        private IAccountServiceFacade accountService = ServiceProvider.GetAccountService();
        private ITransactionServiceFacade transactionService = ServiceProvider.GetTransactionService();

        private BindingSource _bindingSource = new BindingSource();
        private ObservableCollection<GetTransactionDTO> _transactions;
        private IDictionary<TransactionType, String> _transactionTypes = new Dictionary<TransactionType, String>()
        {
            { TransactionType.Incoming,"Доход" },
            { TransactionType.Outcoming,"Расход" },
        };

        public MainForm()
        {
            if (!personService.HasPeopleInDatabase()) new NewUserForm().ShowDialog();

            InitializeComponent();
            transactionType_ComboBox.DataSource = Enum.GetValues(typeof(TransactionType));

            var currentUser = personService.GetFirstPerson();
            var currentUserAccount = accountService
                .GetAccounts(currentUser.Id)
                .FirstOrDefault() ?? throw new InvalidOperationException();

            _currentUserId = currentUser.Id;
            _currentAccountId = currentUserAccount.Id;
            _transactions = new ObservableCollection<GetTransactionDTO>(transactionService.GetTransactions(_currentAccountId).Reverse());
            _transactions.CollectionChanged += _transactions_CollectionChanged;
            _bindingSource.DataSource = _transactions;
            _transactionsNavigator.BindingSource = _bindingSource;

            transactions_DataGridView.AutoGenerateColumns = false;
            transactions_DataGridView.AutoSize = true;

            transactions_DataGridView.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Id",
                Visible = false,
                ReadOnly = true
            });

            transactions_DataGridView.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Description",
                Name = "Описание",
                Width = 200
            });
            transactions_DataGridView.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "TransactionType",
                Name = "Тип операции"
            });
            transactions_DataGridView.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Balance",
                Name = "Сумма",
            });
            transactions_DataGridView.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "CreatedAt",
                Name = "Дата и время"
            });
            transactions_DataGridView.DataSource = _bindingSource;
            transactions_DataGridView.DefaultCellStyle = new DataGridViewCellStyle()
            {
                Font = new Font("Helvetica", 8),
                Padding = new Padding(2)
            };
            transactions_DataGridView.RowTemplate.MinimumHeight = 20;

            fullName_TextBox.Text = currentUser.FullName;
            email_TextBox.Text = currentUser.Email;
            birthDate_TextBox.Text = currentUser.BirthDate?.ToShortDateString();
            balance_TextBox.Text = currentUserAccount.Balance.ToString();
        }

        private void _transactions_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Remove)
            {
                foreach (GetTransactionDTO transaction in e.OldItems)
                    transactionService.DeleteTransaction(transaction.Id);
            }
            RefreshAccountLabel();
        }

        private void BeginTransaction_Button_Click(object sender, EventArgs e)
        {
            try
            {
                var transactionService = ServiceProvider.GetTransactionService();
                var transaction = transactionService.CreateTransaction(new CreateTransactionDTO()
                {
                    AccountId = _currentAccountId,
                    Description = transactionDescription_TextBox.Text,
                    TransactionType = (TransactionType)Enum.Parse(
                            typeof(TransactionType),
                            transactionType_ComboBox.SelectedValue.ToString()),
                    Balance = decimal.Parse(transactionSum_TextBox.Text)
                });
                _transactions.Insert(0, transaction);
                _bindingSource.ResetBindings(true);
                RefreshAccountLabel();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RefreshAccountLabel()
        {
            balance_TextBox.Text = accountService.GetAccount(_currentAccountId).Balance.ToString();
        }
    }
}
