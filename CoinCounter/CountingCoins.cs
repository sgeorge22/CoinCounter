using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinCounter
{
    public class CountingCoins
    {
        public void GenerateCoinCounter()
        {
            //ask the user to input a number
            Console.WriteLine("Welcome to Coin Counter! \n");
            Console.WriteLine("Please enter a number to be used as a cent value: ");
            string userValue = Console.ReadLine();

            //convert user string to double
            double userValueNumber = Convert.ToDouble(userValue);

            //assign values to coin type variables
            double quaterValue = 25;
            double dimeValue = 10;
            double nickleValue = 5;

            double quaterCoin = Math.Floor(userValueNumber / quaterValue);
        }
    }
}
