using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabView
{
    public partial class questionReview : Form
    {
        public questionReview(string rating, string smallBuisness, string interviewee)
        {
            InitializeComponent();
            label1.Text = ("This buisness was rated: " + rating);
            label2.Text = ("Small buisness: " + smallBuisness);
            label3.Text = ("This interview was conducted with: " + interviewee);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
