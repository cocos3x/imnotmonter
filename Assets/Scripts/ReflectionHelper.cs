using UnityEngine;
public static class ReflectionHelper
{
    // Methods
    public static ReflectionHelper.InvokeNamespaceClassStaticMethodResult[] _InvokeNamespaceClassStaticMethod(string namespaceName, string methodName, bool throwExceptions, object[] parameters)
    {
        var val_19;
        var val_20;
        var val_21;
        object val_22;
        System.Func<System.Type, System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo>> val_23;
        536878651 = new System.Collections.Generic.List<Page>();
        System.AppDomain val_2 = System.AppDomain.CurrentDomain;
        System.Reflection.Assembly[] val_3 = 0.GetAssemblies();
        val_19 = 0;
        val_20 = 0;
        goto label_2;
        label_42:
        var val_19 = 0;
        label_30:
        if(((System.String.op_Equality(a:  -1610611231, b:  namespaceName)) != false) && ((-1.084397E-19f.IsClass) != false))
        {
                val_21 = 536900731;
            if(((mem[536900918] & true) == 0) && (mem[536900847] == 0))
        {
                val_21 = 536900731;
        }
        
            val_22 = mem[536900823];
            val_23 = mem[mem[536900823] + 4];
            val_23 = mem[536900823] + 4;
            if(val_23 == 0)
        {
                if(((mem[536900918] & true) == 0) && (mem[536900847] == 0))
        {
                val_22 = mem[536900823];
        }
        
            val_23 = 536875497;
            val_23 = new System.Func<System.Type, System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo>>(object:  val_22, method:  new IntPtr(1610676573));
            mem2[0] = val_23;
        }
        
            System.Collections.Generic.IEnumerable<TResult> val_7 = System.Linq.Enumerable.Select<UnityEngine.Purchasing.ProductDefinition, UnityEngine.Purchasing.Default.WinProductDescription>(source:  parameters, selector:  536875497);
            TSource[] val_8 = System.Linq.Enumerable.ToArray<System.Type>(source:  parameters);
            System.Reflection.MethodInfo val_9 = -1.084397E-19f.GetMethod(name:  methodName, types:  parameters);
            if((((System.Reflection.MethodInfo.op_Inequality(left:  -1610611231, right:  0)) != false) && ((-1.084397E-19f.IsPublic) != false)) && ((-1.084397E-19f.IsStatic) != false))
        {
                536900735 = new ReflectionHelper.InvokeNamespaceClassStaticMethodResult();
            mem[536900743] = -1.084397E-19f;
            mem[536900747] = -1.084397E-19f;
            mem[536900751] = -1.084397E-19f;
            System.Type val_14 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(1073767725)});
            if((System.Type.op_Equality(left:  -1610611231, right:  1073767725)) != false)
        {
                object val_16 = -1.084397E-19f.Invoke(obj:  0, parameters:  parameters);
            mem[536900759] = 1;
        }
        else
        {
                object val_17 = -1.084397E-19f.Invoke(obj:  0, parameters:  parameters);
            mem[536900755] = -1.084397E-19f;
        }
        
            val_1.Add(item:  536900735);
        }
        
        }
        
        val_19 = val_19 + 1;
        goto label_30;
        label_2:
        if( < 0)
        {
            goto label_42;
        }
        
        T[] val_18 = val_1.ToArray();
    }

}
