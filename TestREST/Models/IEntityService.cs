using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestREST
{
    public interface IEntityService
    {
        Task<Entity[]> Find(string text);

        Task<Entity[]> GetEntities();
    }
}
