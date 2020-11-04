using System;
using System.Collections.Generic;
using System.Text;

namespace Cooperchip.ITDeveloper.Domain.Entities
{
    public class EntityBase
    {
        public EntityBase()
        {
            this.Id = Guid.NewGuid();//Gera o Guid aleatório
        }

        public Guid Id { get; set; }
    }
}
