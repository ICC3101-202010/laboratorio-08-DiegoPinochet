﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_Diego_Pinochet.CustomArgs
{
    public class TiendaEventArgs:EventArgs
    {
        public string NameText { get; set; }
        public int IdentNumText { get; set; }
        public string HoursText { get; set; }
        public string CategoryText { get; set; }
    }
}
