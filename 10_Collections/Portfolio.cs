using System;
using System.Collections.Generic;

namespace _10_Collections
{
    internal class Portfolio
    {
        private List<IAsset> stocks;

        public Portfolio(List<IAsset> stocks)
        {
            this.stocks = stocks;
        }

        public Portfolio()
        {

        }

        internal double GetTotalValue()
        {
            double _totalValue = 0;

            for (int i = 0; i < stocks.Count; i++)
            {
                _totalValue += stocks[i].GetValue();
            }

            return _totalValue;
        }

        internal void AddAsset(Stock stock)
        {
            stocks.Add(stock);
        }

        

        
    }
}