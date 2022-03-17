using UnityEngine;

namespace com.adjust.sdk
{
    public class AdjustUtils
    {
        // Fields
        public static string KeyAdid;
        public static string KeyMessage;
        public static string KeyNetwork;
        public static string KeyAdgroup;
        public static string KeyCampaign;
        public static string KeyCreative;
        public static string KeyWillRetry;
        public static string KeyTimestamp;
        public static string KeyCallbackId;
        public static string KeyEventToken;
        public static string KeyClickLabel;
        public static string KeyTrackerName;
        public static string KeyTrackerToken;
        public static string KeyJsonResponse;
        public static string KeyCostType;
        public static string KeyCostAmount;
        public static string KeyCostCurrency;
        public static string KeyTestOptionsBaseUrl;
        public static string KeyTestOptionsGdprUrl;
        public static string KeyTestOptionsSubscriptionUrl;
        public static string KeyTestOptionsExtraPath;
        public static string KeyTestOptionsBasePath;
        public static string KeyTestOptionsGdprPath;
        public static string KeyTestOptionsDeleteState;
        public static string KeyTestOptionsUseTestConnectionOptions;
        public static string KeyTestOptionsTimerIntervalInMilliseconds;
        public static string KeyTestOptionsTimerStartInMilliseconds;
        public static string KeyTestOptionsSessionIntervalInMilliseconds;
        public static string KeyTestOptionsSubsessionIntervalInMilliseconds;
        public static string KeyTestOptionsTeardown;
        public static string KeyTestOptionsNoBackoffWait;
        public static string KeyTestOptionsiAdFrameworkEnabled;
        public static string KeyTestOptionsAdServicesFrameworkEnabled;
        
