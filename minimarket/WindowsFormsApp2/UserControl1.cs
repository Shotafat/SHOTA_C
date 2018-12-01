using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using minimarket;

namespace WindowsFormsApp2
{
    public partial class UserControl1 : UserControl
    {
        private Product _product;

        public UserControl1()
        {
            InitializeComponent();
        }

        public UserControl1(Product p):this() {

            _product = p;
            PName.Text = p.Name;
            PPrice.Text = p.Price.ToString();
            Width = 130;
            Height = 130;
            BackColor = Color.DarkSlateGray;
            
            
        }

        public event EventHandler<Product> ClickAction;
        private void UserControl1_Click(object sender, EventArgs e)
        {
            //  MessageBox.Show("SSS");
            ClickAction.Invoke(this, _product);
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {



        }

        private void რედაქტირებაToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 Editform = new Form3( _product);
            Editform.Show();
            
         

        }

        private void წაშლაToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void დამატებაToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isedit = true;
            Form3 Editform = new Form3(isedit);
            Editform.Show();

        }
    }
}
