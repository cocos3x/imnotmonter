using UnityEngine;

namespace com.adjust.sdk
{
    public class AdjustPlayStoreSubscription
    {
        // Fields
        internal string price;
        internal string currency;
        internal string sku;
        internal string orderId;
        internal string signature;
        internal string purchaseToken;
        internal string billingStore;
        internal string purchaseTime;
        internal System.Collections.Generic.List<string> partnerList;
        internal System.Collections.Generic.List<string> callbackList;
        
        // Methods
        public AdjustPlayStoreSubscription(string price, string currency, string sku, string orderId, string signature, string purchaseToken)
        {
            val_1 = new System.Object();
            this.price = price;
            this.currency = val_1;
            this.sku = sku;
            this.orderId = orderId;
            this.signature = signature;
            this.purchaseToken = purchaseToken;
        }
        public void setPurchaseTime(string purchaseTime)
        {
            this.purchaseTime = purchaseTime;
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
