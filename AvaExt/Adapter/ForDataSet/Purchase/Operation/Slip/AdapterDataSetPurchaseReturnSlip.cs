using System;
using System.Collections.Generic;
using System.Text;
using AvaExt.Adapter.ForDataTable;
using AvaExt.Common;
using AvaExt.Adapter.Tools;
using System.Data;
using AvaExt.Manual.Table;
using AvaExt.Common.Const;

namespace AvaExt.Adapter.ForDataSet.Purchase.Operation.Slip
{
    public class AdapterDataSetPurchaseReturnSlip:AdapterDataSetSlip
    {

        public AdapterDataSetPurchaseReturnSlip(IEnvironment pEnv)
            :base(pEnv)
        {
            lineTrCode = docTrCode = (short)ConstDocTypeMaterial.purchaseReturn;
            lineGroupCode = docGroupCode = (short)ConstDocGroupCode.purchasing;
            lineIOCode = docIOCode = (short)ConstIOCode.output;



            docNumModule = (short)ConstDocNumModule.purchaseReceipts;
           docNumDocType = docTrCode;

         }
        
        
    }
}
