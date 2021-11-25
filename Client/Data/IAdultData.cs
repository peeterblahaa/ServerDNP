using System.Collections.Generic;
using System.Threading.Tasks;
using Client.Models;

namespace Client.Data
{
    internal interface IAdultData
    {
        Task Add(Adult adult);
        Task<IList<Adult>> GetAdults();

        Task RemoveAdult(Adult adult);
    }
}