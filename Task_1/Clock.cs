﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Clock
    {
        int hour;
        int minute;
        int second;

        public  int Hour
        {
            get
            {
                return hour;
            }
            set
            {
                    hour = value % 24;
            }
        }
        public int Minute
        {
            get
            {
                return minute;
            }
            set
            {
                Hour += value/60;
                minute = value % 60;
            }
        }
        public int Second
        {
            get
            {
                return second;
            }
            set
            {
                Minute = value /60;
                second = value % 60;
            }
        }


        public Clock(int hour, int minute, int second)
        {
            this.Hour = hour;
            this.Minute = minute;
            this.Second = second;
        }

        public int ToSecond()
        {
            return second + minute * 60 + hour * 60 * 60;
        }
    }
}
