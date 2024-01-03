using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeDesktop.Model
{
    internal interface IPayloadedModel<DS, Payload>
    {
        public Task<DS> TakeData(Payload payload);
    }
}
