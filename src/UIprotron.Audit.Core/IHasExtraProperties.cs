using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIprotron.Audit.Core
{
    public interface IHasExtraProperties
    {
        ExtraPropertyDictionary ExtraProperties { get; }
    }
}
