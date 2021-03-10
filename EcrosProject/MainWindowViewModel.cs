using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace EcrosProject
{
   public class MainWindowViewModel
    {
        private ICommand _showMeasurmentWindow;
        public ICommand ShowMeasurementWindow
        {
            get
            {
                return _showMeasurmentWindow ?? (_showMeasurmentWindow = new RelayCommand(() =>
                {
                    MeasurementWindow measurementWindow = new MeasurementWindow();
                    measurementWindow.Show();
                }));
                
            }
        }

        private ICommand _showSelectorWindow;
        public ICommand ShowSelectorWindow
        {
            get
            {
                return _showSelectorWindow ?? (_showSelectorWindow = new RelayCommand(() =>
                {
                    SelectorWindow selectorWindow = new SelectorWindow();
                    selectorWindow.Show();
                }));

            }
        }
    }
}
