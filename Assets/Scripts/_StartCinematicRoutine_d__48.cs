using UnityEngine;
private sealed class ProCamera2DCinematics.<StartCinematicRoutine>d__48 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Com.LuisPedroFonseca.ProCamera2D.ProCamera2DCinematics <>4__this;
    private int <count>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ProCamera2DCinematics.<StartCinematicRoutine>d__48(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_9;
        int val_10;
        var val_11;
        if((this.<>1__state) != 1)
        {
                val_9 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_9;
        }
        
            this.<>1__state = 0;
            if((this.<>4__this.OnCinematicStarted) != 0)
        {
                this.<>4__this.OnCinematicStarted.Invoke();
        }
        
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_1 = this.<>4__this.ProCamera2D;
            UnityEngine.Vector3 val_2 = LocalPosition;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_3 = this.<>4__this.ProCamera2D;
            UnityEngine.Vector3 val_4 = LocalPosition;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_5 = this.<>4__this.ProCamera2D;
            float val_9 = 0.5f;
            val_9 = (this.<>4__this.LetterboxAmount) * val_9;
            this.<>4__this._newSize = val_9;
            if((this.<>4__this.UseLetterbox) != false)
        {
                if((this.<>4__this._letterbox) == 0)
        {
                this.<>4__this.SetupLetterbox();
        }
        
            this.<>4__this._letterbox.TweenTo(targetAmount:  val_9, duration:  val_4.y);
        }
        
            val_10 = 0;
            val_11 = this;
            this.<count>5__2 = val_10;
        }
        else
        {
                val_11 = this;
            int val_10 = 0;
            val_10 = this.<count>5__2;
            this.<>1__state = val_10;
        }
        
        val_10 = val_10 - 1;
        if(val_10 < val_10)
        {
                this.<count>5__2 = 1;
            val_10 = this.<>4__this.CinematicTargets;
            this.<>4__this._skipTarget = false;
            if(false <= (this.<count>5__2))
        {
                var val_11 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_11 = val_11 + 4;
            System.Collections.IEnumerator val_7 = this.<>4__this.GoToCinematicTargetRoutine(cinematicTarget:  (0 + 4) + 16, targetIndex:  this.<count>5__2);
            UnityEngine.Coroutine val_8 = this.<>4__this.StartCoroutine(routine:  this.<>4__this);
            this.<>4__this._goToCinematicRoutine = this.<>4__this;
            this.<>2__current = this.<>4__this._goToCinematicRoutine;
            val_9 = 1;
            this.<>1__state = val_9;
            return (bool)val_9;
        }
        
        val_9 = 0;
        this.<>4__this.Stop();
        return (bool)val_9;
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
