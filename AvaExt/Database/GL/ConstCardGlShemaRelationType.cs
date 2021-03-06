using System;
using System.Collections.Generic;
using System.Text;

namespace AvaExt.Database.GL
{
    public enum ConstCardGlShemaRelationType
    {

        ////Materials
        //glPurchaseGLCodes = 0, //PurchaseGLCodes
        //glOther_inputGLcodes = 0, //Other_inputGLcodes
        //glSalesGLcodes = 0, //SalesGLcodes
        //glOther_outputGLcodes = 0, //Other_outputGLcodes
        //glUsageGLcodes = 0, //UsageGLcodes
        //glScrapGLcodes = 0, //ScrapGLcodes
        //glInput_from_productionGLcodes = 0, //Input_from_productionGLcodes
        //glUser_defined_input_slips = 0, //User_defined_input_slips
        //glUser_defined_output_slips = 0, //User_defined_output_slips
        //glPurchase_discountsGLcodes = 0, //Purchase_discountsGLcodes
        //glSales_discountsGLcodes = 0, //Sales_discountsGLcodes
        //glPurchase_surch_GLcodes = 0, //Purchase_surch.GLcodes
        //glSales_surchargesGLcodes = 0, //Sales_surchargesGLcodes
        //glPromotions_received = 0, //Promotions_received
        //glPromotions_issued = 0, //Promotions_issued
        //glPromotion_VAT_account_of_expense = 0, //Promotion_VAT_account_of_expense
        //glPurchase_returnGLcodes = 0, //Purchase_returnGLcodes
        //glSales_returnGLcodes = 0, //Sales_returnGLcodes
        //glCycle_Count_E_GLCodes = 0, //Cycle_Count_(+)GLCodes
        //glCycle_Count_D_GLCodes = 0, //Cycle_Count_(-)GLCodes
        //glCost_Of_Good_SalesGLCodes = 0, //Cost_Of_Good_SalesGLCodes
        //glPrice_DifferenceGLCodes = 0, //Price_DifferenceGLCodes
        //glQuantity_DifferenceGLCodes = 0, //Quantity_DifferenceGLCodes
        //glTransferGLCodes = 0, //TransferGLCodes
        //glPrice_Diff_Invoice_ReceivedGLCodes = 0, //Price_Diff._Invoice_(Received)GLCodes
        //glPrice_Diff_Invoice_IssuedGLCodes = 0, //Price_Diff._Invoice_(Issued)GLCodes
        ////Services
        //glServices_purchased = 0, //Services_purchased
        //glService_purchased_discounts = 0, //Service_purchased_discounts
        //glService_purchased_surcharges = 0, //Service_purchased_surcharges
        //glService_purchased_promotions = 0, //Service_purchased_promotions
        //glService_purchased_returns = 0, //Service_purchased_returns
        //glServices_sold = 0, //Services_sold
        //glService_sales_discounts = 0, //Service_sales_discounts
        //glService_sales_surcharge = 0, //Service_sales_surcharge
        //glService_sales_promotions = 0, //Service_sales_promotions
        //glService_sales_returns = 0, //Service_sales_returns
        //glBanks = 0, //Banks
        //glAccounts_receivable_and_payable = 0, //Accounts_receivable_&_payable
        //glBank_current_accounts = 0, //Bank_current_accounts
        //glCollection_p_notes = 0, //Collection_p.notes
        //glClearing_checks = 0, //Clearing_checks
        //glChecks_issued = 0, //Checks_issued
        //glCollateral_p_notes = 0, //Collateral_p.notes
        //glCollateral_checks = 0, //Collateral_checks
        //glLoan_against_p_note = 0, //Loan_against_p.note
        //glLoan_against_check = 0, //Loan_against_check
        //glSafe_deposits = 0, //Safe_deposits
        //glSales_VATGLcodes = 0, //Sales_VATGLcodes
        //glPurchase_VATGLcodes = 0, //Purchase_VATGLcodes
        //glSales_VATGLcodes = 0, //Sales_VATGLcodes
        //glPurchase_return_VATGLcodes = 0, //Purchase_return_VATGLcodes
        //glSales_return_VATGLcodes = 0, //Sales_return_VATGLcodes
        //glPurchase_deduction_VAT_code = 0, //Purchase_deduction_VAT_code
        //glPayment_deduction_VAT_code = 0, //Payment_deduction_VAT_code
        //glEU_Purchase_VATGLCodes = 0, //EU_Purchase_VATGLCodes
        //glEU_Sales_VATGLCodes = 0, //EU_Sales_VATGLCodes
        //glProducerGLcodes = 0, //ProducerGLcodes
        //glStoppageGLcodes = 0, //StoppageGLcodes
        //glSSDFGLcodes = 0, //SSDFGLcodes
        //glStock_marketGLcodes = 0, //Stock_marketGLcodes
        //glCommissionGLCodes = 0, //CommissionGLCodes
        //glCommission_VATGLcodes = 0, //Commission_VATGLcodes
        //glBag_KurGLcodes = 0, //Bag-KurGLcodes
        //glAdd_1GLConnections = 0, //Add.1GLConnections
        //glAdd_2GLConnections = 0, //Add.2GLConnections
        //glCheck_p_note_transactions = 0, //Check/p._note_transactions
        //glChecks_on_hand = 0, //Checks_on_hand
        //glChecks_issued = 0, //Checks_issued
        //glP_notes_on_hand = 0, //P.notes_on_hand
        //glDebit_p_notes = 0, //Debit_p.notes
        //glBounced_p_notes = 0, //Bounced_p.notes
        //glNSF_checks = 0, //NSF_checks
        //glProvision_expenses = 0, //Provision_expenses
        //glBounce_expenses = 0, //Bounce_expenses
        //glCash_collection_and_payment_cash = 0, //Cash_collection_&_payment_cash
        //glDue_date_diff_issued = 0, //Due_date_diff._issued
        //glDue_date_diff_received = 0, //Due_date_diff._received
        //glBottom_surchargesGLcodes = 0, //Bottom_surchargesGLcodes
        //glPersonnelGLcodes = 0, //PersonnelGLcodes
        //glFixed_assetGLcodes = 0, //Fixed_assetGLcodes
        //glProfit_Loss_on_sales = 0, //Profit/Loss_on_sales
        //glDepreciation_and_Depletion_Portions = 0, //Depreciation_and_Depletion_Portions
        //glRevaluations = 0, //Revaluations
        //glDeferred_VAT = 0, //Deferred_VAT
        //glAccumulated_depreciation = 0, //Accumulated_depreciation
        //glFixed_asset_expenses = 0, //Fixed_asset_expenses
        //glWork_Stations = 0, //Work_Stations
        //glTime_DifferenceGLCodes = 0, //Time_DifferenceGLCodes
        //glFee_DifferenceGLCodes = 0, //Fee_DifferenceGLCodes
        //glTransferGLCodes = 0, //TransferGLCodes
        //glTime_DifferenceGLCodes = 0, //Time_DifferenceGLCodes
        //glTime_DifferenceGLCodes = 0, //Time_DifferenceGLCodes
        //glFee_DifferenceGLCodes = 0, //Fee_DifferenceGLCodes
        //glTransferGLCodes = 0, //TransferGLCodes
        //glCapacity_DifferenceGLCodes = 0, //Capacity_DifferenceGLCodes
        //glCapacity_DifferenceGLCodes = 0, //Capacity_DifferenceGLCodes
        //glBudget_DifferenceGLCodes = 0, //Budget_DifferenceGLCodes
        //glEfficiency_DifferenceGLCodes = 0, //Efficiency_DifferenceGLCodes
        //glTransferGLCodes = 0, //TransferGLCodes
        //glDiscounts_on_Payments = 0, //Discounts_on_Payments
        //glExch_Rate_Diff_Account = 0, //Exch._Rate_Diff._Account
        //glExch_Rate_Diff_Account_Receivable = 0, //Exch._Rate_Diff._Account_(Receivable)
        //glGL_Account_To_Be_Out_Of_Track = 0, //G/L_Account_To_Be_Out_Of_Track
        //glAdditional_TaxGLCodes = 0, //Additional_TaxGLCodes
        //glSales_Additional_TaxGLCodes = 0, //Sales_Additional_TaxGLCodes
        //glSales_Return_Additional_TaxGLCodes = 0, //Sales_Return_Additional_TaxGLCodes
        //glUsage_Additional_TaxGLCodes = 0, //Usage_Additional_TaxGLCodes
        //glScrap_Additional_TaxGLCodes = 0, //Scrap_Additional_TaxGLCodes
        //glAdditional_TaxGLCodes_Will_Be_Reduced = 0, //Additional_TaxGLCodes_(Will_Be_Reduced)
        //glUser_Defined_Output_Slips = 0, //User_Defined_Output_Slips
        //glOther_Additional_Tax_Account = 0, //Other_Additional_Tax_Account
        //glBank_Employee_TransactionsGLCodes = 0//Bank_Employee_TransactionsGLCodes_
    }

}
