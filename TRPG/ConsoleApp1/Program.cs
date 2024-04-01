using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args) //Main 은 제일 먼저 실행되는 코드 방
        {
            Player player = new Player();
            Monster monster1 = new Monster();

            player.AddAt(10);
            //Player at;
            player.Fight(monster1.at);

            Console.WriteLine(monster1.at);
            Console.WriteLine(player.at);

            //player.Addat(10);

            //player.at += 10;
            Console.ReadLine();

        }
}
    
}
