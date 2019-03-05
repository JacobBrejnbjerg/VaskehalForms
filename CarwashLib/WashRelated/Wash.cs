using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CarwashLib
{
    public abstract class Wash
    {
        #region Cryptography
        // Protected makes it safer, as only derived classes can see them.
        protected CancellationTokenSource cts;
        protected readonly byte[] CollectPassword;
        protected readonly byte[] salt;
        protected readonly int amountOfRepitions = 5;
        #endregion


        // Wash specific information
        public int Id { get; set; }
        public Car Car { get; set; }
        public event Action<Wash> OnFihish;
        public event Action<Wash> OnProgressChange;
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

        public Wash(string collectPassword)
        {
            cts = new CancellationTokenSource();
            salt = Hash.GenerateSalt();
            CollectPassword = Hash.HashPasswordWithSalt(collectPassword, salt, amountOfRepitions);
        }

        public virtual Car Collect(string password)
        {
            if (Hash.HashPasswordWithSalt(password, salt, amountOfRepitions).SequenceEqual(CollectPassword))
            {
                Car.CarStatus = CarStatus.Collected;
                return Car;
            }

            return null;
        }

        public virtual void Cancel()
        {
            cts.Cancel();
        }

        protected void InvokeOnFinish(Wash wash)
        {
            OnFihish?.Invoke(wash);
        }

        protected void InvokeOnProgressChange(Wash wash)
        {
            OnProgressChange?.Invoke(wash);
        }

        public virtual void StartAsync()
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
                                InvokeOnFinish(this);
                            }

                            Thread.Sleep(250);
                        }
                    }
                }
            }).Start();
        }
    }
}
