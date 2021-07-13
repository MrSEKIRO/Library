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

namespace Library
{
	/// <summary>
	/// Interaction logic for Manager.xaml
	/// </summary>
	public partial class Manager_Page : Window
	{
		public Manager_Page()
		{
			InitializeComponent();
		}

		private void btn_manager_employee_Click(object sender, RoutedEventArgs e)
		{
			TabControl_manager.SelectedItem = Tab_manager_employee;
		}

		private void btn_manager_books_Click(object sender, RoutedEventArgs e)
		{
			TabControl_manager.SelectedItem = Tab_manager_books;
		}

		private void btn_manager_cash_Click(object sender, RoutedEventArgs e)
		{
			TabControl_manager.SelectedItem = Tab_manager_cash;
		}

		private void btn_manager_exit_Click(object sender, RoutedEventArgs e)
		{
			MainWindow mainWindow = new MainWindow();
			mainWindow.Show();
			this.Close();
		}

		private void btn_manager_addemployee_Click(object sender, RoutedEventArgs e)
		{
			Sign_in_edit_info sign_In_Edit_Info = new Sign_in_edit_info("Add Employee");
			sign_In_Edit_Info.Show();
		}

		private void btn_manager_addbook_Click(object sender, RoutedEventArgs e)
		{
			AddBookPage addBookPage = new AddBookPage();
			addBookPage.Show();
			this.Close();
		}
	}
}