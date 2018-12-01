using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using minimarket;
using SQLite;
using SQLitePCL;

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
           


        }

        public Form3(Product P): this() 
        {
            PNameTBOR.Text =P.Name;
            PPriceTBOR.Text = P.Price.ToString();

        }

        public Form3(bool a) : this()
        {
            NameLabelEdit.Visible = false;
            PriceLabelEdit.Visible = false;
            TNameEditBox.Visible = false;
            TPriceEditBox.Visible = false;




        }

        private void OkayButton_Click(object sender, EventArgs e)
        {
            BridgeClass.Formconn.Insert(new ProductTable { NameDB = PNameTBOR.Text.ToString(), PriceDB = Convert.ToInt32(PPriceTBOR.Text) });
            StringReturner.ButtonLoader.Invoke();
            DialogResult = DialogResult.OK;
            Close();
         


        }
    }
}
