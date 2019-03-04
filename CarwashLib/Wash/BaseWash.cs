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

        public BaseWash(string collectPassword)
        {
            salt = Hash.GenerateSalt();
            CollectPassword = Hash.HashPasswordWithSalt(collectPassword, salt);
        }
    }
}
