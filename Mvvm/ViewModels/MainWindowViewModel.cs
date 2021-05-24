using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;
using Prism.Commands;
using System.Windows.Input;
using System.Windows;

namespace Mvvm.ViewModels
{
    class MainWindowViewModel: BindableBase
    {
        public ICommand MyComman { get; private set; }
        public ICommand command { get;  private set; }
        public MainWindowViewModel()
        {
            MyComman = new DelegateCommand(showmessage);
        }

        private void showmessage()
        {
            MessageBox.Show("ksdjfkajlf");
        }
    }
}
