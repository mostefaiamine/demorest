using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestREST
{
    public class EntityService : IEntityService
    {
        private static Entity[] _data = new Entity[]
            {
                new Entity
                {
                    Address="Hydra",
                    Name="Sonatrach",
                    Number ="001"
                },
            
                new Entity
                {
                    Address="Kouba",
                    Name="Air Algérie",
                    Number="002"
                },
                 new Entity
                {
                    Address="Djasr Constantine",
                    Name="Sonelgaz",
                    Number="003"
                }
            };

        public async Task<Entity[]> Find(string text)
        {
            await Task.Delay(200);
            return _data.Where(e => e.Name.ToLower().Contains(text.ToLower())).ToArray();
        }

        public async Task<Entity[]> GetEntities()
        {
            await Task.Delay(200);
            return _data;
        }
    }
}
