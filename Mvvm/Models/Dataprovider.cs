using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvvm.Models
{
    class Dataprovider
    {
        private static Dataprovider _ins;
        public static Dataprovider Ins { get { if (_ins == null) _ins = new Dataprovider(); return _ins; } set { _ins=value; } }
        public BetongEntities DB { get; set; }

        private Dataprovider()
        {
            DB = new BetongEntities();
        }
    }
}
