﻿//------------------------------------------------------------------------------
// <copyright file="SaveToPackageView.xaml.cs" company="Aras Corporation">
//     © 2017-2023 Aras Corporation. All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

using System.Text.RegularExpressions;
using System.Windows;

namespace Aras.VS.MethodPlugin.Dialogs.Views
{
	/// <summary>
	/// Interaction logic for SaveToLocalPackageViewxaml.xaml
	/// </summary>
	public partial class SaveToPackageView : Window
	{
		public SaveToPackageView()
		{
			InitializeComponent();
		}

		private void MethodName_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
		{
			e.Handled = !Regex.IsMatch(e.Text, @"^\w$|^\w[\w, -]*\w$");
		}
	}
}
