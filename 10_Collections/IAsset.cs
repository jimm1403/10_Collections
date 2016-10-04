using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Collections
{
    public interface IAsset
    {
        string Symbol { get; }
        int Id { get; }
        double GetValue();
         
    }
}
