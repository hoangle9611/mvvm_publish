using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace Mvvm.Myadress
{
    class read_and_writevalue
    {
        private static readonly Lazy<read_and_writevalue> _instance = new Lazy<read_and_writevalue>(() => new read_and_writevalue());
        public static read_and_writevalue Instance
        {
            get
            {
                return _instance.Value;

            }
        }
        private readonly System.Timers.Timer _timer;
       
        tag tag = new tag();
        tag tag1 = new tag();
        tag tag2 = new tag();
        tag tag3 = new tag();
        int i = 0;
        public read_and_writevalue()
        {
            if (myDictionary.Item.Count == 0)
            {
                set_dictionary();
            }

            _timer = new System.Timers.Timer();
            _timer.Interval = 500;
            _timer.Enabled = true;
            
            _timer.Elapsed+= _timer_Elapsed;
            
        }

        private void _timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            OnValuesRefreshed();
            OnValuesRefreshed1();
            if (i == 100) { i = 0; }
            i++;
            tag3.Address = "i";
            tag3.Value = i;
            myDictionary.Item["i"] = tag3;
            
        }
        public void set_dictionary()
        {
            int value = 1997;
            tag.Address = "my";
            tag.Value = value;
            tag1.Address = "99";
            tag1.Value = 99;
            tag2.Address = "100";
            tag2.Value = 100;
            tag3.Address = "i";
            tag3.Value = 0;
            myDictionary.Item.Add("0", tag1);
            myDictionary.Item.Add("6", tag1);
            myDictionary.Item.Add("99", tag2);
            myDictionary.Item.Add("i", tag3);
        }
        public event EventHandler ValuesRefreshed;
        private void OnValuesRefreshed()
        {
            ValuesRefreshed?.Invoke(this, new EventArgs());
        }
        public event EventHandler ValuesRefreshed1;
        private void OnValuesRefreshed1()
        {
            ValuesRefreshed1?.Invoke(this, new EventArgs());
        }
    }
}
