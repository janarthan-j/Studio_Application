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
    public partial class Order : UserControl
    {
        private static Order obj1;
        public static Order Instance
        {
            get
            {
                if (obj1 == null)
                    obj1 = new Order();
                return obj1;
            }
        }
        public Order()
        {
            InitializeComponent();
            
        }

        private void Home_Load(object sender, EventArgs e)
        {
           
        }

  

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (!Order_panel.Controls.Contains(New_Order.Instance))
            {
                Order_panel.Controls.Add(New_Order.Instance);
                New_Order.Instance.BringToFront();
            }
            else
                New_Order.Instance.BringToFront();
        }
    }
}
