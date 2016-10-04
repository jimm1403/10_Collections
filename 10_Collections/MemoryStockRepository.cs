using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace _10_Collections
{
    public class MemoryStockRepository : IStockRepository
    {
        private long id;
        private List<IAsset> assets;
        public MemoryStockRepository()
        {
            assets = new List<IAsset>();
            id = 0;
        }

        public long NextId()
        {
            id++;
            return id;
        }

        public void SaveStock(IAsset _iAsset)
        {
            assets.Add(_iAsset);
        }

        public Stock LoadStock(long id)
        {
            foreach (var item in assets)
            {
                if (item.Id == id)
                {
                    return (Stock)item;
                }
            }
            return null;
        }

        public List<IAsset> FindAllStocks()
        {
            return assets;
        }

        public void Clear()
        {
            assets.Clear();
        }


    }
}
