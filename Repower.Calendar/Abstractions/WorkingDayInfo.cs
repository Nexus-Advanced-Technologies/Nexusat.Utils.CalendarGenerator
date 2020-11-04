﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Repower.Calendar
{
    public class WorkingDayInfo : IWorkingDayInfo
    {
        public bool IsWorkingDay { get; set; }

        public string Description { get; set; }

        public IList<TimePeriod> WorkingPeriods { get; set; }
    }
}