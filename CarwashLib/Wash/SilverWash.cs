﻿using CarwashLib.Wash;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CarwashLib
{
    class SilverWash : IWash
    {
        public int Id { get; set; }
        public Car Car { get; set; }
        public int Progress { get; set; }
        public string CollectPassword { get; set; }
        CancellationTokenSource cts;

        public event Action<IWash> OnFihish;

        public Car Collect(string password)
        {
            if (password == CollectPassword)
            {
                Car.CarStatus = CarStatus.Collected;
                return Car;
            }

            return null;
        }

        public Task StartAsync()
        {
            return Task.Run(() =>
            {
                CancellationToken cancelToken = cts.Token;

                if (Car.CarStatus != CarStatus.Finished)
                {
                    for (; this.Progress < 100; this.Progress++)
                    {
                        if (cancelToken.IsCancellationRequested)
                            break;

                        if (this.Progress < 15)
                        {
                            Car.CarStatus = CarStatus.Preparing;
                        }
                        else if (this.Progress < 40)
                        {
                            Car.CarStatus = CarStatus.Soaping;
                        }
                        else if (this.Progress < 65)
                        {
                            Car.CarStatus = CarStatus.Washing;
                        }
                        else if (this.Progress < 90)
                        {
                            Car.CarStatus = CarStatus.Drying;
                        }
                        else if (this.Progress == 100)
                        {
                            Car.CarStatus = CarStatus.Finished;
                            OnFihish?.Invoke(this);
                        }

                        Thread.Sleep(500);
                    }
                }

                return this;
            });
        }

        public void Cancel()
        {
            cts.Cancel();
        }
    }
}
