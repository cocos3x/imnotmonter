using UnityEngine;

namespace com.adjust.sdk
{
    public class AdjustSessionFailure
    {
        // Fields
        private string <Adid>k__BackingField;
        private string <Message>k__BackingField;
        private string <Timestamp>k__BackingField;
        private bool <WillRetry>k__BackingField;
        private System.Collections.Generic.Dictionary<string, object> <JsonResponse>k__BackingField;
        
        // Properties
        public string Adid { get; set; }
        public string Message { get; set; }
        public string Timestamp { get; set; }
        public bool WillRetry { get; set; }
        public System.Collections.Generic.Dictionary<string, object> JsonResponse { get; set; }
        
        // Methods
        public string get_Adid()
        {
        
        }
        public void set_Adid(string value)
        {
            this.<Adid>k__BackingField = value;
        }
        public string get_Message()
        {
        
        }
        public void set_Message(string value)
        {
            this.<Message>k__BackingField = value;
        }
        public string get_Timestamp()
        {
        
        }
        public void set_Timestamp(string value)
        {
            this.<Timestamp>k__BackingField = value;
        }
        public bool get_WillRetry()
        {
            return (bool)this.<WillRetry>k__BackingField;
        }
        public void set_WillRetry(bool value)
        {
            this.<WillRetry>k__BackingField = value;
        }
        public System.Collections.Generic.Dictionary<string, object> get_JsonResponse()
        {
        
        }
        public void set_JsonResponse(System.Collections.Generic.Dictionary<string, object> value)
        {
            this.<JsonResponse>k__BackingField = value;
        }
        public AdjustSessionFailure()
        {
        
        }
        public AdjustSessionFailure(System.Collections.Generic.Dictionary<string, string> sessionFailureDataMap)
        {
            string val_12;
            var val_13;
            var val_14;
            val_12 = 22998926;
            if(sessionFailureDataMap == 0)
            {
                    return;
            }
            
            val_13 = 536883097;
            if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
            {
                    val_13 = 536883097;
            }
            
            string val_1 = com.adjust.sdk.AdjustUtils.TryGetValue(dictionary:  sessionFailureDataMap, key:  mem[536883189]);
            this.<Adid>k__BackingField = sessionFailureDataMap;
            string val_2 = com.adjust.sdk.AdjustUtils.TryGetValue(dictionary:  sessionFailureDataMap, key:  mem[536883189] + 4);
            mem[1152921510381332380] = sessionFailureDataMap;
            string val_3 = com.adjust.sdk.AdjustUtils.TryGetValue(dictionary:  sessionFailureDataMap, key:  mem[536883189] + 28);
            mem[1152921510381332384] = sessionFailureDataMap;
            string val_4 = com.adjust.sdk.AdjustUtils.TryGetValue(dictionary:  sessionFailureDataMap, key:  mem[536883189] + 24);
            val_12 = sessionFailureDataMap;
            bool val_6 = System.Boolean.TryParse(value:  val_12, result: out  bool val_5 = true);
            if(val_6 == true)
            {
                    val_6 = 0;
                this.<WillRetry>k__BackingField = false;
            }
            
            val_14 = 536883097;
            if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
            {
                    val_14 = 536883097;
            }
            
            string val_7 = com.adjust.sdk.AdjustUtils.TryGetValue(dictionary:  sessionFailureDataMap, key:  mem[536883189] + 52);
            com.adjust.sdk.JSONNode val_8 = com.adjust.sdk.JSON.Parse(aJSON:  sessionFailureDataMap);
            if((com.adjust.sdk.JSONNode.op_Inequality(a:  sessionFailureDataMap, b:  0)) == false)
            {
                    return;
            }
            
            if((com.adjust.sdk.JSONNode.op_Inequality(a:  sessionFailureDataMap, b:  0)) == false)
            {
                    return;
            }
            
            val_12 = 536874379;
            val_12 = new System.Collections.Generic.Dictionary<System.Type, System.Runtime.Serialization.Formatters.Binary.TypeInformation>();
            this.<JsonResponse>k__BackingField = val_12;
            com.adjust.sdk.AdjustUtils.WriteJsonResponseDictionary(jsonObject:  sessionFailureDataMap, output:  536874379);
        }
        public AdjustSessionFailure(string jsonString)
        {
            var val_11;
            var val_12;
            val_11 = 22998927;
            com.adjust.sdk.JSONNode val_1 = com.adjust.sdk.JSON.Parse(aJSON:  jsonString);
            if((com.adjust.sdk.JSONNode.op_Equality(a:  jsonString, b:  0)) == true)
            {
                    return;
            }
            
            val_12 = 536883097;
            if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
            {
                    val_12 = 536883097;
            }
            
            string val_3 = com.adjust.sdk.AdjustUtils.GetJsonString(node:  jsonString, key:  mem[536883189]);
            this.<Adid>k__BackingField = jsonString;
            string val_4 = com.adjust.sdk.AdjustUtils.GetJsonString(node:  jsonString, key:  mem[536883189] + 4);
            mem[1152921510381452572] = jsonString;
            string val_5 = com.adjust.sdk.AdjustUtils.GetJsonString(node:  jsonString, key:  mem[536883189] + 28);
            mem[1152921510381452576] = jsonString;
            string val_6 = com.adjust.sdk.AdjustUtils.GetJsonString(node:  jsonString, key:  mem[536883189] + 24);
            this.<WillRetry>k__BackingField = System.Convert.ToBoolean(value:  jsonString);
            val_11 = mem[mem[536883189] + 52];
            val_11 = mem[536883189] + 52;
            if((com.adjust.sdk.JSONNode.op_Equality(a:  jsonString, b:  0)) == true)
            {
                    return;
            }
            
            if((com.adjust.sdk.JSONNode.op_Equality(a:  jsonString, b:  0)) != false)
            {
                    return;
            }
            
            536874379 = new System.Collections.Generic.Dictionary<System.Type, System.Runtime.Serialization.Formatters.Binary.TypeInformation>();
            this.<JsonResponse>k__BackingField = 536874379;
            com.adjust.sdk.AdjustUtils.WriteJsonResponseDictionary(jsonObject:  jsonString, output:  536874379);
        }
        public void BuildJsonResponseFromString(string jsonResponseString)
        {
            com.adjust.sdk.JSONNode val_1 = com.adjust.sdk.JSON.Parse(aJSON:  jsonResponseString);
            if((com.adjust.sdk.JSONNode.op_Equality(a:  jsonResponseString, b:  0)) != false)
            {
                    return;
            }
            
            536874379 = new System.Collections.Generic.Dictionary<System.Type, System.Runtime.Serialization.Formatters.Binary.TypeInformation>();
            this.<JsonResponse>k__BackingField = 536874379;
            com.adjust.sdk.AdjustUtils.WriteJsonResponseDictionary(jsonObject:  jsonResponseString, output:  536874379);
        }
        public string GetJsonResponse()
        {
            if((mem[536883284] & true) != 0)
            {
                    return com.adjust.sdk.AdjustUtils.GetJsonResponseCompact(dictionary:  this.<JsonResponse>k__BackingField);
            }
            
            if(mem[536883213] != 0)
            {
                    return com.adjust.sdk.AdjustUtils.GetJsonResponseCompact(dictionary:  this.<JsonResponse>k__BackingField);
            }
            
            return com.adjust.sdk.AdjustUtils.GetJsonResponseCompact(dictionary:  this.<JsonResponse>k__BackingField);
        }
    
    }

}
