using System;
using System.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;

/* Validation for Insert and select query
   Author : V SHALINI
   Date :20-8-2021
*/
namespace Atomation_Database
{
    [TestClass]
    public class UnitTest1
    {
        SqlConnection conn = new SqlConnection();
        
        
        [TestMethod]
        public void RetrieveDataFromDB()
        {
            conn.ConnectionString = @"server=DESKTOP-TKJCNNQ;Database=Automation_Database;Trusted_Connection=True";
            string query = @"select * from ColumnName";
            SqlCommand selectCommand = new SqlCommand(query, conn);
            SqlDataReader reader;
            conn.Open();
            reader = selectCommand.ExecuteReader();
            Assert.AreEqual(8, reader.VisibleFieldCount);





        }

        [TestMethod]
        public void TestMethod1()
        {
            conn.ConnectionString = @"server=DESKTOP-TKJCNNQ;Database=Automation_Database;Trusted_Connection=True";
            conn.Open();

            SqlCommand insertCommand3 = new SqlCommand("INSERT INTO ColumnName(FirstColumn,SecondColumn,ThirdColumn,FourthColumn)VALUES(@0,@1,@2,@3)", conn);
            insertCommand3.Parameters.Add(new SqlParameter("0" ,"8"));
            insertCommand3.Parameters.Add(new SqlParameter("1", "AfterNoon"));
            insertCommand3.Parameters.Add(new SqlParameter("2", DateTime.Now));
            insertCommand3.Parameters.Add(new SqlParameter("3","3" ));


            int rows = insertCommand3.ExecuteNonQuery();
            Assert.AreEqual(1, rows);
            



            



        }
    }
}
