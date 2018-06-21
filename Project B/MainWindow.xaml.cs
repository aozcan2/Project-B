using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;

namespace Project_B
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<User> users = new ObservableCollection<User>();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }


        private void Login_Button(object sender, RoutedEventArgs e)
        {
            users.Add(item: new User() { UserName = username_box.ToString(), Password = password_box.Password.ToString(), LoginTime = DateTime.Now.ToString() });
        }
        
    }
}
