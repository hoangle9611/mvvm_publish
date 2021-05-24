using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;
using Mvvm.Models;
using Mvvm.Views;
using MyControlElements;
//using Notifications.Wpf;
using ToastNotifications;
using ToastNotifications.Lifetime;
using ToastNotifications.Position;
using ToastNotifications.Messages;
using System.Windows.Data;
using Mvvm.Myadress;
using System.ComponentModel;
using System.Windows.Controls;
using Mvvm.Properties;

namespace Mvvm.ViewModels
{
    class MainViewModels : BaseViewModel
    {
      //  read_and_writevalue read_And_Writevalue = new read_and_writevalue();
        public ICommand Buttoncommand { get; set; }
        public ICommand command_insets { get; set; }
        public ICommand popup_arlet { get; set; }
        public ICommand comand_refeshvalue { get; set; }
        public ICommand command_openWindow { get; set; }
        public string namewindow { get; set; }
        public string value { get; set; }
        private string _myvalue;

        Select_Driver_Result _Select_Driver;
       

        
        public Select_Driver_Result SelectedDriver
        {
            get
            {
                return _Select_Driver;
            }

            set
            {
                _Select_Driver = value;
                if (value != null)
                {
                    Name = value.Name;
                    // Birthday = value.BirthDay;
                    //Number = value.Number;
                    Id = value.ID;
                }
                else
                {
                    Name = default(string);
                    //Address = default(string);
                    //PhoneNumber = default(string);
                    //Email = default(string);
                    Id = default(int);
                }
            }
        }


        public Driver _driverSelected;
        public Driver DriverSelected
        {
            get
            {
                return _driverSelected;
            }

            set
            {
                _driverSelected = value;
                if (value != null)
                {
                    Name = value.Name;
                   // Birthday = value.BirthDay;
                   //Number = value.Number;
                    Id = value.ID;
                }
                else
                {
                    Name = default(string);
                    //Address = default(string);
                    //PhoneNumber = default(string);
                    //Email = default(string);
                    Id = default(int);
                }
            }
        }
        private int _id;
        private string _name;
       

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private DataGridCellInfo _cellInfo;
        public DataGridCellInfo CellInfo
        {
            get { return _cellInfo; }
            set
            {
                _cellInfo = value;
                OnPropertyChanged("CellInfo");
              //  MessageBox.Show(string.Format("Column: {0}",_cellInfo.Column.DisplayIndex != null ? _cellInfo.Column.DisplayIndex.ToString() : "Index out of range!"));
            }
        }
        public string Myvalue
        {
            get { return _myvalue; }
            set
            {
                _myvalue = value;
                OnPropertyChanged();
            }
        }
        #region
        //[Category("My Properties")]

        //public string Address
        //{

        //    get { return (string)GetValue(_Address); }
        //    set { SetValue(_Address, value); }
        //}
        //// Using a DependencyProperty as the backing store for Value.  This enables animation, styling, binding, etc...
        //public static readonly DependencyProperty _Address =
        //    DependencyProperty.Register("Address", typeof(string), typeof(TextBox),
        //        new FrameworkPropertyMetadata(null, new PropertyChangedCallback(OnValue1Property)));
        ////new PropertyMetadata(default(ItemCollection), OnValue1Property));
        //private static void OnValue1Property(DependencyObject d, DependencyPropertyChangedEventArgs e)
        //{
        //    string address = (string)e.NewValue;

        //        Binding bd = new Binding("Value");
        //        bd.Source = myDictionary.Item[address];
        //        bd.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
        //        bd.Mode = BindingMode.OneWay;

        //        // myTextBox.SetBinding(MyTextBox.ValueProperty, bd);
        //        //myTextBox.ToolTip = address;

        // }
        #endregion
        public DataTable datatb { get; set; }
        public object testdatasouc { get; set; }
        private ObservableCollection<Driver> _Driver;
        public ObservableCollection<Driver> Driver1 { get => _Driver; set { _Driver = value; OnPropertyChanged(); } }
        public Driver mydriver { get; set; }
       // private readonly NotificationManager _notificationManager = new NotificationManager();
        public MainViewModels()
        {

            Buttoncommand = new RelayCommand<object>((p) => { return true; }, (p) => { MessageBox.Show("kteam"); });
            command_insets = new RelayCommand<object>((p) => { return true; }, (p) => { add_driver(); });
            popup_arlet = new RelayCommand<object>((p) => { return true; }, (P) => { showpopupwindow(); });
            comand_refeshvalue = new RelayCommand<object>((p) => { return true; }, (P) => {  });//getvalue_dictionary();
            command_openWindow = new RelayCommand<object>((p) => { return true; }, (P) => { open_window(); });
            getdatatable();
            //getvalue_dictionary();
            myfuction(null, null);
            read_and_writevalue.Instance.ValuesRefreshed += myfuction;
            read_and_writevalue.Instance.ValuesRefreshed1 += myfuction1;

            //CollectionViewSource.GetDefaultView(myDictionary.Item).Refresh();
            //TextBox textBlock = new TextBox();
            //textBlock.SetBinding(TextBlock.TextProperty, createFieldBinding("i"));
            //;

            //ValueProperty = DependencyProperty.Register("ValueProperty",
            //    typeof(object), typeof(My),
            //    new FrameworkPropertyMetadata(null, new PropertyChangedCallback(OnValueProperty)));
            //TagAddressProperty = DependencyProperty.Register("TagAddress",
            //    typeof(string), typeof(My),
            //    new FrameworkPropertyMetadata(string.Empty, new PropertyChangedCallback(OnTagAddressProperty)));
        }

