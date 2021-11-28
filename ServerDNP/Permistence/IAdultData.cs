using System.Collections.Generic;
using System.Threading.Tasks;
using Entities;


namespace ServerDNP.Permistence
{
    public interface IAdultData
    {
        
        Task DeleteAdult(int adultId);
        Task Add(Adult adult);
        
        Task<IList<Adult>> GetAdults();

       Adult Get(int id);
    }
}
