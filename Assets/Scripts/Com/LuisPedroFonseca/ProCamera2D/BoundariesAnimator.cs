using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D
{
    public class BoundariesAnimator
    {
        // Fields
        public System.Action OnTransitionStarted;
        public System.Action OnTransitionFinished;
        public bool UseTopBoundary;
        public float TopBoundary;
        public bool UseBottomBoundary;
        public float BottomBoundary;
        public bool UseLeftBoundary;
        public float LeftBoundary;
        public bool UseRightBoundary;
        public float RightBoundary;
        public float TransitionDuration;
        public Com.LuisPedroFonseca.ProCamera2D.EaseType TransitionEaseType;
        private Com.LuisPedroFonseca.ProCamera2D.ProCamera2D ProCamera2D;
        private Com.LuisPedroFonseca.ProCamera2D.ProCamera2DNumericBoundaries NumericBoundaries;
        private System.Func<UnityEngine.Vector3, float> Vector3H;
        private System.Func<UnityEngine.Vector3, float> Vector3V;
        
        // Methods
        public BoundariesAnimator(Com.LuisPedroFonseca.ProCamera2D.ProCamera2D proCamera2D, Com.LuisPedroFonseca.ProCamera2D.ProCamera2DNumericBoundaries numericBoundaries)
        {
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_8;
            var val_9;
            var val_10;
            var val_11;
            object val_12;
            System.Func<UnityEngine.Vector3, System.Single> val_13;
            object val_14;
            var val_15;
            object val_16;
            System.Func<UnityEngine.Vector3, System.Single> val_17;
            var val_18;
            object val_19;
            System.Func<UnityEngine.Vector3, System.Single> val_20;
            var val_21;
            object val_22;
            var val_23;
            object val_24;
            System.Func<UnityEngine.Vector3, System.Single> val_25;
            var val_26;
            object val_27;
            val_8 = proCamera2D;
            this.TransitionDuration = 1f;
            val_9 = this;
            this.ProCamera2D = val_8;
            this.NumericBoundaries = numericBoundaries;
            if(proCamera2D.Axis == 2)
            {
                goto label_2;
            }
            
            if(proCamera2D.Axis == 1)
            {
                goto label_3;
            }
            
            if(proCamera2D.Axis != 0)
            {
                    return;
            }
            
            val_10 = 22717300;
            val_11 = 536898149;
            if(((mem[536898336] & true) == 0) && (mem[536898265] == 0))
            {
                    val_11 = 536898149;
            }
            
            val_12 = mem[536898241];
            val_13 = mem[mem[536898241] + 4];
            val_13 = mem[536898241] + 4;
            if(val_13 == 0)
            {
                    if(((mem[536898336] & true) == 0) && (mem[536898265] == 0))
            {
                    val_12 = mem[536898241];
            }
            
                val_14 = mem[mem[536898241]];
                val_14 = val_12;
                val_13 = 536875575;
                val_13 = new System.Func<UnityEngine.Vector3, System.Single>(object:  val_14, method:  new IntPtr(1610684105));
                mem2[0] = val_13;
            }
            
            this.Vector3H = val_13;
            val_15 = 536898149;
            if(((mem[536898336] & true) == 0) && (mem[536898265] == 0))
            {
                    val_15 = 536898149;
            }
            
            val_16 = mem[536898241];
            val_17 = mem[mem[536898241] + 8];
            val_17 = mem[536898241] + 8;
            if(val_17 != 0)
            {
                goto label_34;
            }
            
            if(((mem[536898336] & true) == 0) && (mem[536898265] == 0))
            {
                    val_16 = mem[536898241];
            }
            
            val_14 = mem[mem[536898241]];
            val_14 = val_16;
            val_17 = 536875575;
            val_17 = new System.Func<UnityEngine.Vector3, System.Single>(object:  val_14, method:  new IntPtr(1610684107));
            mem2[0] = val_17;
            goto label_26;
            label_2:
            val_10 = 22717300;
            val_18 = 536898149;
            if(((mem[536898336] & true) == 0) && (mem[536898265] == 0))
            {
                    val_18 = 536898149;
            }
            
            val_19 = mem[536898241];
            val_20 = mem[mem[536898241] + 20];
            val_20 = mem[536898241] + 20;
            if(val_20 == 0)
            {
                    if(((mem[536898336] & true) == 0) && (mem[536898265] == 0))
            {
                    val_19 = mem[536898241];
            }
            
                val_14 = mem[mem[536898241]];
                val_14 = val_19;
                val_20 = 536875575;
                val_20 = new System.Func<UnityEngine.Vector3, System.Single>(object:  val_14, method:  new IntPtr(1610684113));
                mem2[0] = val_20;
            }
            
            this.Vector3H = val_20;
            val_21 = 536898149;
            if(((mem[536898336] & true) == 0) && (mem[536898265] == 0))
            {
                    val_21 = 536898149;
            }
            
            val_22 = mem[536898241];
            val_17 = mem[mem[536898241] + 24];
            val_17 = mem[536898241] + 24;
            if(val_17 != 0)
            {
                goto label_34;
            }
            
            if(((mem[536898336] & true) == 0) && (mem[536898265] == 0))
            {
                    val_22 = mem[536898241];
            }
            
            val_14 = mem[mem[536898241]];
            val_14 = val_22;
            val_17 = 536875575;
            val_17 = new System.Func<UnityEngine.Vector3, System.Single>(object:  val_14, method:  new IntPtr(1610684115));
            mem2[0] = val_17;
            goto label_26;
            label_3:
            val_10 = 22717300;
            val_23 = 536898149;
            if(((mem[536898336] & true) == 0) && (mem[536898265] == 0))
            {
                    val_23 = 536898149;
            }
            
            val_24 = mem[536898241];
            val_25 = mem[mem[536898241] + 12];
            val_25 = mem[536898241] + 12;
            if(val_25 == 0)
            {
                    if(((mem[536898336] & true) == 0) && (mem[536898265] == 0))
            {
                    val_24 = mem[536898241];
            }
            
                val_14 = mem[mem[536898241]];
                val_14 = val_24;
                val_25 = 536875575;
                val_25 = new System.Func<UnityEngine.Vector3, System.Single>(object:  val_14, method:  new IntPtr(1610684109));
                mem2[0] = val_25;
            }
            
            this.Vector3H = val_25;
            val_26 = 536898149;
            if(((mem[536898336] & true) == 0) && (mem[536898265] == 0))
            {
                    val_26 = 536898149;
            }
            
            val_27 = mem[536898241];
            val_17 = mem[mem[536898241] + 16];
            val_17 = mem[536898241] + 16;
            if(val_17 != 0)
            {
                goto label_34;
            }
            
            if(((mem[536898336] & true) == 0) && (mem[536898265] == 0))
            {
                    val_27 = mem[536898241];
            }
            
            val_14 = mem[mem[536898241]];
            val_14 = val_27;
            val_17 = 536875575;
            val_17 = new System.Func<UnityEngine.Vector3, System.Single>(object:  val_14, method:  new IntPtr(1610684111));
            mem2[0] = val_17;
            label_26:
            label_34:
            this.Vector3V = val_17;
        }
        public int GetAnimsCount()
        {
            var val_1;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2DNumericBoundaries val_2;
            val_1 = 1;
            if(this.UseLeftBoundary != true)
            {
                    val_1 = 0;
                if(this.NumericBoundaries.UseLeftBoundary == true)
            {
                    this.NumericBoundaries.UseLeftBoundary = this.UseRightBoundary;
            }
            
                if(this.NumericBoundaries.UseLeftBoundary != false)
            {
                    val_2 = this.NumericBoundaries;
                if(val_2 < 0)
            {
                    val_1 = 1;
            }
            
            }
            
            }
            
            if(this.UseRightBoundary != false)
            {
                    val_1 = val_1 + 1;
            }
            else
            {
                    val_2 = this.NumericBoundaries;
                if(this.NumericBoundaries.UseRightBoundary == true)
            {
                    this.NumericBoundaries.UseRightBoundary = this.UseLeftBoundary;
            }
            
                if(this.NumericBoundaries.UseRightBoundary != false)
            {
                    val_2 = this.NumericBoundaries;
                if(val_2 > 0)
            {
                    val_1 = val_1 + 1;
            }
            
            }
            
            }
            
            if(this.UseTopBoundary != false)
            {
                    val_1 = val_1 + 1;
            }
            else
            {
                    val_2 = this.NumericBoundaries;
                if(this.NumericBoundaries.UseTopBoundary == true)
            {
                    this.NumericBoundaries.UseTopBoundary = this.UseBottomBoundary;
            }
            
                if(this.NumericBoundaries.UseTopBoundary != false)
            {
                    val_2 = this.NumericBoundaries;
                if(val_2 > 0)
            {
                    val_1 = val_1 + 1;
            }
            
            }
            
            }
            
            if(this.UseBottomBoundary != false)
            {
                    val_1 = val_1 + 1;
                return (int)val_1;
            }
            
            val_2 = this.NumericBoundaries;
            if(this.NumericBoundaries.UseBottomBoundary == true)
            {
                    this.NumericBoundaries.UseBottomBoundary = this.UseTopBoundary;
            }
            
            if(this.NumericBoundaries.UseBottomBoundary == false)
            {
                    return (int)val_1;
            }
            
            val_2 = this.NumericBoundaries;
            if(val_2 < 0)
            {
                    val_1 = val_1 + 1;
            }
            
            return (int)val_1;
        }
        public void Transition()
        {
            var val_13;
            var val_14;
            UnityEngine.Coroutine val_15;
            UnityEngine.Coroutine val_16;
            UnityEngine.Coroutine val_17;
            UnityEngine.Coroutine val_18;
            UnityEngine.Coroutine val_19;
            var val_20;
            UnityEngine.Coroutine val_21;
            UnityEngine.Coroutine val_22;
            UnityEngine.Coroutine val_23;
            val_13 = this;
            val_14 = this;
            if((this.NumericBoundaries.HasFiredTransitionStarted != true) && (this.OnTransitionStarted != 0))
            {
                    this.NumericBoundaries.HasFiredTransitionStarted = true;
                this.OnTransitionStarted.Invoke();
            }
            
            this.NumericBoundaries.HasFiredTransitionFinished = false;
            this.NumericBoundaries.UseNumericBoundaries = true;
            if(this.UseLeftBoundary == false)
            {
                goto label_7;
            }
            
            this.NumericBoundaries.UseLeftBoundary = true;
            if(this.NumericBoundaries.LeftBoundaryAnimRoutine == 0)
            {
                goto label_10;
            }
            
            if(this.NumericBoundaries == 0)
            {
                goto label_11;
            }
            
            val_15 = this.NumericBoundaries.LeftBoundaryAnimRoutine;
            goto label_12;
            label_7:
            if(this.NumericBoundaries.UseLeftBoundary == true)
            {
                    this.NumericBoundaries.UseLeftBoundary = this.UseRightBoundary;
                goto label_14;
            }
            
            label_59:
            if(this.UseLeftBoundary == true)
            {
                goto label_17;
            }
            
            this.NumericBoundaries.UseLeftBoundary = false;
            goto label_17;
            label_11:
            val_15 = 4096;
            label_12:
            this.NumericBoundaries.StopCoroutine(routine:  4096);
            label_10:
            label_90:
            System.Collections.IEnumerator val_1 = this.LeftTransitionRoutine(duration:  null, turnOffBoundaryAfterwards:  this.TransitionDuration);
            if(this.NumericBoundaries != 0)
            {
                    UnityEngine.Coroutine val_2 = this.NumericBoundaries.StartCoroutine(routine:  983584624);
                val_16 = this.NumericBoundaries;
            }
            else
            {
                    UnityEngine.Coroutine val_3 = 0.StartCoroutine(routine:  983584624);
                val_16 = 0;
            }
            
            this.NumericBoundaries.LeftBoundaryAnimRoutine = val_16;
            label_17:
            if(this.UseRightBoundary == false)
            {
                goto label_20;
            }
            
            this.NumericBoundaries.UseRightBoundary = true;
            if(this.NumericBoundaries.RightBoundaryAnimRoutine == 0)
            {
                goto label_23;
            }
            
            if(this.NumericBoundaries == 0)
            {
                goto label_24;
            }
            
            val_17 = this.NumericBoundaries.RightBoundaryAnimRoutine;
            goto label_25;
            label_20:
            if(this.NumericBoundaries.UseRightBoundary == true)
            {
                    this.NumericBoundaries.UseRightBoundary = this.UseLeftBoundary;
                goto label_27;
            }
            
            label_67:
            if(this.UseRightBoundary == true)
            {
                goto label_30;
            }
            
            this.NumericBoundaries.UseRightBoundary = false;
            goto label_30;
            label_24:
            val_17 = 1;
            label_25:
            this.NumericBoundaries.StopCoroutine(routine:  1);
            label_23:
            label_91:
            System.Collections.IEnumerator val_4 = this.RightTransitionRoutine(duration:  null, turnOffBoundaryAfterwards:  this.TransitionDuration);
            if(this.NumericBoundaries != 0)
            {
                    UnityEngine.Coroutine val_5 = this.NumericBoundaries.StartCoroutine(routine:  983584624);
                val_16 = this.NumericBoundaries;
            }
            else
            {
                    UnityEngine.Coroutine val_6 = 0.StartCoroutine(routine:  983584624);
                val_16 = 0;
            }
            
            this.NumericBoundaries.RightBoundaryAnimRoutine = val_16;
            label_30:
            if(this.UseTopBoundary == false)
            {
                goto label_33;
            }
            
            this.NumericBoundaries.UseTopBoundary = true;
            if(this.NumericBoundaries.TopBoundaryAnimRoutine == 0)
            {
                goto label_36;
            }
            
            if(this.NumericBoundaries == 0)
            {
                goto label_37;
            }
            
            val_18 = this.NumericBoundaries.TopBoundaryAnimRoutine;
            goto label_38;
            label_33:
            if(this.NumericBoundaries.UseTopBoundary == true)
            {
                    this.NumericBoundaries.UseTopBoundary = this.UseBottomBoundary;
                goto label_40;
            }
            
            label_75:
            if(this.UseTopBoundary == true)
            {
                goto label_43;
            }
            
            this.NumericBoundaries.UseTopBoundary = false;
            goto label_43;
            label_37:
            val_18 = 22013840;
            label_38:
            this.NumericBoundaries.StopCoroutine(routine:  22013840);
            label_36:
            label_92:
            System.Collections.IEnumerator val_7 = this.TopTransitionRoutine(duration:  null, turnOffBoundaryAfterwards:  this.TransitionDuration);
            if(this.NumericBoundaries != 0)
            {
                    UnityEngine.Coroutine val_8 = this.NumericBoundaries.StartCoroutine(routine:  983584624);
                val_16 = this.NumericBoundaries;
            }
            else
            {
                    UnityEngine.Coroutine val_9 = 0.StartCoroutine(routine:  983584624);
                val_16 = 0;
            }
            
            this.NumericBoundaries.TopBoundaryAnimRoutine = val_16;
            label_43:
            if(this.UseBottomBoundary == false)
            {
                goto label_46;
            }
            
            this.NumericBoundaries.UseBottomBoundary = true;
            if(this.NumericBoundaries.BottomBoundaryAnimRoutine == 0)
            {
                goto label_49;
            }
            
            if(this.NumericBoundaries == 0)
            {
                goto label_50;
            }
            
            val_16 = this.NumericBoundaries.BottomBoundaryAnimRoutine;
            goto label_51;
            label_46:
            if(this.NumericBoundaries.UseBottomBoundary == true)
            {
                    this.NumericBoundaries.UseBottomBoundary = this.UseTopBoundary;
                goto label_53;
            }
            
            label_83:
            if(this.UseBottomBoundary == true)
            {
                    return;
            }
            
            this.NumericBoundaries.UseBottomBoundary = false;
            return;
            label_50:
            val_16 = 5;
            label_51:
            this.NumericBoundaries.StopCoroutine(routine:  5);
            label_49:
            label_93:
            System.Collections.IEnumerator val_10 = this.BottomTransitionRoutine(duration:  null, turnOffBoundaryAfterwards:  this.TransitionDuration);
            if(this.NumericBoundaries != 0)
            {
                    UnityEngine.Coroutine val_11 = this.NumericBoundaries.StartCoroutine(routine:  983584624);
                val_19 = this.NumericBoundaries;
            }
            else
            {
                    UnityEngine.Coroutine val_12 = 0.StartCoroutine(routine:  983584624);
                val_19 = 0;
            }
            
            this.NumericBoundaries.BottomBoundaryAnimRoutine = val_19;
            label_14:
            if((R4 + 60) >= 0)
            {
                goto label_59;
            }
            
            mem2[0] = 1;
            mem2[0] = 1;
            mem2[0] = R4 + 44;
            if((R4 + 60 + 112) == 0)
            {
                goto label_90;
            }
            
            if(R7 == 0)
            {
                goto label_64;
            }
            
            val_20 = mem[R7 + 112];
            val_20 = R7 + 112;
            goto label_65;
            label_27:
            if(this.NumericBoundaries <= 0)
            {
                goto label_67;
            }
            
            this.NumericBoundaries.UseRightBoundary = true;
            this.UseRightBoundary = true;
            this.RightBoundary = this.LeftBoundary;
            if(this.NumericBoundaries.RightBoundaryAnimRoutine == 0)
            {
                goto label_91;
            }
            
            if(this.NumericBoundaries == 0)
            {
                goto label_72;
            }
            
            val_21 = this.NumericBoundaries.RightBoundaryAnimRoutine;
            goto label_73;
            label_40:
            if(this.NumericBoundaries <= 0)
            {
                goto label_75;
            }
            
            this.NumericBoundaries.UseTopBoundary = true;
            this.UseTopBoundary = true;
            this.TopBoundary = this.BottomBoundary;
            if(this.NumericBoundaries.TopBoundaryAnimRoutine == 0)
            {
                goto label_92;
            }
            
            if(this.NumericBoundaries == 0)
            {
                goto label_80;
            }
            
            val_22 = this.NumericBoundaries.TopBoundaryAnimRoutine;
            goto label_81;
            label_53:
            if(this.NumericBoundaries >= 0)
            {
                goto label_83;
            }
            
            this.NumericBoundaries.UseBottomBoundary = true;
            this.UseBottomBoundary = true;
            this.BottomBoundary = this.TopBoundary;
            if(this.NumericBoundaries.BottomBoundaryAnimRoutine == 0)
            {
                goto label_93;
            }
            
            if(this.NumericBoundaries == 0)
            {
                goto label_88;
            }
            
            val_23 = this.NumericBoundaries.BottomBoundaryAnimRoutine;
            goto label_89;
            label_64:
            val_20 = 4096;
            label_65:
            R7.StopCoroutine(routine:  4096);
            goto label_90;
            label_72:
            val_21 = 1;
            label_73:
            this.NumericBoundaries.StopCoroutine(routine:  1);
            goto label_91;
            label_80:
            val_22 = 22013840;
            label_81:
            this.NumericBoundaries.StopCoroutine(routine:  22013840);
            goto label_92;
            label_88:
            val_23 = 5;
            label_89:
            this.NumericBoundaries.StopCoroutine(routine:  5);
            goto label_93;
        }
        private System.Collections.IEnumerator LeftTransitionRoutine(float duration, bool turnOffBoundaryAfterwards = False)
        {
            BoundariesAnimator.<LeftTransitionRoutine>d__19 val_1 = 536898155;
            val_1 = new BoundariesAnimator.<LeftTransitionRoutine>d__19(<>1__state:  0);
            if(val_1 != 0)
            {
                    22999073 = val_1;
                mem[536898171] = this;
                mem[536898175] = turnOffBoundaryAfterwards;
            }
            else
            {
                    mem[16] = this;
                mem[20] = turnOffBoundaryAfterwards;
            }
            
            mem[536898179] = R2;
        }
        private System.Collections.IEnumerator RightTransitionRoutine(float duration, bool turnOffBoundaryAfterwards = False)
        {
            BoundariesAnimator.<RightTransitionRoutine>d__20 val_1 = 536898157;
            val_1 = new BoundariesAnimator.<RightTransitionRoutine>d__20(<>1__state:  0);
            if(val_1 != 0)
            {
                    22999074 = val_1;
                mem[536898173] = this;
                mem[536898177] = turnOffBoundaryAfterwards;
            }
            else
            {
                    mem[16] = this;
                mem[20] = turnOffBoundaryAfterwards;
            }
            
            mem[536898181] = R2;
        }
        private System.Collections.IEnumerator TopTransitionRoutine(float duration, bool turnOffBoundaryAfterwards = False)
        {
            BoundariesAnimator.<TopTransitionRoutine>d__21 val_1 = 536898159;
            val_1 = new BoundariesAnimator.<TopTransitionRoutine>d__21(<>1__state:  0);
            if(val_1 != 0)
            {
                    22999075 = val_1;
                mem[536898175] = this;
                mem[536898179] = turnOffBoundaryAfterwards;
            }
            else
            {
                    mem[16] = this;
                mem[20] = turnOffBoundaryAfterwards;
            }
            
            mem[536898183] = R2;
        }
        private System.Collections.IEnumerator BottomTransitionRoutine(float duration, bool turnOffBoundaryAfterwards = False)
        {
            BoundariesAnimator.<BottomTransitionRoutine>d__22 val_1 = 536898153;
            val_1 = new BoundariesAnimator.<BottomTransitionRoutine>d__22(<>1__state:  0);
            if(val_1 != 0)
            {
                    22999076 = val_1;
                mem[536898169] = this;
                mem[536898173] = turnOffBoundaryAfterwards;
            }
            else
            {
                    mem[16] = this;
                mem[20] = turnOffBoundaryAfterwards;
            }
            
            mem[536898177] = R2;
        }
    
    }

}
