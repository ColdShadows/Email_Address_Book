using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Email_Address_Book
{
    public partial class Email : Form
    {
        public string name, email, phone;
        public Email()
        {
            InitializeComponent();
        }

        private void Email_Load(object sender, EventArgs e)
        {
            lblName.Text = name;
            lblEmail.Text = email;
            lblPhoneNumber.Text = phone;

        }
    }
}
