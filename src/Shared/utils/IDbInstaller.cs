using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Torneos.src.Shared.utils
{
    public interface IDbInstaller
    {
        void EnsureDatabaseExists();
    }
}