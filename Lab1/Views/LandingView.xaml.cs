using KMA.CSharp2024.Lab1.ViewModels;
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

namespace KMA.CSharp2024.Lab1.Views
{
    /// <summary>
    /// Interaction logic for LandingView.xaml
    /// </summary>
    public partial class LandingView : UserControl
    {
        public LandingView()
        {
            InitializeComponent();
            DataContext = new LandingViewModel();
        }

        private void DpOnSelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DataContext is LandingViewModel viewModel)
            {
                viewModel.BirthDate = (sender as DatePicker)?.SelectedDate ?? DateTime.Today;
            }
        }
    }
}
