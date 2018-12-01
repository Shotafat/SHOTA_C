using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using SQLite;
using SQLitePCL;


namespace minimarket
{
    public class Product
    {
        public int ID { get;  set; }
        public string Name { get;  set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

    }


    public static class StringReturner {

        public static string Stringer { get; set; }
        public static Action formchecker { get; set; }
        public static Action ButtonLoader { get; set; }
        public static Action FormOPen { get; set; }
        public static Action FormClose { get; set; }

    }

    public class DB
    {
        public SQLITEPCL  databaseclass { get; set; }
        public List<Product> ProductsDB { get; set; } 
        //    = new List<Product>
        //{
        //    new Product{ID=1, Name="puri", Price=4, Quantity=1}

        //};
        //                                                                                                                     //    {
        //                                                                                                                     //new Product{ID=1, Name="COCA-COLA", Price=1.5, Quantity=10},
                                                                                                                             // new Product{ID=2, Name="XACHAPURI", Price=2, Quantity=10},
                                                                                                                             //  new Product{ID=3, Name="IMERULI", Price=3, Quantity=10},
                                                                                                                             //   new Product{ID=4, Name="LOBIANI", Price=2.5, Quantity=10},
                                                                                                                             //    new Product{ID=5, Name="SHAURMA", Price=3, Quantity=10},
                                                                                                                             //     new Product{ID=6, Name="PIZZA", Price=5, Quantity=10},
                                                                                                                             //      new Product{ID=7, Name="KUBDARI", Price=2.5, Quantity=10},

        //  };
        //string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "data.db");
        //SQLiteConnection conn = new SQLiteConnection(pathh);
        

        //SQLITEPCL PDB = new SQLITEPCL(SQLiteConnection conn, string path);


        //public List<Product> DBconverter(SQLITEPCL PDB)
        //{
        //    var TableA = PDB.conn.Table<ProductTable>();
        //    if (TableA != null)
        //    { 
        //    var products = from o in PDB.conn.Table<ProductTable>() select new List<Product> { new Product { ID = o.id, Name = o.NameDB, Price = o.PriceDB, Quantity = 10 } };
        //    ProductsDB = products as List<Product>;
        //    return ProductsDB;
        //    }
        //    return null;
        //}

      //  public string teststring { get; set; } = "XAR GOCHIVIT?";

        public void Addproduct(int id, string name, double price, int quantity)
        => ProductsDB.Add(new Product { ID = id, Name = name, Price = price, Quantity = quantity });

        public void RemoveProduct(int index) => ProductsDB.RemoveAt(index);

        public List<string> All()
        {
            var Liststring = (from a in ProductsDB
                              select a.Name + " " + a.Price).ToList();
            //var TotalStockPrice = ProductsDB.Sum(o => o.Price);
            return Liststring;
        }








    }

    public class Order
    {
        public List<Product> SelectedProducts { get; set; }
        public double TotalPrice() => SelectedProducts.Sum(o => o.Price);

        //იღებს შერჩეულ პროდუქტებს, შემდეგ DB-ს კლასში ეძებს სახელების მიხედვით და აკორექტირებს მოცულობებს.
        public Func<List<Product>> SaleDelegate { get; set; }
        //იღებს შერჩეულ პროდუქტებს, შემდეგ DB-ს კლასში ეძებს სახელების მიხედვით და აკორექტირებს მოცულობებს.
        public Action StockChecker { get; set; }


    }















}
