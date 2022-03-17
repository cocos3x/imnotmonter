using UnityEngine;

namespace Water2D
{
    public class MultiColorManager : MonoBehaviour
    {
        // Fields
        public static Water2D.MultiColorManager instance;
        private UnityEngine.Color[] _arrayColors;
        private float[] _arrayCutOffStroke;
        private UnityEngine.Texture2D _arrayTexture2DColors;
        private UnityEngine.Camera fresnelCamera;
        private ResizeQuadEffectController quadEffect;
        public MetaballParticleClass[] _allparticles;
        
        // Methods
        private static void Initialize(UnityEngine.Color _c)
        {
            var val_12;
            var val_13;
            float val_14;
            var val_15;
            val_12 = 22713552;
            if(mem[536890951] != 0)
            {
                    return;
            }
            
            UnityEngine.GameObject val_2 = UnityEngine.GameObject.Find(name:  -1610602575);
            if((-1610602575) != 0)
            {
                goto label_6;
            }
            
            T[] val_4 = UnityEngine.Object.FindObjectsOfType<Water2D.Water2D_Spawner>();
            val_13 = 0;
            goto label_9;
            label_15:
            UnityEngine.GameObject val_5 = mem[3221279059].gameObject;
            UnityEngine.Object.DestroyImmediate(obj:  mem[3221279059]);
            val_13 = 1;
            label_9:
            if(val_13 < mem[3221279055])
            {
                goto label_15;
            }
            
            label_6:
            if((-1610602575) == 0)
            {
                    536887303 = new UnityEngine.GameObject(name:  -1610602575);
                SynchronizationContextBehavoir val_8 = 536887303.AddComponent<SynchronizationContextBehavoir>();
                mem2[0] = 536887303;
                val_14 = _c.a;
                536887303.hideFlags = 1;
            }
            else
            {
                    val_14 = _c.a;
                if(mem[536890951] == 0)
            {
                    Weight val_10 = -1610602575.GetComponent<Weight>();
                mem2[0] = -1610602575;
            }
            
            }
            
            mem2[0] = 536881823;
            mem2[0] = 536882357;
            val_15 = 0;
            val_12 = 16025;
            val_12 = 1050253722;
            goto label_28;
            label_37:
            var val_11 = (mem[536890951] + 12) + 0;
            mem2[0] = _c.r;
            mem2[0] = _c.g;
            mem2[0] = _c.b;
            mem2[0] = val_14;
            mem2[0] = val_12;
            val_15 = 1;
            label_28:
            if(val_15 < (mem[536890951] + 12 + 12))
            {
                goto label_37;
            }
        
        }
        public static void SetFresnelColor(UnityEngine.Color StrokeColor)
        {
            var val_6;
            Water2D.MultiColorManager.Initialize(_c:  new UnityEngine.Color() {r = StrokeColor.r, g = StrokeColor.g, b = StrokeColor.b, a = StrokeColor.a});
            if((mem[536890951] + 24) == 0)
            {
                    UnityEngine.GameObject val_2 = UnityEngine.GameObject.Find(name:  -1610611591);
                Weight val_3 = -1610611591.GetComponent<Weight>();
                mem2[0] = -1610611591;
            }
            
            T[] val_4 = UnityEngine.Object.FindObjectsOfType<Water2D.Water2D_Spawner>();
            val_6 = 0;
            goto label_9;
            label_13:
            val_6 = 1;
            mem2[0] = StrokeColor.r;
            mem2[0] = StrokeColor.g;
            mem2[0] = StrokeColor.b;
            mem2[0] = StrokeColor.a;
            label_9:
            if(val_6 < mem[3221279071])
            {
                goto label_13;
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  mem[536890951] + 24)) == false)
            {
                    return;
            }
            
