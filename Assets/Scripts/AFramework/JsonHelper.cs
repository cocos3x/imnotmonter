using UnityEngine;

namespace AFramework
{
    public static class JsonHelper
    {
        // Methods
        public static T[] getJsonArray<T>(string json)
        {
            string val_1 = -1610597133(-1610597133) + json + -1610596933(-1610596933);
            if((-1610597133) != 0)
            {
                    return;
            }
        
        }
        public static System.Collections.Generic.List<T> getJsonList<T>(string json)
        {
            string val_1 = -1610597125(-1610597125) + json + -1610596933(-1610596933);
            if((-1610597125) != 0)
            {
                    return;
            }
        
        }
        public static System.Collections.Generic.List<T> FromJson<T>(string json)
        {
            if(json != null)
            {
                    return;
            }
        
        }
        public static string ToJson<T>(System.Collections.Generic.List<T> array)
        {
            mem2[0] = array;
            return UnityEngine.JsonUtility.ToJson(obj:  __RuntimeMethodHiddenParam + 24);
        }
        public static string ToJson<T>(System.Collections.Generic.List<T> array, bool prettyPrint)
        {
            mem2[0] = array;
            return UnityEngine.JsonUtility.ToJson(obj:  __RuntimeMethodHiddenParam + 24, prettyPrint:  prettyPrint);
        }
    
    }

}
