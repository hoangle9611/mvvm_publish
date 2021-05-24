using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Controls;
using System.Windows.Data;
using System.Globalization;
using System.Collections;

namespace Mvvm.Myadress
{
    //class DictionaryItemConverter : DependencyObject, INotifyPropertyChanged
    //{
    //    [Category("My Properties")]
    //    public string Address
    //    {
    //        get { return (string)GetValue(_Address); }
    //        set { SetValue(_Address, value); }
    //    }

    //    // Using a DependencyProperty as the backing store for Value.  This enables animation, styling, binding, etc...
    //    public static readonly DependencyProperty _Address =
    //        DependencyProperty.Register("Address", typeof(string), typeof(DictionaryItemConverter),
    //            new FrameworkPropertyMetadata(null, new PropertyChangedCallback(OnValue1Property)));
    //    //new PropertyMetadata(default(ItemCollection), OnValue1Property));
    //    private static void OnValue1Property(DependencyObject d, DependencyPropertyChangedEventArgs e)
    //    {
    //        //MyControlBar myControlBar = (MyControlBar)d;
    //        //myControlBar.txttile.Text = (string)e.NewValue;//cho nay chua hieu lam
    //        Binding bd = new Binding("Value");
    //        bd.Source = myDictionary.Item[(string)e.NewValue];
    //        bd.Mode = BindingMode.OneWay;
    //    }
    //    public event PropertyChangedEventHandler PropertyChanged;
    //    protected virtual void OnPropertyChanged(string newName)
    //    {
    //        if (PropertyChanged != null)
    //        {
    //            PropertyChanged(this, new PropertyChangedEventArgs(newName));
    //        }
    //    }
    //}
   
        public class DictionaryItemConverter : IValueConverter
        {
            public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
            {
                var dict = value as Dictionary<string, tag>;
                if (dict != null)
                {
                    return dict[parameter as string];
                }
                throw new NotImplementedException();
            }

            public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
            {
                throw new NotImplementedException();
            }
        }
    
}
