using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalki_V2
{
    public partial class New_Order : UserControl
    {
        public static Order order;
        private static New_Order obj1;
        public static New_Order Instance
        {
            get
            {
                if (obj1 == null)
                    obj1 = new New_Order();
                return obj1;
            }
        }
        public New_Order()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        
        private void New_Order_Load(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //this.Parent.Controls.Clear();
            //(this.Parent as  ).Children.Remove(this);
            obj1 = new New_Order();
            this.Dispose(false);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            // obj1 = new New_Order();
            //obj1.Show();
            //this.Dispose(false);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox13.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
        }

        private void Create_btn_Click(object sender, EventArgs e)
        {
            new Manager_Code().Show();
        }
    }
}
