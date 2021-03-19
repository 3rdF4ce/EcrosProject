using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using System.IO.Ports;
using System.IO;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace EcrosProject
{
    public class MeasurementWindowViewModel : INotifyPropertyChanged
    {

            
        private int[] signal;
        private string filename;
       
        public int[] Signal 
        {
            get { return signal; }
            set {
                 signal = value;
                 OnPropertyChanged("Signal");
                 }
        
        }
              
        public string Filename
        {
            get { return filename; }
            set
            {
                filename = value;
                OnPropertyChanged("Filename");
             }

        }


        public MeasurementWindowViewModel()
        {
            Signal = new int[4400];
            Filename = "Название файла";
        }

        private ICommand _showMeasurment;
        public ICommand ShowMeasurement => _showMeasurment ?? (_showMeasurment = new RelayCommand(() =>
                                                         {
                                                             Readfile(@"\AK\Ecros\EcrosProjectWpf\EcrosProject\Data\data.pte");
                                                         }));

        public void Readfile(String readfilepath)
        {

            
            StreamReader fstream = File.OpenText(readfilepath);
            Filename = readfilepath;
            int i = 0;
            while ((readfilepath = fstream.ReadLine()) != null)
            {
                Signal[i] = Convert.ToInt32(readfilepath);
                i++;
            }
            fstream.Close();
        }
       
        
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    
    }
    
}
