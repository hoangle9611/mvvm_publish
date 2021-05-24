using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Mvvm.ViewModels;

namespace Mvvm.Myadress
{
    class tag: BaseViewModel /*: INotifyPropertyChanged*/
    {
        public delegate void EventValueChangedHandler(object value);
        private string _address;

        public string Address
        {
            get { return _address; }
            set
            {
                _address = value;
                OnPropertyChanged("Address"); 


            }
        }
        private dynamic _value;

        public dynamic Value
        {
            get { return _value; }
            set
            {
                _value = value;
                OnPropertyChanged("Value");
                OnEventValueChanged();
            }

        }
        public tag()
        {

        }
        public tag(string adress)
        {
            this.Address = adress;
        }
        public tag(string adress, dynamic value)
        {
            this.Address = adress;
            this.Value = Value;
        }
      //  public event PropertyChangedEventHandler PropertyChanged;
        public event EventValueChangedHandler EventValueChanged = null;
        //protected virtual void OnPropertyChanged(string newName)
        //{
        //    if (PropertyChanged != null)
        //    {
        //        PropertyChanged(this, new PropertyChangedEventArgs(newName));
        //    }
        //}
        protected virtual void OnEventValueChanged()
        {
            if (EventValueChanged != null)
                EventValueChanged(this.Value);
        }
        //protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        //{
        //    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}
    }
}
