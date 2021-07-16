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
using System.Data;
using System.Data.SqlClient;
using System.IO;
using Library.Classes;


namespace Library
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Person person = new Person();

        static string connstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Arshia\Library\Library\DbLibrary.mdf;Integrated Security=True";
        static SqlConnection conn = new SqlConnection(connstring);

        public MainWindow()
        {
            InitializeComponent();
        }

		public MainWindow(Person_Type person_Type,int id)
		{
            InitializeComponent();

			string tbl = "tbl" + person.person_type.ToString();
			string command = "select [Email],[Password] from " + tbl + " where Id='" + id + "'";

			try
			{
                conn.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command, conn);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                txtbx_login_username.Text = dataTable.Rows[0][0].ToString();
                conn.Close();
			}
            catch { }

			switch(person_Type)
			{
                case Person_Type.User:
				{
                    btn_welcom_user_Click(null, null);
				}
				break;

                case Person_Type.Manager:
				{
                    btn_welcom_manager_Click(null, null);
				}
				break;

                case Person_Type.Employee:
				{
                    btn_welcom_employee_Click(null, null);
				}
				break;
			}

		}

		private void btn_welcom_exit_Click(object sender, RoutedEventArgs e)
		{
            this.Close();
		}

		private void btn_welcom_user_Click(object sender, RoutedEventArgs e)
		{
            //** set person type to user
            person.person_type=Person_Type.User;

            TabControl_welcom.SelectedItem = Tab_Login;
            btn_signin.Visibility = Visibility.Visible;
		}

		private void btn_welcom_manager_Click(object sender, RoutedEventArgs e)
		{
            //** set person type to manager
            person.person_type = Person_Type.Manager;

            TabControl_welcom.SelectedItem = Tab_Login;
            btn_signin.Visibility = Visibility.Hidden;
		}

		private void btn_welcom_employee_Click(object sender, RoutedEventArgs e)
		{
            //** set person type to employee
            person.person_type = Person_Type.Employee;

            TabControl_welcom.SelectedItem = Tab_Login;
            btn_signin.Visibility = Visibility.Hidden;
		}

		private void btn_signin_Click(object sender, RoutedEventArgs e)
		{
            Sign_in_edit_info signpage = new Sign_in_edit_info();
            signpage.Show();
            this.Close();
		}

		private void btn_welcom_back_Click(object sender, RoutedEventArgs e)
		{
            TabControl_welcom.SelectedItem = Tab_welcom;
		}
		private void btn_login_Click(object sender, RoutedEventArgs e)
		{
			//** check the password and email
			if(txtbx_login_username.Text == string.Empty)
			{
                lbl_login_user_error.Content = "Username is empty";
			}

			if(txtbx_login_pass.Password == string.Empty)
			{
                lbl_login_pass_error.Content = "Password is empty";
                return;
			}

			//** open one of these with regard to person type

			//** 1.User user= new User(id);

			//** 2.Manager manager = new Manager(id);

			//** 3.Employee employee = new Employee(id);

            int id = check_EmailPass(person.person_type, txtbx_login_username.Text, txtbx_login_pass.Password);

			switch(person.person_type)
			{
                case Person_Type.Manager:
				{
					if(id != 0)
					{
                        Manager_Page manager_Page = new Manager_Page(id, (bool)chkbx_remeberme.IsChecked);
                        manager_Page.Show();
                        this.Close();
					}
				}
                break;

                case Person_Type.Employee:
				{
					if(id != 0)
					{
                        Employee_Page employee_Page = new Employee_Page(id, (bool)chkbx_remeberme.IsChecked);
                        employee_Page.Show();
                        this.Close();
					}
				}
                break;

                case Person_Type.User:
				{
					if(id != 0)
					{
                        User_Page user_Page = new User_Page(id, (bool)chkbx_remeberme.IsChecked);
                        user_Page.Show();
                        this.Close();
					}
				}
                break;
			}
		}

        private int check_EmailPass(Person_Type person_Type,string email,string pass) //** return id of person, 0 if it is not found or pass was wrong
		{
			string tbl="tbl"+person.person_type.ToString();

			try
			{
				conn.Open();
				string command = $"select [Id],[Password] from " + tbl + " where Email='" + email + "'";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command,conn);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                conn.Close();

                if(dataTable.Rows.Count < 1)
				{
                    lbl_login_user_error.Content = "Email not found";
                    return 0;
				}
				else
				{
					if(dataTable.Rows[0][1].ToString() == pass)
					{
                        return (int)dataTable.Rows[0][0];
					}
					else
					{
                        lbl_login_pass_error.Content = "Password is not correct";
                        return 0;
					}
				}
			}
			catch
			{
				lbl_login_pass_error.Content = "Database error";
			}
			
            return 0;
		}

		private void txtbx_login_username_TextChanged(object sender, TextChangedEventArgs e)
		{
            lbl_login_user_error.Content = string.Empty;
		}

		private void txtbx_login_pass_PasswordChanged(object sender, RoutedEventArgs e)
		{
            lbl_login_pass_error.Content = string.Empty;
		}
	}
}