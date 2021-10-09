using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AwarenessWebApp.Server
{
    public interface IAwarenessPlusService
    {
        public Task<string> GetUserAuthentication();
    }
}
