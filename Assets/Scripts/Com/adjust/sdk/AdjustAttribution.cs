using UnityEngine;

namespace com.adjust.sdk
{
    public class AdjustAttribution
    {
        // Fields
        private string <adid>k__BackingField;
        private string <network>k__BackingField;
        private string <adgroup>k__BackingField;
        private string <campaign>k__BackingField;
        private string <creative>k__BackingField;
        private string <clickLabel>k__BackingField;
        private string <trackerName>k__BackingField;
        private string <trackerToken>k__BackingField;
        private string <costType>k__BackingField;
        private System.Nullable<double> <costAmount>k__BackingField;
        private string <costCurrency>k__BackingField;
        
        // Properties
        public string adid { get; set; }
        public string network { get; set; }
        public string adgroup { get; set; }
        public string campaign { get; set; }
        public string creative { get; set; }
        public string clickLabel { get; set; }
        public string trackerName { get; set; }
        public string trackerToken { get; set; }
        public string costType { get; set; }
        public System.Nullable<double> costAmount { get; set; }
        public string costCurrency { get; set; }
        
        // Methods
        public string get_adid()
        {
        
        }
        public void set_adid(string value)
        {
            this.<adid>k__BackingField = value;
        }
        public string get_network()
        {
        
        }
        public void set_network(string value)
        {
            this.<network>k__BackingField = value;
        }
        public string get_adgroup()
        {
        
        }
        public void set_adgroup(string value)
        {
            this.<adgroup>k__BackingField = value;
        }
        public string get_campaign()
        {
        
        }
        public void set_campaign(string value)
        {
            this.<campaign>k__BackingField = value;
        }
        public string get_creative()
        {
        
        }
        public void set_creative(string value)
        {
            this.<creative>k__BackingField = value;
        }
        public string get_clickLabel()
        {
        
        }
        public void set_clickLabel(string value)
        {
            this.<clickLabel>k__BackingField = value;
        }
        public string get_trackerName()
        {
        
        }
        public void set_trackerName(string value)
        {
            this.<trackerName>k__BackingField = value;
        }
        public string get_trackerToken()
        {
        
        }
        public void set_trackerToken(string value)
        {
            this.<trackerToken>k__BackingField = value;
        }
        public string get_costType()
        {
        
        }
        public void set_costType(string value)
        {
            this.<costType>k__BackingField = value;
        }
        public System.Nullable<double> get_costAmount()
        {
            var val_1 = R1 + 48;
            return (System.Nullable<System.Double>)this;
        }
        public void set_costAmount(System.Nullable<double> value)
        {
            this.<costAmount>k__BackingField = new System.Nullable<System.Double>();
            mem[1152921510368940356] = ???;
            mem[1152921510368940360] = ???;
            mem[1152921510368940364] = ???;
        }
        public string get_costCurrency()
        {
        
        }
        public void set_costCurrency(string value)
        {
            this.<costCurrency>k__BackingField = value;
        }
        public AdjustAttribution()
        {
        
        }
        public AdjustAttribution(string jsonString)
        {
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            val_17 = 22998894;
            com.adjust.sdk.JSONNode val_1 = com.adjust.sdk.JSON.Parse(aJSON:  jsonString);
            if((com.adjust.sdk.JSONNode.op_Equality(a:  jsonString, b:  0)) == true)
            {
                    return;
            }
            
            val_18 = 536883097;
            if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
            {
                    val_18 = 536883097;
            }
            
            string val_3 = com.adjust.sdk.AdjustUtils.GetJsonString(node:  jsonString, key:  mem[536883189] + 44);
            this.<trackerName>k__BackingField = jsonString;
            string val_4 = com.adjust.sdk.AdjustUtils.GetJsonString(node:  jsonString, key:  mem[536883189] + 48);
            mem[1152921510369408820] = jsonString;
            string val_5 = com.adjust.sdk.AdjustUtils.GetJsonString(node:  jsonString, key:  mem[536883189] + 8);
            mem[1152921510369408796] = jsonString;
            string val_6 = com.adjust.sdk.AdjustUtils.GetJsonString(node:  jsonString, key:  mem[536883189] + 16);
            mem[1152921510369408804] = jsonString;
            string val_7 = com.adjust.sdk.AdjustUtils.GetJsonString(node:  jsonString, key:  mem[536883189] + 12);
            mem[1152921510369408800] = jsonString;
            string val_8 = com.adjust.sdk.AdjustUtils.GetJsonString(node:  jsonString, key:  mem[536883189] + 20);
            mem[1152921510369408808] = jsonString;
            string val_9 = com.adjust.sdk.AdjustUtils.GetJsonString(node:  jsonString, key:  mem[536883189] + 40);
            mem[1152921510369408812] = jsonString;
            string val_10 = com.adjust.sdk.AdjustUtils.GetJsonString(node:  jsonString, key:  mem[536883189]);
            mem[1152921510369408792] = jsonString;
            string val_11 = com.adjust.sdk.AdjustUtils.GetJsonString(node:  jsonString, key:  mem[536883189] + 56);
            mem[1152921510369408824] = jsonString;
            val_19 = 536883097;
            if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
            {
                    val_19 = 536883097;
            }
            
            string val_12 = com.adjust.sdk.AdjustUtils.GetJsonString(node:  jsonString, key:  mem[536883189] + 60);
            System.Globalization.CultureInfo val_13 = System.Globalization.CultureInfo.InvariantCulture;
            System.Nullable<System.Double> val_15 = new System.Nullable<System.Double>(value:  System.Double.Parse(s:  jsonString, provider:  0));
            val_20 = 536883097;
            if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
            {
                    val_20 = 536883097;
            }
            
            string val_16 = com.adjust.sdk.AdjustUtils.GetJsonString(node:  jsonString, key:  mem[536883189] + 64);
            this.<costCurrency>k__BackingField = jsonString;
        }
        public AdjustAttribution(System.Collections.Generic.Dictionary<string, string> dicAttributionData)
        {
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            val_15 = 22998895;
            if(dicAttributionData == 0)
            {
                    return;
            }
            
            val_16 = 536883097;
            if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
            {
                    val_16 = 536883097;
            }
            
            string val_1 = com.adjust.sdk.AdjustUtils.TryGetValue(dictionary:  dicAttributionData, key:  mem[536883189] + 44);
            this.<trackerName>k__BackingField = dicAttributionData;
            string val_2 = com.adjust.sdk.AdjustUtils.TryGetValue(dictionary:  dicAttributionData, key:  mem[536883189] + 48);
            mem[1152921510369529012] = dicAttributionData;
            string val_3 = com.adjust.sdk.AdjustUtils.TryGetValue(dictionary:  dicAttributionData, key:  mem[536883189] + 8);
            mem[1152921510369528988] = dicAttributionData;
            string val_4 = com.adjust.sdk.AdjustUtils.TryGetValue(dictionary:  dicAttributionData, key:  mem[536883189] + 16);
            mem[1152921510369528996] = dicAttributionData;
            string val_5 = com.adjust.sdk.AdjustUtils.TryGetValue(dictionary:  dicAttributionData, key:  mem[536883189] + 12);
            mem[1152921510369528992] = dicAttributionData;
            string val_6 = com.adjust.sdk.AdjustUtils.TryGetValue(dictionary:  dicAttributionData, key:  mem[536883189] + 20);
            mem[1152921510369529000] = dicAttributionData;
            string val_7 = com.adjust.sdk.AdjustUtils.TryGetValue(dictionary:  dicAttributionData, key:  mem[536883189] + 40);
            mem[1152921510369529004] = dicAttributionData;
            string val_8 = com.adjust.sdk.AdjustUtils.TryGetValue(dictionary:  dicAttributionData, key:  mem[536883189]);
            mem[1152921510369528984] = dicAttributionData;
            string val_9 = com.adjust.sdk.AdjustUtils.TryGetValue(dictionary:  dicAttributionData, key:  mem[536883189] + 56);
            mem[1152921510369529016] = dicAttributionData;
            val_17 = 536883097;
            if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
            {
                    val_17 = 536883097;
            }
            
            string val_10 = com.adjust.sdk.AdjustUtils.TryGetValue(dictionary:  dicAttributionData, key:  mem[536883189] + 60);
            System.Globalization.CultureInfo val_11 = System.Globalization.CultureInfo.InvariantCulture;
            System.Nullable<System.Double> val_13 = new System.Nullable<System.Double>(value:  System.Double.Parse(s:  dicAttributionData, provider:  0));
            val_18 = 536883097;
            if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
            {
                    val_18 = 536883097;
            }
            
            string val_14 = com.adjust.sdk.AdjustUtils.TryGetValue(dictionary:  dicAttributionData, key:  mem[536883189] + 64);
            this.<costCurrency>k__BackingField = dicAttributionData;
        }
    
    }

}
