using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppITP
{
    public class Notificable : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChange
            (string Elemento=null)
        {

            if (PropertyChanged != null)
            {
                PropertyChanged.Invoke(this,

               new PropertyChangedEventArgs(Elemento));
            }
        }
    }
}
