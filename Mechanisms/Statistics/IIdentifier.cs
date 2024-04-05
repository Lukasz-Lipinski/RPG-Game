using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myRPG.Dtos.Schemas
{
    public interface IIdentifier
    {
        public Guid Id { get; set; }
    }
}
