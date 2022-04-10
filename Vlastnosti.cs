using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Raznice
{
    public static class Vlastnosti
    {
        //bool aEdit = false;

        public static bool allowEdit;
        public static bool exit;
        public static string logText;

        public static string logToText 
        {
            get { return logText; }
            set { value = logText; }
        }

        /*
        {
            get { }
            set { };
        }
        */ 
    }

    /*
    class Counter
    {
        private int threshold;
        private int total;

        public Counter(int passedThreshold)
        {
            threshold = passedThreshold;
        }

        public void Add(int x)
        {
            total += x;
            if (total >= threshold)
            {
                OnThresholdReached(EventArgs.Empty);
                
            }
        }

        protected virtual void OnThresholdReached(EventArgs e)
        {
            EventHandler handler = ThresholdReached;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        public event EventHandler ThresholdReached;
    }   
    */
}
