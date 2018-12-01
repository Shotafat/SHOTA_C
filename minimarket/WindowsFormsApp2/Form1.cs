using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using minimarket;
using SQLite;
using SQLitePCL;



namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

   

        public void Check(Product product)
        {
            if (ProductsforDataGrid.Contains(product))
            {
                int i = 0;
                double previusprice = 0;
               i= ProductsforDataGrid[ProductsforDataGrid.FindIndex(o => o== product)].Quantity;
                i++;
                ProductsforDataGrid[ProductsforDataGrid.FindIndex(o => o == product)].Quantity = i;
                previusprice=ProductsforDataGrid[ProductsforDataGrid.FindIndex(o => o == product)].Price;
                ProductsforDataGrid[ProductsforDataGrid.FindIndex(o => o == product)].Price = (previusprice / (i - 1)) * i;
              //  MessageBox.Show(i.ToString());
              // product.Quantity = product.Quantity++;
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ProductsforDataGrid;
                

            }
            else
            { 
                ProductsforDataGrid.Add(product);
                product.Quantity = 1;
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ProductsforDataGrid;

            }

            sumfun();
        }

        public void sumfun()
        {
            var sumlist = ProductsforDataGrid.Sum(o => o.Price);
            SumLabel.Text = sumlist.ToString() + " ლარი";
            StringReturner.Stringer = sumlist.ToString();
        }

        public void ButtonsADD()
        {
            if (ShotaDB.ProductsDB != null)
            {
                var ButtonListText = (from o in ShotaDB.ProductsDB
                                      select new UserControl1(o) { }).ToList();
                flowLayoutPanel1.Controls.Clear();
                foreach (var item in ButtonListText)
                {
                    flowLayoutPanel1.Controls.Add(item);

                    item.ClickAction += btn_onclick;

                }
             //   flowLayoutPanel1.Controls.
                 }
          

        }
        


        public void NextBuy()
        {
            this.Visible = true;
            dataGridView1.DataSource = null;
        }
        
        SQLITEPCL SQDatabase = new SQLITEPCL();

        DB ShotaDB = new DB { };
        Order ShotaOrder = new Order { };
       List<Product> ProductsforDataGrid=new List<Product>();

        private void btn_onclick(object sender, Product e)
        {
            //var bt = (sender as UserControl1);
          //  e.Quantity = 1;
        
            //            dataGridView1.Rows.Add(bt.PName.Text, bt.PPrice.Text, 1);
           // Product P = e;
        //   ProductsforDataGrid.Add(e);
            //   ShotaOrder.SelectedProducts.Add(e);
            //  MessageBox.Show(ShotaOrder.SelectedProducts[0].Name);
            // ProductsforDataGrid = ShotaOrder.SelectedProducts;

            //var m = from o in ProductsforDataGrid select new { o.Name, o.Price };
            Check(e);
         



            

        }


        public void Form1_Load(object sender, EventArgs e)
        {

          


            StringReturner.ButtonLoader += ButtonsADD;
            SQDatabase.path= Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "data.db");
            SQDatabase.conn = new SQLiteConnection(SQDatabase.path);
            SQDatabase.createtable();
            BridgeClass.Formconn = SQDatabase.conn;
          //  SQDatabase.InsertFun("Name", 23);
            //   SQDatabase.InsertFun("SGITA", 2);

            //ShotaDB.DBconverter(SQDatabase);
           
         var sqlitedatabase=(from o in SQDatabase.conn.Table<ProductTable>() select  new Product { ID = o.id, Name = o.NameDB, Price = o.PriceDB, Quantity = 10 } )?.ToList();

            // if()
            ShotaDB.ProductsDB = new List<Product>();

           if (SQDatabase.conn.Table<ProductTable>().Count()==0)
            {
                Form3 productisdamateba = new Form3(true);
                productisdamateba.Show();
              
            }
           else
            { 
                ShotaDB.ProductsDB.AddRange((sqlitedatabase as List<Product>).ToList());
                StringReturner.ButtonLoader.Invoke();

            }

            //  Action<UserControl1, Product> Click__;
            //aq Chavsva BUTTONFUNC




        }

      


        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RemoveBT_Click(object sender, EventArgs e)
        {

            if(dataGridView1.SelectedCells.Count>0)
            {
                int selectedindex = dataGridView1.SelectedCells[0].RowIndex;
                //MessageBox.Show(selectedindex.ToString());

                DataGridViewRow selectedrow = dataGridView1.Rows[selectedindex];
                string ProductName = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
//                MessageBox.Show(ProductName);

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ProductsforDataGrid;
               Product P=ProductsforDataGrid.Where(o => o.Name == ProductName).FirstOrDefault();

                ProductsforDataGrid.Remove(P);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ProductsforDataGrid;

                sumfun();
            }

        }

        private void SaleBT_Click(object sender, EventArgs e)
        {
            Form2 SaleForm = new Form2();
            SaleForm.Show();
            //  StringReturner.formchecker = true;
            this.Visible=true;
      //      StringReturner.formchecker += NextBuy;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form3 productisdamateba = new Form3(true);
            productisdamateba.Show();


        //    SQDatabase.InsertFun("Lobio", 5);
        }
    }
}