            mem[536890951] + 24.backgroundColor = new UnityEngine.Color() {r = StrokeColor.r, g = StrokeColor.g, b = StrokeColor.b, a = 0f};
        }
        public static void SetSorting(int sortingID)
        {
            UnityEngine.Color val_1 = UnityEngine.Color.white;
            Water2D.MultiColorManager.Initialize(_c:  new UnityEngine.Color());
            if((mem[536890951] + 28) == 0)
            {
                    UnityEngine.GameObject val_3 = UnityEngine.GameObject.Find(name:  -1610608585);
                Weight val_4 = -1610608585.GetComponent<Weight>();
                mem2[0] = -1610608585;
            }
            
            mem[536890951] + 28.SetSorting(id:  sortingID);
        }
        public static void SetColorScheme(int scheme, UnityEngine.Material material, UnityEngine.Color fillColor, UnityEngine.Color strokeColor, float AlphaCutoff, float AlphaStroke)
        {
            float val_1;
            float val_2;
            Water2D.MultiColorManager.Initialize(_c:  new UnityEngine.Color() {r = fillColor.r, g = fillColor.g, b = fillColor.b, a = fillColor.a});
            var val_3 = 1 + (scheme << 1);
            var val_4 = (mem[536890951] + 12) + (val_3 << 4);
            mem2[0] = fillColor.r;
            mem2[0] = fillColor.g;
            mem2[0] = fillColor.b;
            mem2[0] = fillColor.a;
            int val_5 = scheme << 1;
            val_5 = val_5 - 1;
            var val_6 = (mem[536890951] + 12) + (val_5 << 4);
            mem2[0] = strokeColor.r;
            mem2[0] = strokeColor.g;
            mem2[0] = strokeColor.b;
            mem2[0] = strokeColor.a;
            var val_7 = (mem[536890951] + 16) + (val_3 << 2);
            mem2[0] = val_2;
            var val_8 = (mem[536890951] + 16) + (val_5 << 2);
            mem2[0] = val_1;
            material.SetColorArray(name:  -1610601923, values:  mem[536890951] + 12);
            material.SetFloatArray(name:  -1610601919, values:  mem[536890951] + 16);
        }
        public static void SetColorSchemeURP(int scheme, UnityEngine.Material material, UnityEngine.Color fillColor, UnityEngine.Color strokeColor, float AlphaCutoff, float AlphaStroke)
        {
            var val_5;
            Water2D.MultiColorManager.Initialize(_c:  new UnityEngine.Color() {r = fillColor.r, g = fillColor.g, b = fillColor.b, a = fillColor.a});
            if((mem[536890951] + 20) != 0)
            {
                    val_5 = 0;
                mem[536890951] + 20.filterMode = 0;
                mem[536890951] + 20.SetPixel(x:  0, y:  1 + (scheme << 1), color:  new UnityEngine.Color() {r = fillColor.r, g = fillColor.g, b = fillColor.b, a = fillColor.a});
                mem[536890951] + 20.SetPixel(x:  0, y:  0 + (scheme << 1), color:  new UnityEngine.Color() {r = strokeColor.r, g = strokeColor.g, b = strokeColor.b, a = strokeColor.a});
            }
            else
            {
                    val_5 = 0;
                0.filterMode = 0;
                0.SetPixel(x:  0, y:  1 + (scheme << 1), color:  new UnityEngine.Color() {r = fillColor.r, g = fillColor.g, b = fillColor.b, a = fillColor.a});
                0.SetPixel(x:  0, y:  0 + (scheme << 1), color:  new UnityEngine.Color() {r = strokeColor.r, g = strokeColor.g, b = strokeColor.b, a = strokeColor.a});
            }
            
            mem[536890951] + 20.Apply();
            mem2[0] = mem[536890951] + 20;
            material.SetTexture(name:  -1610602019, value:  mem[536890951] + 20);
        }
        public static MetaballParticleClass[] GetAllParticles()
        {
            if(mem[536890951] == 0)
            {
                    UnityEngine.Color val_2 = UnityEngine.Color.white;
                Water2D.MultiColorManager.Initialize(_c:  new UnityEngine.Color());
            }
            
            mem[536890951].fetchAllParticles();
            if(mem[536890951] != 0)
            {
                    return;
            }
        
        }
        public void fetchAllParticles()
        {
            UnityEngine.Color val_1 = UnityEngine.Color.white;
            Water2D.MultiColorManager.Initialize(_c:  new UnityEngine.Color());
            T[] val_2 = UnityEngine.Object.FindObjectsOfType<Water2D.Water2D_Spawner>();
            this._allparticles = -1073688255;
        }
        public MultiColorManager()
        {
        
        }
    
    }

}
