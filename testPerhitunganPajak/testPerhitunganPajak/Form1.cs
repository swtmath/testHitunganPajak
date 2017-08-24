using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testPerhitunganPajak.BusinessDataLayer;
using testPerhitunganPajak.DataAccessLayer;
using static testPerhitunganPajak.BusinessDataLayer.PajakTypeData;

namespace testPerhitunganPajak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Guid employeeId = GetData.GetEmployee("14 2421").Id;
            string period = "201704";
            TaxCalculationMethod taxCalculationMethod = TaxCalculationMethod.WeightedAverage;
            TaxType taxType = TaxType.TaxEmp;
            decimal brutoPrev,brutoPrevBonus, brutoCurrent;
            brutoPrev = Pajak.CountBrutoListPayment(GetData.GetListPrevPeriodSalaryEmployeePayment(employeeId, period.Substring(0, 4), period, taxType));
            brutoPrevBonus = Pajak.CountBrutoBonusListPayment(GetData.GetListPrevPeriodSalaryEmployeePayment(employeeId, period.Substring(0, 4), period, taxType));
            brutoCurrent = Pajak.CountBruto(GetData.GetSalaryEmployeePayment(employeeId, period, taxType));

            Pajak.CalculateBrutoYearly(employeeId, taxCalculationMethod, brutoCurrent, brutoPrev, brutoPrevBonus, 1, 12, int.Parse(period.Substring(4, 2)));
        }
    }
}
