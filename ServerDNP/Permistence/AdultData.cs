using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using ServerDNP.DataAcces;


namespace ServerDNP.Permistence
{
    public class AdultData : IAdultData
    {
        private DbCntxt dbcontext;

        public AdultData(DbCntxt context)
        {
            this.dbcontext = context;
        }
        public async Task<IList<Adult>> GetAdults()
        {
            return await dbcontext.Adults.Include(a => a.JobTitle).ToListAsync();
        }

        public async Task Add(Adult adult)
        {
            EntityEntry<Adult> newlyAdded = await dbcontext.Adults.AddAsync(adult);
            await dbcontext.SaveChangesAsync();
            
        }

        
        public async Task DeleteAdult(int adultId)
        {
            Adult toDelete = await dbcontext.Adults.FirstOrDefaultAsync(t => t.Id == adultId);
            if (toDelete != null)
            {
                dbcontext.Adults.Remove(toDelete);
                await dbcontext.SaveChangesAsync();
            }
        }

        public Adult Get(int id)
        {
            return dbcontext.Adults.FirstOrDefault(a => a.Id == id);
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