﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Infrastructure
{
    public class Constant
    {
        // DATE FORMAT
        public static string FORMAT_DATETIME { get { return "dd/MM/yyyy hh:MM"; } }
        public static string FORMAT_DATE { get { return "dd/MM/yyyy"; } }

        // TYPE OF PRODUCT
        public static string TYPE_VEHICLE = "01";
        public static string TYPE_ACCESSORY = "02";
    }
}
