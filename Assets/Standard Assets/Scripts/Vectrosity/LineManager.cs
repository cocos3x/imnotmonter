using UnityEngine;

namespace Vectrosity
{
    public class LineManager : MonoBehaviour
    {
        // Fields
        private static System.Collections.Generic.List<Vectrosity.VectorLine> lines;
        private static System.Collections.Generic.List<UnityEngine.Transform> transforms;
        private static int lineCount;
        private bool destroyed;
        
        // Methods
        private void Awake()
        {
            this.Initialize();
        }
        private void Initialize()
        {
            var val_3;
            536878531 = new System.Collections.Generic.List<Page>();
            val_3 = 536889681;
            if(((mem[536889868] & true) == 0) && (mem[536889797] == 0))
            {
                    val_3 = 536889681;
            }
            
            mem2[0] = 536878531;
            536878437 = new System.Collections.Generic.List<Page>();
            mem2[0] = 536878437;
            mem2[0] = 0;
            this.enabled = false;
        }
        public void AddLine(Vectrosity.VectorLine vectorLine, UnityEngine.Transform thisTransform, float time)
        {
            Vectrosity.VectorLine val_6;
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            val_6 = vectorLine;
            System.Collections.IEnumerator val_1 = this.DisableLine(vectorLine:  val_6, time:  time, remove:  R3);
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  363670544);
            label_10:
            val_7 = 536889681;
            val_8 = mem[536889867] & 512;
            val_8 = 0;
            val_9 = mem[536889773];
            if(0 >= (mem[536889773] + 8))
            {
                goto label_5;
            }
            
            if(( != 0) && (mem[536889797] == 0))
            {
                    val_10 = mem[536889773];
            }
            
