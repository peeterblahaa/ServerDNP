using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServerDNP.Models;

namespace ServerDNP.Permistence
{
    public class AdultData : IAdultData
    {

        private FileContext fileContext;

        public AdultData()
        {
            fileContext = new FileContext();
        }

        public async Task<Adult> Add(Adult adult)
        {
            await Task.Run(() =>
            {
                int max = fileContext.Adults.Max(adult => adult.Id);
                adult.Id = ++max;
                fileContext.Adults.Add(adult);
                fileContext.SaveChanges();
            });

            return adult;
        }

        public async Task<IList<Adult>> GetAdults()
        {
            return fileContext.Adults;
        }

        public async Task RemoveAdult(Adult adult)
        {
            await Task.Run(() => fileContext.Adults.Remove(adult));
            fileContext.SaveChanges();
        }

        
        

        public Adult Get(int id)
        {
            return fileContext.Adults.FirstOrDefault(a => a.Id == id);
        }
    }
}
