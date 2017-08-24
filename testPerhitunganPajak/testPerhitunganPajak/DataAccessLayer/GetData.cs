using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testPerhitunganPajak.BusinessDataLayer;

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
        public static SalaryEmployeePayment GetSalaryEmployeePayment(Guid employeeId, string period, PajakTypeData.TaxType taxType)
        {
            APMDatabaseEntities databaseEntities = new APMDatabaseEntities();
            var res = from a in databaseEntities.SalaryEmployeePayments
                      where a.EmployeeId == employeeId && a.TaxType == (int) taxType && a.Period==period
                      select a;
            
            return res.First();
        }
        public static List<SalaryEmployeePayment> GetListSalaryEmployeePayment(Guid employeeId, string year,PajakTypeData.TaxType taxType)
        {
            APMDatabaseEntities databaseEntities = new APMDatabaseEntities();
            var res = from a in databaseEntities.SalaryEmployeePayments
                      where a.EmployeeId == employeeId && a.TaxType == (int) taxType && a.Period.Substring(0, 4) == year
                      select a;
            List<SalaryEmployeePayment> list = res.ToList();
            return list;
        }
        public static List<SalaryEmployeePayment> GetListPrevPeriodSalaryEmployeePayment(Guid employeeId, string year, string period, PajakTypeData.TaxType taxType)
        {
            APMDatabaseEntities databaseEntities = new APMDatabaseEntities();
            var res = from a in databaseEntities.SalaryEmployeePayments
                      where a.EmployeeId == employeeId && a.TaxType == (int) taxType && a.Period.Substring(0, 4) == year && a.Period.CompareTo(period) < 0
                      orderby a.LineNumber ascending
                      select a;
            List<SalaryEmployeePayment> list = res.ToList();

            List<SalaryEmployeePayment> list2 = new List<SalaryEmployeePayment>();
            int cari = 0;
            SalaryEmployeePayment s = list.LastOrDefault(x => x.EmployeeCondition == 3);
            cari = list.LastIndexOf(s);
            list2 = list.GetRange(cari + 1, list.Count - cari - 1);
            return list2;
        }
    }
}
