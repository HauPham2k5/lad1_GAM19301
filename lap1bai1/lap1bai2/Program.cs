using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public class Maps

{
    public string id;
    public string userName;
    public static string _inGame = "Lien Minh Huyen Thoai";


    public Maps(string id, string userName)
    {
        this.id = id;
        this.userName = userName;
    }

    public string ShowData()
    {
        return "ID: " + id + " |Name: " + userName + " |inGame: " + _inGame;
    }
    public class Program
    {
        public static int Main(string[] args)
        {
            Maps maps = new Maps("2024", "URF");
            Console.WriteLine(maps.ShowData());
            Console.ReadLine();
            return 0;
        }

    }
}