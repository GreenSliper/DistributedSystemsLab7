﻿using System;
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

namespace DistributedSystemsLab7
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

		string passwordTagDefault = "password";

		private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
		{
			PasswordBox pb = sender as PasswordBox;
			pb.Tag = (string.IsNullOrEmpty(pb.Password) ? passwordTagDefault : "");
		}

		private void OnLoginBtnClick(object sender, RoutedEventArgs e)
		{
			MessageBox.Show("Welcome!");
		}
	}
}
