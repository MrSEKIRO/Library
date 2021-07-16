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
using Library.Classes;

namespace Library
{
	/// <summary>
	/// Interaction logic for Manager.xaml
	/// </summary>
	public partial class Manager_Page : Window
	{
		private int manager_id;
		private bool isChkbx_Checked;
		public Manager_Page(int id,bool isChkbx_Checked)
		{
			InitializeComponent();
			manager_id = id;
			this.isChkbx_Checked = isChkbx_Checked;
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
			MessageBoxResult result = MessageBox.Show("Are you sure to exit?", "Exit", MessageBoxButton.YesNo);

			if(result == MessageBoxResult.Yes)
			{
				if(isChkbx_Checked == true)
				{
					MainWindow mainWindow = new MainWindow(Person_Type.Manager, manager_id);
					mainWindow.Show();
					this.Close();
				}
				else
				{
					MainWindow mainWindow = new MainWindow();
					mainWindow.Show();
					this.Close();
				}
			}
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