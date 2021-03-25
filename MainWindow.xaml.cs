using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using ToDoApp.Models;

namespace ToDoApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Создаём контейнер для хранения моделей
        private BindingList<ToDoModel> _todoDataList;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _todoDataList = new BindingList<ToDoModel>()
            { 
                new ToDoModel() {Text = "test"},
                new ToDoModel() {Text = "test 2"},
                new ToDoModel() {Text = "test 3", IsDone = true}
            };

            //привязка списка к графической части
            dgToDoList.ItemsSource = _todoDataList;
            _todoDataList.ListChanged += _todoDataList_ListChanged;                                 //это событие возникает, когда в списке что-то меняется
        }

        private void _todoDataList_ListChanged(object sender, ListChangedEventArgs e)               //sender - это _todoDataList
        {
            if (e.ListChangedType == ListChangedType.ItemAdded || e.ListChangedType == ListChangedType.ItemDeleted || e.ListChangedType == ListChangedType.ItemChanged)
            {

            }
        }
    }
}