        private void myfuction1(object sender, EventArgs e)
        {
            int i = 1 + 3;
        }

        private void open_window()
        {
            Window1 window1 = new Window1();
            window1.Show();
        }

        private void myfuction(object sender, EventArgs e)
        {
            try
            {
                Myvalue = myDictionary.Item["i"].Value.ToString();
            }
            catch { }
        }

        
        private static void OnValueProperty(DependencyObject o, DependencyPropertyChangedEventArgs e)
        {
            //WeightIndicator seg = (WeightIndicator)o;
            //seg.dv.SetNumber(a);
            //seg.chuc.SetNumber(b);
        }
        private static void OnTagAddressProperty(DependencyObject o, DependencyPropertyChangedEventArgs e)
        {
            //WeightIndicator seg = (WeightIndicator)o;
            //if (S7Tags.Item.ContainsKey((string)e.NewValue))
            //{
            //    Binding bd = new Binding("Value");
            //    bd.Source = S7Tags.Item[(string)e.NewValue];
            //    bd.Mode = BindingMode.OneWay;
            //    bd.FallbackValue = 9999;
            //    seg.SetBinding(WeightIndicator.ValueProperty, bd);
            //    seg.ToolTip = (string)e.NewValue;
            //}
        }
        private BindingBase createFieldBinding(string myPropertyName)
        {
            Binding binding = new Binding("Value");
            binding.Source = myDictionary.Item[myPropertyName].Value; ;
            binding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            return binding;
        }

        Notifier notifier = new Notifier(cfg =>
        {
            cfg.PositionProvider = new WindowPositionProvider(
                parentWindow: Application.Current.MainWindow,
                corner: Corner.TopRight,//goc xuat hien
                offsetX: 10,
                offsetY: 20);

            cfg.LifetimeSupervisor = new TimeAndCountBasedLifetimeSupervisor(
                notificationLifetime: TimeSpan.FromSeconds(3),
                maximumNotificationCount: MaximumNotificationCount.FromCount(5));

            cfg.Dispatcher = Application.Current.Dispatcher;
        });
        private void showpopupwindow()
        {
            notifier.ShowSuccess(Myvalue);
            //var content = new NotificationContent
            //{
            //    Title = "Sample notification",
            //    Message = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
            //    Type = (NotificationType)2
            //};
            //_notificationManager.Show(content);
            //var content = new NotificationContent { Title = "Notification in window", Message = "Click me!" };
            //var clickContent = new NotificationContent
            //{
            //    Title = "Clicked!",
            //    Message = "Window notification was clicked!",
            //    Type = NotificationType.Information
            //};
            //_notificationManager.Show(content, "WindowArea", onClick: () => _notificationManager.Show(clickContent));
        }
        
        private void getvalue_dictionary()
        {
           // Myvalue = myDictionary.Item["i"].Value.ToString();
            Binding bd = new Binding("Value");
            bd.Source = myDictionary.Item["i"].Value;
            bd.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            bd.Mode = BindingMode.OneWay;
            Myvalue = bd.Source.ToString();
        }

        private void add_driver()
        {
            try
            {
                Driver driver = new Driver();
                driver.Name = "hoang";
                driver.Number = "90";
                //driver.BirthDay=
                Dataprovider.Ins.DB.Drivers.Add(driver);
                Dataprovider.Ins.DB.SaveChanges();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            //  Dataprovider.Ins.DB.i


        }
        ObservableCollection<Driver> employees = new ObservableCollection<Driver>();
        public void getdatatable()
        {

            ListCollectionView collectionView = new ListCollectionView(employees);
            //collectionView = Dataprovider.Ins.DB.Drivers.ToList();
            collectionView.GroupDescriptions.Add(new PropertyGroupDescription("Number"));
            // myDataGrid.ItemsSource = collectionView;
            //Driver = new ObservableCollection<Driver>(Dataprovider.Ins.DB.Drivers);
            //Dataprovider.Ins.DB.Select_Driver();
            var query = Dataprovider.Ins.DB.Drivers;
            var query1 = Dataprovider.Ins.DB.Select_Driver();
            testdatasouc = query1.ToList();
          //  testdatasouc = query.ToList();//= Dataprovider.Ins.DB.Select_Driver();//.ToList();
           // Driver1 = Dataprovider.Ins.DB.Drivers;
          
            namewindow = "day la main";
            ;
        }

        //    public IEnumerable<Driver> GetDrivers()
        //    {
        //       // return datatb= Dataprovider.Ins.DB.Select_Driver().cop;
        //    }
    }
}
