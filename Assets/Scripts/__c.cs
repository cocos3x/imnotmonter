using UnityEngine;
[Serializable]
private sealed class ExpressionParser.<>c
{
    // Fields
    public static readonly B83.ExpressionParser.ExpressionParser.<>c <>9;
    public static System.Func<double> <>9__4_0;
    public static System.Func<double> <>9__4_1;
    public static System.Func<double[], double> <>9__4_2;
    public static System.Func<double[], double> <>9__4_3;
    public static System.Func<double[], double> <>9__4_4;
    public static System.Func<double[], double> <>9__4_5;
    public static System.Func<double[], double> <>9__4_6;
    public static System.Func<double[], double> <>9__4_7;
    public static System.Func<double[], double> <>9__4_8;
    public static System.Func<double[], double> <>9__4_9;
    public static System.Func<double[], double> <>9__4_10;
    public static System.Func<double[], double> <>9__4_11;
    public static System.Func<double[], double> <>9__4_12;
    public static System.Func<double[], double> <>9__4_13;
    public static System.Func<double[], double> <>9__4_14;
    public static System.Func<double[], double> <>9__4_15;
    public static System.Func<double[], double> <>9__4_16;
    
    // Methods
    private static ExpressionParser.<>c()
    {
        object val_1 = 536898935;
        val_1 = new System.Object();
        mem2[0] = val_1;
    }
    public ExpressionParser.<>c()
    {
    
    }
    internal double <.ctor>b__4_0()
    {
        return (double)D0;
    }
    internal double <.ctor>b__4_1()
    {
        return (double)D0;
    }
    internal double <.ctor>b__4_2(double[] p)
    {
        bool val_2 = mem[536890482];
        if((val_2 & true) == 0)
        {
                val_2 = mem[536890411];
        }
        
        if(val_2 <= _TYPE_MAX_)
        {
                return (double)System.Linq.Enumerable.FirstOrDefault<System.Double>(source:  p);
        }
    
    }
    internal double <.ctor>b__4_3(double[] p)
    {
        bool val_2 = mem[536890482];
        if((val_2 & true) == 0)
        {
                val_2 = mem[536890411];
        }
        
        double val_2 = System.Math.Abs(p);
        return (double)System.Linq.Enumerable.FirstOrDefault<System.Double>(source:  p);
    }
    internal double <.ctor>b__4_4(double[] p)
    {
        double val_1 = System.Linq.Enumerable.FirstOrDefault<System.Double>(source:  p);
    }
    internal double <.ctor>b__4_5(double[] p)
    {
        double val_1 = System.Linq.Enumerable.FirstOrDefault<System.Double>(source:  p);
    }
    internal double <.ctor>b__4_6(double[] p)
    {
        double val_1 = System.Linq.Enumerable.FirstOrDefault<System.Double>(source:  p);
    }
    internal double <.ctor>b__4_7(double[] p)
    {
        var val_2;
        var val_6;
        double val_7;
        var val_8;
        var val_9;
        if(mem[536890411] >= 0)
        {
            goto label_3;
        }
        
        if(mem[536890411] != 0)
        {
            goto label_4;
        }
        
        val_6 = val_2;
        val_7 = -1;
        goto label_5;
        label_3:
        if(mem[536890411] != 0)
        {
            goto label_6;
        }
        
        val_6 = val_2;
        val_7 = 1;
        label_5:
        double val_3 = val_6 + val_7;
        if((3221277689 & 1) != 0)
        {
                val_8 = val_6;
        }
        
        return (double)System.Linq.Enumerable.FirstOrDefault<System.Double>(source:  p);
        label_4:
        System.Double[] val_4 = p + (-0.5);
        val_9 = 3221277689;
        goto label_8;
        label_6:
        System.Double[] val_5 = p + 0.5;
        val_9 = 3221277689;
        label_8:
        val_8 = 3221277689;
        return (double)System.Linq.Enumerable.FirstOrDefault<System.Double>(source:  p);
    }
    internal double <.ctor>b__4_8(double[] p)
    {
        double val_1 = System.Linq.Enumerable.FirstOrDefault<System.Double>(source:  p);
    }
    internal double <.ctor>b__4_9(double[] p)
    {
        double val_1 = System.Linq.Enumerable.FirstOrDefault<System.Double>(source:  p);
    }
    internal double <.ctor>b__4_10(double[] p)
    {
        double val_1 = System.Linq.Enumerable.FirstOrDefault<System.Double>(source:  p);
    }
    internal double <.ctor>b__4_11(double[] p)
    {
        double val_1 = System.Linq.Enumerable.FirstOrDefault<System.Double>(source:  p);
    }
    internal double <.ctor>b__4_12(double[] p)
    {
        double val_1 = System.Linq.Enumerable.FirstOrDefault<System.Double>(source:  p);
    }
    internal double <.ctor>b__4_13(double[] p)
    {
        double val_1 = System.Linq.Enumerable.FirstOrDefault<System.Double>(source:  p);
    }
    internal double <.ctor>b__4_14(double[] p)
    {
        double val_1 = System.Linq.Enumerable.FirstOrDefault<System.Double>(source:  p);
        double val_2 = System.Linq.Enumerable.ElementAtOrDefault<System.Double>(source:  p, index:  1);
    }
    internal double <.ctor>b__4_15(double[] p)
    {
        double val_1 = System.Linq.Enumerable.FirstOrDefault<System.Double>(source:  p);
        return (double)System.Math.Min(val1:  System.Linq.Enumerable.ElementAtOrDefault<System.Double>(source:  p, index:  1), val2:  null);
    }
    internal double <.ctor>b__4_16(double[] p)
    {
        double val_1 = System.Linq.Enumerable.FirstOrDefault<System.Double>(source:  p);
        return (double)System.Math.Max(val1:  System.Linq.Enumerable.ElementAtOrDefault<System.Double>(source:  p, index:  1), val2:  null);
    }

}
