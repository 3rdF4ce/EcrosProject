using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using LiveCharts;
using LiveCharts.Defaults; //Contains the already defined types
namespace EcrosProject
{
    /// <summary>
    /// Interaction logic for MeasurementWindow.xaml
    /// </summary>
    /// 
   
    public partial class MeasurementWindow : Window
    {
       
        public string ViewModel { get; set; }

        public void ShowViewModel()
        {
            MessageBox.Show(ViewModel);
        }
        
        public MeasurementWindow()
        {
            InitializeComponent();
        } 
     }
}
