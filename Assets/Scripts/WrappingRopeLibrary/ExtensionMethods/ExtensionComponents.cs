using UnityEngine;

namespace WrappingRopeLibrary.ExtensionMethods
{
    public static class ExtensionComponents
    {
        // Methods
        public static T GetCopyOf<T>(UnityEngine.Component comp, T other)
        {
            var val_10;
            System.Type val_11;
            var val_12;
            System.Type val_13;
            var val_14;
            System.Func<MessageTypeSubscribers, System.Boolean> val_15;
            var val_16;
            var val_18;
            System.Collections.Generic.IEnumerable<TSource> val_19;
            var val_20;
            System.Func<MessageTypeSubscribers, System.Boolean> val_21;
            var val_22;
            val_10 = __RuntimeMethodHiddenParam;
            val_11 = other;
            System.Type val_1 = comp.GetType();
            UnityEngine.Component val_9 = comp;
            val_12 = 0;
            System.Type val_2 = val_11.GetType();
            val_13 = val_11;
            if((System.Type.op_Inequality(left:  val_9, right:  val_13)) == true)
            {
                    return;
            }
            
            val_9 = val_9 + 16;
            var val_4 = val_10 + 24;
            val_13 = val_9;
            var val_10 = 0;
            label_27:
            if(val_10 >= 0)
            {
                goto label_8;
            }
            
            if(1152921504735174656 != 0)
            {
                    val_14 = mem[(__RuntimeMethodHiddenParam + 24) + 4 + 186];
                val_14 = (__RuntimeMethodHiddenParam + 24) + 4 + 186;
                if(val_14 == 1)
            {
                    val_14 = mem[(__RuntimeMethodHiddenParam + 24) + 4 + 186];
                val_14 = (__RuntimeMethodHiddenParam + 24) + 4 + 186;
            }
            
                val_15 = mem[(__RuntimeMethodHiddenParam + 24) + 4 + 92 + 4];
                val_15 = (__RuntimeMethodHiddenParam + 24) + 4 + 92 + 4;
                if(val_15 == 0)
            {
                    val_16 = mem[(__RuntimeMethodHiddenParam + 24) + 4 + 186];
                val_16 = (__RuntimeMethodHiddenParam + 24) + 4 + 186;
                if(val_16 == 1)
            {
                    val_16 = mem[(__RuntimeMethodHiddenParam + 24) + 4 + 186];
                val_16 = (__RuntimeMethodHiddenParam + 24) + 4 + 186;
            }
            
                val_15 = 536875475;
                val_15 = new System.Func<MessageTypeSubscribers, System.Boolean>(object:  (__RuntimeMethodHiddenParam + 24) + 4 + 92, method:  (__RuntimeMethodHiddenParam + 24) + 8);
                mem2[0] = val_15;
            }
            
                bool val_6 = System.Linq.Enumerable.All<WrappingRopeLibrary.Model.WrapPoint>(source:  128327680, predicate:  536875475);
            }
            
            val_10 = val_10 + 1;
            goto label_27;
            label_8:
            val_18 = val_9;
            val_10 = val_9 + 16;
            val_11 = 0;
            goto label_32;
            label_51:
            val_13 = mem[(comp + 16) + 0];
            val_13 = (comp + 16) + 0;
            val_19 = val_13;
            val_20 = mem[(__RuntimeMethodHiddenParam + 24) + 4 + 186];
            val_20 = (__RuntimeMethodHiddenParam + 24) + 4 + 186;
            if(val_20 == 1)
            {
                    val_20 = mem[(__RuntimeMethodHiddenParam + 24) + 4 + 186];
                val_20 = (__RuntimeMethodHiddenParam + 24) + 4 + 186;
            }
            
            val_21 = mem[(__RuntimeMethodHiddenParam + 24) + 4 + 92 + 8];
            val_21 = (__RuntimeMethodHiddenParam + 24) + 4 + 92 + 8;
            if(val_21 == 0)
            {
                    val_22 = mem[(__RuntimeMethodHiddenParam + 24) + 4 + 186];
                val_22 = (__RuntimeMethodHiddenParam + 24) + 4 + 186;
                if(val_22 == 1)
            {
                    val_22 = mem[(__RuntimeMethodHiddenParam + 24) + 4 + 186];
                val_22 = (__RuntimeMethodHiddenParam + 24) + 4 + 186;
            }
            
                val_21 = 536875475;
                val_21 = new System.Func<MessageTypeSubscribers, System.Boolean>(object:  (__RuntimeMethodHiddenParam + 24) + 4 + 92, method:  (__RuntimeMethodHiddenParam + 24) + 12);
                mem2[0] = val_21;
                val_18 = val_18;
                val_19 = val_19;
            }
            
            if((System.Linq.Enumerable.All<WrappingRopeLibrary.Model.WrapPoint>(source:  val_19, predicate:  536875475)) != false)
            {
                    val_13.SetValue(obj:  comp, value:  val_13);
            }
            
            val_11 = 1;
            label_32:
            if(val_11 < (comp + 12))
            {
                goto label_51;
            }
            
            val_12 = 0;
            if(comp == 0)
            {
                    return;
            }
            
            val_12 = comp;
            if(comp != 0)
            {
                    return;
            }
            
            val_12 = 0;
        }
    
    }

}
