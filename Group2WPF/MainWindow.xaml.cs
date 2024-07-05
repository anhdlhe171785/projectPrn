using DataAccess;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Group2WPF
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private FlightManagementDbContext _context;
		public MainWindow()
		{
            InitializeComponent();
			_context = new FlightManagementDbContext();
		}

		private void btn_Click(object sender, RoutedEventArgs e)
		{
			lbl.Content = _context.Airlines.First().Name;
		}
	}
}