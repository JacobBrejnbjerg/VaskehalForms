﻿using CarwashLib;
using CarwashLib.Wash;
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
            return Carwashes.Find(c => c.Id == id);
        }

        public static Carwash GetCarwashByName(string name)
        {
            return Carwashes.Find(c => c.Name == name);
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
                id = Carwashes.Max(c => c.Id) + 1;
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

        public static void AddWash(int carwashId, IWash wash)
        {
            Carwash carwash = GetCarwash(carwashId);
            carwash.Washes.Add(wash);
        }
    }
}
