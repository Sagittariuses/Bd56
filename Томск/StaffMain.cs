using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Томск
{
    public partial class StaffMain : Form
    {
        Washing wash;
        public StaffMain()
        {
            InitializeComponent();
        }

        private void StaffMain_Load(object sender, EventArgs e)
        {
            ConnectionHelper.ConnObj = new Entities();
            wash = new Washing();
            var washings = ConnectionHelper.ConnObj.Washing.ToList();
            dataGridView1.DataSource = washings;
            dataGridView2.DataSource = ConnectionHelper.ConnObj.Washing.ToList();
        }
    }
}
