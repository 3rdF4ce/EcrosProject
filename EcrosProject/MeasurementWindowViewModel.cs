using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using System.IO.Ports;
using System.IO;

namespace EcrosProject
{
    public class MeasurementWindowViewModel : ViewModelBase
    {

        private string filename;
        private int[] chanel;
        private int[] signal;

        public int[] Signal 
        {
            get { return signal; }
            
            set {
                 signal = value;
                 RaisePropertyChanged(() => Signal);
                }
        
        }
        
        public int[] Chanel
        {
            get { return chanel; }

            set
            {
                chanel = value;
                RaisePropertyChanged(() => Chanel);
            }


        }

        public string Filename
        {
            get { return filename; }
            set
            {
                filename = value;
                RaisePropertyChanged(() => Filename);
            }

        }


        private ICommand _showMeasurment;
       

        public MeasurementWindowViewModel()
        {
            Signal = new int[4400];
            Chanel = new int[4400];
            Filename = "Название спектра";
        }


        public ICommand ShowMeasurement => _showMeasurment ?? (_showMeasurment = new RelayCommand(() =>
                                                         {
                                                             String read;
                                                             StreamReader fstream = File.OpenText(@"\AK\Ecros\EcrosProjectWpf\EcrosProject\Data\data.pte");
                                                             Filename = "data.pte";
                                                             int i = 0;
                                                             while ((read = fstream.ReadLine()) != null)
                                                             {
                                                                 
                                                                 Signal[i] = Convert.ToInt32(read);
                                                                 Chanel[i] = i;
                                                                 i++;
                                                             }
                                                             fstream.Close();
                                                         }));

    }
}
