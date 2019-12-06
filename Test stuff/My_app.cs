using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Test_stuff
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("https://tycoleman523.wixsite.com/truegaming");
            SendToBack();
            panel2.Show();
        }

        private void All_links_Click(object sender, EventArgs e)
        {
            panel2.Hide();
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Youtube_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/channel/UCb26GSI8QUzlUeCKivAscDA?view_as=subscriber");
            SendToBack();
            panel2.Show();
        }

        private void Steam_Click(object sender,EventArgs e)
        {
            Process.Start("https://steamcommunity.com/id/TrueTrizz/");
            SendToBack();
            panel2.Show();
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Mcserver_pannel_Click(object sender, EventArgs e)
        {
            Process.Start("http://107.3.253.110:8081/");
            SendToBack();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel5.Show();
            BringToFront();
            panel6.Hide();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            BringToFront();
            
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            SendToBack();
        }
    }
}
