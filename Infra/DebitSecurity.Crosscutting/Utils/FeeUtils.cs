using System;

namespace DebitSecurity.Crosscutting.Utils
{
    public class FeeUtils
    {
        private double _MonthlyToDailyConversionTax = 1/30;
        private double _DailyToMonthConversionTax = 30;
        private double _YearlyToMonthlyConversionTax = 1/12;
        private double _MonthlyToYearlyConversionTax = 12;

        public double ConvertMonthlyToDaily(double fee) {
            return Convert(fee, _MonthlyToDailyConversionTax);
        }

        public double ConvertMonthlyToYearly(double fee) {
            return Convert(fee, _MonthlyToYearlyConversionTax);
        }

        public double ConvertYearlyToMonthly(double fee) {
            return Convert(fee, _YearlyToMonthlyConversionTax);
        }
        
        public double ConvertDailyToMonthly(double fee) {
            return Convert(fee, _DailyToMonthConversionTax);
        }

        private double Convert(double fee, double conversionTax) {
            return Math.Pow(1 + fee/100, conversionTax) - 1;
        }

        public double CalculateSingleInterestDiff(double installmentValue, double monthlyFee) {
            return (installmentValue * monthlyFee) - installmentValue;
        }

        public double CalculateInterestDiff(double installmentValue, double dailyFee, double daysOverDue) {
            return (installmentValue * Math.Pow(1 + dailyFee, daysOverDue)) - installmentValue;
        }
    }
}