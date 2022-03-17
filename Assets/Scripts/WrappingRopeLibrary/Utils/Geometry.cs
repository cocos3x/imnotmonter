using UnityEngine;

namespace WrappingRopeLibrary.Utils
{
    public class Geometry
    {
        // Methods
        public static bool Raycast(UnityEngine.Ray ray, out WrappingRopeLibrary.Model.HitInfo hitInfo, float maxDistance, UnityEngine.LayerMask layerMask)
        {
            float val_3;
            float val_4;
            float val_5;
            int val_7;
            UnityEngine.GameObject val_11;
            float val_21;
            float val_22;
            float val_23;
            float val_24;
            float val_26;
            float val_27;
            float val_28;
            float val_29;
            float val_30;
            var val_31;
            var val_32;
            object val_1 = 536887777;
            val_1 = new System.Object();
            hitInfo = val_1;
            UnityEngine.Vector3 val_2 = origin;
            val_27 = val_3;
            val_28 = val_4;
            UnityEngine.Vector3 val_6 = direction;
            val_31 = 0;
            if((UnityEngine.Physics.Raycast(origin:  new UnityEngine.Vector3() {x = val_27, y = val_28, z = val_5}, direction:  new UnityEngine.Vector3() {x = R4}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 3.083101E-07f, y = layerMask.m_Mask, z = UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask() {m_Mask = val_7})}, m_Normal = new UnityEngine.Vector3() {x = 0f}, m_UV = new UnityEngine.Vector2()}, maxDistance:  val_6.x, layerMask:  0)) == false)
            {
                    return (bool)val_31;
            }
            
            val_32 = 0;
            UnityEngine.Collider val_10 = collider;
            if((883262928 != 0) && ((val_11 + 180) >= mem[536890617]))
            {
                    var val_26 = val_11 + 100;
                val_26 = val_26 + (mem[536890617] << 2);
                val_32 = 0;
            }
            
            if(0 != 0)
            {
                    if(val_32.convex == false)
            {
                goto label_8;
            }
            
            }
            
            val_26 = ray.m_Origin.x;
            val_30 = ray.m_Origin.y;
            val_27 = ray.m_Origin.z;
            val_29 = ray.m_Direction.x;
            val_28 = ray.m_Direction.y;
            UnityEngine.Collider val_14 = collider;
            UnityEngine.GameObject val_15 = gameObject;
            val_31 = WrappingRopeLibrary.Utils.Geometry.TryRaycast(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = val_26, y = val_30, z = val_27}, m_Direction = new UnityEngine.Vector3() {x = val_29, y = val_28, z = ray.m_Direction.z}}, gameObject:  val_11, maxDistance:  val_6.x, hitInfo: out  layerMask.m_Mask);
            return (bool)val_31;
            label_8:
            UnityEngine.Transform val_18 = transform;
            UnityEngine.GameObject val_19 = gameObject;
            if((WrappingRopeLibrary.Utils.Geometry.IsAllowedCollision(gameObject:  883262928)) == false)
            {
                    return (bool)val_31;
            }
            
            536887777 = new WrappingRopeLibrary.Model.HitInfo(raycastHit:  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = val_11, y = val_21, z = val_22}, m_Normal = new UnityEngine.Vector3() {x = val_23}, m_UV = new UnityEngine.Vector2() {y = val_24}, m_Collider = ray.m_Origin.x});
            hitInfo = 536887777;
            return (bool)val_31;
        }
        public static bool TryRaycast(UnityEngine.Ray ray, UnityEngine.GameObject gameObject, float maxDistance, out WrappingRopeLibrary.Model.HitInfo hitInfo)
        {
            WrappingRopeLibrary.Model.HitInfo val_2;
            float val_17;
            float val_18;
            float val_19;
            var val_62;
            float val_63;
            UnityEngine.GameObject val_72;
            float val_73;
            float val_74;
            float val_75;
            float val_76;
            float val_77;
            float val_78;
            float val_79;
            float val_80;
            val_73 = 0f;
            val_75 = 22711508;
            object val_1 = 536887777;
            val_1 = new System.Object();
            mem2[0] = val_1;
            val_76 = 22713552;
            if(gameObject == 0)
            {
                    return true;
            }
            
            if((WrappingRopeLibrary.Utils.Geometry.IsAllowedCollision(gameObject:  gameObject)) == false)
            {
                    return true;
            }
            
            Weight val_5 = gameObject.GetComponent<Weight>();
            mem2[0] = gameObject;
            mem2[0] = gameObject;
            Weight val_6 = gameObject.GetComponent<Weight>();
            if(gameObject == 0)
            {
                goto label_11;
            }
            
            val_77 = 0;
            if(gameObject.convex == false)
            {
                goto label_13;
            }
            
            label_11:
            Weight val_9 = gameObject.GetComponent<Weight>();
            val_73 = 0;
            UnityEngine.Mesh val_10 = gameObject.sharedMesh;
            val_72 = gameObject;
            if(gameObject == 0)
            {
                    return true;
            }
            
            UnityEngine.Transform val_12 = val_72.transform;
            UnityEngine.Vector3 val_13 = origin;
            UnityEngine.Vector3 val_14 = InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_72, y = R5, z = R6});
            UnityEngine.Transform val_15 = val_72.transform;
            UnityEngine.Vector3 val_16 = origin;
            UnityEngine.Vector3 val_20 = direction;
            UnityEngine.Vector3 val_21 = normalized;
            val_72 = 0f;
            UnityEngine.Vector3 val_22 = InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_72, y = val_17, z = val_18});
            float val_74 = R7;
            float val_73 = R8;
            val_73 = val_18 - val_73;
            val_74 = val_17 - val_74;
            float val_24 = val_74.magnitude;
            UnityEngine.Ray val_25 = new UnityEngine.Ray(origin:  new UnityEngine.Vector3() {x = R7, y = R8, z = SL}, direction:  new UnityEngine.Vector3() {x = val_74, y = val_73, z = val_19 - SL});
            UnityEngine.Vector3 val_26 = origin;
            UnityEngine.Vector3 val_27 = origin;
            UnityEngine.Vector3 val_28 = direction;
            UnityEngine.Vector3 val_29 = origin;
            UnityEngine.Vector3 val_30 = direction;
            UnityEngine.Vector3 val_31 = WrappingRopeLibrary.Utils.Geometry.GetThirdPoint(direction:  new UnityEngine.Vector3() {x = 3.118375E-07f});
            float val_75 = val_17;
            float val_77 = val_18;
            float val_76 = val_19;
            val_75 = val_17 + val_75;
            val_76 = val_19 + val_76;
            val_77 = val_18 + val_77;
            UnityEngine.Plane val_35 = new UnityEngine.Plane(a:  new UnityEngine.Vector3() {x = R5, y = R6, z = R7}, b:  new UnityEngine.Vector3() {x = val_17 + val_17, y = val_18 + val_18, z = val_19 + val_19}, c:  new UnityEngine.Vector3() {x = val_75, y = val_77, z = val_76});
            UnityEngine.Vector3 val_36 = origin;
            UnityEngine.Vector3 val_37 = origin;
            UnityEngine.Vector3 val_38 = direction;
            UnityEngine.Vector3 val_39 = origin;
            UnityEngine.Vector3 val_40 = normal;
            float val_78 = val_17;
            float val_80 = val_18;
            float val_79 = val_19;
            val_78 = val_17 + val_78;
            val_79 = val_19 + val_79;
            val_80 = val_18 + val_80;
            UnityEngine.Plane val_44 = new UnityEngine.Plane(a:  new UnityEngine.Vector3() {x = R5, y = R6, z = R7}, b:  new UnityEngine.Vector3() {x = val_17 + val_17, y = val_18 + val_18, z = val_19 + val_19}, c:  new UnityEngine.Vector3() {x = val_78, y = val_80, z = val_79});
            if(gameObject == 0)
            {
                goto label_23;
            }
            
            System.Int32[] val_45 = gameObject.triangles;
            goto label_24;
            label_13:
            UnityEngine.Vector3 val_46 = direction;
            val_17.Normalize();
            ray.m_Origin.x.direction = new UnityEngine.Vector3() {x = val_17, y = val_44.m_Normal.y, z = val_19};
            val_74 = ray.m_Direction.z;
            if(gameObject == 0)
            {
                    val_80 = val_80;
                val_79 = val_79;
                val_78 = val_78;
            }
            
            val_73 = 0f;
            if((gameObject.Raycast(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = val_78, y = val_79, z = val_80}, m_Direction = new UnityEngine.Vector3() {x = val_76, y = val_77, z = val_74}}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = val_35.m_Normal.x, y = hitInfo, z = val_73}, m_Normal = new UnityEngine.Vector3() {x = val_72}, m_UV = new UnityEngine.Vector2()}, maxDistance:  val_46.x)) == false)
            {
                    return true;
            }
            
            val_72 = val_25.m_Direction.y;
            val_77 = val_25.m_Direction.x;
            val_74 = val_35.m_Distance;
            val_76 = val_25.m_Origin.y;
            val_75 = val_25.m_Origin.x;
            536887777 = new WrappingRopeLibrary.Model.HitInfo(raycastHit:  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = val_35.m_Normal.x, y = val_35.m_Normal.y, z = val_35.m_Normal.z}, m_Normal = new UnityEngine.Vector3() {x = val_74, y = val_75, z = val_76}, m_FaceID = val_25.m_Origin.z, m_Distance = val_77, m_UV = new UnityEngine.Vector2() {x = val_72, y = val_25.m_Direction.z}, m_Collider = val_74});
            val_73 = 1;
            mem2[0] = 536887777;
            return true;
            label_23:
            System.Int32[] val_49 = 0.triangles;
            label_24:
            UnityEngine.Vector3[] val_50 = gameObject.vertices;
            goto label_28;
            label_48:
            var val_51 = 0 + 0;
            var val_52 = ((0 + 0) + 16) + (((0 + 0) + 16) << 1);
            val_52 = gameObject + (val_52 << 2);
            UnityEngine.GameObject val_53 = val_52 + 16;
            var val_54 = ((0 + 0) + 20) + (((0 + 0) + 20) << 1);
            val_54 = gameObject + (val_54 << 2);
            val_72 = mem[(gameObject + (((0 + 0) + 20 + ((0 + 0) + 20) << 1)) << 2) + 16];
            val_72 = (gameObject + (((0 + 0) + 20 + ((0 + 0) + 20) << 1)) << 2) + 16;
            val_75 = mem[(gameObject + (((0 + 0) + 20 + ((0 + 0) + 20) << 1)) << 2) + 20];
            val_75 = (gameObject + (((0 + 0) + 20 + ((0 + 0) + 20) << 1)) << 2) + 20;
            var val_55 = ((0 + 0) + 24) + (((0 + 0) + 24) << 1);
            val_55 = gameObject + (val_55 << 2);
            if((val_35.m_Normal.x.SameSide(inPt0:  new UnityEngine.Vector3() {x = mem[((gameObject + (((0 + 0) + 16 + ((0 + 0) + 16) << 1)) << 2) + 16) + (0)], y = mem[((gameObject + (((0 + 0) + 16 + ((0 + 0) + 16) << 1)) << 2) + 16) + (4)], z = mem[((gameObject + (((0 + 0) + 16 + ((0 + 0) + 16) << 1)) << 2) + 16) + (8)]}, inPt1:  new UnityEngine.Vector3() {x = val_72, y = val_75, z = (gameObject + (((0 + 0) + 20 + ((0 + 0) + 20) << 1)) << 2) + 24})) != false)
            {
                    if((val_35.m_Normal.x.SameSide(inPt0:  new UnityEngine.Vector3() {x = val_72, y = val_75, z = (gameObject + (((0 + 0) + 20 + ((0 + 0) + 20) << 1)) << 2) + 24}, inPt1:  new UnityEngine.Vector3() {x = (gameObject + (((0 + 0) + 24 + ((0 + 0) + 24) << 1)) << 2) + 16, y = (gameObject + (((0 + 0) + 24 + ((0 + 0) + 24) << 1)) << 2) + 20, z = (gameObject + (((0 + 0) + 24 + ((0 + 0) + 24) << 1)) << 2) + 24})) == true)
            {
                goto label_43;
            }
            
            }
            
            if((val_17.SameSide(inPt0:  new UnityEngine.Vector3() {x = mem[((gameObject + (((0 + 0) + 16 + ((0 + 0) + 16) << 1)) << 2) + 16) + (0)], y = mem[((gameObject + (((0 + 0) + 16 + ((0 + 0) + 16) << 1)) << 2) + 16) + (4)], z = mem[((gameObject + (((0 + 0) + 16 + ((0 + 0) + 16) << 1)) << 2) + 16) + (8)]}, inPt1:  new UnityEngine.Vector3() {x = val_72, y = val_75, z = (gameObject + (((0 + 0) + 20 + ((0 + 0) + 20) << 1)) << 2) + 24})) == false)
            {
                goto label_38;
            }
            
            bool val_59 = val_17.SameSide(inPt0:  new UnityEngine.Vector3() {x = val_72, y = val_75, z = (gameObject + (((0 + 0) + 20 + ((0 + 0) + 20) << 1)) << 2) + 24}, inPt1:  new UnityEngine.Vector3() {x = (gameObject + (((0 + 0) + 24 + ((0 + 0) + 24) << 1)) << 2) + 16, y = (gameObject + (((0 + 0) + 24 + ((0 + 0) + 24) << 1)) << 2) + 20, z = (gameObject + (((0 + 0) + 24 + ((0 + 0) + 24) << 1)) << 2) + 24});
            if(val_59 == true)
            {
                goto label_43;
            }
            
            label_38:
            val_74 = mem[((gameObject + (((0 + 0) + 16 + ((0 + 0) + 16) << 1)) << 2) + 16) + (4)];
            val_76 = mem[((gameObject + (((0 + 0) + 16 + ((0 + 0) + 16) << 1)) << 2) + 16) + (8)];
            UnityEngine.Plane val_60 = WrappingRopeLibrary.Utils.Geometry.GetPlane(v1:  new UnityEngine.Vector3() {x = 3.118375E-07f, y = mem[((gameObject + (((0 + 0) + 16 + ((0 + 0) + 16) << 1)) << 2) + 16) + (0)], z = mem[((gameObject + (((0 + 0) + 16 + ((0 + 0) + 16) << 1)) << 2) + 16) + (4)]}, v2:  new UnityEngine.Vector3() {x = mem[((gameObject + (((0 + 0) + 16 + ((0 + 0) + 16) << 1)) << 2) + 16) + (8)], y = val_72, z = val_75}, v3:  new UnityEngine.Vector3() {x = (gameObject + (((0 + 0) + 20 + ((0 + 0) + 20) << 1)) << 2) + 24, y = (gameObject + (((0 + 0) + 24 + ((0 + 0) + 24) << 1)) << 2) + 16, z = (gameObject + (((0 + 0) + 24 + ((0 + 0) + 24) << 1)) << 2) + 20});
            UnityEngine.Vector3 val_61 = normal;
            var val_81 = val_62;
            val_81 = val_81 * val_73;
            if(val_59 < 0)
            {
                    bool val_66 = Raycast(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = val_25.m_Origin.x, y = val_25.m_Origin.y, z = val_25.m_Origin.z}, m_Direction = new UnityEngine.Vector3() {x = val_25.m_Direction.x, y = val_25.m_Direction.y, z = val_25.m_Direction.z}}, enter: out  val_73);
                if(val_66 != false)
            {
                    UnityEngine.Vector3 val_67 = GetPoint(distance:  val_63);
                val_77 = val_17;
                val_72 = val_19;
                if((val_66 <= false) && ((WrappingRopeLibrary.Utils.Geometry.IsPointInTriangle(point:  new UnityEngine.Vector3() {x = val_77, y = val_18, z = val_19}, a:  new UnityEngine.Vector3() {x = mem[((gameObject + (((0 + 0) + 16 + ((0 + 0) + 16) << 1)) << 2) + 16) + (0)], y = val_74, z = val_76}, b:  new UnityEngine.Vector3() {x = val_72, y = val_75, z = (gameObject + (((0 + 0) + 20 + ((0 + 0) + 20) << 1)) << 2) + 24}, c:  new UnityEngine.Vector3() {x = (gameObject + (((0 + 0) + 24 + ((0 + 0) + 24) << 1)) << 2) + 16, y = (gameObject + (((0 + 0) + 24 + ((0 + 0) + 24) << 1)) << 2) + 20, z = (gameObject + (((0 + 0) + 24 + ((0 + 0) + 24) << 1)) << 2) + 24})) != false))
            {
                    val_75 = val_77;
                val_77 = val_2;
                UnityEngine.Vector3 val_69 = normal;
                var val_70 = val_77 + 12;
                mem2[0] = val_75;
                mem2[0] = val_18;
                mem2[0] = val_72;
                mem2[0] = 1431655766;
            }
            
            }
            
            }
            
            label_43:
            var val_82 = 0;
            val_82 = val_82 + 3;
            label_28:
            if(val_82 < 0)
            {
                goto label_48;
            }
            
            UnityEngine.Transform val_71 = gameObject.transform;
            WrappingRopeLibrary.Utils.Geometry.ApplyTransform(hitInfo: ref  val_2, transform:  gameObject);
            if(gameObject != 0)
            {
                    val_73 = 1;
            }
            
            return true;
        }
        private static bool IsAllowedCollision(UnityEngine.GameObject gameObject)
        {
            Weight val_1 = gameObject.GetComponent<Weight>();
            if(gameObject == 0)
            {
                    return false;
            }
            
            bool val_3 = gameObject.isPartOfStaticBatch;
            val_3 = val_3 ^ 1;
            return (bool)val_3;
        }
        private static void ApplyTransform(ref WrappingRopeLibrary.Model.HitInfo hitInfo, UnityEngine.Transform transform)
        {
            UnityEngine.Vector3 val_1 = TransformPoint(position:  new UnityEngine.Vector3() {x = transform, y = hitInfo.<Normal>k__BackingField, z = mem[hitInfo + 16]});
            UnityEngine.Vector3 val_2 = TransformPoint(position:  new UnityEngine.Vector3() {x = transform, y = hitInfo.<Point>k__BackingField, z = mem[hitInfo + 28]});
        }
        private static bool IsVisible(UnityEngine.Vector3 normal, UnityEngine.Vector3 viewDir)
        {
            float val_1 = viewDir.y;
            val_1 = normal.y * val_1;
            if(<0)
            {
                    0 = 1;
            }
            
            return true;
        }
        private static UnityEngine.Vector3 GetThirdPoint(UnityEngine.Vector3 direction)
        {
            float val_6;
            var val_7;
            float val_8;
            var val_9 = R3;
            float val_8 = direction.z;
            float val_10 = direction.y;
            536878291 = new System.Collections.Generic.List<System.Single>();
            val_8 = val_8 & (~2147483648);
            val_9 = val_9 & (~2147483648);
            val_10 = val_10 & (~2147483648);
            if(536878291 != 0)
            {
                    val_8 = 4.021724E-38f;
                536878291.Add(item:  null);
                536878291.Add(item:  null);
            }
            else
            {
                    val_8 = 4.021724E-38f;
                536878291.Add(item:  null);
                536878291.Add(item:  null);
            }
            
            536878291.Add(item:  null);
            float val_2 = System.Linq.Enumerable.Min(source:  536878291);
            if(536878291 == 0)
            {
                    UnityEngine.Vector3 val_3 = UnityEngine.Vector3.up;
            }
            else
            {
                    if(536878291 == 0)
            {
                    UnityEngine.Vector3 val_4 = UnityEngine.Vector3.right;
            }
            else
            {
                    if(536878291 != 0)
            {
                goto label_8;
            }
            
                UnityEngine.Vector3 val_5 = UnityEngine.Vector3.forward;
            }
            
            }
            
            label_8:
            mem2[0] = val_7;
            mem2[0] = val_6;
            return new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
        }
        private static bool IsPointInTriangle(UnityEngine.Vector3 point, UnityEngine.Vector3 a, UnityEngine.Vector3 b, UnityEngine.Vector3 c)
        {
            float val_12 = a.y;
            float val_14 = a.x;
            float val_1 = c.y - val_12;
            float val_2 = b.y - val_12;
            float val_3 = b.x - val_14;
            float val_15 = a.z;
            float val_4 = c.x - val_14;
            float val_13 = b.z;
            val_12 = point.y - val_12;
            val_13 = val_13 - val_15;
            float val_5 = c.z - val_15;
            float val_6 = val_1 * val_1;
            float val_7 = val_2 * val_2;
            float val_8 = val_2 * val_1;
            val_1 = val_12 * val_1;
            val_14 = point.x - val_14;
            val_2 = val_12 * val_2;
            val_15 = point.z - val_15;
            float val_10 = val_7 * val_1;
            float val_11 = 1f / (val_7 * val_6);
            val_10 = val_10 * val_11;
            if()
            {
                    val_6 = val_2 * val_6;
            }
            
            if()
            {
                    val_6 = val_6 * val_11;
            }
            
            if()
            {
                    return false;
            }
            
            val_6 = val_10 + val_6;
            if(<0)
            {
                    0 = 1;
            }
            
            return true;
        }
        public static System.Collections.Generic.List<UnityEngine.Vector3> CreatePolygon(int vertexCount, WrappingRopeLibrary.Enums.Axis normal, float radius, float initAngle)
        {
            float val_2;
            float val_3;
            float val_4;
            var val_5;
            val_2 = R2;
            536878517 = new System.Collections.Generic.List<UnityEngine.Vector3>();
            if(vertexCount < 1)
            {
                    return;
            }
            
            var val_4 = 0;
            label_10:
            float val_2 = 0f;
            val_2 = val_2 / (float)vertexCount;
            val_2 = 1f - val_2;
            val_2 = val_2 * 1130.973f;
            val_2 = val_2 / 180f;
            float val_3 = val_2;
            val_2 = val_2 * val_2;
            val_3 = val_3 * val_2;
            if(normal == 2)
            {
                goto label_2;
            }
            
            if(normal == 1)
            {
                goto label_3;
            }
            
            if(normal != 0)
            {
                goto label_4;
            }
            
            val_2 = val_3;
            val_3 = 0;
            val_4 = val_2;
            goto label_6;
            label_3:
            val_2 = val_3;
            val_3 = val_2;
            val_4 = 0;
            label_6:
            val_5 = val_2;
            goto label_8;
            label_2:
            val_2 = val_3;
            val_3 = val_2;
            val_4 = val_2;
            val_5 = 0;
            label_8:
            536878517.Add(item:  new UnityEngine.Vector3() {x = val_3, y = val_4, z = 0f});
            label_4:
            val_4 = val_4 + 1;
            if(vertexCount != val_4)
            {
                goto label_10;
            }
        
        }
        public static System.Collections.Generic.List<UnityEngine.Vector3> RotatePoly(System.Collections.Generic.List<UnityEngine.Vector3> vertices, float angle, UnityEngine.Vector3 axis)
        {
            float val_4;
            float val_6;
            float val_7;
            float val_8;
            System.Collections.Generic.List<UnityEngine.Vector3> val_9;
            var val_10;
            var val_11;
            val_9 = vertices;
            536878517 = new System.Collections.Generic.List<UnityEngine.Vector3>();
            val_10 = 0;
            val_11 = 0;
            goto label_1;
            label_5:
            UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.AngleAxis(angle:  angle, axis:  new UnityEngine.Vector3() {x = 3.354015E-07f, y = axis.x, z = axis.y});
            if(884216124 <= val_11)
            {
                    var val_9 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_9 = val_9 + val_10;
            UnityEngine.Vector3 val_5 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = 3.354015E-07f, y = R6, z = R8, w = SB}, point:  new UnityEngine.Vector3() {x = val_4, y = (0 + val_10) + 16, z = (0 + val_10) + 20});
            536878517.Add(item:  new UnityEngine.Vector3() {x = val_6, y = val_7, z = val_8});
            val_10 = 12;
            val_9 = val_9;
            val_11 = 1;
            label_1:
            if(val_11 < (vertices + 12))
            {
                goto label_5;
            }
        
        }
        public static System.Collections.Generic.List<UnityEngine.Vector3> RotatePoly(System.Collections.Generic.List<UnityEngine.Vector3> vertices, UnityEngine.Quaternion rotation)
        {
            float val_3;
            float val_4;
            float val_5;
            var val_6;
            var val_7;
            536878517 = new System.Collections.Generic.List<UnityEngine.Vector3>();
            val_6 = 0;
            val_7 = 0;
            goto label_1;
            label_5:
            if(536878517 <= val_7)
            {
                    var val_6 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_6 = val_6 + val_6;
            UnityEngine.Vector3 val_2 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = 3.388177E-07f, y = rotation.x, z = rotation.y, w = rotation.z}, point:  new UnityEngine.Vector3() {x = rotation.w, y = (0 + val_6) + 16, z = (0 + val_6) + 20});
            536878517.Add(item:  new UnityEngine.Vector3() {x = val_3, y = val_4, z = val_5});
            val_6 = 12;
            val_7 = 1;
            label_1:
            if(val_7 < 536878517)
            {
                goto label_5;
            }
        
        }
        public static void RotatePoly(UnityEngine.Vector3[] target, UnityEngine.Vector3[] source, UnityEngine.Quaternion rotation)
        {
            var val_3;
            UnityEngine.Vector3[] val_4;
            val_3 = 0;
            goto label_0;
            label_5:
            UnityEngine.Vector3 val_1 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = 3.442128E-07f, y = rotation.x, z = rotation.y, w = rotation.z}, point:  new UnityEngine.Vector3() {x = rotation.w, y = mem[source[0x10] + (0)], z = mem[source[0x10] + (4)]});
            if(val_4 == null)
            {
                    val_4 = target;
            }
            
            val_3 = 1;
            label_0:
            if(val_3 < (target + 12))
            {
                goto label_5;
            }
        
        }
        public static void RotatePoly(UnityEngine.Vector3[] target, UnityEngine.Vector3[] source, float angle, UnityEngine.Vector3 axis)
        {
        
        }
        public static System.Collections.Generic.List<UnityEngine.Vector3> TranslatePoly(System.Collections.Generic.List<UnityEngine.Vector3> vertices, UnityEngine.Vector3 direction)
        {
            float val_2;
            float val_3;
            var val_4;
            val_2 = direction.y;
            val_3 = direction.x;
            536878517 = new System.Collections.Generic.List<UnityEngine.Vector3>();
            val_4 = 0;
            goto label_1;
            label_5:
            if(536878517 <= val_4)
            {
                    var val_2 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_2 = val_2 + 0;
            float val_3 = (0 + 0) + 16;
            float val_4 = (0 + 0) + 20;
            float val_5 = (0 + 0) + 24;
            val_3 = val_3 + val_3;
            val_4 = val_4 + val_2;
            val_5 = val_5 + direction.z;
            val_2 = val_4;
            val_3 = val_5;
            536878517.Add(item:  new UnityEngine.Vector3() {x = val_3, y = val_2, z = val_3});
            val_4 = 1;
            label_1:
            if(val_4 < 536878517)
            {
                goto label_5;
            }
        
        }
        public static System.Collections.Generic.List<UnityEngine.Vector3> ScalePoly(System.Collections.Generic.List<UnityEngine.Vector3> vertices, float scale)
        {
            var val_2;
            536878517 = new System.Collections.Generic.List<UnityEngine.Vector3>();
            val_2 = 0;
            goto label_1;
            label_5:
            if(536878517 <= val_2)
            {
                    var val_2 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_2 = val_2 + 0;
            float val_3 = (0 + 0) + 16;
            float val_4 = (0 + 0) + 20;
            float val_5 = (0 + 0) + 24;
            val_3 = val_3 * R1;
            val_4 = val_4 * R1;
            val_5 = val_5 * R1;
            536878517.Add(item:  new UnityEngine.Vector3() {x = val_3, y = val_4, z = val_5});
            val_2 = 1;
            label_1:
            if(val_2 < 536878517)
            {
                goto label_5;
            }
        
        }
        public static void ScalePoly(UnityEngine.Vector3[] target, UnityEngine.Vector3[] source, float scale)
        {
            var val_6;
            val_6 = 0;
            goto label_0;
            label_5:
            mem2[0] = 1152921504993032688 * R2;
            mem2[0] = S20 * R2;
            val_6 = 1;
            mem2[0] = S18 * R2;
            label_0:
            if(val_6 < target)
            {
                goto label_5;
            }
        
        }
        public static float Angle(UnityEngine.Vector3 vec1, UnityEngine.Vector3 vec2, UnityEngine.Vector3 n)
        {
            var val_3;
            float val_1 = UnityEngine.Vector3.Angle(from:  new UnityEngine.Vector3() {x = vec1.x, y = vec1.y, z = vec1.z}, to:  new UnityEngine.Vector3() {x = vec2.x, y = vec2.y, z = vec2.z});
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.Cross(lhs:  new UnityEngine.Vector3() {x = 3.710719E-07f, y = vec1.x, z = vec1.y}, rhs:  new UnityEngine.Vector3() {x = vec1.z, y = vec2.x, z = vec2.y});
            float val_8 = n.y;
            val_8 = val_3 * val_8;
            float val_6 = UnityEngine.Mathf.Sign(f:  val_8);
            if(<0)
            {
                    vec1.x = 360f - vec1.x;
            }
            
            return val_8;
        }
        public static bool IsPolyTheSame(System.Collections.Generic.List<UnityEngine.Vector3> p1, System.Collections.Generic.List<UnityEngine.Vector3> p2)
        {
            var val_2;
            var val_3;
            val_2 = 0;
            if(22999514 != true)
            {
                    return (bool)val_2;
            }
            
            if(true >= 1)
            {
                    var val_4 = 0;
                val_3 = 0;
                do
            {
                if(true <= val_3)
            {
                    var val_2 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_2 = val_2 + val_4;
                if((p2 + 12) <= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_3 = p2 + 8;
                val_2 = 0;
                val_3 = val_3 + val_4;
                bool val_1 = UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = (0 + 0) + 16, y = (0 + 0) + 20, z = (0 + 0) + 24}, rhs:  new UnityEngine.Vector3() {x = (p2 + 8 + 0) + 16, y = (p2 + 8 + 0) + 20, z = (p2 + 8 + 0) + 24});
                if(val_1 == true)
            {
                    return (bool)val_2;
            }
            
                val_3 = val_3 + 1;
                val_4 = val_4 + 12;
            }
            while(val_3 < val_1);
            
            }
            
            val_2 = 1;
            return (bool)val_2;
        }
        public static UnityEngine.Plane GetPlane(UnityEngine.Vector3 v1, UnityEngine.Vector3 v2, UnityEngine.Vector3 v3)
        {
            float val_5;
            float val_1 = v1.z - v2.z;
            float val_3 = v2.x - v3.x;
            float val_4 = v1.y - v2.y.sqrMagnitude;
            if(<0)
            {
                goto label_1;
            }
            
            float val_6 = v2.z - v3.z;
            float val_8 = v3.x - val_5;
            float val_9 = v2.y - v3.y.sqrMagnitude;
            if(<0)
            {
                goto label_1;
            }
            
            float val_10 = v3.z - v1.z;
            float val_12 = val_5 - v2.x;
            float val_13 = v3.y - v1.y.sqrMagnitude;
            if(>=0)
            {
                goto label_2;
            }
            
            label_1:
            float val_25 = 100f;
            UnityEngine.Plane val_22;
            val_25 = v2.y * val_25;
            val_22 = new UnityEngine.Plane(a:  new UnityEngine.Vector3() {x = v1.y * val_25, y = v1.z * val_25, z = v2.x * val_25}, b:  new UnityEngine.Vector3() {x = val_25, y = v2.z * val_25, z = v3.x * val_25}, c:  new UnityEngine.Vector3() {x = v3.y * val_25, y = v3.z * val_25, z = val_5 * val_25});
            UnityEngine.Vector3 val_23 = normal;
            val_22.m_Normal.x.SetNormalAndPosition(inNormal:  new UnityEngine.Vector3(), inPoint:  new UnityEngine.Vector3() {x = v1.y, y = v1.z, z = v2.x});
            return new UnityEngine.Plane() {m_Normal = new UnityEngine.Vector3() {x = 3.779039E-07f}};
            label_2:
            UnityEngine.Plane val_24 = new UnityEngine.Plane(a:  new UnityEngine.Vector3() {x = v1.y, y = v1.z, z = v2.x}, b:  new UnityEngine.Vector3() {x = v2.y, y = v2.z, z = v3.x}, c:  new UnityEngine.Vector3() {x = v3.y, y = v3.z, z = val_5});
            return new UnityEngine.Plane() {m_Normal = new UnityEngine.Vector3() {x = 3.779039E-07f}};
        }
        public Geometry()
        {
        
        }
    
    }

}
