using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public interface IProductInventoryRepository
    {
        Dictionary<string, int> GetInventory();
        void UpdateInventory(string code);
    }
}
