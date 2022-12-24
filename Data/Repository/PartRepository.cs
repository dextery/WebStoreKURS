using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStoreKURS.Data.Interfaces;
using WebStoreKURS.Data.Models;

namespace WebStoreKURS.Data.Repository
{
    public class PartRepository : IAllParts
    {
        private readonly AppDBContent appDBContent;

        public PartRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Parts> AllParts => appDBContent.Part.Include(c => c.Category);

        public IEnumerable<Parts> FavParts => appDBContent.Part.Where(p => p.isFavourite).Include(c => c.Category);

        public Parts getObjectPart(int partID) => appDBContent.Part.FirstOrDefault(p => p.id == partID);
    }
}
