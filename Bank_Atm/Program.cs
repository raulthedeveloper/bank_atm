using System;
using Bank_Atm.View;
using System.Threading;


namespace Bank_Atm
{
    class Program
    {
        static void Main(string[] args)
        {

            // Creates database connection
            //CreateDatabase connect = new CreateDatabase();
            //connect.DataBaseConnect();

            

            DisplayMainMenu menu = new DisplayMainMenu();

            menu.StartScreen();


        }
    }
}
