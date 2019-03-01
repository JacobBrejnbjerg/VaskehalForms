﻿using CarwashLib;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    public class CarwashRepository
    {
        private static List<Carwash> Carwashes = new List<Carwash>();

        public static List<Carwash> GetCarwashes()
        {
            return Carwashes;
        }

        public static Carwash GetCarwash(int id)
        {
            return Carwashes.Find(v => v.Id == id);
        }

        public static Carwash NewCarwash(string name)
        {
            if (Carwashes.Any(c => c.Name == name))
            {
                return null;
            }

            int id = 0;

            if (Carwashes.Count > 0)
            {
                id = Carwashes.Max(v => v.Id);
            }

            Carwash carwash = new Carwash()
            {
                Id = id,
                Name = name
            };

            Carwashes.Add(carwash);
            return carwash;
        }

        public static bool DeleteCarwash(string name)
        {
            return Carwashes.RemoveAll(c => c.Name == name) > 0;
        }
    }
}
