using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.builder
{
    public interface IEmployeeReportBuilder
    {
        IEmployeeReportBuilder BuildHeader();
        IEmployeeReportBuilder BuildBody();
        IEmployeeReportBuilder BuildFooter();

        EmployeeReport GetReport();
    }
}
