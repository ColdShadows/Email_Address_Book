using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Email_Address_Book
{
    public partial class Form1 : Form
    {
        StreamReader infile;
        List<Person> people = new List<Person>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            infile = File.OpenText("People.txt");

            while (!infile.EndOfStream)
            {
                Person p = new Person();

                p.Name = infile.ReadLine();
                p.Email = infile.ReadLine();
                p.Phone = infile.ReadLine();

                people.Add(p);
            }

            foreach (Person p in people)
            {
                lstPeople.Items.Add(p.Name);

            }
        }

        private void lstPeople_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = 0;
            index = lstPeople.SelectedIndex;
            Email email = new Email();
            email.name = people[index].Name;
            email.phone = people[index].Phone;
            email.email = people[index].Email;
            email.ShowDialog();
        }
    }
}
