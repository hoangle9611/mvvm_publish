using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;
using Mvvm.Myadress;

namespace Mvvm.Views
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        int i = 0;
        public Window1()
        {
            InitializeComponent();
           // read_and_writevalue.Instance.ValuesRefreshed += funce;
        }
        private void funce(object sender, EventArgs e)
        {
        }
    }
}
