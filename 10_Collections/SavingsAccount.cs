using System;
using _09_Portfolio;

namespace _10_Collections
{
    internal class SavingsAccount : IAsset
    {
        private double _inRate;
        private string accountName;
        private double value;
        

        public SavingsAccount(string _accountName, double _value, double _interest)
        {
            accountName = _accountName;
            value = _value;
            _inRate = _interest;
        }

        public double InterestRate
        {
            get
            {
                return _inRate;
            }
            internal set
            {
                _inRate = value;
            }
        }

        public override string ToString()
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";

            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

            return "SavingsAccount[value=" + GetValue().ToString(".0") + ",interestRate=" + _inRate + "]";
        }
        
        public double GetValue()
        {
            return value;
        }

        internal void ApplyInterest()
        {
            value +=  _inRate * value / 100;
        }
        
    }
}