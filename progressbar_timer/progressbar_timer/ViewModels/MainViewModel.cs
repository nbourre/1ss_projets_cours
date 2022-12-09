using progressbar_timer.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows.Input;
using System.Windows.Threading;

namespace progressbar_timer.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        #region Propriétés

        private string currentTime;
        public DispatcherTimer timer;

        private int currentProgress;

        public int CurrentProgress
        {
            get { return currentProgress; }
            private set
            {
                if (currentProgress != value)
                {
                    currentProgress = value;
                    OnPropertyChanged();
                }
            }
        }

        public int MaxProgress => 60;

        public string CurrentTime
        {
            get { return currentTime; }
            set { 
                if (currentTime == value)
                    return;
                
                currentTime = value;
                OnPropertyChanged();
            }
        }


        #endregion

        public MainViewModel()
        {
            timer = new DispatcherTimer(DispatcherPriority.Render);
            timer.Interval =TimeSpan.FromSeconds(1);
            timer.Tick += (sender, args) =>
            {
                CurrentTime = DateTime.Now.ToLongTimeString();
                CurrentProgress = DateTime.Now.Second % 60;
            };
            timer.Start();

        }

    }
}