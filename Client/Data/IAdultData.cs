using System.Collections.Generic;
using System.Threading.Tasks;
using Entities;


namespace Client.Data
{
    internal interface IAdultData
    {
        Task Add(Adult adult);
        Task<IList<Adult>> GetAdults();

        Task RemoveAdult(Adult adult);
    }
}