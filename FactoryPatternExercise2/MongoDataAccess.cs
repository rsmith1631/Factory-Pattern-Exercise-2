﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class MongoDataAccess : IDataAccess
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product (){ Name = "Xbox", Price = 350},
            new Product (){ Name = "Guitar", Price = 1000},
            new Product (){ Name = "Blender", Price = 50},
            new Product (){ Name = "Kite", Price = 10},

        };
        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from a Mongo data access");
            return Products;
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data to a Mongo database");
        }
    
    }
}
