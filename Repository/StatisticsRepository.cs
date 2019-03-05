using CarwashLib;
using CarwashLib.Cryptography;

using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class StatisticsRepository
    {
        public static byte[] GetStatistics(byte[] key, byte[] iv, int carwashId)
        {
            AesEncryption aes = new AesEncryption();
            Statistics statistics = new Statistics();
            Carwash carwash = CarwashRepository.GetCarwash(carwashId);
            statistics.TotalWashes = carwash.Washes.Count;

            foreach (Wash wash in carwash.Washes)
            {
                if (wash is BasicWash)
                    statistics.BasicWashes++;
                if (wash is SilverWash)
                    statistics.SilverWashes++;
                if (wash is GoldWash)
                    statistics.GoldWashes++;
            }

            string json = JsonHelper.SerializeJson<Statistics>(statistics);
            return aes.Encrypt(json, key, iv);
        }
    }
}
