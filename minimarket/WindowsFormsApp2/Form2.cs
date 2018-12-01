using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using minimarket;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {

        public Form2()
        {
          
            InitializeComponent();
          //  Load+= new EventHandler(Form2);
        }

        public void RemoveText()
        {
            if (NumLabel.Text == "0"||NumLabel.Text.Length==1)
                NumLabel.Text = "0";
            else
            {
                string labeltext = NumLabel.Text.ToString();
                NumLabel.Text = labeltext.Substring(0, labeltext.Length - 1);
            }
        }


        public void button_onclick (object sender, EventArgs e)
        {
            

            Button butttontext = sender as Button;

            if (butttontext.Text == "DEL")
              RemoveText();

            if (NumLabel.Text == "0" && butttontext.Text != "DEL")
            {
                NumLabel.Text = butttontext.Text;
            }
            else if(butttontext.Text!="DEL")
            {
                NumLabel.Text = NumLabel.Text + butttontext.Text;

            }


        }



        private void Form2_Load(object sender, EventArgs e)
        {
            var a = CultureInfo.CurrentUICulture.NumberFormat.NumberDecimalSeparator;
                        List<string> Numbers = new List<string> { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", a.ToString(), "DEL" };
            var buttons = from o in Numbers select new Button { Text = o.ToString() };
            Fpanel.Width = this.Width-this.Width/2;
            Fpanel.Height = this.Height - this.Height / 5; ;


            foreach (var item in buttons)
            {
                Fpanel.Controls.Add(item);
                item.Click += button_onclick;
            }
            salesbutton.Height = Fpanel.Height - 50;


            
        }
        

        private void salesbutton_Click(object sender, EventArgs e)
        {
            ////dagvchirdeba Numlabel da SumLabel gamosaklebia _ლარი
           double Xurda = Convert.ToDouble(NumLabel.Text) - Convert.ToDouble(StringReturner.Stringer);
            if (Convert.ToDouble(NumLabel.Text) < Convert.ToDouble(StringReturner.Stringer))
                MessageBox.Show("Migebuli Tanxa araa sakmarisi");
            else
            {
                //   this.Close();
                MessageBox.Show("TQVENI XURDA " + Xurda.ToString() + " LARI");
                //      StringReturner.formchecker = false;
                //  StringReturner.formchecker.Invoke();
            }
            this.Close();
            DialogResult = DialogResult.OK;
        }
    }
}
