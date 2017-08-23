using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testPerhitunganPajak.DataAccessLayer
{
    class GetData
    {
        public static C_Employee GetEmployee(string number)
        {
            APMDatabaseEntities databaseEntities = new APMDatabaseEntities();
            var res = from a in databaseEntities.C_Employee
                      where a.Number == number
                      select a;
            return res.First();
        }
        public static List<SalaryEmployeePayment> GetListSalaryEmployeePayment(Guid employeeId, string year)
        {
            APMDatabaseEntities databaseEntities = new APMDatabaseEntities();
            var res = from a in databaseEntities.SalaryEmployeePayments
                      where a.EmployeeId == employeeId && a.TaxType != 1 && a.Period.Substring(0, 4) == year
                      select a;
            List<SalaryEmployeePayment> list = res.ToList();
            return list;
        }
        public static List<SalaryEmployeePayment> GetListPrevPeriodSalaryEmployeePayment(Guid employeeId, string year, string period)
        {
            APMDatabaseEntities databaseEntities = new APMDatabaseEntities();
            var res = from a in databaseEntities.SalaryEmployeePayments
                      where a.EmployeeId == employeeId && a.TaxType != 1 && a.Period.Substring(0, 4) == year && a.Period.CompareTo(period)<0
                      select a;
            List<SalaryEmployeePayment> list = res.ToList();
            return list;
        }
    }
}
