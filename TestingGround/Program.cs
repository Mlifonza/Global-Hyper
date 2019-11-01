using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using UseDatabase;

namespace TestingGround
{
    class Program
    {
        static void Main(string[] args)
        {
            UseDatabase.UseDatabase useDbSql;
            try
            {
                TcpChannel channel = new TcpChannel();
                ChannelServices.RegisterChannel(channel, true);

                useDbSql = (UseDatabase.UseDatabase)Activator.GetObject(typeof(UseDatabase.UseDatabase), "tcp://localhost:720/GlobalHyper");

                //Console.WriteLine("Just write something");

                //useDbSql = new UseDatabase.UseDatabase();

                //useDbSql.ConnectToDB();

                //Console.WriteLine("This is the first line \n This is the second line\n\n");

                //DataTable dt;
                //dt = useDbSql.getProduct().Tables[0];

                //DataColumn[] cols = new DataColumn[1];
                //cols[0] = dt.Columns["name"];
                //dt.PrimaryKey = cols;

                //string expression;
                //expression = "name='bread'";
                //DataRow[] foundRows;
                //foundRows = dt.Select(expression);

                //Console.WriteLine(foundRows[0]["name"] + " " + foundRows[0]["price"]);

                //string randomNumber = Console.ReadLine();
                //var num = Decimal.Parse(randomNumber);
                //Console.WriteLine(decimal.Round(num, 2));

                //for (int i = 0; i < foundRows.Length; i++)
                //{
                //    Console.WriteLine("Old balance = {0}", foundRows[0]["balance"]);
                //    int updateBal = Convert.ToInt32(foundRows[0]["balance"]);
                //    updateBal += 4;
                //    foundRows[0]["balance"] = updateBal;
                //    foundRows[i]["loggedIn"] = "true";
                //    Console.WriteLine(foundRows[i]["name"]);
                //    Console.WriteLine(foundRows[i]["loggedIn"]);
                //    Console.WriteLine("Balance = {0}", foundRows[0]["balance"]);
                //}

                //DataRow search = dt.Rows.Find("madabbz");
                //object change = search;
                //search["name"] = "Fana";

                //if (change != null)
                //{
                //    Console.WriteLine(search["name"] + " " + search["surname"]);
                //    if (search["cashRecieved"] == (object) 0)
                //    {
                //        Console.WriteLine("It is 0");
                //    }
                //    else
                //    {
                //        Console.WriteLine("It's not zero");
                //    }
                //}
                //else
                //{
                //    Console.WriteLine("Name not found");
                //}

                int? number = 0;
                int total = (Int16) number + 9;
                Console.WriteLine("Total is " + total);


                useDbSql.DisconnectToDB();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.Read();
        }
    }
}

/*
 Things to complete
 * ----------------*
 * finish the items
 * finish the financial report
 */