using UnityEngine;

namespace Vectrosity
{
    public class VectorManager
    {
        // Fields
        public static float minBrightnessDistance;
        public static float maxBrightnessDistance;
        private static int brightnessLevels;
        public static float distanceCheckFrequency;
        private static UnityEngine.Color fogColor;
        public static bool useDraw3D;
        private static System.Collections.Generic.List<Vectrosity.VectorLine> vectorLines;
        private static System.Collections.Generic.List<Vectrosity.RefInt> objectNumbers;
        public static int _arrayCount;
        private static System.Collections.Generic.List<Vectrosity.VectorLine> vectorLines2;
        private static System.Collections.Generic.List<Vectrosity.RefInt> objectNumbers2;
        private static int _arrayCount2;
        private static System.Collections.Generic.List<UnityEngine.Transform> transforms3;
        private static System.Collections.Generic.List<Vectrosity.VectorLine> vectorLines3;
        private static System.Collections.Generic.List<int> oldDistances;
        private static System.Collections.Generic.List<UnityEngine.Color> colors;
        private static System.Collections.Generic.List<Vectrosity.RefInt> objectNumbers3;
        private static int _arrayCount3;
        private static System.Collections.Generic.Dictionary<string, UnityEngine.Mesh> meshTable;
        
        // Properties
        public static int arrayCount { get; }
        public static int arrayCount2 { get; }
        
        // Methods
        public static void SetBrightnessParameters(float fadeOutDistance, float fullBrightDistance, int levels, float frequency, UnityEngine.Color color)
        {
            var val_1;
            var val_2;
            var val_3;
            var val_6;
            var val_7;
            var val_8;
            val_6 = levels;
            val_7 = val_1;
            val_8 = 536896703;
            if(((mem[536896890] & true) == 0) && (mem[536896819] == 0))
            {
                    val_6 = val_7;
                val_8 = 536896703;
                val_7 = val_6;
            }
            
            mem2[0] = val_6 * val_6;
            mem2[0] = color.r * color.r;
            mem2[0] = color.g;
            mem2[0] = color.b;
            mem2[0] = color.a;
            mem2[0] = val_3;
            mem2[0] = val_2;
            mem2[0] = val_7;
        }
        public static float GetBrightnessValue(UnityEngine.Vector3 pos)
        {
            var val_3;
            var val_4;
            var val_5;
            var val_9;
            if(Vectrosity.VectorLine.camTransformExists != true)
            {
                    Vectrosity.VectorLine.SetCamera3D();
            }
            
            val_9 = 536896703;
            if(((mem[536896890] & true) == 0) && (mem[536896819] == 0))
            {
                    val_9 = 536896703;
            }
            
            UnityEngine.Vector3 val_2 = Vectrosity.VectorLine.camTransformPosition;
            float val_10 = pos.x;
            float val_9 = pos.y;
            val_9 = val_9 - val_4;
            val_10 = val_10 - val_3;
            float val_6 = pos.z - val_5;
            return (float)UnityEngine.Mathf.InverseLerp(a:  val_10.sqrMagnitude, b:  val_2.y, value:  val_9);
        }
        public static void ObjectSetup(UnityEngine.GameObject go, Vectrosity.VectorLine line, Vectrosity.Visibility visibility, Vectrosity.Brightness brightness)
        {
            Vectrosity.VectorManager.ObjectSetup(go:  go, line:  line, visibility:  visibility, brightness:  brightness, makeBounds:  true);
        }
        public static void ObjectSetup(UnityEngine.GameObject go, Vectrosity.VectorLine line, Vectrosity.Visibility visibility, Vectrosity.Brightness brightness, bool makeBounds)
        {
            var val_40;
            var val_41;
            var val_42;
            var val_43;
            var val_44;
            var val_45;
            var val_46;
            Vectrosity.Visibility val_47;
            var val_48;
            var val_49;
            Vectrosity.Brightness val_50;
            var val_51;
            var val_52;
            Vectrosity.VectorLine val_53;
            var val_54;
            val_40 = 0;
            System.Type val_1 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(1073767707)});
            UnityEngine.Component val_2 = go.GetComponent(type:  1073767707);
            if(go != 0)
            {
                    if(((UnityEngine.GameObject.__il2cppRuntimeField_typeHierarchy + (mem[536896975]) << 2) + -4) != 536896795)
            {
                    go = 0;
            }
            
                val_40 = go;
            }
            
