using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOADProject.ChildForms
{
    public partial class FormSalary : Form
    {
        string query = "", connectionString = @"Data Source = LAPHAO\TIEUMANTHAU; Initial Catalog = QLNS; User ID = sa; Password = 15122001";

        private void FormSalary_Load(object sender, EventArgs e)
        {

        }

        public FormSalary()
        {
            InitializeComponent();
        }
    }
}
