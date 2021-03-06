using System;
using System.Collections.Generic;
using System.Text;

namespace AvaExt.Database.GL
{
    public enum ConstCardGlRelationType: short
    {

        // material and fixed asset 
        m_purchaseAccount = 1,
        m_otherInput = 2,
        m_saleAccount = 3,
        m_otherOutput = 4,
        m_usage = 5,
        m_scrap = 6,
        m_inputFromProduction = 7,
        m_userDefindeInput = 8,
        m_userDefinedOutput = 9,
        m_purchaseReturn = 10,
        m_saleReturn = 11,
        m_purchaseDiscount = 12,
        m_saleDiscount = 13,
        m_purchaseSurcharge = 14,
        m_saleSurcharge = 15,
        m_purchasePromotion = 16,
        m_salePromotion = 17,
        m_promotionVatExpenses = 18,
        m_cycleCountExcess = 95,
        m_cycleCountDeficit = 96,
        m_costOfGoodSales = 99,
        m_additionalTax = 135,
        m_priceDiffReceived = 136,
        m_priceDiffIssued = 137,
        m_iternationalSales = 143,
        // fixed asset
        m_fa_profitOrLossOnSales = 19,
        m_fa_depreciationAndDeplationPortions = 20,
        m_fa_revaluations = 21,
        m_fa_defferedVAT = 22,
        m_fa_accumulatedDepreciations = 23,
        m_fa_fixedAssetExpenses = 24,
        m_fa_profitOrLossOnSalesAlternative = 145,
        m_fa_depreciationAndDeplationPortionsAlternative = 146,
        m_fa_revaluationsAlternative = 147,
        m_fa_accumulatedDepreciationsAlternative = 148,
        m_fa_fixedAssetExpensesAlternative = 149,
        m_fa_defferedVATAlternative = 150,
        // service purchase and sale 
        s_services = 1,
        s_serviceDiscounts = 2,
        s_serviceSurcharges = 3,
        s_servicePromotions = 4,
        s_serviceReturns = 5,
        // client
        cl_client = 1,
        // bank
        b_bank1 = 1,
        b_bank2 = 2,
        b_bank3 = 3,
        b_bank4 = 4,
        b_bank7 = 7,
        // cash
        csh_cash = 1,
        csh_cashExpenses = 2 

    }
}
