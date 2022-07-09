using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace matuhaMagasin
{
    internal class dataBase
    {
        public static string Host = "localhost";
        public static string User = "postgres";
        public static string DBname = "matuhaMagasin";
        public static string Password = "123";
        public static string Port = "5432";

        public static string connString =
            String.Format("Server={0};Username={1};Database={2};Port={3};Password={4};SSLMode=Prefer",
            Host,
            User,
            DBname,
            Port,
            Password);

        // **** Select **** // 

        public static List<suppliers> dbGetListSuppliers()
        {
            List<suppliers> suppliersList = new List<suppliers>();
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                using (var command = new NpgsqlCommand("SELECT * FROM suppliers", conn))
                {
                    var reader = command.ExecuteReader();
                    while (reader.Read()) { suppliersList.Add(new suppliers(reader.GetInt32(0).ToString(), reader.GetString(1))); }
                    reader.Close();
                }
                conn.Close();
            }
            return suppliersList;
        }
        public static List<products> dbGetListProducts()
        {
            List<products> productsList = new List<products>();
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                using (var command = new NpgsqlCommand("SELECT * FROM products", conn))
                {
                    var reader = command.ExecuteReader();
                    while (reader.Read()) { productsList.Add(new products(reader.GetInt32(0).ToString(), reader.GetString(1), reader.GetInt32(2), reader.GetDouble(3))); }
                    reader.Close();
                }
                conn.Close();
            }
            return productsList;
        }
        public static List<supplies> dbGetListSupplies()
        {
            List<supplies> suppliesList = new List<supplies>();
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                using (var command = new NpgsqlCommand("SELECT * FROM supplies", conn))
                {
                    var reader = command.ExecuteReader();
                    while (reader.Read()) { suppliesList.Add(new supplies(reader.GetInt32(0).ToString(), reader.GetInt32(1).ToString(), reader.GetInt32(2).ToString(), reader.GetInt32(3), reader.GetDouble(4), reader.GetDateTime(5))); }
                    reader.Close();
                }
                conn.Close();
            }
            return suppliesList;
        }
        public static List<payments> dbGetListPayments()
        {
            List<payments> paymentsList = new List<payments>();
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                using (var command = new NpgsqlCommand("SELECT * FROM payments", conn))
                {
                    var reader = command.ExecuteReader();
                    while (reader.Read()) { paymentsList.Add(new payments(reader.GetInt32(0).ToString(), reader.GetInt32(1).ToString(), reader.GetDouble(2), reader.GetDateTime(3))); }
                    reader.Close();
                }
                conn.Close();
            }
            return paymentsList;
        }

        // **** Insert **** //

        public static void dbInsertProducts(string name, int amount, double price)
        {
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                using (var command = new NpgsqlCommand("INSERT INTO products (name, amount, price) " +
                    "VALUES ('" + name + "', " + amount + ", " + price + ")", conn))
                {
                    command.ExecuteReader();
                }
                conn.Close();
            }
        }
        public static void dbInsertSuppliers(string name)
        {
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                using (var command = new NpgsqlCommand("INSERT INTO suppliers (name) " +
                    "VALUES ('" + name + "')", conn))
                {
                    command.ExecuteReader();
                }
                conn.Close();
            }
        }
        public static void dbInsertSupplies(string id_suppliers, string id_product, int amount, double total_price, string date)
        {
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                using (var command = new NpgsqlCommand("INSERT INTO supplies (id_suppliers, id_product, amount, total_price, date) " +
                    "VALUES (" + id_suppliers + ", " + id_product + ", " + amount + ", " + total_price + ", '" + date + "')", conn))
                {
                    command.ExecuteReader();
                }
                conn.Close();
            }
        }
        public static void dbInsertPayments(string id_supplies, double paid, string date)
        {
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                using (var command = new NpgsqlCommand("INSERT INTO payments (id_supplies, paid, date) " +
                    "VALUES (" + id_supplies + ", " +  paid + ", '" + date + "')", conn))
                {
                    command.ExecuteReader();
                }
                conn.Close();
            }
        }

        // **** Update **** //

        public static void dbUpdateProducts(string id, string name, int amount, double price)
        {
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                using (var command = new NpgsqlCommand("UPDATE products " +
                                                        "SET name = '" + name + "', amount =  " + amount + ", price = " + price + " " + 
                                                        "WHERE id = " + id, conn))
                {
                    command.ExecuteReader();
                }
                conn.Close();
            }
        }
        public static void dbUpdateSupplies(string id, string id_suppliers, string id_product, int amount, double total_price, string date)
        {
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                using (var command = new NpgsqlCommand("UPDATE supplies " +
                                                        "SET id_suppliers = " + id_suppliers + ", id_product =  " + id_product + ", amount = " + amount + ", total_price = " + total_price + ", date = '" + date + "' " + 
                                                        "WHERE id = " + id, conn))
                {
                    command.ExecuteReader();
                }
                conn.Close();
            }
        }
        public static void dbUpdateSuppliers(string id, string name)
        {
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                using (var command = new NpgsqlCommand("UPDATE suppliers " +
                                                        "SET name = '" + name + "' " +
                                                        "WHERE id = " + id, conn))
                {
                    command.ExecuteReader();
                }
                conn.Close();
            }
        }
        public static void dbUpdatePayments(string id, string id_supplies, double paid, string date)
        {
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                using (var command = new NpgsqlCommand("UPDATE payments " +
                                                        "SET id_supplies = " + id_supplies + ", paid =  " + paid + ", date = '" + date + "' " +
                                                        "WHERE id = " + id, conn))
                {
                    command.ExecuteReader();
                }
                conn.Close();
            }
        }

        // **** Delete **** //

        public static void dbDeleteSupplies(string id)
        {
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                using (var command = new NpgsqlCommand("DELETE FROM supplies " +
                                                        "WHERE id = " + id, conn))
                {
                    command.ExecuteReader();
                }
                conn.Close();
            }
        }
        public static void dbDeleteSuppliers(string id)
        {
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                using (var command = new NpgsqlCommand("DELETE FROM suppliers " +
                                                        "WHERE id = " + id, conn))
                {
                    command.ExecuteReader();
                }
                conn.Close();
            }
        }
        public static void dbDeletePayments(string id)
        {
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                using (var command = new NpgsqlCommand("DELETE FROM payments " +
                                                        "WHERE id = " + id, conn))
                {
                    command.ExecuteReader();
                }
                conn.Close();
            }
        }
        public static void dbDeleteProducts(string id)
        {
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                using (var command = new NpgsqlCommand("DELETE FROM products " +
                                                        "WHERE id = " + id, conn))
                {
                    command.ExecuteReader();
                }
                conn.Close();
            }
        }

        // **** Report **** //
        
        public static List<report> dbGetReport(List<string> productsID, DateTime dateFrom, DateTime dateTo)
        {
            List<report> preReport = new List<report>();
            List<report> Report = new List<report>();
            using (var conn = new NpgsqlConnection(connString))
            {
                foreach (var product in productsID)
                {
                    conn.Open();
                    using (var command = new NpgsqlCommand("SELECT suppliers.name, products.name, supplies.total_price, supplies.id, supplies.date " +
                                                       "FROM suppliers, supplies, products " +
                                                       "WHERE supplies.id_product = " + product + " " +
                                                       "AND supplies.id_product = products.id " +
                                                       "AND supplies.id_suppliers = suppliers.id " +
                                                       "AND DATE(supplies.date) > '" + dateFrom.Year + "-" + dateFrom.Month + "-" + dateFrom.Day + "' " +
                                                       "AND DATE(supplies.date) < '" + dateTo.Year + "-" + dateTo.Month + "-" + dateTo.Day + "'", conn))
                    {
                        var reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            preReport.Add(new report(reader.GetString(0), reader.GetString(1), reader.GetDouble(2), reader.GetInt32(3).ToString(), reader.GetDateTime(4)));
                        }
                        reader.Close();
                    }
                    conn.Close();
                }
            }

            
            using (var conn = new NpgsqlConnection(connString))
            {
                double sumPaid = 0;
                foreach (var someShit in preReport)
                {
                    conn.Open();
                    using (var command = new NpgsqlCommand("SELECT * " +
                                                       "FROM payments " +
                                                       "WHERE id_supplies = " + someShit.id_supplies + " " +
                                                       "AND DATE(payments.date) > '" + dateFrom.Year + "-" + dateFrom.Month + "-" + dateFrom.Day + "' " +
                                                       "AND DATE(payments.date) < '" + dateTo.Year + "-" + dateTo.Month + "-" + dateTo.Day + "'", conn))
                    {
                        List<payments> Payments = new List<payments>();
                        var reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            Payments.Add(new payments(reader.GetInt32(0).ToString(), reader.GetInt32(1).ToString(), reader.GetDouble(2), reader.GetDateTime(3)));
                        }
                        reader.Close();
                        sumPaid = 0;
                        // т.к. у нас все данные по оплате для одной поставки, то можно так 
                        foreach (var payment in Payments)
                            sumPaid += payment.paid;
                    }
                    conn.Close();
                    Report.Add(new report(someShit.supplierName, someShit.productName, someShit.orderPrice, sumPaid, someShit.orderPrice - sumPaid));
                }
            }

            return Report;
        }
    }
}
