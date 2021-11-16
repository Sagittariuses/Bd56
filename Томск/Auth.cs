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
    public partial class Aunthorization : Form
    {
        public Aunthorization()
        {
            InitializeComponent();
        }
        Staff role;
        private void EnterBtn_Click(object sender, EventArgs e)
        {
            role = new Staff();
            try
            {
                if (LoginTb.Text != "" && PasswordTb.Text != "")
                {
                    if (LoginTb.Text == role.StfLogin)
                    {
                        if (PasswordTb.Text != "'")
                        {
                            if (PasswordTb.Text == role.StfPassword)
                            {
                                string roleld = Convert.ToString(role.StfRole);
                                switch (roleld)
                                {
                                    case "A":
                                        {
                                            AdminMain adm = new AdminMain();
                                            adm.Show();
                                            this.Hide();
                                        }
                                        break;
                                    case "U":
                                        {
                                            StaffMain staff = new StaffMain();
                                            staff.Show();
                                            this.Hide();
                                        }
                                        break;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Неверные данные!");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }
    }
}
