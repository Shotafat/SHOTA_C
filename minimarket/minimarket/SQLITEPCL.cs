using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using minimarket;
using System.Data;
using System.IO;

namespace minimarket
{
   public class SQLITEPCL
    {
       
        public SQLiteConnection conn { get; set; }
        public string path { get; set; }
        public void  createtable()
        {
            conn.CreateTable<ProductTable>();
        }


     


        //public SQLITEPCL()
        //    {
        // path= Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "data.db");
        //  conn= new SQLiteConnection(path);
        //    conn.CreateTable<ProductTable>();
        //    //conn.Insert(new ProductTable { NameDB = "YVELI", PriceDB = 5});
        //    }



        public void InsertFun(string name, int price)
        {
            conn.Insert(new ProductTable { NameDB = name, PriceDB = price });


        }
                                  
  }

     
   public class ProductTable
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public string NameDB { get; set; }
        public int PriceDB { get; set; }

    }



    public static class BridgeClass
    {

        public static SQLiteConnection Formconn { get; set; }


    }

}



