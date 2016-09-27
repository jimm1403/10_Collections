using System;


namespace _10_Collections
{
    internal class Stock : IAsset
    {
        private string _symbol;
        private double _pricePerShare;
        private double _numShares;

        public Stock()
        {

        }

        public Stock (string _name, double _price, double _shares)
        {
            _symbol = _name;
            _pricePerShare = _price;
            _numShares = _shares;
        }

        public double PricePerShare
        {
            get
            {
                return _pricePerShare;
            }
            internal set
            {
                _pricePerShare = value;
            }
        }

        public string Symbol
        {
            get
            {
                return _symbol;
            }
            internal set
            {
                _symbol = value;
            }
        }

        public double NumShares
        {
            get
            {
                return _numShares;
            }
            internal set
            {
                _numShares = value;
            }
        }

        public double GetValue()
        {
            
            return _pricePerShare * _numShares;
        }

        internal static double TotalValue(IAsset[] stocks)
        {
            double _totalValue = 0;

            for (int i = 0; i < stocks.Length; i++)
            {
                _totalValue += stocks[i].GetValue();
            }

            return _totalValue;
        }

        override public string  ToString()
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";

            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

            return "Stock[symbol=" + _symbol + ",pricePerShare=" + _pricePerShare + ",numShares=" + _numShares + "]";
        }

        public override bool Equals(object obj)
        {
            

            if (obj == null)
            {
                return false;
            }

            return this.ToString().Equals(obj.ToString());
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

    }
}