        // Methods
        public static int ConvertLogLevel(System.Nullable<com.adjust.sdk.AdjustLogLevel> logLevel)
        {
            var val_2;
            if((R1 & 255) == 0)
            {
                    val_2;
                DG.Tweening.LoopType val_1 = logLevel.HasValue.Value;
                return (int)val_2;
            }
            
            val_2 = 0;
            return (int)val_2;
        }
        public static int ConvertBool(System.Nullable<bool> value)
        {
            if(((uint)value.HasValue & 65535) >= 256)
            {
                    return (int)value.HasValue.Value;
            }
            
            return 0;
        }
        public static double ConvertDouble(System.Nullable<double> value)
        {
            bool val_2;
            double val_3;
            val_2 = static_value_015EEF9A;
            if((R2 & 255) == 0)
            {
                    val_2 = -1073707223;
                double val_1 = value.HasValue.Value;
                val_3 = 1482034192;
                return (double)D0;
            }
            
            val_3 = -1;
            return (double)D0;
        }
        public static int ConvertInt(System.Nullable<int> value)
        {
            var val_2;
            if((R1 & 255) == 0)
            {
                    int val_1 = value.HasValue.Value;
                return (int)val_2;
            }
            
            val_2 = 0;
            return (int)val_2;
        }
        public static long ConvertLong(System.Nullable<long> value)
        {
            var val_2;
            if((R2 & 255) == 0)
            {
                    long val_1 = value.HasValue.Value;
                return (long)val_2;
            }
            
            val_2 = 0;
            return (long)val_2;
        }
        public static string ConvertListToJson(System.Collections.Generic.List<string> list)
        {
            string val_4;
            if(list == 0)
            {
                    return;
            }
            
            com.adjust.sdk.JSONArray val_1 = 536889311;
            val_1 = new com.adjust.sdk.JSONArray();
            List.Enumerator<T> val_2 = GetEnumerator();
            label_4:
            if(MoveNext() == false)
            {
                goto label_2;
            }
            
            536889323 = new com.adjust.sdk.JSONData(aData:  val_4);
            if(val_1 != 0)
            {
                goto label_4;
            }
            
            goto label_4;
            label_2:
            Dispose();
            if(val_1 != 0)
            {
                    return;
            }
        
        }
        public static string GetJsonResponseCompact(System.Collections.Generic.Dictionary<string, object> dictionary)
        {
            var val_5;
            var val_15;
            var val_16;
            var val_17;
            if(dictionary == 0)
            {
                    return;
            }
            
            string val_1 = -1610612735(-1610612735) + -1610597137(-1610597137);
            Dictionary.Enumerator<TKey, TValue> val_2 = GetEnumerator();
            var val_16 = 0;
            label_50:
            if(0.MoveNext() == false)
            {
                goto label_2;
            }
            
            val_15 = 0;
            if(val_5 == 0)
            {
                goto label_5;
            }
            
            if(val_5 == 536894583)
            {
                goto label_4;
            }
            
            if((val_5 + 180) >= mem[536874559])
            {
                    var val_15 = val_5 + 100;
                val_15 = val_15 + (mem[536874559] << 2);
                if(((val_5 + 100 + (mem[536874559]) << 2) + -4) != 536874379)
            {
                    val_5 = 0;
            }
            
                val_15 = val_5;
            }
            
            label_5:
            val_16 = val_16 + 1;
            if(val_16 < 2)
            {
                    val_16 = -1610612735;
            }
            else
            {
                    string val_6 = -1610612735(-1610612735) + -1610611911(-1610611911);
                val_16 = -1610612735;
            }
            
            string val_7 = -1610612735(-1610612735) + -1610612241(-1610612241) + null + -1610612189(-1610612189);
            string val_8 = -1610612735(-1610612735) + null;
            goto label_50;
            label_4:
            val_16 = val_16 + 1;
            if(val_16 < 2)
            {
                    val_17 = -1610612735;
            }
            else
            {
                    string val_9 = -1610612735(-1610612735) + -1610611911(-1610611911);
                val_17 = -1610612735;
            }
            
            if(((val_5.StartsWith(value:  -1610597137)) == false) || ((val_5.EndsWith(value:  -1610596933)) == false))
            {
                goto label_15;
            }
            
            mem[536882417] = val_17;
            mem[536882421] = -1610612241;
            mem[536882425] = 0;
            mem[536882429] = -1610612189;
            mem[536882433] = val_5;
            string val_12 = +536882401;
            goto label_50;
            label_15:
            mem[536882417] = val_17;
            mem[536882421] = -1610612241;
            mem[536882425] = 0;
            mem[536882429] = -1610612187;
            mem[536882433] = val_5;
            mem[536882437] = -1610612241;
            string val_13 = +536882401;
            goto label_50;
            label_2:
            0.Dispose();
            string val_14 = -1610612735(-1610612735) + -1610596933(-1610596933);
        }
        public static string GetJsonString(com.adjust.sdk.JSONNode node, string key)
        {
            var val_4;
            bool val_5;
            var val_6;
            val_4 = 22998943;
            if((com.adjust.sdk.JSONNode.op_Equality(a:  node, b:  0)) == true)
            {
                    return;
            }
            
            val_6 = 0;
            if(node != 0)
            {
                    val_5 = mem[536889503];
                if(((com.adjust.sdk.JSONNode.__il2cppRuntimeField_typeHierarchy + (mem[536889503]) << 2) + -4) != 536889323)
            {
                    node = 0;
            }
            
                val_6 = node;
            }
            
            if((com.adjust.sdk.JSONNode.op_Equality(a:  0, b:  0)) == true)
            {
                    return;
            }
            
            if((com.adjust.sdk.JSONNode.op_Equality(a:  0, b:  -1610612735)) != false)
            {
                    return;
            }
            
            if(val_6 == 0)
            {
                
            }
        
        }
        public static void WriteJsonResponseDictionary(com.adjust.sdk.JSONClass jsonObject, System.Collections.Generic.Dictionary<string, object> output)
        {
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            System.Collections.IEnumerator val_1 = jsonObject.GetEnumerator();
            label_24:
            var val_10 = 0;
            val_9 = 0;
            val_10 = val_10 + 1;
            val_9 = (uint)val_10 & 65535;
            val_10 = jsonObject;
            if(jsonObject == 0)
            {
                goto label_7;
            }
            
            var val_11 = 0;
            val_11 = val_11 + 1;
            val_11 = jsonObject;
            val_12 = 0;
            com.adjust.sdk.JSONClass val_4 = jsonObject.AsObject;
            if((com.adjust.sdk.JSONNode.op_Equality(a:  jsonObject, b:  0)) == false)
            {
                goto label_17;
            }
            
            string val_6 = jsonObject.Value;
            output.Add(key:  328966144, value:  jsonObject);
            goto label_24;
            label_17:
            536874379 = new System.Collections.Generic.Dictionary<System.Type, System.Runtime.Serialization.Formatters.Binary.TypeInformation>();
            output.Add(key:  328966144, value:  536874379);
            if(((mem[536883284] & true) != 0) || (mem[536883213] != 0))
            {
                goto label_24;
            }
            
            goto label_24;
            label_7:
            val_13 = 22711796;
            if(jsonObject != 0)
            {
                    val_13 = 0;
                val_13 = val_13 + 1;
                val_14 = jsonObject;
            }
            
            if(1 == 0)
            {
                    return;
            }
            
            var val_9 = 1 - 1;
        }
        public static string TryGetValue(System.Collections.Generic.Dictionary<string, string> dictionary, string key)
        {
            if((dictionary.TryGetValue(key:  key, value: out  string val_1 = 1482875540)) == false)
            {
                    return;
            }
            
            if((System.String.op_Equality(a:  null, b:  -1610612735)) == true)
            {
                    0 = 0;
            }
        
        }
        public static UnityEngine.AndroidJavaObject TestOptionsMap2AndroidJavaObject(System.Collections.Generic.Dictionary<string, string> testOptionsMap, UnityEngine.AndroidJavaObject ajoCurrentActivity)
        {
            if(mem[22998946] != true)
            {
                
            }
        
        }
        public AdjustUtils()
        {
        
        }
        private static AdjustUtils()
        {
            mem2[0] = -1610601829;
            mem2[0] = -1610599271;
            mem2[0] = -1610599109;
            mem2[0] = -1610601831;
            mem2[0] = -1610601499;
            mem2[0] = -1610601075;
            mem2[0] = -1610597389;
            mem2[0] = -1610597749;
            mem2[0] = -1610601501;
            mem2[0] = -1610600601;
            mem2[0] = -1610601377;
            mem2[0] = -1610597691;
            mem2[0] = -1610597689;
            mem2[0] = -1610599643;
            mem2[0] = -1610601167;
            mem2[0] = -1610601171;
            mem2[0] = -1610601169;
            mem2[0] = -1610601633;
            mem2[0] = -1610600449;
            mem2[0] = -1610597969;
            mem2[0] = -1610600591;
            mem2[0] = -1610601637;
            mem2[0] = -1610600451;
            mem2[0] = -1610600873;
            mem2[0] = -1610597529;
            mem2[0] = -1610597753;
            mem2[0] = -1610597751;
            mem2[0] = -1610598475;
            mem2[0] = -1610597967;
            mem2[0] = -1610597807;
            mem2[0] = -1610599065;
            mem2[0] = -1610600065;
            mem2[0] = -1610601859;
        }
    
    }

}
