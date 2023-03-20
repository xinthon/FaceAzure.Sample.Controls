using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace FaceAzure.Sample.Controls
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window , INotifyPropertyChanged
    {
        private string sampleString =  string.Empty;

        public string SampleString
        { 
            get => sampleString; 
            set {
                sampleString = value;
                OnPropertyChanged(nameof(SampleString));
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext= this;

            this.btnOne.Click += delegate
            {
                if(labelOne.LabelState == State.Edit)
                {
                    labelOne.LabelState = State.Normal;
                    return;
                }

                labelOne.LabelState = State.Edit;
            };
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
