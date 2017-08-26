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
			string period = "201703";
			TaxCalculationMethod taxCalculationMethod = TaxCalculationMethod.WeightedAverage;
			TaxType taxType = TaxType.TaxEmp;
			decimal brutoPrev, brutoPrevBonus, brutoCurrent,jhtPrev,jhtCurrent,jpPrev,jpCurrent,pensionPrev,pensionCurrent;
			PajakTypeData.EmployeeCondition employeeCondition;
			int periodStart, periodEnd, periodCurent;
            bool fMarried = false,fNPWP= true;
            int tanggungan = 0;
            decimal begSalaryNetto, begSalaryPPh21;
            decimal brutoYearly, jhtYearly, jpYearly, pensionYearly, biayaJabatan, nettoYearly, PTKP, PKP, PPh21Yearly, PPh21Monthly, sumPPh21Prev, sumPPh21PrevBonus;

			List<SalaryEmployeePayment> listPrevPeriodSalaryEmployeePayment = GetData.GetListPrevPeriodSalaryEmployeePayment(employeeId, period.Substring(0, 4), period, taxType);
			SalaryEmployeePayment currentPeriodSalaryEmployeePayment = GetData.GetSalaryEmployeePayment(employeeId, period, taxType);

            begSalaryNetto = PajakData.GetBegSalaryNetto(currentPeriodSalaryEmployeePayment);
            begSalaryPPh21 = PajakData.GetBegSalaryPPh21(currentPeriodSalaryEmployeePayment);

			brutoPrev = PajakData.CountBrutoListPayment(listPrevPeriodSalaryEmployeePayment);
			brutoPrevBonus = PajakData.CountBrutoBonusListPayment(listPrevPeriodSalaryEmployeePayment);
			brutoCurrent = PajakData.CountBruto(currentPeriodSalaryEmployeePayment);

			jhtPrev = PajakData.CountJHTListPayment(listPrevPeriodSalaryEmployeePayment);
			jhtCurrent = PajakData.CountJHT(currentPeriodSalaryEmployeePayment);

			jpPrev = PajakData.CountJPListPayment(listPrevPeriodSalaryEmployeePayment);
			jpCurrent = PajakData.CountJP(currentPeriodSalaryEmployeePayment);

			pensionPrev = PajakData.CountPensionListPayment(listPrevPeriodSalaryEmployeePayment);
			pensionCurrent = PajakData.CountPension(currentPeriodSalaryEmployeePayment);

			employeeCondition = PajakData.GetEmployeeCondition(currentPeriodSalaryEmployeePayment);

            periodCurent = PajakData.GetCurrentPeriod(currentPeriodSalaryEmployeePayment);
            periodStart = PajakData.GetFirstPeriod(listPrevPeriodSalaryEmployeePayment);
            periodEnd = PajakData.GetEndPeriod(employeeCondition, periodCurent);

            brutoYearly = PajakCalculation.CalculateBrutoYearly(taxCalculationMethod, brutoCurrent, brutoPrev, brutoPrevBonus, periodStart, periodEnd, periodCurent, employeeCondition);
            jhtYearly = PajakCalculation.CalculateBpjsOrPensionYearly(taxCalculationMethod, jhtCurrent, jhtPrev, periodStart, periodEnd, periodCurent, employeeCondition);
            jpYearly = PajakCalculation.CalculateBpjsOrPensionYearly(taxCalculationMethod, jpCurrent, jpPrev, periodStart, periodEnd, periodCurent, employeeCondition);
            pensionYearly = PajakCalculation.CalculateBpjsOrPensionYearly(taxCalculationMethod, pensionCurrent, pensionPrev, periodStart, periodEnd, periodCurent, employeeCondition);
            biayaJabatan = PajakCalculation.CalculateBiayaJabatan(brutoYearly, periodStart, periodEnd,employeeCondition);

            nettoYearly = PajakCalculation.CalculateNettoYearly(brutoYearly, jhtYearly, jpYearly, pensionYearly, biayaJabatan, begSalaryNetto);
            PTKP = PajakCalculation.CalculatePTKP(fMarried, tanggungan);
            PKP = PajakCalculation.CalculatePKP(nettoYearly, PTKP);
            PPh21Yearly = PajakCalculation.CalculateTaxYearly(PKP, fNPWP);
            sumPPh21Prev = PajakData.CountPPh21ListPayment(listPrevPeriodSalaryEmployeePayment);
            sumPPh21PrevBonus = PajakData.CountPPh21BonusListPayment(listPrevPeriodSalaryEmployeePayment);
            PPh21Monthly = PajakCalculation.CalculateTaxMonthly(PPh21Yearly, sumPPh21Prev, sumPPh21PrevBonus, periodStart, periodEnd, periodCurent, begSalaryPPh21, taxCalculationMethod, employeeCondition);
            decimal pph21 = PajakData.CountPPh21(currentPeriodSalaryEmployeePayment);
            label1.Text = PPh21Monthly.ToString("#,0.00");
            label2.Text = pph21.ToString("#,0.00");
            //PPh21Monthly=PajakCalculation.CalculateTaxMonthly(PPh21Yearly,)
            //PPh21Yearly=PajakCalculation.CalculateTaxYearly(PKP,)
            //decimal brutoYearly =PajakCalculation.CalculateBrutoYearly(taxCalculationMethod,brutoCurrent,brutoPrev,brutoPrevBonus)

            //Pajak.CalculateBrutoYearly(employeeId, taxCalculationMethod, brutoCurrent, brutoPrev, brutoPrevBonus, 1, 12, int.Parse(period.Substring(4, 2)));
            //bool fNPWP = true;
            //decimal brutoCurrent = 0,jhtCurrent=0,jpCurrent=0;
            //decimal brutoPrev = 19235360,jht;
            //decimal a = 762036872;
            //decimal b = Pajak.CalculatePKP(a, Pajak.CalculatePTKP(false, 0));
            //decimal c = Pajak.CalculateTaxYearly(b,false);
            //label1.Text = c.ToString("#,0.00");
        }
    }
}
