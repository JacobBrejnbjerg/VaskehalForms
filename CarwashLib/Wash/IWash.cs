using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarwashLib
{
    interface IWash<T>
    {
        Task<T> StartAsync();
        event Action<int> OnFihish;
    }
}
