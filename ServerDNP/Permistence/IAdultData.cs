using System.Collections.Generic;
using System.Threading.Tasks;
using Entities;


namespace ServerDNP.Permistence
{
    public interface IAdultData
    {
        
        Task DeleteAdult(int adultId);
        Task<Adult> Add(Adult adult);
        
        Task<IList<Adult>> GetAdults();

       Adult Get(int id);
    }
}
