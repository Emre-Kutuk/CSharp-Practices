﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myprogram = new Program();
            myprogram.Start();
        }

        void Start()
        {
            BookStore Broese = new BookStore();

            Broese.Add(new Book("Dracula", "Bram Stoker", 15.00));
            Broese.Add(new Book("Joe Speedbot", "Tommy Wieringa", 12.50));
            Broese.Add(new Magazine("Time", "Friday", 3.90));
            Broese.Add(new Magazine("Donald Duck", "Thursday", 2.50));
            Broese.Add(new Book("The Hobbit", "J.R.R. Tolkien", 12.50));

            Broese.PrintEveryBookStoreItem();
            Console.WriteLine();
            Broese.PrintCompleteStock();
            Console.ReadKey();
        }
    }
}
