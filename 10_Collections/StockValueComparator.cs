using System;
using System.Collections.Generic;

namespace _10_Collections
{
    internal class StockValueComparator : IComparer<IAsset>
    {
        public int Compare(IAsset assetNo1, IAsset assetNo2)
        {
            return assetNo2.GetValue().CompareTo(assetNo1.GetValue());
        }
    }
}