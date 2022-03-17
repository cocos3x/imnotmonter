using UnityEngine;

namespace com.adjust.sdk
{
    public class AdjustEvent
    {
        // Fields
        internal string currency;
        internal string eventToken;
        internal string callbackId;
        internal string transactionId;
        internal System.Nullable<double> revenue;
        internal System.Collections.Generic.List<string> partnerList;
        internal System.Collections.Generic.List<string> callbackList;
        internal string receipt;
        internal bool isReceiptSet;
        
        // Methods
        public AdjustEvent(string eventToken)
        {
            string val_1 = eventToken;
            val_1 = new System.Object();
            this.eventToken = val_1;
            mem[1152921510374063556] = 0;
        }
        public void setRevenue(double amount, string currency)
        {
            string val_1;
            System.Nullable<System.Double> val_2 = new System.Nullable<System.Double>(value:  amount);
            this.currency = val_1;
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
        public void setTransactionId(string transactionId)
        {
            this.transactionId = transactionId;
        }
        public void setCallbackId(string callbackId)
        {
            this.callbackId = callbackId;
        }
        public void setReceipt(string receipt, string transactionId)
        {
            this.receipt = receipt;
            this.transactionId = transactionId;
            mem[1152921510374821572] = 1;
        }
    
    }

}
