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
	/// Interaction logic for Billing_Page.xaml
	/// </summary>
	public partial class Billing_Page : Window
	{
		public double Money { get; set; }

		public bool Is_user_siginin { get; set; }
		
		public Billing_Page(double money,bool user_signin)
		{
			InitializeComponent();
			this.Money = money;
			Is_user_siginin = user_signin;
			btn_bank_pay.Content = $"Pay {Money}$";
		}

		private void btn_bank_pay_Click(object sender, RoutedEventArgs e)
		{
			//** check fields 

			if(Is_user_siginin == true)
			{
				User_Page user = new User_Page(1/*shoud chang*/,false);
				user.Show();
				this.Close();
			}
			else
			{
				this.Close();
			}
		}

		private void btn_bank_cancel_Click(object sender, RoutedEventArgs e)
		{
			if(Is_user_siginin == true)
			{
				MainWindow mainWindow = new MainWindow();
				mainWindow.Show();
				this.Close();
			}
			else
			{
				this.Close();
			}
		}
	}
}