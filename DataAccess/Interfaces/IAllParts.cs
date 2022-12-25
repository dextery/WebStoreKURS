using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess.Interfaces
{
	public interface IAllParts
    {
        IEnumerable<Parts> AllParts { get; }
        IEnumerable<Parts> FavParts { get; }
        Parts getObjectPart(int partID);
    }
}
