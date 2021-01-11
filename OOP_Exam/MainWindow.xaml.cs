using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OOP_Exam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        //Dummy data
        CurrentAccount CA1 = new CurrentAccount("John", "Doe", 1295);
        SavingsAccount SA1 = new SavingsAccount("Jane", "Doe", 1937);
        CurrentAccount CA2 = new CurrentAccount("Joe", "Smith", 1375);
        SavingsAccount SA2 = new SavingsAccount("Jess", "Murphy", 1937);

        ObservableCollection<Account> AccountCollection = new ObservableCollection<Account>();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Dummy data added to collection to be viewed in list.
            AccountCollection.Add(CA1);
            AccountCollection.Add(SA1);
            AccountCollection.Add(CA2);
            AccountCollection.Add(SA2);

            lbxAccountNames.ItemsSource = AccountCollection;
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //find selected account
            Account selectedAccount = lbxAccountNames.SelectedItem as Account;
            //ensure selection is not null
            if (selectedAccount != null)
            {
                //populate text boxes
                fNameBox.Text = selectedAccount.FirstName;
                sNameBox.Text = selectedAccount.SurName;
                balanceBox.Text = selectedAccount.Balance.ToString();
                if (selectedAccount is CurrentAccount)
                {
                    accTypeBox.Text = "Current Account";
                }
                else if (selectedAccount is SavingsAccount)
                {
                    accTypeBox.Text = "Savings Account";
                }
                interestBox.Text = selectedAccount.InterestDate.ToString();

            }
        }
    }
}