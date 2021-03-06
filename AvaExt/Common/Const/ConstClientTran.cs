using System;
using System.Collections.Generic;
using System.Text;

namespace AvaExt.Common.Const
{
    public enum ConstClientTran
    {
        clientToCash = 1,
        clientFromCash = 2,
        //3- (03) Borç Dekontu, 
        //4- (04) Alacak Dekontu,
        //5- (05) Virman İşlemi, 
        //6- (06) Kur Farkı İşlemi, 
        //12- (12) Özel İşlem,
        //14- (14) Açılış İşlemi, 
        //20- (20) Gelen Havaleler,
        //21- (21) Gönderilen Havale	ler,
        //31- (31) Mal Alım Faturası, 
        retailSalesReturnInvoice = 32,
        wholeSaleReturnInvoice = 33,
        //34- (34) Alınan Hizmet Faturası, 
        //35- (35) Alınan Proforma Fatura,
        //36- (36) Alım İade Faturası,
        retailSalesInvoice = 37,
        wholeSaleInvoice = 38
        //39- (39) Verilen Hizmet Faturası, 
        //40- (40) Verilen Proforma Fatura, 
        //41- (41) Verilen Vade Farkı Faturası,
        //42- (42) Alınan Vade Farkı Faturası, 
        //43- (43) Alınan Fiyat Farkı Faturası,
        //44- (44) Verilen Fiyat Farkı Faturası, 
        //56- (56) Müstahsil Makbu	zu,
        //61- (61) Çek Girişi, 
        //62- (62) Senet Girişi,
        //63- (63) Çek Çıkış (Cari Hesaba), 
        //64- (64) Senet Çıkış (Cari Hesaba)


    }
}
