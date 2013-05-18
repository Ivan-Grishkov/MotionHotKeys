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
using MotionHotKeys.RaiseEvents;

namespace MotionHotKeys
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private string _textStr;

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void RaiseSpace_Click(object sender, RoutedEventArgs e)
        {
            EventsGenerator.RiseSpacePressed();
        }

        public string TextStr
        {
            get { return _textStr; }
            set
            {
                //_textStr = value;
                //OnPropertyChanged("TextStr");
                EventsGenerator.RiseSpacePressed();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
