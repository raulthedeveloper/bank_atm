using System;
using Bank_Atm.Database;


namespace Bank_Atm
{
    class Program
    {
        static void Main(string[] args)
        {

            // Creates database connection
            CreateDatabase connect = new CreateDatabase();
            connect.DataBaseConnect();


        }
    }
}
