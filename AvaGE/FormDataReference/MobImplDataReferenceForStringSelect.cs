using System;
using System.Collections.Generic;
using System.Text;

using AvaExt.AndroidEnv.ControlsBase;
using AvaGE.FormDataReference.UserForm;
using AvaExt.DataRefernce;
using AvaExt.Common;

namespace AvaGE.FormDataReference
{
    public class MobImplDataReferenceForStringSelect: MobImplDataReferenceForValueSelect  
    {

        public MobImplDataReferenceForStringSelect(string pCmd)
            : base(pCmd)
        {
 
        }

        protected override Type getActivityType()
        {
            return typeof(MobDataReferenceStringSelectForm);
        }
      
    }
}
