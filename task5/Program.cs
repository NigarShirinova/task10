﻿
using System;
using System.Net.Mail;
using task5;
namespace Lesson
{
    public static class Program
    {

        public static void Main(string[] args)
        {
            Invoice inv = new Invoice(678904, "Alex", "Foxtrot");
            inv.Article = "USB-hab";
            inv.Quantity = 6;
            inv.Price = 30;
            Console.WriteLine( inv.CostCalculation(true));
        }


    }
}