using UnityEngine;

namespace com.adjust.sdk
{
    public class AdjustEventSuccess
    {
        // Fields
        private string <Adid>k__BackingField;
        private string <Message>k__BackingField;
        private string <Timestamp>k__BackingField;
        private string <EventToken>k__BackingField;
        private string <CallbackId>k__BackingField;
        private System.Collections.Generic.Dictionary<string, object> <JsonResponse>k__BackingField;
        
        // Properties
        public string Adid { get; set; }
        public string Message { get; set; }
        public string Timestamp { get; set; }
        public string EventToken { get; set; }
        public string CallbackId { get; set; }
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
        public string get_EventToken()
        {
        
        }
        public void set_EventToken(string value)
        {
            this.<EventToken>k__BackingField = value;
        }
        public string get_CallbackId()
        {
        
        }
        public void set_CallbackId(string value)
        {
            this.<CallbackId>k__BackingField = value;
        }
        public System.Collections.Generic.Dictionary<string, object> get_JsonResponse()
        {
        
        }
        public void set_JsonResponse(System.Collections.Generic.Dictionary<string, object> value)
        {
            this.<JsonResponse>k__BackingField = value;
        }
        public AdjustEventSuccess()
        {
        
        }
        public AdjustEventSuccess(System.Collections.Generic.Dictionary<string, string> eventSuccessDataMap)
        {
            var val_11;
            var val_12;
            val_11 = 22998918;
            if(eventSuccessDataMap == 0)
            {
                    return;
            }
            
            val_12 = 536883097;
            if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
            {
                    val_12 = 536883097;
            }
            
            string val_1 = com.adjust.sdk.AdjustUtils.TryGetValue(dictionary:  eventSuccessDataMap, key:  mem[536883189]);
            val_11 = this;
            this.<Adid>k__BackingField = eventSuccessDataMap;
            string val_2 = com.adjust.sdk.AdjustUtils.TryGetValue(dictionary:  eventSuccessDataMap, key:  mem[536883189] + 4);
            mem[1152921510378759196] = eventSuccessDataMap;
            string val_3 = com.adjust.sdk.AdjustUtils.TryGetValue(dictionary:  eventSuccessDataMap, key:  mem[536883189] + 28);
            mem[1152921510378759200] = eventSuccessDataMap;
            string val_4 = com.adjust.sdk.AdjustUtils.TryGetValue(dictionary:  eventSuccessDataMap, key:  mem[536883189] + 36);
            mem[1152921510378759204] = eventSuccessDataMap;
            string val_5 = com.adjust.sdk.AdjustUtils.TryGetValue(dictionary:  eventSuccessDataMap, key:  mem[536883189] + 32);
            mem[1152921510378759208] = eventSuccessDataMap;
            string val_6 = com.adjust.sdk.AdjustUtils.TryGetValue(dictionary:  eventSuccessDataMap, key:  mem[536883189] + 52);
            com.adjust.sdk.JSONNode val_7 = com.adjust.sdk.JSON.Parse(aJSON:  eventSuccessDataMap);
            if((com.adjust.sdk.JSONNode.op_Inequality(a:  eventSuccessDataMap, b:  0)) == false)
            {
                    return;
            }
            
            if((com.adjust.sdk.JSONNode.op_Inequality(a:  eventSuccessDataMap, b:  0)) == false)
            {
                    return;
            }
            
            536874379 = new System.Collections.Generic.Dictionary<System.Type, System.Runtime.Serialization.Formatters.Binary.TypeInformation>();
            this.<JsonResponse>k__BackingField = 536874379;
            com.adjust.sdk.AdjustUtils.WriteJsonResponseDictionary(jsonObject:  eventSuccessDataMap, output:  536874379);
        }
        public AdjustEventSuccess(string jsonString)
        {
            var val_11;
            var val_12;
            val_11 = 22998919;
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
            mem[1152921510378879388] = jsonString;
            string val_5 = com.adjust.sdk.AdjustUtils.GetJsonString(node:  jsonString, key:  mem[536883189] + 28);
            mem[1152921510378879392] = jsonString;
            string val_6 = com.adjust.sdk.AdjustUtils.GetJsonString(node:  jsonString, key:  mem[536883189] + 36);
            mem[1152921510378879396] = jsonString;
            string val_7 = com.adjust.sdk.AdjustUtils.GetJsonString(node:  jsonString, key:  mem[536883189] + 32);
            mem[1152921510378879400] = jsonString;
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