            val_41 = 0;
            System.Type val_3 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(1073767713)});
            UnityEngine.Component val_4 = go.GetComponent(type:  1073767713);
            if(go != 0)
            {
                    if(((UnityEngine.GameObject.__il2cppRuntimeField_typeHierarchy + (mem[536896981]) << 2) + -4) != 536896801)
            {
                    go = 0;
            }
            
                val_41 = go;
            }
            
            System.Type val_5 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(1073767711)});
            UnityEngine.Component val_6 = go.GetComponent(type:  1073767711);
            if(go != 0)
            {
                    if(((UnityEngine.GameObject.__il2cppRuntimeField_typeHierarchy + (mem[536896979]) << 2) + -4) != 536896799)
            {
                    go = 0;
            }
            
            }
            
            val_42 = 0;
            System.Type val_7 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(1073755229)});
            UnityEngine.Component val_8 = go.GetComponent(type:  1073755229);
            if(go != 0)
            {
                    if(((UnityEngine.GameObject.__il2cppRuntimeField_typeHierarchy + (mem[536884497]) << 2) + -4) != 536884317)
            {
                    go = 0;
            }
            
                val_42 = go;
            }
            
            System.Type val_9 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(1073761355)});
            val_43 = 0;
            UnityEngine.Component val_10 = go.GetComponent(type:  1073761355);
            if(go != 0)
            {
                    if(null != 536890443)
            {
                    go = 0;
            }
            
                val_43 = go;
            }
            
            if(0 == 0)
            {
                    SynchronizationContextBehavoir val_12 = go.AddComponent<SynchronizationContextBehavoir>();
            }
            
            System.Type val_13 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(1073761375)});
            val_44 = 0;
            UnityEngine.Component val_14 = go.GetComponent(type:  1073761375);
            val_45 = 22713552;
            if(go != 0)
            {
                    if(((UnityEngine.GameObject.__il2cppRuntimeField_typeHierarchy + (mem[536890643]) << 2) + -4) != 536890463)
            {
                    go = 0;
            }
            
                val_44 = go;
            }
            
            val_46 = val_41;
            val_47 = visibility;
            val_48 = val_40;
            if(0 == 0)
            {
                    SynchronizationContextBehavoir val_16 = go.AddComponent<SynchronizationContextBehavoir>();
            }
            
            if(val_47 == 2)
            {
                goto label_30;
            }
            
            if(val_47 == 1)
            {
                goto label_31;
            }
            
            if(val_47 != 0)
            {
                goto label_32;
            }
            
            val_49 = go;
            if((UnityEngine.Object.op_Implicit(exists:  0)) != false)
            {
                    mem[21] = 1;
                UnityEngine.Object.Destroy(obj:  0);
                Vectrosity.VectorManager.ResetLinePoints(vcs:  0, line:  line);
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  0)) != false)
            {
                    mem[21] = 1;
                UnityEngine.Object.Destroy(obj:  0);
            }
            
            if(0 != 0)
            {
                goto label_104;
            }
            
            System.Type val_20 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(1073767707)});
            val_48 = 0;
            UnityEngine.Component val_21 = go.AddComponent(componentType:  1073767707);
            val_45 = 22713552;
            val_48.Setup(line:  line, makeBounds:  makeBounds);
            goto label_80;
            label_30:
            val_49 = go;
            if((UnityEngine.Object.op_Implicit(exists:  0)) != false)
            {
                    mem[21] = 1;
                UnityEngine.Object.Destroy(obj:  0);
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  0)) != false)
            {
                    mem[21] = 1;
                UnityEngine.Object.Destroy(obj:  0);
                Vectrosity.VectorManager.ResetLinePoints(vcs:  0, line:  line);
            }
            
            if(0 != 0)
            {
                goto label_104;
            }
            
            System.Type val_25 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(1073767711)});
            val_49 = 0;
            UnityEngine.Component val_26 = go.AddComponent(componentType:  1073767711);
            val_45 = 22713552;
            val_49.Setup(line:  line);
            goto label_80;
            label_31:
            val_49 = go;
            if((UnityEngine.Object.op_Implicit(exists:  0)) != false)
            {
                    mem[21] = 1;
                UnityEngine.Object.Destroy(obj:  0);
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  0)) != false)
            {
                    mem[21] = 1;
                UnityEngine.Object.Destroy(obj:  0);
            }
            
            if(0 != 0)
            {
                goto label_104;
            }
            
            System.Type val_30 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(1073767713)});
            val_46 = 0;
            UnityEngine.Component val_31 = go.AddComponent(componentType:  1073767713);
            val_45 = 22713552;
            val_46.Setup(line:  line, makeBounds:  makeBounds);
            label_80:
            if(0 != 0)
            {
                    mem[20] = 0;
            }
            
            label_104:
            val_50 = brightness;
            goto label_106;
            label_32:
            val_50 = brightness;
            val_49 = go;
            label_106:
            var val_40 = mem[536891407];
            val_40 = val_40 & 512;
            if(val_50 != 0)
            {
                    if((UnityEngine.Object.op_Implicit(exists:  0)) == false)
            {
                    return;
            }
            
                UnityEngine.Object.Destroy(obj:  0);
                return;
            }
            
            if(0 != 0)
            {
                    return;
            }
            
            val_51 = 0;
            System.Type val_35 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(1073755229)});
            UnityEngine.Component val_36 = go.AddComponent(componentType:  1073755229);
            if(go != 0)
            {
                    val_52 = 22713552;
                if(((UnityEngine.GameObject.__il2cppRuntimeField_typeHierarchy + (mem[536884497]) << 2) + -4) != 536884317)
            {
                    go = 0;
            }
            
                val_51 = go;
            }
            else
            {
                    val_52 = 22713552;
            }
            
            if(((0 == 0) && (0 == 0)) && (0 == 0))
            {
                    val_53 = line;
                val_54 = 1;
            }
            else
            {
                    val_53 = line;
                val_54 = 0;
            }
            
            val_51.Setup(line:  val_53, m_useLine:  false);
        }
        private static void ResetLinePoints(Vectrosity.VisibilityControlStatic vcs, Vectrosity.VectorLine line)
        {
            var val_5;
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            UnityEngine.Matrix4x4 val_1 = inverse;
            val_6 = 0;
            val_8 = 0;
            goto label_2;
            label_10:
            if(val_1.m22 != 0f)
            {
                    val_9 = val_1.m22;
            }
            else
            {
                    val_9 = 0;
            }
            
            var val_5 = val_1.m22 + 8;
            float val_2 = val_1.m32 - 96;
            val_5 = val_5 + val_6;
            mem2[0] = (val_1.m22 + 8 + val_6) + 24;
            mem2[0] = 0;
            float val_3 = val_1.m13 + 8;
            val_7 = mem[val_1.m13 + 8];
            val_7 = val_1.m13 + 8;
            val_5 = mem[val_1.m13 + 16];
            val_5 = val_1.m13 + 16;
            mem2[0] = val_5;
            mem2[0] = -1073711317;
            val_6 = 12;
            val_8 = 1;
            label_2:
            if(val_8 < (val_1.m22 + 12))
            {
                goto label_10;
            }
            
            float val_4 = val_1.m32 - 28;
        }
        public static int get_arrayCount()
        {
            if((mem[536896890] & true) != 0)
            {
                    return (int)mem[536896795] + 44;
            }
            
            if(mem[536896819] != 0)
            {
                    return (int)mem[536896795] + 44;
            }
            
            536896703 = 536896703;
            return (int)mem[536896795] + 44;
        }
        public static void VisibilityStaticSetup(Vectrosity.VectorLine line, out Vectrosity.RefInt objectNum)
        {
            var val_5;
            var val_6;
            var val_7;
            val_5 = 536896703;
            if(((mem[536896890] & true) == 0) && (mem[536896819] == 0))
            {
                    val_5 = 536896703;
            }
            
            if((mem[536896795] + 36) == 0)
            {
                    536878531 = new System.Collections.Generic.List<Page>();
                val_6 = 536896703;
                if(((mem[536896890] & true) == 0) && (mem[536896819] == 0))
            {
                    val_6 = 536896703;
            }
            
                mem2[0] = 536878531;
                536878233 = new System.Collections.Generic.List<Page>();
                mem2[0] = 536878233;
            }
            
            line.m_drawTransform = 0;
            val_7 = 536896703;
            if(((mem[536896890] & true) == 0) && (mem[536896819] == 0))
            {
                    val_7 = 536896703;
            }
            
            mem[536896795] + 36.Add(item:  line);
            mem2[0] = (mem[536896795] + 44) + 1;
            Vectrosity.RefInt val_4 = 536892611;
            val_4 = new Vectrosity.RefInt(value:  mem[536896795] + 44);
            objectNum = val_4;
            mem[536896795] + 40.Add(item:  536892611);
            Vectrosity.VectorLine.LineManagerEnable();
        }
        public static void VisibilityStaticRemove(int objectNumber)
        {
            var val_5;
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            val_5 = 536896703;
            if(((mem[536896890] & true) == 0) && (mem[536896819] == 0))
            {
                    val_5 = 536896703;
            }
            
            if((mem[536896795] + 36 + 12) <= objectNumber)
            {
                goto label_4;
            }
            
            val_6 = objectNumber + 5;
            goto label_5;
            label_15:
            if((mem[536896795] + 40 + 12) <= R7)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_7 = mem[mem[536896795] + 40 + 8 + ((objectNumber + 5)) << 2];
            val_7 = mem[536896795] + 40 + 8 + ((objectNumber + 5)) << 2;
            if(val_7 != 0)
            {
                    val_8 = mem[mem[536896795] + 40 + 8 + ((objectNumber + 5)) << 2 + 8];
                val_8 = mem[536896795] + 40 + 8 + ((objectNumber + 5)) << 2 + 8;
            }
            else
            {
                    val_7 = 8;
                val_8 = 0;
            }
            
            val_6 = val_6 + 1;
            mem[8] = val_8 - 1;
            label_5:
            val_9 = 536896703;
            val_10 = mem[536896889] & 512;
            if(val_7 == 0)
            {
                    val_10 = 0;
            }
            else
            {
                    if(mem[536896819] == 0)
            {
                    val_9 = 536896703;
                val_10 = mem[536896889] & 512;
            }
            
            }
            
            val_11 = mem[536896795];
            if((val_6 - 4) < (mem[536896795] + 44))
            {
                goto label_15;
            }
            
            if((val_10 != 0) && (mem[536896819] == 0))
            {
                    val_11 = mem[536896795];
            }
            
            mem[536896795] + 36.RemoveAt(index:  objectNumber);
            mem[536896795] + 40.RemoveAt(index:  objectNumber);
            var val_3 = mem[536896795] + 44;
            val_3 = val_3 - 1;
            mem2[0] = val_3;
            Vectrosity.VectorLine.LineManagerDisable();
            return;
            label_4:
            UnityEngine.Debug.LogError(message:  -1610602665);
        }
        public static int get_arrayCount2()
        {
            if((mem[536896890] & true) != 0)
            {
                    return (int)mem[536896795] + 56;
            }
            
            if(mem[536896819] != 0)
            {
                    return (int)mem[536896795] + 56;
            }
            
            536896703 = 536896703;
            return (int)mem[536896795] + 56;
        }
        public static void VisibilitySetup(UnityEngine.Transform thisTransform, Vectrosity.VectorLine line, out Vectrosity.RefInt objectNum)
        {
            System.Collections.Generic.List<Page> val_5;
            var val_6;
            var val_7;
            var val_8;
            val_5 = 22987812;
            val_6 = 536896703;
            if(((mem[536896890] & true) == 0) && (mem[536896819] == 0))
            {
                    val_6 = 536896703;
            }
            
            if((mem[536896795] + 48) == 0)
            {
                    536878531 = new System.Collections.Generic.List<Page>();
                val_7 = 536896703;
                if(((mem[536896890] & true) == 0) && (mem[536896819] == 0))
            {
                    val_7 = 536896703;
            }
            
                mem2[0] = 536878531;
                val_5 = 536878233;
                val_5 = new System.Collections.Generic.List<Page>();
                mem2[0] = val_5;
            }
            
            line.m_drawTransform = thisTransform;
            val_8 = 536896703;
            if(((mem[536896890] & true) == 0) && (mem[536896819] == 0))
            {
                    val_8 = 536896703;
            }
            
            mem[536896795] + 48.Add(item:  line);
            mem2[0] = (mem[536896795] + 56) + 1;
            Vectrosity.RefInt val_4 = 536892611;
            val_4 = new Vectrosity.RefInt(value:  mem[536896795] + 56);
            objectNum = val_4;
            mem[536896795] + 52.Add(item:  536892611);
            Vectrosity.VectorLine.LineManagerEnable();
        }
        public static void VisibilityRemove(int objectNumber)
        {
            var val_5;
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            val_5 = 536896703;
            if(((mem[536896890] & true) == 0) && (mem[536896819] == 0))
            {
                    val_5 = 536896703;
            }
            
            if((mem[536896795] + 48 + 12) <= objectNumber)
            {
                goto label_4;
            }
            
            val_6 = objectNumber + 5;
            goto label_5;
            label_15:
            if((mem[536896795] + 52 + 12) <= R7)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_7 = mem[mem[536896795] + 52 + 8 + ((objectNumber + 5)) << 2];
            val_7 = mem[536896795] + 52 + 8 + ((objectNumber + 5)) << 2;
            if(val_7 != 0)
            {
                    val_8 = mem[mem[536896795] + 52 + 8 + ((objectNumber + 5)) << 2 + 8];
                val_8 = mem[536896795] + 52 + 8 + ((objectNumber + 5)) << 2 + 8;
            }
            else
            {
                    val_7 = 8;
                val_8 = 0;
            }
            
            val_6 = val_6 + 1;
            mem[8] = val_8 - 1;
            label_5:
            val_9 = 536896703;
            val_10 = mem[536896889] & 512;
            if(val_7 == 0)
            {
                    val_10 = 0;
            }
            else
            {
                    if(mem[536896819] == 0)
            {
                    val_9 = 536896703;
                val_10 = mem[536896889] & 512;
            }
            
            }
            
            val_11 = mem[536896795];
            if((val_6 - 4) < (mem[536896795] + 56))
            {
                goto label_15;
            }
            
            if((val_10 != 0) && (mem[536896819] == 0))
            {
                    val_11 = mem[536896795];
            }
            
            mem[536896795] + 48.RemoveAt(index:  objectNumber);
            mem[536896795] + 52.RemoveAt(index:  objectNumber);
            var val_3 = mem[536896795] + 56;
            val_3 = val_3 - 1;
            mem2[0] = val_3;
            Vectrosity.VectorLine.LineManagerDisable();
            return;
            label_4:
            UnityEngine.Debug.LogError(message:  -1610602667);
        }
        public static void CheckDistanceSetup(UnityEngine.Transform thisTransform, Vectrosity.VectorLine line, UnityEngine.Color color, Vectrosity.RefInt objectNum)
        {
            var val_7;
            var val_8;
            var val_9;
            Vectrosity.VectorLine.LineManagerEnable();
            val_7 = 536896703;
            if(((mem[536896890] & true) == 0) && (mem[536896819] == 0))
            {
                    val_7 = 536896703;
            }
            
            if((mem[536896795] + 64) == 0)
            {
                    536878531 = new System.Collections.Generic.List<Page>();
                val_8 = 536896703;
                if(((mem[536896890] & true) == 0) && (mem[536896819] == 0))
            {
                    val_8 = 536896703;
            }
            
                mem2[0] = 536878531;
                536878437 = new System.Collections.Generic.List<Page>();
                mem2[0] = 536878437;
                536877987 = new System.Collections.Generic.List<System.Int32>();
                mem2[0] = 536877987;
                536877805 = new System.Collections.Generic.List<UnityEngine.Color>();
                mem2[0] = 536877805;
                536878233 = new System.Collections.Generic.List<Page>();
                mem2[0] = 536878233;
                Vectrosity.VectorLine.LineManagerCheckDistance();
                val_7 = 536896703;
            }
            
            if(((mem[536896890] & true) == 0) && (mem[536896819] == 0))
            {
                    val_7 = 536896703;
            }
            
            mem[536896795] + 60.Add(item:  thisTransform);
            mem[536896795] + 64.Add(item:  line);
            mem[536896795] + 68.Add(item:  0);
            mem[536896795] + 72.Add(item:  new UnityEngine.Color() {r = color.r, g = color.g, b = color.b, a = color.a});
            val_9 = 536896703;
            mem2[0] = (mem[536896795] + 80) + 1;
            if(objectNum == 0)
            {
                    val_9 = 536896795;
            }
            
            objectNum.i = mem[536896795] + 80;
            mem[536896795] + 76.Add(item:  objectNum);
        }
        public static void DistanceRemove(int objectNumber)
        {
            var val_5;
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            val_5 = 536896703;
            if(((mem[536896890] & true) == 0) && (mem[536896819] == 0))
            {
                    val_5 = 536896703;
            }
            
            if((mem[536896795] + 64 + 12) <= objectNumber)
            {
                goto label_4;
            }
            
            val_6 = objectNumber + 5;
            goto label_5;
            label_15:
            if((mem[536896795] + 76 + 12) <= R7)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_7 = mem[mem[536896795] + 76 + 8 + ((objectNumber + 5)) << 2];
            val_7 = mem[536896795] + 76 + 8 + ((objectNumber + 5)) << 2;
            if(val_7 != 0)
            {
                    val_8 = mem[mem[536896795] + 76 + 8 + ((objectNumber + 5)) << 2 + 8];
                val_8 = mem[536896795] + 76 + 8 + ((objectNumber + 5)) << 2 + 8;
            }
            else
            {
                    val_7 = 8;
                val_8 = 0;
            }
            
            val_6 = val_6 + 1;
            mem[8] = val_8 - 1;
            label_5:
            val_9 = 536896703;
            val_10 = mem[536896889] & 512;
            if(val_7 == 0)
            {
                    val_10 = 0;
            }
            else
            {
                    if(mem[536896819] == 0)
            {
                    val_9 = 536896703;
                val_10 = mem[536896889] & 512;
            }
            
            }
            
            val_11 = mem[536896795];
            if((val_6 - 4) < (mem[536896795] + 80))
            {
                goto label_15;
            }
            
            if((val_10 != 0) && (mem[536896819] == 0))
            {
                    val_11 = mem[536896795];
            }
            
            mem[536896795] + 60.RemoveAt(index:  objectNumber);
            mem[536896795] + 64.RemoveAt(index:  objectNumber);
            mem[536896795] + 68.RemoveAt(index:  objectNumber);
            mem[536896795] + 72.RemoveAt(index:  objectNumber);
            mem[536896795] + 76.RemoveAt(index:  objectNumber);
            var val_3 = mem[536896795] + 80;
            val_3 = val_3 - 1;
            mem2[0] = val_3;
            return;
            label_4:
            UnityEngine.Debug.LogError(message:  -1610602669);
        }
        public static void CheckDistance()
        {
            var val_1;
            var val_2;
            val_1 = 0;
            goto label_1;
            label_6:
            Vectrosity.VectorManager.SetDistanceColor(i:  0);
            val_1 = 1;
            label_1:
            val_2 = 536896703;
            if(((mem[536896890] & true) == 0) && (mem[536896819] == 0))
            {
                    val_2 = 536896703;
            }
            
            if(val_1 < (mem[536896795] + 80))
            {
                goto label_6;
            }
        
        }
        public static void SetOldDistance(int objectNumber, int val)
        {
            if(((mem[536896890] & true) == 0) && (mem[536896819] == 0))
            {
                    536896703 = 536896703;
            }
            
            mem[536896795] + 68.set_Item(index:  objectNumber, value:  val);
        }
        public static void SetDistanceColor(int i)
        {
            var val_6;
            var val_7;
            var val_8;
            int val_9;
            var val_10;
            float val_11;
            float val_12;
            float val_13;
            var val_14;
            val_6 = 22716508;
            val_7 = 536896703;
            if(((mem[536896890] & true) == 0) && (mem[536896819] == 0))
            {
                    val_7 = 536896703;
            }
            
            if((mem[536896795] + 64 + 12) <= i)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_6 = mem[536896795] + 64 + 8;
            val_6 = val_6 + (i << 2);
            if(((mem[536896795] + 64 + 8 + (i) << 2) + 16 + 100) == 0)
            {
                    return;
            }
            
            val_8 = 536896703;
            if(((mem[536896890] & true) == 0) && (mem[536896819] == 0))
            {
                    val_8 = 536896703;
            }
            
            if((mem[536896795] + 60 + 12) <= i)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_7 = mem[536896795] + 60 + 8;
            val_7 = val_7 + (i << 2);
            UnityEngine.Vector3 val_1 = position;
            float val_2 = Vectrosity.VectorManager.GetBrightnessValue(pos:  new UnityEngine.Vector3());
            float val_8 = (float)mem[536896795] + 8;
            val_8 = R0 * val_8;
            val_9 = (int)val_8;
            if((mem[536896795] + 68 + 12) <= i)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_9 = mem[536896795] + 68 + 8;
            val_9 = val_9 + (i << 2);
            if(((mem[536896795] + 68 + 8 + (i) << 2) + 16) != val_9)
            {
                    val_10 = 536896703;
                if(((mem[536896890] & true) == 0) && (mem[536896819] == 0))
            {
                    val_10 = 536896703;
            }
            
                if((mem[536896795] + 64 + 12) <= i)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_10 = mem[536896795] + 64 + 8;
                val_10 = val_10 + (i << 2);
                var val_3 = mem[536896795] + 16;
                if((mem[536896795] + 72) == 0)
            {
                    val_13 = mem[(mem[536896795] + 16) + (8)];
                val_12 = mem[(mem[536896795] + 16) + (0)];
                val_11 = mem[(mem[536896795] + 16) + (4)];
            }
            
                if((mem[536896795] + 72 + 12) <= i)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_13 = val_13;
                val_12 = val_12;
                val_11 = val_11;
            }
            
                var val_11 = mem[536896795] + 72 + 8;
                val_11 = val_11 + (i << 4);
                UnityEngine.Color val_4 = UnityEngine.Color.Lerp(a:  new UnityEngine.Color() {r = 9.889457E-24f, g = val_12, b = val_11, a = val_13}, b:  new UnityEngine.Color() {r = mem[(mem[536896795] + 16) + (12)], g = (mem[536896795] + 72 + 8 + (i) << 4) + 16, b = (mem[536896795] + 72 + 8 + (i) << 4) + 20, a = (mem[536896795] + 72 + 8 + (i) << 4) + 24}, t:  val_8);
                UnityEngine.Color32 val_5 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color());
                (mem[536896795] + 64 + 8 + (i) << 2) + 16.SetColor(color:  new UnityEngine.Color32() {r = val_5.r, g = val_5.g, b = val_5.b, a = val_5.a});
                val_6 = 22716508;
                val_9 = val_9;
            }
            
            if(((mem[536896890] & true) == 0) && (mem[536896819] == 0))
            {
                    val_14 = 536896703;
            }
            
            mem[536896795] + 68.set_Item(index:  i, value:  val_9);
        }
        public static void DrawArrayLine(int i)
        {
            var val_2;
            var val_3;
            var val_4;
            var val_5;
            var val_6;
            val_2 = 0;
            val_3 = 536896703;
            var val_1 = mem[536896889];
            val_1 = val_1 & 512;
            if(mem[536896819] != 0)
            {
                    val_2 = val_1;
            }
            else
            {
                    val_3 = 536896703;
                val_2 = mem[536896889] & 512;
            }
            
            val_4 = mem[536896795];
            if((mem[536896795] + 32) != 0)
            {
                    if((val_2 != 0) && (mem[536896819] == 0))
            {
                    val_5 = mem[536896795];
            }
            
                if((mem[536896795] + 36 + 12) <= i)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_2 = mem[536896795] + 36 + 8;
                val_2 = val_2 + (i << 2);
                (mem[536896795] + 36 + 8 + (i) << 2) + 16.Draw3D();
                return;
            }
            
            if((val_2 != 0) && (mem[536896819] == 0))
            {
                    val_6 = mem[536896795];
            }
            
            if((mem[536896795] + 36 + 12) <= i)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_3 = mem[536896795] + 36 + 8;
            val_3 = val_3 + (i << 2);
            (mem[536896795] + 36 + 8 + (i) << 2) + 16.Draw();
        }
        public static void DrawArrayLine2(int i)
        {
            var val_2;
            var val_3;
            var val_4;
            var val_5;
            var val_6;
            val_2 = 0;
            val_3 = 536896703;
            var val_1 = mem[536896889];
            val_1 = val_1 & 512;
            if(mem[536896819] != 0)
            {
                    val_2 = val_1;
            }
            else
            {
                    val_3 = 536896703;
                val_2 = mem[536896889] & 512;
            }
            
            val_4 = mem[536896795];
            if((mem[536896795] + 32) != 0)
            {
                    if((val_2 != 0) && (mem[536896819] == 0))
            {
                    val_5 = mem[536896795];
            }
            
                if((mem[536896795] + 48 + 12) <= i)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_2 = mem[536896795] + 48 + 8;
                val_2 = val_2 + (i << 2);
                (mem[536896795] + 48 + 8 + (i) << 2) + 16.Draw3D();
                return;
            }
            
            if((val_2 != 0) && (mem[536896819] == 0))
            {
                    val_6 = mem[536896795];
            }
            
            if((mem[536896795] + 48 + 12) <= i)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_3 = mem[536896795] + 48 + 8;
            val_3 = val_3 + (i << 2);
            (mem[536896795] + 48 + 8 + (i) << 2) + 16.Draw();
        }
        public static void DrawArrayLines()
        {
            var val_1;
            var val_2;
            var val_3;
            var val_4;
            val_1 = 536896703;
            if(((mem[536896890] & true) == 0) && (mem[536896819] == 0))
            {
                    val_1 = 536896703;
            }
            
            val_2 = 0;
            if((mem[536896795] + 32) != 0)
            {
                goto label_3;
            }
            
            goto label_4;
            label_12:
            if((mem[536896795] + 36 + 12) <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_1 = mem[536896795] + 36 + 8;
            val_1 = val_1 + 0;
            (mem[536896795] + 36 + 8 + 0) + 16.Draw3D();
            val_3 = 536896703;
            val_2 = 1;
            label_3:
            if(((mem[536896890] & true) == 0) && (mem[536896819] == 0))
            {
                    val_3 = 536896703;
            }
            
            if(val_2 < (mem[536896795] + 44))
            {
                goto label_12;
            }
            
            return;
            label_21:
            if((mem[536896795] + 36 + 12) <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_2 = mem[536896795] + 36 + 8;
            val_2 = val_2 + 4;
            (mem[536896795] + 36 + 8 + 4) + 16.Draw();
            val_4 = 536896703;
            val_2 = 2;
            label_4:
            if(((mem[536896890] & true) == 0) && (mem[536896819] == 0))
            {
                    val_4 = 536896703;
            }
            
            if(val_2 < (mem[536896795] + 44))
            {
                goto label_21;
            }
        
        }
        public static void DrawArrayLines2()
        {
            var val_1;
            var val_2;
            var val_3;
            var val_4;
            val_1 = 536896703;
            if(((mem[536896890] & true) == 0) && (mem[536896819] == 0))
            {
                    val_1 = 536896703;
            }
            
            val_2 = 0;
            if((mem[536896795] + 32) != 0)
            {
                goto label_3;
            }
            
            goto label_4;
            label_12:
            if((mem[536896795] + 48 + 12) <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_1 = mem[536896795] + 48 + 8;
            val_1 = val_1 + 0;
            (mem[536896795] + 48 + 8 + 0) + 16.Draw3D();
            val_3 = 536896703;
            val_2 = 1;
            label_3:
            if(((mem[536896890] & true) == 0) && (mem[536896819] == 0))
            {
                    val_3 = 536896703;
            }
            
            if(val_2 < (mem[536896795] + 56))
            {
                goto label_12;
            }
            
            return;
            label_21:
            if((mem[536896795] + 48 + 12) <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_2 = mem[536896795] + 48 + 8;
            val_2 = val_2 + 4;
            (mem[536896795] + 48 + 8 + 4) + 16.Draw();
            val_4 = 536896703;
            val_2 = 2;
            label_4:
            if(((mem[536896890] & true) == 0) && (mem[536896819] == 0))
            {
                    val_4 = 536896703;
            }
            
            if(val_2 < (mem[536896795] + 56))
            {
                goto label_21;
            }
        
        }
        public static UnityEngine.Bounds GetBounds(Vectrosity.VectorLine line)
        {
            float val_4;
            var val_5;
            var val_6;
            var val_7;
            UnityEngine.Color32[] val_8;
            val_5 = 22987823;
            System.Collections.Generic.List<UnityEngine.Vector3> val_1 = R1.points3;
            if(R1 != 0)
            {
                    System.Collections.Generic.List<UnityEngine.Vector3> val_2 = R1.points3;
                UnityEngine.Bounds val_3 = Vectrosity.VectorManager.GetBounds(points3:  424142272);
                mem2[0] = val_4;
                return new UnityEngine.Bounds() {m_Center = new UnityEngine.Vector3() {x = 2.802597E-44f, y = 0f}, m_Extents = new UnityEngine.Vector3()};
            }
            
            val_7 = 0;
            val_8 = 0;
            UnityEngine.Debug.LogError(message:  -1610602671);
            val_6 = 20;
            line.m_lineColors = val_8;
            mem2[0] = val_8;
            return new UnityEngine.Bounds() {m_Center = new UnityEngine.Vector3() {x = 2.802597E-44f, y = 0f}, m_Extents = new UnityEngine.Vector3()};
        }
        public static UnityEngine.Bounds GetBounds(System.Collections.Generic.List<UnityEngine.Vector3> points3)
        {
            var val_10;
            var val_11;
            float val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            var val_24;
            var val_25;
            var val_26;
            var val_27;
            var val_28;
            var val_29;
            float val_30;
            val_10 = mem[R1 + 12];
            val_10 = R1 + 12;
            val_11 = 32639;
            val_11 = 2139095039;
            if(val_10 < 1)
            {
                goto label_2;
            }
            
            val_12 = 3.402823E+38f;
            val_13 = 2139095039;
            val_14 = 2139095039;
            val_15 = 0;
            val_16 = 24;
            goto label_3;
            label_25:
            val_13 = 2139095039;
            val_15 = 1;
            val_10 = mem[R1 + 12];
            val_10 = R1 + 12;
            val_16 = 36;
            val_12 = S0;
            val_14 = S24;
            label_3:
            if(val_10 <= val_15)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_10 = mem[R1 + 12];
                val_10 = R1 + 12;
            }
            
            val_17 = mem[R1 + 8];
            val_17 = R1 + 8;
            var val_2 = val_17 + val_16;
            if(val_10 >= 0)
            {
                goto label_5;
            }
            
            if(val_10 > val_15)
            {
                goto label_7;
            }
            
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_17 = mem[R1 + 8];
            val_17 = R1 + 8;
            var val_3 = val_17 + val_16;
            val_18 = (R1 + 8 + val_16) + -8;
            goto label_7;
            label_5:
            if(val_10 <= val_15)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_17 = mem[R1 + 8];
                val_17 = R1 + 8;
                var val_4 = val_17 + val_16;
            }
            
            if(val_10 > val_15)
            {
                    if((R1 + 12) <= val_15)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_17 = mem[R1 + 8];
                val_17 = R1 + 8;
                var val_5 = val_17 + val_16;
                val_19 = (R1 + 8 + val_16) + -8;
            }
            
            }
            
            label_7:
            val_20 = mem[R1 + 12];
            val_20 = R1 + 12;
            if(val_20 <= val_15)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_17 = mem[R1 + 8];
                val_17 = R1 + 8;
                val_20 = mem[R1 + 12];
                val_20 = R1 + 12;
            }
            
            var val_6 = val_17 + val_16;
            if(val_20 < 0)
            {
                    if(val_20 <= val_15)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_17 = mem[R1 + 8];
                val_17 = R1 + 8;
                var val_7 = val_17 + val_16;
                val_21 = (R1 + 8 + val_16) + -4;
            }
            
                val_22 = val_21;
            }
            else
            {
                    if(val_20 <= val_15)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_17 = mem[R1 + 8];
                val_17 = R1 + 8;
                var val_8 = val_17 + val_16;
            }
            
                if(val_20 > val_15)
            {
                    if((R1 + 12) <= val_15)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_17 = mem[R1 + 8];
                val_17 = R1 + 8;
                var val_9 = val_17 + val_16;
                val_23 = (R1 + 8 + val_16) + -4;
            }
            
            }
            
                val_22 = val_11;
            }
            
            val_24 = mem[R1 + 12];
            val_24 = R1 + 12;
            if(val_24 <= val_15)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_17 = mem[R1 + 8];
                val_17 = R1 + 8;
                val_22 = val_22;
                val_24 = mem[R1 + 12];
                val_24 = R1 + 12;
            }
            
            val_17 = val_17 + val_16;
            if(val_24 >= 0)
            {
                goto label_19;
            }
            
            if(val_24 > val_15)
            {
                goto label_21;
            }
            
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            var val_10 = R1 + 8;
            val_22 = val_22;
            val_10 = val_10 + val_16;
            val_25 = mem[(R1 + 8 + val_16)];
            val_25 = val_10;
            goto label_21;
            label_19:
            if(val_24 <= val_15)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                var val_11 = R1 + 8;
                val_22 = val_22;
                val_11 = val_11 + val_16;
            }
            
            if(val_24 > val_15)
            {
                    if((R1 + 12) <= val_15)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                var val_12 = R1 + 8;
                val_22 = val_22;
                val_12 = val_12 + val_16;
                val_26 = mem[(R1 + 8 + val_16)];
                val_26 = val_12;
            }
            
            }
            
            label_21:
            if((val_10 - 1) != val_15)
            {
                goto label_25;
            }
            
            val_27 = val_26;
            val_28 = val_23;
            val_29 = val_25;
            val_30 = val_19;
            val_11 = val_18;
            goto label_26;
            label_2:
            val_30 = 8388608;
            val_28 = 8388608;
            val_27 = 8388608;
            val_22 = val_11;
            val_29 = val_11;
            label_26:
            0.min = new UnityEngine.Vector3() {x = 3.402823E+38f, y = 3.402823E+38f, z = 3.402823E+38f};
            0.max = new UnityEngine.Vector3() {x = 1.175494E-38f, y = 1.175494E-38f, z = 1.175494E-38f};
            mem2[0] = 0f;
            mem[4] = 0f;
            return new UnityEngine.Bounds() {m_Center = new UnityEngine.Vector3() {x = 1.042926E-23f, y = 1.175494E-38f, z = 1.175494E-38f}, m_Extents = new UnityEngine.Vector3() {x = 1.175494E-38f, z = 0f}};
        }
        private static UnityEngine.Mesh MakeBoundsMesh(UnityEngine.Bounds bounds)
        {
            float val_3;
            float val_4;
            float val_5;
            536890419 = new UnityEngine.Mesh();
            UnityEngine.Vector3 val_2 = center;
            float val_37 = val_3;
            float val_38 = val_4;
            float val_39 = val_5;
            UnityEngine.Vector3 val_6 = extents;
            UnityEngine.Vector3 val_7 = extents;
            UnityEngine.Vector3 val_8 = extents;
            val_37 = val_37 - val_3;
            val_38 = val_38 + val_4;
            val_39 = val_39 + val_5;
            mem[536882613] = val_37;
            mem[536882617] = val_38;
            mem[536882621] = val_39;
            UnityEngine.Vector3 val_9 = center;
            float val_40 = val_3;
            float val_41 = val_4;
            float val_42 = val_5;
            UnityEngine.Vector3 val_10 = extents;
            UnityEngine.Vector3 val_11 = extents;
            UnityEngine.Vector3 val_12 = extents;
            val_40 = val_40 + val_3;
            val_41 = val_41 + val_4;
            val_42 = val_42 + val_5;
            mem[536882625] = val_40;
            mem[536882629] = val_41;
            mem[536882633] = val_42;
            UnityEngine.Vector3 val_13 = center;
            float val_43 = val_3;
            float val_44 = val_4;
            float val_45 = val_5;
            UnityEngine.Vector3 val_14 = extents;
            UnityEngine.Vector3 val_15 = extents;
            UnityEngine.Vector3 val_16 = extents;
            val_43 = val_43 - val_3;
            val_44 = val_44 + val_4;
            val_45 = val_45 - val_5;
            mem[536882637] = val_43;
            mem[536882641] = val_44;
            mem[536882645] = val_45;
            UnityEngine.Vector3 val_17 = center;
            float val_46 = val_3;
            float val_47 = val_4;
            float val_48 = val_5;
            UnityEngine.Vector3 val_18 = extents;
            UnityEngine.Vector3 val_19 = extents;
            UnityEngine.Vector3 val_20 = extents;
            val_46 = val_46 + val_3;
            val_47 = val_47 + val_4;
            val_48 = val_48 - val_5;
            mem[536882649] = val_46;
            mem[536882653] = val_47;
            mem[536882657] = val_48;
            UnityEngine.Vector3 val_21 = center;
            float val_49 = val_3;
            float val_50 = val_4;
            float val_51 = val_5;
            UnityEngine.Vector3 val_22 = extents;
            UnityEngine.Vector3 val_23 = extents;
            UnityEngine.Vector3 val_24 = extents;
            val_49 = val_49 - val_3;
            val_50 = val_50 - val_4;
            val_51 = val_51 + val_5;
            mem[536882661] = val_49;
            mem[536882665] = val_50;
            mem[536882669] = val_51;
            UnityEngine.Vector3 val_25 = center;
            float val_52 = val_3;
            float val_53 = val_4;
            float val_54 = val_5;
            UnityEngine.Vector3 val_26 = extents;
            UnityEngine.Vector3 val_27 = extents;
            UnityEngine.Vector3 val_28 = extents;
            val_52 = val_52 + val_3;
            val_53 = val_53 - val_4;
            val_54 = val_54 + val_5;
            mem[536882673] = val_52;
            mem[536882677] = val_53;
            mem[536882681] = val_54;
            UnityEngine.Vector3 val_29 = center;
            float val_55 = val_3;
            float val_56 = val_4;
            float val_57 = val_5;
            UnityEngine.Vector3 val_30 = extents;
            UnityEngine.Vector3 val_31 = extents;
            UnityEngine.Vector3 val_32 = extents;
            val_55 = val_55 - val_3;
            val_56 = val_56 - val_4;
            val_57 = val_57 - val_5;
            mem[536882685] = val_55;
            mem[536882689] = val_56;
            mem[536882693] = val_57;
            UnityEngine.Vector3 val_33 = center;
            float val_58 = val_3;
            float val_59 = val_4;
            float val_60 = val_5;
            UnityEngine.Vector3 val_34 = extents;
            UnityEngine.Vector3 val_35 = extents;
            UnityEngine.Vector3 val_36 = extents;
            val_58 = val_58 + val_3;
            val_59 = val_59 - val_4;
            val_60 = val_60 - val_5;
            mem[536882697] = val_58;
            mem[536882701] = val_59;
            mem[536882705] = val_60;
            val_1.vertices = 536882597;
        }
        public static void SetupBoundsMesh(UnityEngine.GameObject go, Vectrosity.VectorLine line)
        {
            float val_10;
            UnityEngine.Object val_15;
            UnityEngine.Object val_16;
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            Weight val_1 = go.GetComponent<Weight>();
            val_15 = go;
            if(val_15 == 0)
            {
                    SynchronizationContextBehavoir val_3 = go.AddComponent<SynchronizationContextBehavoir>();
                val_15 = go;
            }
            
            Weight val_4 = go.GetComponent<Weight>();
            val_16 = go;
            if(val_16 == 0)
            {
                    SynchronizationContextBehavoir val_6 = go.AddComponent<SynchronizationContextBehavoir>();
                val_16 = go;
            }
            
            val_16.enabled = true;
            val_17 = 536896703;
            if(((mem[536896890] & true) == 0) && (mem[536896819] == 0))
            {
                    val_17 = 536896703;
            }
            
            if((mem[536896795] + 84) == 0)
            {
                    536874375 = new System.Collections.Generic.Dictionary<System.Type, System.Runtime.Serialization.Formatters.Binary.TypeInformation>();
                val_18 = 536896703;
                if(((mem[536896890] & true) == 0) && (mem[536896819] == 0))
            {
                    val_18 = 536896703;
            }
            
                mem2[0] = 536874375;
                val_17 = 536896703;
            }
            
            if(((mem[536896890] & true) == 0) && (mem[536896819] == 0))
            {
                    val_17 = 536896703;
            }
            
            val_19 = mem[mem[536896795] + 84];
            val_19 = mem[536896795] + 84;
            if((val_19.ContainsKey(key:  line.m_name)) != true)
            {
                    val_20 = 536896703;
                if(((mem[536896890] & true) == 0) && (mem[536896819] == 0))
            {
                    val_20 = 536896703;
            }
            
                val_16 = mem[mem[536896795] + 84];
                val_16 = mem[536896795] + 84;
                UnityEngine.Bounds val_9 = Vectrosity.VectorManager.GetBounds(line:  424519220);
                UnityEngine.Mesh val_11 = Vectrosity.VectorManager.MakeBoundsMesh(bounds:  new UnityEngine.Bounds() {m_Center = new UnityEngine.Vector3(), m_Extents = new UnityEngine.Vector3() {y = ???, z = val_10}});
                val_16.Add(key:  line.m_name, value:  R0);
                UnityEngine.Purchasing.IStoreExtension val_12 = mem[536896795] + 84.Item[line.m_name];
                val_19 = mem[536896795] + 84;
                string val_13 = line.m_name + -1610612469(-1610612469);
                val_19.name = line.m_name;
            }
            
            val_21 = 536896703;
            if(((mem[536896890] & true) == 0) && (mem[536896819] == 0))
            {
                    val_21 = 536896703;
            }
            
            UnityEngine.Purchasing.IStoreExtension val_14 = mem[536896795] + 84.Item[line.m_name];
            val_15.mesh = mem[536896795] + 84;
        }
        public VectorManager()
        {
        
        }
        private static VectorManager()
        {
            mem2[0] = 1140457472;
            mem2[0] = 1132068864;
            mem2[0] = 32;
            mem2[0] = 1045220557;
            mem2[0] = 0;
            mem2[0] = 0;
            mem2[0] = 0;
            mem2[0] = 0;
        }
    
    }

}
