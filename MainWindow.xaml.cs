using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace ArtikliWPF
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public ObservableCollection<Artikal> Art = new ObservableCollection<Artikal>();
		
		public MainWindow()
		{
			InitializeComponent();
			Art.Add(new Artikal("001", "Plazam", 100, 25));
			Art.Add(new Artikal("002", "Nesto", 200, 12));
			Art.Add(new Artikal("003", "Nesto trece", (decimal)54.5, 90));

			

			dg.ItemsSource = Art;
		}

		private void Dodavanje(object sender, RoutedEventArgs e)
		{
			ArtEd Editor = new ArtEd();
			Editor.Owner = this;
			Editor.ShowDialog();
		}
		private void Brisanje(object sender, RoutedEventArgs e)
		{

		}
		private void Izmena(object sender, RoutedEventArgs e)
		{

		}
	}
}
