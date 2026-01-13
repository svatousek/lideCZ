using lideCZ.Interfaces;
using lideCZ.Models;
using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace lideCZ.Windows
{
    /// <summary>
    /// Interakční logika pro CreateNewPersonWindow.xaml
    /// </summary>
    public partial class CreateNewPersonWindow : Window
    {
        IPersonManager PersonManager { get; set; }
        public Person newPerson { get; private set; }

        public CreateNewPersonWindow(IPersonManager personManager)
        {
            PersonManager = personManager;
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string firstName = FN.Text;
                string lastName = LN.Text;
                int age = int.Parse(Age.Text);

                Person newPerson = new Person()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Age = age
                };

                PersonManager.Add(newPerson);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
