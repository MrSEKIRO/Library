using Microsoft.Win32;
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
	/// Interaction logic for Sign_in_edit_info.xaml
	/// </summary>
	public partial class Sign_in_edit_info : Window
	{
		public string title_page { get; set; }
		public Sign_in_edit_info(string tilte="Sign in")
		{
			InitializeComponent();
			title_page = tilte;
			
			if(title_page=="Sign in")
			{
				lbl_siginin_title.Content = tilte;
				btn_signPage_billing.Content = "Go to Billing page";
			}
			if(title_page=="Edit info")
			{
				lbl_siginin_title.Content = "Edit information";
				btn_signPage_billing.Content = "Edit";
			}
			if(title_page=="Add Employee")
			{
				lbl_siginin_title.Content = title_page;
				btn_signPage_billing.Content = "Add";
			}
		}

		private void btn_signPage_billing_Click(object sender, RoutedEventArgs e)
		{
			//** check the info for exeptions and save them in db


			Billing_Page billing_Page = new Billing_Page(5,true);
			billing_Page.Show();
			this.Close();
		}

		private void btn_browse_Click(object sender, RoutedEventArgs e)
		{
			OpenFileDialog op = new OpenFileDialog();
			op.Title = "Select a picture";  
			op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +  
			"JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +  
			"Portable Network Graphic (*.png)|*.png";  
			if (op.ShowDialog() == true)  
			{  
				imgPhoto.Source = new BitmapImage(new Uri(op.FileName));  
			}  
		}

		private void btn_signPage_back_Click(object sender, RoutedEventArgs e)
		{
			if(title_page=="Sign in")
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