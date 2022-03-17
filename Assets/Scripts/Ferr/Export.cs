using UnityEngine;

namespace Ferr
{
    public static class Export
    {
        // Methods
        public static void SaveOBJ(UnityEngine.Mesh aMesh, string aFileName)
        {
            var val_14;
            UnityEngine.Mesh val_15;
            var val_16;
            var val_17;
            var val_18;
            if(aMesh != 0)
            {
                    UnityEngine.Vector3[] val_1 = aMesh.vertices;
                val_14 = aMesh;
                UnityEngine.Vector2[] val_2 = aMesh.uv;
            }
            else
            {
                    UnityEngine.Vector3[] val_3 = 0.vertices;
                val_14 = 0;
                UnityEngine.Vector2[] val_4 = 0.uv;
            }
            
            System.Int32[] val_5 = aMesh.triangles;
            val_15 = aMesh;
            System.Text.StringBuilder val_6 = 536894635;
            val_16 = val_6;
            val_6 = new System.Text.StringBuilder();
            string val_7 = aMesh.name;
            System.Text.StringBuilder val_8 = val_16.AppendFormat(format:  -1610599023, arg0:  aMesh);
            var val_9 = val_14 + 16;
            val_17 = 0;
            goto label_5;
            label_15:
            System.Text.StringBuilder val_10 = val_16.AppendFormat(format:  -1610597491, arg0:  536893745, arg1:  536893745, arg2:  536893745);
            var val_16 = 0;
            val_15 = val_15;
            val_16 = val_16 + 0;
            val_16 = val_16;
            System.Text.StringBuilder val_11 = val_16.AppendFormat(format:  -1610597423, arg0:  536893745, arg1:  536893745);
            val_9 = val_9 + 12;
            val_17 = 1;
            val_14 = val_14;
            label_5:
            if(val_17 < 0)
            {
                goto label_15;
            }
            
            val_18 = 0;
            goto label_16;
            label_22:
            UnityEngine.Mesh val_12 = val_15 + 0;
            var val_17 = (aMesh + 0) + 16;
            val_17 = val_17 + 1;
            val_14 = 536888987;
            var val_18 = (aMesh + 0) + 20;
            val_18 = val_18 + 1;
            var val_19 = (aMesh + 0) + 24;
            val_19 = val_19 + 1;
            val_16 = val_16;
            System.Text.StringBuilder val_14 = val_16.AppendFormat(format:  -1610600581, arg0:  536888987, arg1:  536888987, arg2:  536888987);
            val_18 = (1 + 1) + 1;
            val_15 = val_15;
            label_16:
            if(val_18 < (aMesh + 12))
            {
                goto label_22;
            }
            
            536894567 = new System.IO.StreamWriter(path:  aFileName);
            UnityEngine.Debug.Log(message:  aFileName);
        }
        public static void SavePLY(UnityEngine.Mesh aMesh, string aFileName)
        {
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            if(aMesh != 0)
            {
                    UnityEngine.Vector3[] val_1 = aMesh.vertices;
                val_13 = aMesh;
                UnityEngine.Vector2[] val_2 = aMesh.uv;
                val_14 = aMesh;
                UnityEngine.Color[] val_3 = aMesh.colors;
                val_15 = aMesh;
            }
            else
            {
                    UnityEngine.Vector3[] val_4 = 0.vertices;
                val_13 = 0;
                UnityEngine.Vector2[] val_5 = 0.uv;
                val_14 = 0;
                UnityEngine.Color[] val_6 = 0.colors;
                val_15 = 0;
            }
            
            System.Int32[] val_7 = aMesh.triangles;
            System.Text.StringBuilder val_8 = 536894635;
            val_16 = val_8;
            val_8 = new System.Text.StringBuilder();
            val_17 = val_13;
            System.Text.StringBuilder val_9 = val_16.AppendFormat(format:  -1610598827, arg0:  536888987, arg1:  536888987);
            val_18 = val_16;
            if(0 >= 1)
            {
                    do
            {
                var val_11 = val_15 + 0;
                val_19 = 536893745;
                val_18 = val_16;
                mem[536882227] = val_19;
                mem[536882231] = 536893745;
                mem[536882235] = 536893745;
                mem[536882239] = 536893745;
                mem[536882243] = 536893745;
                mem[536882247] = 536893745;
                mem[536882251] = 536893745;
                mem[536882255] = 536893745;
                mem[536882259] = 536893745;
                System.Text.StringBuilder val_12 = val_18.AppendFormat(format:  -1610597023, args:  536882211);
                val_17 = 0 + 1;
                val_16 = (val_17 + 16) + 12;
            }
            while(val_17 < 0);
            
            }
            
            val_20 = 0;
            goto label_42;
            label_48:
            val_16 = 24;
            val_19 = 1179403647;
            val_17 = 1 + 1;
            val_18 = val_16;
            System.Text.StringBuilder val_13 = val_18.AppendFormat(format:  -1610610937, arg0:  1179403647, arg1:  1179403647, arg2:  1179403647);
            val_20 = val_17 + 1;
            label_42:
            if(val_20 < (aMesh + 12))
            {
                goto label_48;
            }
            
            536894567 = new System.IO.StreamWriter(path:  aFileName);
            UnityEngine.Debug.Log(message:  aFileName);
        }
    
    }

}
