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
	/// Interaction logic for Employee.xaml
	/// </summary>
	public partial class Employee_Page : Window
	{
		private int employee_id;
		private bool isChkbx_Checked;
		public Employee_Page(int id,bool isChkbx_Checked)
		{
			InitializeComponent();
			employee_id = id;
			this.isChkbx_Checked = isChkbx_Checked;
		}

		private void btn_employee_books_Click(object sender, RoutedEventArgs e)
		{
			TabControl_employee.SelectedItem = Tab_employee_books;
		}

		private void btn_employee_users_Click(object sender, RoutedEventArgs e)
		{
			TabControl_employee.SelectedItem = Tab_employee_users;
		}

		private void btn_employee_cart_Click(object sender, RoutedEventArgs e)
		{
			TabControl_employee.SelectedItem = Tab_employee_cart;
		}

		private void btn_employee_editinfo_Click(object sender, RoutedEventArgs e)
		{
			Sign_in_edit_info sign_In_Edit_Info = new Sign_in_edit_info("Edit info");
			sign_In_Edit_Info.Show();
		}

		private void btn_employee_exit_Click(object sender, RoutedEventArgs e)
		{
			MessageBoxResult result = MessageBox.Show("Are you sure to exit?", "Exit", MessageBoxButton.YesNo);

			if(result == MessageBoxResult.Yes)
			{
				if(isChkbx_Checked == true)
				{
					//** make a minewindow  (Person_type.User,id)
					MainWindow mainWindow = new MainWindow(Person_Type.Employee, employee_id);
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
	}
}