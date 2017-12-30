using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    static class DataBaseAccess
    {

        private static SqlConnection getConnection()
        {
            String connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mitch\documents\visual studio 2017\Projects\WindowsFormsApp1\WindowsFormsApp1\Customers.mdf;Integrated Security = True";
            SqlConnection conn = new SqlConnection(connString);
            return conn;

        }
        public static Customer getCustomer(String Id)
        {


            string customerInfo = "SELECT * FROM Customers WHERE CustomerId =" + Id;

            try
            {
                SqlConnection conn = getConnection();
                conn.Open();
                SqlCommand comm = new SqlCommand(customerInfo, conn);
                SqlDataReader reader = comm.ExecuteReader();
                if (reader.HasRows)
                {
                    List<String> values = new List<String>();
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {

                            values.Add(reader[i].ToString());
                        }

                    }
                    Customer newCustomer = new Customer(Convert.ToInt32(values[0]), values[1], values[2], values[3], values[4], Convert.ToInt32(values[5]));
                    reader.Close();
                    conn.Close();

                    return newCustomer;
                }
                else {

                    String message = "No Customer exists with that login";
                    String header = "Invalid Log In";
                    MessageBoxButtons button = MessageBoxButtons.OK;
                    MessageBox.Show(message, header, button);
                    return null;
                }

                
            }
            catch 
            {
               

                throw new Exception();
               
            }

        }

        public static Item getItem(String Id)
        {


            string ItemInfo = "SELECT * FROM AvailableItems WHERE ItemId = " + Id;

            try
            {
                SqlConnection conn = getConnection();
                conn.Open();
                SqlCommand comm = new SqlCommand(ItemInfo, conn);
                SqlDataReader reader = comm.ExecuteReader();
                if (reader.HasRows)
                {
                    List<String> values = new List<String>();

                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {


                            values.Add(reader[i].ToString());

                        }


                    }
                    Item newItem = new Item(Convert.ToInt32(values[0]), values[1], Convert.ToInt32(values[2]));
                    reader.Close();
                    conn.Close();
                    return newItem;
                }
                else {
                    String message = "No Item exists with that code";
                    String header = "Invalid Item";
                    MessageBoxButtons button = MessageBoxButtons.OK;
                    MessageBox.Show(message, header, button);
                    return null;

                }
               
            }
            catch (SqlException ex)
            {


                Console.Write("Problem parsing customer");
                throw ex;
            }

        }

        public static void updateCustomer(Customer currentCustomer)
        {



            string CustomerUpdate = "UPDATE Customers SET ItemsBought = " + currentCustomer.getCustomerTotalItems() + "WHERE CustomerId = " + currentCustomer.getId();

            try
            {
                SqlConnection conn = getConnection();
                conn.Open();
                SqlCommand comm = new SqlCommand(CustomerUpdate, conn);
                comm.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
