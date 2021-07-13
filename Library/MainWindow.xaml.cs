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
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace Library
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

		private void btn_signin_Click(object sender, RoutedEventArgs e)
		{
            Sign_in_edit_info signpage = new Sign_in_edit_info();
            signpage.Show();
            this.Close();
		}

		private void btn_welcom_exit_Click(object sender, RoutedEventArgs e)
		{
            this.Close();
		}

		private void btn_welcom_user_Click(object sender, RoutedEventArgs e)
		{
            //** set person type to user

            TabControl_welcom.SelectedItem = Tab_Login;
            btn_signin.Visibility = Visibility.Visible;
		}

		private void btn_welcom_manager_Click(object sender, RoutedEventArgs e)
		{
            //** set person type to manager

            TabControl_welcom.SelectedItem = Tab_Login;
            btn_signin.Visibility = Visibility.Hidden;
		}

		private void btn_welcom_employee_Click(object sender, RoutedEventArgs e)
		{
            //** set person type to employee

            TabControl_welcom.SelectedItem = Tab_Login;
            btn_signin.Visibility = Visibility.Hidden;
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
            TabControl_welcom.SelectedItem = Tab_welcom;
		}

		private void btn_login_Click(object sender, RoutedEventArgs e)
		{
            //** check the password and email


            //** open one of these with regard to person type

            //** 1.

            //** 2.Manager manager = new Manager();

            //** 3.Employee employee = new Employee();

		}
	}
}