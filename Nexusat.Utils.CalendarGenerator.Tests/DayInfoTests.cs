using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Nexusat.Utils.CalendarGenerator.Tests
{
    [TestClass]
    public class DayInfoTests
    {
        [TestMethod]
        public void DefaultCtor()
        {
            var di = new DayInfo();

            Assert.IsFalse(di.IsWorkingDay);
            Assert.IsNull(di.Description);
            Assert.IsNull(di.WorkingPeriods);
        }

        [TestMethod]
        public void OnlyDescription()
        {
            var desc = "description";
            var di = new DayInfo(desc);

            Assert.IsFalse(di.IsWorkingDay);
            Assert.AreEqual(desc, di.Description);
            Assert.IsNull(di.WorkingPeriods);
        }

        [TestMethod]
        public void EmptyWorkingPeriods()
        {
            // ReSharper disable once CollectionNeverUpdated.Local
            var wps = new List<TimePeriod>();
            var di = new DayInfo(workingPeriods: wps);

            Assert.IsFalse(di.IsWorkingDay);
            Assert.IsNull(di.Description);
            Assert.IsNull(di.WorkingPeriods);
        }

        [TestMethod]
        public void NonEmptyWorkingPeriods()
        {
            // ReSharper disable once CollectionNeverUpdated.Local
            var wps = new List<TimePeriod>
            {
                new TimePeriod()
            };
            var di = new DayInfo(workingPeriods: wps);

            Assert.IsTrue(di.IsWorkingDay);
            Assert.IsNull(di.Description);
            Assert.IsNotNull(di.WorkingPeriods);
        }
    }
}