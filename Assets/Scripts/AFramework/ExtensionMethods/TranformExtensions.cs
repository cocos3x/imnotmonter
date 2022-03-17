using UnityEngine;

namespace AFramework.ExtensionMethods
{
    public static class TranformExtensions
    {
        // Methods
        public static T[] GetComponentsInChildrenFD<T>(UnityEngine.Transform trans)
        {
            var val_3;
            var val_4;
            val_3 = mem[__RuntimeMethodHiddenParam + 24];
            val_3 = __RuntimeMethodHiddenParam + 24;
            val_4 = 0;
            goto label_1;
            label_7:
            UnityEngine.Transform val_1 = trans.GetChild(index:  0);
            val_3 = trans;
            if(val_3 != 0)
            {
                    val_3 = val_3;
            }
            
            val_4 = 1;
            label_1:
            if(val_4 < trans.childCount)
            {
                goto label_7;
            }
            
            if(val_3 == 0)
            {
                
            }
        
        }
        public static UnityEngine.Transform FindDeepChild(UnityEngine.Transform aParent, string aName)
        {
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            string val_1 = aName.ToLower();
            System.Collections.IEnumerator val_2 = aParent.GetEnumerator();
            label_22:
            val_9 = 0;
            val_9 = val_9 + 1;
            val_10 = aParent;
            if(aParent == 0)
            {
                goto label_8;
            }
            
            var val_10 = 0;
            val_10 = val_10 + 1;
            val_11 = aParent;
            val_12 = aParent;
            val_12 = 0;
            string val_5 = val_12.name;
            val_9 = val_12;
            string val_6 = val_9.ToLower();
            if((System.String.op_Equality(a:  null, b:  aName)) == true)
            {
                goto label_18;
            }
            
            val_12 = val_12;
            if(0 == 0)
            {
                goto label_22;
            }
            
            label_18:
            val_13 = 1;
            val_14 = 0;
            goto label_23;
            label_8:
            val_13 = 1;
            val_14 = 0;
            val_12 = 0;
            label_23:
            if(aParent != 0)
            {
                    var val_11 = 0;
                val_9 = 0;
                val_11 = val_11 + 1;
                val_9 = (uint)val_11 & 65535;
                val_15 = aParent;
            }
            
            if(val_13 == 0)
            {
                    return;
            }
            
            var val_9 = val_13 - 1;
            if((1152921510087711516 + ((val_13 - 1)) << 2) == 103)
            {
                    return;
            }
        
        }
        public static UnityEngine.Transform FindDeepChildLower(UnityEngine.Transform aParent, string aName)
        {
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            string val_1 = aName.ToLower();
            System.Collections.IEnumerator val_2 = aParent.GetEnumerator();
            label_21:
            val_10 = 0;
            val_10 = val_10 + 1;
            val_11 = aParent;
            if(aParent == 0)
            {
                goto label_8;
            }
            
            var val_11 = 0;
            val_11 = val_11 + 1;
            val_12 = aParent;
            val_13 = aParent;
            val_13 = 0;
            string val_5 = val_13.name;
            val_10 = val_13;
            string val_6 = val_10.ToLower();
            if((System.String.op_Equality(a:  null, b:  aName)) == true)
            {
                goto label_18;
            }
            
            UnityEngine.Transform val_8 = AFramework.ExtensionMethods.TranformExtensions.FindDeepChild(aParent:  0, aName:  aName);
            val_13 = val_13;
            if(0 == 0)
            {
                goto label_21;
            }
            
            label_18:
            val_14 = 1;
            val_15 = 0;
            goto label_22;
            label_8:
            val_14 = 1;
            val_15 = 0;
            val_13 = 0;
            label_22:
            if(aParent != 0)
            {
                    var val_12 = 0;
                val_10 = 0;
                val_12 = val_12 + 1;
                val_10 = (uint)val_12 & 65535;
                val_16 = aParent;
            }
            
            if(val_14 == 0)
            {
                    return;
            }
            
            var val_10 = val_14 - 1;
            if((1152921510087839900 + ((val_14 - 1)) << 2) == 103)
            {
                    return;
            }
        
        }
        public static UnityEngine.GameObject[] FindDeepChildsWithStartName(UnityEngine.Transform aParent, string startName)
        {
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            val_12 = 22969857;
            string val_1 = startName.ToLower();
            536877883 = new System.Collections.Generic.List<Page>();
            System.Collections.IEnumerator val_3 = aParent.GetEnumerator();
            label_25:
            var val_13 = 0;
            val_13 = val_13 + 1;
            val_12 = (uint)val_13 & 65535;
            val_13 = aParent;
            if(aParent == 0)
            {
                goto label_8;
            }
            
            var val_14 = 0;
            val_14 = val_14 + 1;
            val_14 = aParent;
            string val_6 = 0.name;
            string val_7 = 0.ToLower();
            if((0.StartsWith(value:  startName)) == false)
            {
                goto label_19;
            }
            
            UnityEngine.GameObject val_9 = 0.gameObject;
            536877883.Add(item:  0);
            goto label_25;
            label_19:
            536877883.AddRange(collection:  0);
            goto label_25;
            label_8:
            val_15 = 22711796;
            if(aParent != 0)
            {
                    val_15 = 0;
                val_12 = 0;
                val_15 = val_15 + 1;
                val_12 = (uint)val_15 & 65535;
                val_16 = aParent;
            }
            
            if(1 != 0)
            {
                    var val_11 = 1 - 1;
            }
            
            T[] val_12 = 536877883.ToArray();
        }
        public static UnityEngine.Transform FindDeepChildWithStartName(UnityEngine.Transform aParent, string startName)
        {
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            string val_1 = startName.ToLower();
            System.Collections.IEnumerator val_2 = aParent.GetEnumerator();
            label_23:
            val_9 = 0;
            val_9 = val_9 + 1;
            val_10 = aParent;
            if(aParent == 0)
            {
                goto label_8;
            }
            
            var val_10 = 0;
            val_10 = val_10 + 1;
            val_11 = aParent;
            val_12 = aParent;
            val_12 = 0;
            string val_5 = val_12.name;
            string val_6 = val_12.ToLower();
            val_9 = val_12;
            if((val_9.StartsWith(value:  startName)) == true)
            {
                goto label_19;
            }
            
            val_12 = val_12;
            if(0 == 0)
            {
                goto label_23;
            }
            
            label_19:
            val_13 = 1;
            val_14 = 0;
            goto label_24;
            label_8:
            val_13 = 1;
            val_14 = 0;
            val_12 = 0;
            label_24:
            if(aParent != 0)
            {
                    var val_11 = 0;
                val_9 = 0;
                val_11 = val_11 + 1;
                val_9 = (uint)val_11 & 65535;
                val_15 = aParent;
            }
            
            if(val_13 == 0)
            {
                    return;
            }
            
            var val_9 = val_13 - 1;
            if((1152921510088096668 + ((val_13 - 1)) << 2) == 103)
            {
                    return;
            }
        
        }
        public static UnityEngine.GameObject[] FindChildsSameDeep(UnityEngine.Transform trans, string startName, bool includeInactive)
        {
            var val_12;
            var val_13;
            UnityEngine.Transform val_1 = AFramework.ExtensionMethods.TranformExtensions.FindDeepChildWithStartName(aParent:  trans, startName:  startName);
            536877883 = new System.Collections.Generic.List<Page>();
            if(trans == 0)
            {
                goto label_3;
            }
            
            val_12 = 0;
            UnityEngine.Transform val_4 = trans.parent;
            goto label_5;
            label_17:
            UnityEngine.Transform val_5 = trans.GetChild(index:  0);
            if(includeInactive == false)
            {
                goto label_7;
            }
            
            UnityEngine.GameObject val_6 = trans.gameObject;
            val_13 = trans;
            if(val_13.activeSelf == false)
            {
                goto label_13;
            }
            
            label_7:
            string val_8 = trans.name;
            val_13 = trans;
            if((val_13.StartsWith(value:  startName)) != false)
            {
                    UnityEngine.GameObject val_10 = trans.gameObject;
                536877883.Add(item:  trans);
            }
            
            label_13:
            val_12 = 1;
            label_5:
            if(val_12 < trans.childCount)
            {
                goto label_17;
            }
            
            label_3:
            if(536877883 != 0)
            {
                    return 536877883.ToArray();
            }
            
            return 536877883.ToArray();
        }
        public static int GetChildCount(UnityEngine.Transform trans, bool includeInactive)
        {
            var val_5;
            var val_6;
            if(includeInactive != false)
            {
                    if(trans != 0)
            {
                    return trans.childCount;
            }
            
                return trans.childCount;
            }
            
            val_5 = 0;
            val_6 = 0;
            goto label_2;
            label_7:
            UnityEngine.Transform val_1 = trans.GetChild(index:  0);
            UnityEngine.GameObject val_2 = trans.gameObject;
            val_6 = val_6 + trans.activeSelf;
            val_5 = 1;
            label_2:
            if(val_5 < trans.childCount)
            {
                goto label_7;
            }
            
            return (int)val_6;
        }
    
    }

}
