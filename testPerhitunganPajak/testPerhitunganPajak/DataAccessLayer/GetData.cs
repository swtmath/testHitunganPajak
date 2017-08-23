using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testPerhitunganPajak.DataAccessLayer
{
    class GetData
    {
        C_Employee GetEmployee(string number)
        {
            APMDatabaseEntities databaseEntities = new APMDatabaseEntities();
            var res = from a in databaseEntities.C_Employee
                      where a.Number == number
                      select a;
            return res.First();
        }
        List<SalaryEmployeePayment> GetListSalaryEmployeePayment(Guid employeeid,string year)
        {
            APMDatabaseEntities databaseEntities = new APMDatabaseEntities();
            var res = from a in databaseEntities.SalaryEmployeePayments
                      where a.EmployeeId == employeeid && a.TaxType != 1 && a.Period.Substring(0, 4) == year
                      select a;
            List<SalaryEmployeePayment> list = res.ToList();
            return list;
        }
    }
}
