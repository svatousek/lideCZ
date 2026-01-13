using lideCZ.Database;
using lideCZ.Interfaces;
using lideCZ.Managers;
using lideCZ.Models;
using lideCZ.Repositories;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lideCZ
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public IPersonManager PersonManager { get; set; }

        ObservableCollection<Person> Data { get; set; }

        public MainWindow()
        {
            IPersonRepository personRepository = new PersonRepositary(new PersonContext());
            PersonManager = new PersonManager(personRepository);
            Data = new ObservableCollection<Person>((PersonManager.GetAll()));
            InitializeComponent();
            LV.DataContext = Data;

            //LV.DataContext = new ObservableCollection<Person>(PersonManager.GetAll());
        }
    }
}