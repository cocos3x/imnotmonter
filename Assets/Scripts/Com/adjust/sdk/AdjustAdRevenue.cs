using UnityEngine;

namespace com.adjust.sdk
{
    public class AdjustAdRevenue
    {
        // Fields
        internal string source;
        internal System.Nullable<double> revenue;
        internal string currency;
        internal System.Nullable<int> adImpressionsCount;
        internal string adRevenueNetwork;
        internal string adRevenueUnit;
        internal string adRevenuePlacement;
        internal System.Collections.Generic.List<string> partnerList;
        internal System.Collections.Generic.List<string> callbackList;
        
        // Methods
        public AdjustAdRevenue(string source)
        {
            string val_1 = source;
            val_1 = new System.Object();
            this.source = val_1;
        }
        public void setRevenue(double amount, string currency)
        {
            string val_1;
            System.Nullable<System.Double> val_2 = new System.Nullable<System.Double>(value:  amount);
            this.currency = val_1;
        }
        public void setAdImpressionsCount(int adImpressionsCount)
        {
            System.Nullable<System.Int32> val_1 = new System.Nullable<System.Int32>(value:  adImpressionsCount);
            this.adImpressionsCount = val_1.HasValue;
            mem[1152921510365260856] = 0;
        }
        public void setAdRevenueNetwork(string adRevenueNetwork)
        {
            this.adRevenueNetwork = adRevenueNetwork;
        }
        public void setAdRevenueUnit(string adRevenueUnit)
        {
            this.adRevenueUnit = adRevenueUnit;
        }
        public void setAdRevenuePlacement(string adRevenuePlacement)
        {
            this.adRevenuePlacement = adRevenuePlacement;
        }
        public void addCallbackParameter(string key, string value)
        {
            if(this.callbackList == 0)
            {
                    536878341 = new System.Collections.Generic.List<Page>();
                this.callbackList = 536878341;
            }
            
            0.Add(item:  key);
            this.callbackList.Add(item:  value);
        }
        public void addPartnerParameter(string key, string value)
        {
            if(this.partnerList == 0)
            {
                    536878341 = new System.Collections.Generic.List<Page>();
                this.partnerList = 536878341;
            }
            
            0.Add(item:  key);
            this.partnerList.Add(item:  value);
        }
    
    }

}
