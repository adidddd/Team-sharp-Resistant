using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public static class GlobalTicket
    {
        public static string name{get; set;}
        public static int ID { get; set; }
        public static string deptTime { get; set; }
        public static string arrivalTime { get; set; }
        public static int price { get; set; }

        public static string from { get; set; }
        public static string to { get; set; }
    }
}
