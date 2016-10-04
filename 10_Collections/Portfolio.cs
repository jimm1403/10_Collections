using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace _10_Collections
{
    public class Portfolio 
    {
        //Fields
        private List<IAsset> assetList = new List<IAsset>();
        //Constructors
        public Portfolio(List<IAsset> _assetList)
        {
            this.assetList = _assetList;
        }
        public Portfolio()
        {

        }
        //Methods
        public double GetTotalValue()
        {
            double totalvalue = 0;
            for (int i = 0; i < assetList.Count; i++)
            {
                totalvalue += assetList[i].GetValue();
            }

            return totalvalue;
        }

        public void AddAsset(IAsset _asset)
        {
            this.assetList.Add(_asset);
        }

        public IList<IAsset> GetAssets()
        {
            IReadOnlyList<IAsset> roc = new ReadOnlyCollection<IAsset>(assetList);
            return (IList<IAsset>)roc;
        }

        public IAsset GetAssetByName(string name)
        {
            foreach (IAsset asset in assetList)
            {
                if (asset.Symbol == name)
                {
                    return asset;
                }
            }
            return null;
        }

        public IList<IAsset> GetAssetsSortedByName()
        {
            IComparer<IAsset> com = new StockNameComparator();
            assetList.Sort(com);
            return assetList; 
        }

        public IList<IAsset> GetAssetsSortedByValue()
        {
            IComparer<IAsset> com = new StockValueComparator();
            assetList.Sort(com);
            return assetList;
        }
     }
}