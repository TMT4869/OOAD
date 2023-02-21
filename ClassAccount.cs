using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace OOADProject
{
    internal class ClassAccount
    {
        static string taikhoan;
        static int msnv;
        public static string username
        {
            get { return taikhoan; }
            set { taikhoan = value; }
        }

        public static int id
        {
            get { return msnv; }
            set { msnv = value; }
        }

        public static string name { get;set; }
        public static string email { get; set; }
        public static string PN { get; set; }
        public static DateTime BD { get; set; }
        public static string position { get; set; }
        public static string department { get; set; }
        public static string acc { get; set; }
    }
}
