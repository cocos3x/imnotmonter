using UnityEngine;
private sealed class TextMeshProFloatingText.<DisplayTextMeshProFloatingText>d__15 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public TMPro.Examples.TextMeshProFloatingText <>4__this;
    private float <CountDuration>5__2;
    private float <starting_Count>5__3;
    private float <current_Count>5__4;
    private UnityEngine.Vector3 <start_pos>5__5;
    private UnityEngine.Color32 <start_color>5__6;
    private float <alpha>5__7;
    private float <fadeDuration>5__8;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TextMeshProFloatingText.<DisplayTextMeshProFloatingText>d__15(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_15;
        float val_16;
        float val_17;
        float val_18;
        int val_32;
        var val_33;
        float val_34;
        UnityEngine.Quaternion val_35;
        var val_36;
        float val_37;
        float val_38;
        UnityEngine.Quaternion val_40;
        var val_42;
        val_32 = 0;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        if((this.<>1__state) != 0)
        {
                return (bool)val_32;
        }
        
        this.<CountDuration>5__2 = 2f;
        this.<>1__state = 0;
        float val_1 = UnityEngine.Random.Range(minInclusive:  null, maxInclusive:  null);
        this.<starting_Count>5__3 = 5f;
        this.<current_Count>5__4 = 5f;
        val_33 = 0;
        UnityEngine.Vector3 val_2 = position;
        val_34 = this.<current_Count>5__4;
        UnityEngine.Color val_3 = color;
        UnityEngine.Color32 val_4 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color());
        float val_32 = 3f;
        this.<start_color>5__6 = val_4;
        this.<alpha>5__7 = 255f;
        val_32 = val_32 / (this.<starting_Count>5__3);
        val_32 = val_32 * (this.<CountDuration>5__2);
        this.<fadeDuration>5__8 = val_32;
        goto label_7;
        label_1:
        this.<>1__state = 0;
        val_32 = 0;
        this.<>4__this.m_floatingText_Transform.position = new UnityEngine.Vector3() {x = mem[this.<start_pos>5__5 + (0)], y = mem[this.<start_pos>5__5 + (4)], z = mem[this.<start_pos>5__5 + (8)]};
        System.Collections.IEnumerator val_5 = this.<>4__this.DisplayTextMeshProFloatingText();
        UnityEngine.Coroutine val_6 = this.<>4__this.StartCoroutine(routine:  this.<>4__this);
        return (bool)val_32;
        label_2:
        val_34 = this.<current_Count>5__4;
        this.<>1__state = 0;
        label_7:
        if((this.<>1__state) <= 1)
        {
                val_36 = 536895275;
            if(((mem[536895462] & true) == 0) && (mem[536895391] == 0))
        {
                val_36 = 536895275;
        }
        
            var val_8 = (mem[536895367] + 4) + ((UnityEngine.Random.Range(minInclusive:  0, maxExclusive:  19)) << 2);
            this.<>2__current = (mem[536895367] + 4 + (val_7) << 2) + 16;
            val_32 = 1;
            this.<>1__state = 2;
            return (bool)val_32;
        }
        
        float val_9 = UnityEngine.Time.deltaTime;
        float val_33 = this.<CountDuration>5__2;
        val_33 = 0 / val_33;
        this.<current_Count>5__4 = val_34;
        if((this.<>1__state) <= 1)
        {
                float val_10 = UnityEngine.Time.deltaTime;
            float val_34 = this.<fadeDuration>5__8;
            val_34 = 0 / val_34;
            float val_11 = UnityEngine.Mathf.Clamp(value:  val_34, min:  null, max:  -255f);
            val_37 = this.<current_Count>5__4;
            this.<alpha>5__7 = this.<alpha>5__7;
        }
        
        string val_12 = (int)val_37.ToString();
        this.<>4__this.m_textMeshPro.text = 960888420;
        if((this.<>4__this.m_textMeshPro) < 0)
        {
                (uint)this.<alpha>5__7 = (int)this.<alpha>5__7;
        }
        
        UnityEngine.Color32 val_13 = new UnityEngine.Color32(r:  this.<start_color>5__6, g:  24, b:  24, a:  (int)((uint)this.<alpha>5__7) & 255);
        UnityEngine.Color val_14 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32() {r = 84, g = 254, b = 69, a = 57});
        val_38 = val_16;
        if((this.<>4__this.m_textMeshPro) == 0)
        {
                val_38 = val_38;
        }
        
        this.<>4__this.m_textMeshPro.color = new UnityEngine.Color() {r = val_15, g = val_38, b = val_17, a = val_18};
        UnityEngine.Vector3 val_19 = position;
        float val_20 = val_17 + 0f;
        float val_21 = UnityEngine.Time.deltaTime;
        float val_22 = val_15 + 0f;
        this.<>4__this.m_floatingText_Transform.position = new UnityEngine.Vector3() {x = val_22, y = val_16, z = val_20};
        UnityEngine.Vector3 val_23 = position;
        if((TMPro.TMPro_ExtensionMethods.Compare(v1:  new UnityEngine.Vector3() {x = this.<>4__this.lastPOS, y = val_22, z = val_20}, v2:  new UnityEngine.Vector3() {x = val_15, y = val_16, z = val_17}, accuracy:  1000)) == false)
        {
            goto label_24;
        }
        
        TMPro.Examples.TextMeshProFloatingText val_25 = (this.<>4__this) + 56;
        val_40 = this.<>4__this.lastRotation;
        UnityEngine.Quaternion val_26 = rotation;
        if((TMPro.TMPro_ExtensionMethods.Compare(q1:  new UnityEngine.Quaternion() {x = val_40, y = mem[(this.<>4__this + 56) + (0)], z = mem[(this.<>4__this + 56) + (4)], w = mem[(this.<>4__this + 56) + (8)]}, q2:  new UnityEngine.Quaternion(), accuracy:  1000)) == true)
        {
            goto label_26;
        }
        
        label_24:
        UnityEngine.Vector3 val_28 = position;
        UnityEngine.Quaternion val_29 = rotation;
        val_35 = val_15;
        TMPro.Examples.TextMeshProFloatingText val_30 = (this.<>4__this) + 56;
        this.<>4__this.lastRotation = val_35;
        this.<>4__this.m_floatingText_Transform.rotation = new UnityEngine.Quaternion() {x = val_35, y = R7, z = R8, w = ???};
        val_33 = 0;
        UnityEngine.Vector3 val_31 = position;
        float val_35 = val_15;
        float val_36 = val_17;
        val_35 = val_35 - (this.<>4__this.lastPOS);
        val_36 = val_36 - S6;
        val_34 = val_35;
        this.<>4__this.m_transform.forward = new UnityEngine.Vector3() {x = val_34, y = 0f, z = val_36};
        label_26:
        val_42 = 536895275;
        if(((mem[536895462] & true) == 0) && (mem[536895391] == 0))
        {
                val_42 = 536895275;
        }
        
        this.<>2__current = mem[536895367];
        val_32 = 1;
        this.<>1__state = val_32;
        return (bool)val_32;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
    
    }
    private void System.Collections.IEnumerator.Reset()
    {
        22713476 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
    
    }

}
