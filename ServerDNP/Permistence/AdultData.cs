using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using ServerDNP.DataAcces;
using ServerDNP.Models;

namespace ServerDNP.Permistence
{
    public class AdultData : IAdultData
    {
        private DbCntxt dbCntxt;
        public async Task<Adult> Add(Adult adult)
        {
            using DbCntxt dbCntxt = new DbCntxt();
            EntityEntry<Adult> adultAdded = await dbCntxt.Adults.AddAsync(adult);
            await dbCntxt.SaveChangesAsync();
            return adultAdded.Entity;
        }

        public async Task<IList<Adult>> GetAdults()
        {
            using DbCntxt dbCntxt = new DbCntxt();
            return await dbCntxt.Adults.ToListAsync();
        }
        
        public async Task DeleteAdult(int adultId)
        {
            using DbCntxt dbCntxt = new DbCntxt();
            Adult toDelete = await dbCntxt.Adults.FirstOrDefaultAsync(t => t.Id == adultId);
            if (toDelete != null)
            {
                dbCntxt.Adults.Remove(toDelete);
                await dbCntxt.SaveChangesAsync();
            }
        }
        public Adult Get(int id)
        {
            using DbCntxt dbCntxt = new DbCntxt();
            return dbCntxt.Adults.FirstOrDefault(a => a.Id == id);
        }
    }
}
/*
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
*/