﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class UserData
{
    public static string ID;
    public static string UserName;
    public static float Gold;
    public static int Point;

    static UserData()
    {
        ID = "2024";
        UserName = "Hide on bush";
        Gold = 100.5f;
        Point = 100;
    }
    public static void ShowData()
    {
        Console.WriteLine("Id: " + ID);
        Console.WriteLine("UserName: " + UserName);
        Console.WriteLine("Health: " + Gold);
        Console.WriteLine("Point: " + Point);
        Console.ReadKey();

    }
    public class Program
    {
        static void Main(string[] args)
        {
            UserData.ShowData();
            return;
        }
    }
}