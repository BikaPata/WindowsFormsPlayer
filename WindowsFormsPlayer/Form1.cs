using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            
        }

        Random rand= new Random();   

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            try
            {
                if (progBarLoad.Value >= 100)
                    {
                        Player player = new Player();
                        player.Show();
                        this.Hide();
                        timer1.Enabled = false;
                    }
                else
                    {
                        int rnd = rand.Next(3, 15);
                        if (progBarLoad.Value+rnd > 100) { progBarLoad.Value = 100; }   
                        else { progBarLoad.Value += rnd; }
                   }

            }
            catch (Exception)
            {

            }


        }

    }
}
