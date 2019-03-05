using CarwashLib.Wash;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CarwashLib
{
    class BasicWash : BaseWash, IWash
    {
        public int Id { get; set; }
        public Car Car { get; set; }
        private int _progress = 0;
        public int Progress
        {
            get => _progress;
            set
            {
                _progress = value;
                OnProgressChange?.Invoke(this);
            }
        }
        public event Action<IWash> OnFihish;
        public event Action<IWash> OnProgressChange;

        public BasicWash(Car car, string collectPassword) : base(collectPassword)
        {
            Car = car;
        }

        public Car Collect(string password)
        {
            if (Hash.HashPasswordWithSalt(password, salt, amountOfRepitions).SequenceEqual(CollectPassword))
            {
                Car.CarStatus = CarStatus.Collected;
                return Car;
            }

            return null;
        }

        public void StartAsync()
        {
            new Thread(() =>
            {
                CancellationToken cancelToken = cts.Token;

                if (Car != null)
                {
                    if (Car.CarStatus != CarStatus.Finished)
                    {
                        for (; this.Progress < 100; this.Progress++)
                        {
                            if (cancelToken.IsCancellationRequested)
                            {
                                // Fjerner bilen fra oversigten. Den er også collected-ish på en måde.
                                Car.CarStatus = CarStatus.Collected;
                                break;
                            }

                            if (this.Progress < 25)
                            {
                                Car.CarStatus = CarStatus.Preparing;
                            }
                            else if (this.Progress < 50)
                            {
                                Car.CarStatus = CarStatus.Washing;
                            }
                            else if (this.Progress < 75)
                            {
                                Car.CarStatus = CarStatus.Drying;
                            }
                            else if (this.Progress == 99)
                            {
                                Car.CarStatus = CarStatus.Finished;
                                OnFihish?.Invoke(this);
                            }

                            Thread.Sleep(250);
                        }
                    }
                }
            }).Start();
        }

        public void Cancel()
        {
            cts.Cancel();
        }
    }
}
