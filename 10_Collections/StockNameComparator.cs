using System.Globalization;
using System.Collections.Generic;
using System;

namespace _10_Collections
{
    public class StockNameComparator : IComparer<IAsset>
    {
        
        public int Compare(IAsset assetNo1, IAsset assetNo2)
        {
            return assetNo1.Symbol.CompareTo(assetNo2.Symbol); 
          
          
        }
    }
}