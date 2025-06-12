using System.Diagnostics.Tracing;

namespace OOPProbalkozas
{
    public partial class Form1 : Form
    {
        List<BankAccount> bankAccounts = new List<BankAccount>();
        public Form1()
        {
            InitializeComponent();

            /*
             
            BankAccount bankAccount = new BankAccount();
            bankAccount.Owner = "Apad Fasza";
            bankAccount.AccountNumber = Guid.NewGuid();
            bankAccount.Amount = 200;

            BankAccount bankAccount2 = new BankAccount();
            bankAccount2.Owner = "Apad Fasza2";
            bankAccount2.AccountNumber = Guid.NewGuid();
            bankAccount2.Amount = 600;

            BankAccount bankAccount3 = new BankAccount();
            bankAccount3.Owner = "Apad Fasza3";
            bankAccount3.AccountNumber = Guid.NewGuid();
            bankAccount3.Balance = 200;

            List<BankAccount> bankAccounts = new List<BankAccount>();
            bankAccounts.Add(bankAccount);
            bankAccounts.Add(bankAccount2);
            bankAccounts.Add(bankAccount3);

            BankAccountsGrid.DataSource = bankAccounts;
            */
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            /*
            EN MEGOLDASOM:
            if (OwnerTxt.Text != null && OwnerTxt.Text != "")
            {
                BankAccount bankaccount = new BankAccount(OwnerTxt.Text);
                bankAccounts.Add(bankaccount);


                refreshGrid();

                MessageBox.Show("Sikeres hozzaadas!");
            }
            else
            {
                MessageBox.Show("Irjon be egy tulajdonost!");
            }
            */

            //videoban a megoldas
            if (string.IsNullOrEmpty(OwnerTxt.Text))
            {
                return;
            }

            BankAccount bankaccount = new BankAccount(OwnerTxt.Text);
            bankAccounts.Add(bankaccount);

            refreshGrid();

            OwnerTxt.Clear();

        }

        private void refreshGrid()
        {
            BankAccountsGrid.DataSource = null;
            BankAccountsGrid.DataSource = bankAccounts;
        }

        private void DepositBtn_Click(object sender, EventArgs e)
        {
            if (BankAccountsGrid.SelectedRows.Count == 1 && AmountNum.Value > 0)
            {
                BankAccount selectedAccount = BankAccountsGrid.SelectedRows[0].DataBoundItem as BankAccount;

                MessageBox.Show(selectedAccount.deposit(AmountNum.Value));

                refreshGrid();
                AmountNum.Value = 0;
            }
        }

        private void WithdrawBtn_Click(object sender, EventArgs e)
        {
            if(BankAccountsGrid.SelectedRows.Count == 1 && AmountNum.Value > 0) {
                BankAccount selectedAccount = BankAccountsGrid.SelectedRows[0].DataBoundItem as BankAccount;

                if (selectedAccount.Balance - AmountNum.Value < 0) {
                    MessageBox.Show("Nem lehet többet kivenni, mint amennyi bent van!");
                    AmountNum.Value = selectedAccount.Balance;

                }
                else
                {
                    MessageBox.Show(selectedAccount.withdraw(AmountNum.Value));
                    refreshGrid();
                    AmountNum.Value = 0;
                }                   
            }
        }
    }
}
