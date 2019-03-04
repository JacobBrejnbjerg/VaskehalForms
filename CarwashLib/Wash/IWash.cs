using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CarwashLib.Wash
{
    public interface IWash
    {
        int Id { get; set; }
        Car Car { get; set; }
        int Progress { get; set; }
        string CollectPassword { get; set; }
        event Action<IWash> OnFihish;

        Car Collect(string password);
        Task StartAsync();
        void Cancel();
    }
}
