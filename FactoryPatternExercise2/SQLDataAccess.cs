﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class SQLDataAccess : IDataAccess
    {
        public void SaveData()
        {
            Console.WriteLine("I am saving data to a SQL database");
        }

        public static List<Product> Products = new List<Product>()
        {
            new Product (){ Name = "Xbox", Price = 350},
            new Product (){ Name = "Guitar", Price = 1000},
            new Product (){ Name = "Blender", Price = 50},
            new Product (){ Name = "Kite", Price = 10},

        };
        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from a SQL data access");
            return Products;
        }
    }
}
