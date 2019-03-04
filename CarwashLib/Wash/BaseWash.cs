using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CarwashLib.Wash
{
    public abstract class BaseWash
    {
        protected CancellationTokenSource cts;
        protected readonly byte[] CollectPassword;
        protected readonly byte[] salt;
        protected readonly int amountOfRepitions = 5;

        public BaseWash(string collectPassword)
        {
            cts = new CancellationTokenSource();
            salt = Hash.GenerateSalt();
            CollectPassword = Hash.HashPasswordWithSalt(collectPassword, salt, amountOfRepitions);
        }
    }
}
