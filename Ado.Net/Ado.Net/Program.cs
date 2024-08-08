using System.Data;
using System.Data.SqlClient;

namespace Ado.Net
{
    internal class Program
    {
        private static readonly string connectionString = "Server=DESKTOP-NIJAT;Database=C#06;Integrated Security = true";
        private static readonly SqlConnection connection = new(connectionString);

        static void Main(string[] args)
        {


            //try
            //{
            //    #region SQLCommand 

            //    //string query = "Update Region " +
            //    //               "Set RegionDescription = 'Kuba' " +
            //    //               "Where RegionId = 5";

            //    //var cmd = new SqlCommand(query, connection);

            //    //connection.Open();

            //    //cmd.ExecuteNonQuery();

            //    //connection.Close();
            //    #endregion

            //    #region SQLDataReader

            //    //string query = "Select * from Region";

            //    //var reader = new SqlCommand(query,connection);

            //    //connection.Open();

            //    //var dataReader = reader.ExecuteReader();

            //    //while (dataReader.Read())
            //    //{
            //    //    Console.WriteLine($"RegionId:{dataReader[0]} RegionDesc:{dataReader[1]}");
            //    //}

            //    //connection.Close();

            //    #endregion

            //    #region DataAdapter -DataTable

            //    //string query = "Select * from Region";

            //    //var adapter = new SqlDataAdapter(query, connection);

            //    //var regions = new DataTable();

            //    //adapter.Fill(regions);

            //    //foreach (DataRow row in regions.Rows)
            //    //{
            //    //    Console.WriteLine($"RegionId:{row["RegionId"]}  RegionDescr:{row[1]}");
            //    //}

            //    #endregion

            //    #region DataSet

            //    //string query1 = "Select * from Products";
            //    //string query2 = "Select * from Categories";
            //    //var adapter = new SqlDataAdapter(query1, connection);

            //    //var set = new DataSet();

            //    //adapter.Fill(set, "Products");

            //    //adapter.SelectCommand.CommandText = query2;

            //    //adapter.Fill(set, "Categories");


            //    //foreach (DataTable table in set.Tables)
            //    //{
            //    //    Console.WriteLine(table.TableName +"`s data:");
            //    //    foreach (DataRow row in table.Rows) 
            //    //    {
            //    //        Console.WriteLine($"ID:{row[0]}   Name:{row[1]}");
            //    //    }
            //    //}

            //    #endregion

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}


            string menu = "1.Group Add\n" +
                          "2.Group Update\n" +
                          "3.Group Remove\n" +
                          "4.Group Get\n" +
                          "5.Group GetAll\n" +
                          "0.Exit";

            bool isContinue = true;

            while (isContinue)
            {
                Console.WriteLine(menu);
                Console.Write("Enter operation number:");
                int.TryParse(Console.ReadLine(), out int opeId);
                switch (opeId)
                {
                    case 1:
                        AddGroup();
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        GetAllGroups();
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Enter valid operation number!!!");
                        break;
                }
            }



        }

        private static void AddGroup()
        {
            Console.Write("Enter group Name:");
            string? groupName = Console.ReadLine();

            Console.Write("Description:");
            string? description = Console.ReadLine();

            string query = "Insert into Groups " +
                           $"Values('{groupName}','{description}')";

            var cmd = new SqlCommand(query, connection);
            //Bu hisse extensiona cixacaq ve SqlConnection extensionu olacaq!
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        private static void GetAllGroups()
        {
            string query = "Select * from Groups";

            var cmd = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine($"Group Id:{reader[0]}  Group Name:{reader[1]}" +
                                  $" Group Desc:{reader[2]}");
            }
            connection.Close();

        }
    }
}