            if((mem[536889773] + 12) <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_4 = mem[536889773] + 8;
            val_4 = val_4 + 0;
            val_11 = 0 + 1;
            if(((mem[536889773] + 8 + 0) + 16) != val_6)
            {
                goto label_10;
            }
            
            return;
            label_5:
            if(( != 0) && (mem[536889797] == 0))
            {
                    val_12 = mem[536889773];
            }
            
            val_11 = mem[mem[536889773]];
            val_11 = val_12;
            val_11.Add(item:  val_6);
            val_6 = mem[mem[536889773] + 4];
            val_6 = mem[536889773] + 4;
            val_6.Add(item:  thisTransform);
            mem2[0] = (mem[536889773] + 8) + 1;
            if((mem[536889773] + 8) != 0)
            {
                    return;
            }
            
            this.enabled = true;
        }
        public void DisableLine(Vectrosity.VectorLine vectorLine, float time)
        {
            System.Collections.IEnumerator val_1 = this.DisableLine(vectorLine:  vectorLine, time:  time, remove:  false);
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  363794832);
        }
        private System.Collections.IEnumerator DisableLine(Vectrosity.VectorLine vectorLine, float time, bool remove)
        {
            Vectrosity.LineManager val_2 = this;
            LineManager.<DisableLine>d__8 val_1 = 536899575;
            val_1 = new LineManager.<DisableLine>d__8(<>1__state:  0);
            if(val_1 != 0)
            {
                    mem[536899599] = val_2;
                val_2 = val_1;
                mem[536899603] = vectorLine;
                mem[536899591] = remove;
            }
            else
            {
                    mem[24] = val_2;
                mem[28] = vectorLine;
                mem[16] = remove;
            }
            
            mem[536899595] = R3;
        }
        private void LateUpdate()
        {
            var val_5;
            UnityEngine.Object val_6;
            var val_7;
            var val_8;
            if(Vectrosity.VectorLine.camTransformExists == false)
            {
                    return;
            }
            
            val_5 = 0;
            goto label_4;
            label_21:
            if((mem[536889773] + 12) <= val_5)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_5 = mem[536889773] + 8;
            val_5 = val_5 + 0;
            UnityEngine.RectTransform val_2 = (mem[536889773] + 8 + 0) + 16.rectTransform;
            val_6 = (mem[536889773] + 8 + 0) + 16;
            if(val_6 != 0)
            {
                    val_7 = 536889681;
                if(((mem[536889868] & true) == 0) && (mem[536889797] == 0))
            {
                    val_7 = 536889681;
            }
            
                if((mem[536889773] + 12) <= val_5)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_6 = mem[536889773] + 8;
                val_6 = val_6 + 0;
                val_6 = mem[(mem[536889773] + 8 + 0) + 16];
                val_6 = (mem[536889773] + 8 + 0) + 16;
                val_6.Draw3D();
            }
            else
            {
                    this.RemoveLine(i:  0);
            }
            
            val_5 = 0;
            label_4:
            val_8 = 536889681;
            if(((mem[536889868] & true) == 0) && (mem[536889797] == 0))
            {
                    val_8 = 536889681;
            }
            
            if(val_5 < (mem[536889773] + 8))
            {
                goto label_21;
            }
            
            if(Vectrosity.VectorLine.CameraHasMoved() != false)
            {
                    Vectrosity.VectorManager.DrawArrayLines();
            }
            
            Vectrosity.VectorLine.UpdateCameraInfo();
            Vectrosity.VectorManager.DrawArrayLines2();
        }
        private void RemoveLine(int i)
        {
            if(((mem[536889868] & true) == 0) && (mem[536889797] == 0))
            {
                    536889681 = 536889681;
            }
            
            mem[536889773].RemoveAt(index:  i);
            mem[536889773] + 4.RemoveAt(index:  i);
            var val_1 = mem[536889773] + 8;
            val_1 = val_1 - 1;
            mem2[0] = val_1;
            this.DisableIfUnused();
        }
        public void RemoveLine(Vectrosity.VectorLine vectorLine)
        {
            var val_1;
            var val_2;
            val_1 = 0;
            goto label_1;
            label_9:
            if((mem[536889773] + 12) <= val_1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_1 = mem[536889773] + 8;
            val_1 = val_1 + 0;
            if(((mem[536889773] + 8 + 0) + 16) == vectorLine)
            {
                goto label_6;
            }
            
            val_1 = 1;
            label_1:
            val_2 = 536889681;
            if(((mem[536889868] & true) == 0) && (mem[536889797] == 0))
            {
                    val_2 = 536889681;
            }
            
            if(val_1 < (mem[536889773] + 8))
            {
                goto label_9;
            }
            
            return;
            label_6:
            this.RemoveLine(i:  0);
        }
        public void DisableIfUnused()
        {
            var val_2;
            var val_3;
            var val_4;
            if(this.destroyed == true)
            {
                    return;
            }
            
            val_2 = 536889681;
            if(((mem[536889868] & true) == 0) && (mem[536889797] == 0))
            {
                    val_2 = 536889681;
            }
            
            if((mem[536889773] + 8) != 0)
            {
                    return;
            }
            
            var val_1 = 12847059;
            val_1 = 10132072 + val_1;
            if(val_1 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_3 = 536896703;
            if(((mem[536896890] & true) == 0) && (mem[536896819] == 0))
            {
                    val_3 = 536896703;
            }
            
            if((mem[536896795] + 44) != 0)
            {
                    return;
            }
            
            var val_2 = 12846940;
            val_2 = 10132192 + val_2;
            if(val_2 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_4 = mem[R5];
            val_4 = R5;
            if((((R5 + 187) & 2) == 0) && ((R5 + 116) == 0))
            {
                    val_4 = mem[R5];
                val_4 = R5;
            }
            
            if((R5 + 92 + 56) != 0)
            {
                    return;
            }
            
            R4.enabled = false;
        }
        public void EnableIfUsed()
        {
            var val_1;
            var val_2;
            var val_3;
            val_1 = 10132704 + 12846427;
            if(val_1 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_2 = 536896703;
            if(((mem[536896890] & true) == 0) && (mem[536896819] == 0))
            {
                    val_2 = 536896703;
            }
            
            if((mem[536896795] + 44) != 1)
            {
                    val_1 = 10132824 + 12846308;
                if(val_1 == 0)
            {
                    mem2[0] = 1;
            }
            
                val_3 = 536896703;
                if(((mem[536896890] & true) == 0) && (mem[536896819] == 0))
            {
                    val_3 = 536896703;
            }
            
                if((mem[536896795] + 56) != 1)
            {
                    return;
            }
            
            }
            
            this.enabled = true;
        }
        public void StartCheckDistance()
        {
            if(((mem[536896890] & true) == 0) && (mem[536896819] == 0))
            {
                    536896703 = 536896703;
            }
            
            this.InvokeRepeating(methodName:  -1610609363, time:  null, repeatRate:  null);
        }
        private void CheckDistance()
        {
            Vectrosity.VectorManager.CheckDistance();
        }
        private void OnDestroy()
        {
            this.destroyed = true;
        }
        public LineManager()
        {
        
        }
        private static LineManager()
        {
        
        }
    
    }

}
