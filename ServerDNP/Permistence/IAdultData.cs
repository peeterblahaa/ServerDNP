using System.Collections.Generic;
using System.Threading.Tasks;
using ServerDNP.Models;

namespace ServerDNP.Permistence
{
    public interface IAdultData
    {
        
        Task RemoveAdult(Adult adult);
        Task<Adult> Add(Adult adult);
        
        Task<IList<Adult>> GetAdults();
        Task UpdateAdult(Adult adult);

        Adult Get(int id);
    }
}
