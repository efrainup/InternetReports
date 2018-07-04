using System;
using System.Collections.Generic;
using System.Text;

namespace Reports.DAL
{
    public interface IReportSource<T>
    {
        IEnumerable<T> GetReport();
    }
}
