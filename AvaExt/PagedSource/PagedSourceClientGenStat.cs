using System;
using System.Collections.Generic;
using System.Text;
using AvaExt.Common;
using AvaExt.SQL.Dynamic;

namespace AvaExt.PagedSource
{
    public class PagedSourceClientGenStat : ImplPagedSource
    {
        public PagedSourceClientGenStat(IEnvironment pEnv)
            : base(pEnv, new SqlBuilderClientGenStat(pEnv))
        {
          
        }
    }
}
