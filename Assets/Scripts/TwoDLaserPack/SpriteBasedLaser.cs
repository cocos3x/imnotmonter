using UnityEngine;

namespace TwoDLaserPack
{
    public class SpriteBasedLaser : MonoBehaviour
    {
        // Fields
        public UnityEngine.GameObject laserStartPiece;
        public UnityEngine.GameObject laserMiddlePiece;
        public UnityEngine.GameObject laserEndPiece;
        public UnityEngine.LineRenderer laserLineRendererArc;
        public int laserArcSegments;
        public RandomPositionMover laserOscillationPositionerScript;
        public bool oscillateLaser;
        public float maxLaserLength;
        public float oscillationSpeed;
        public bool laserActive;
        public bool ignoreCollisions;
        public UnityEngine.GameObject targetGo;
        public UnityEngine.ParticleSystem hitSparkParticleSystem;
        public float laserArcMaxYDown;
        public float laserArcMaxYUp;
        public float maxLaserRaycastDistance;
        public bool laserRotationEnabled;
        public bool lerpLaserRotation;
        public float turningRate;
        public float collisionTriggerInterval;
        public UnityEngine.LayerMask mask;
        private TwoDLaserPack.SpriteBasedLaser.LaserHitTriggerHandler OnLaserHitTriggered;
        public bool useArc;
        public float oscillationThreshold;
        private UnityEngine.GameObject gameObjectCached;
        private float laserAngle;
        private float lerpYValue;
        private float startLaserLength;
        private UnityEngine.GameObject startGoPiece;
        private UnityEngine.GameObject middleGoPiece;
        private UnityEngine.GameObject endGoPiece;
        private float startSpriteWidth;
        private bool waitingForTriggerTime;
        private UnityEngine.ParticleSystem.EmissionModule hitSparkEmission;
        private bool Active;
        
        // Methods
        public void add_OnLaserHitTriggered(TwoDLaserPack.SpriteBasedLaser.LaserHitTriggerHandler value)
        {
            var val_2;
            label_3:
            System.Delegate val_1 = System.Delegate.Combine(a:  this.OnLaserHitTriggered, b:  value);
            if(this.OnLaserHitTriggered == 0)
            {
                goto label_1;
            }
            
            val_2 = this.OnLaserHitTriggered;
            if(null == 536901447)
            {
                goto label_2;
            }
            
            label_1:
            val_2 = 0;
            label_2:
            if(this.OnLaserHitTriggered != 1152921510386368232)
            {
                goto label_3;
            }
        
        }
        public void remove_OnLaserHitTriggered(TwoDLaserPack.SpriteBasedLaser.LaserHitTriggerHandler value)
        {
            var val_2;
            label_3:
            System.Delegate val_1 = System.Delegate.Remove(source:  this.OnLaserHitTriggered, value:  value);
            if(this.OnLaserHitTriggered == 0)
            {
                goto label_1;
            }
            
            val_2 = this.OnLaserHitTriggered;
            if(null == 536901447)
            {
                goto label_2;
            }
            
            label_1:
            val_2 = 0;
            label_2:
            if(this.OnLaserHitTriggered != 1152921510386496616)
            {
                goto label_3;
            }
        
        }
        private void Awake()
        {
            ParticleSystem.EmissionModule val_1 = this.hitSparkParticleSystem.emission;
            this.hitSparkEmission = val_1;
        }
        private void OnEnable()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            this.gameObjectCached = this;
            if(this.laserLineRendererArc == 0)
            {
                    return;
            }
            
            R4 + 24.SetVertexCount(count:  R4 + 28);
        }
        private void Start()
        {
            this.startLaserLength = this.maxLaserLength;
            if(this.laserOscillationPositionerScript == 0)
            {
                    return;
            }
            
            mem2[0] = R4 + 96;
        }
        private void OscillateLaserParts(float currentLaserDistance)
        {
            float val_4;
            float val_11;
            RandomPositionMover val_23;
            var val_24;
            val_23 = this.laserOscillationPositionerScript;
            if(val_23 == 0)
            {
                    return;
            }
            
            UnityEngine.Transform val_2 = this.middleGoPiece.transform;
            UnityEngine.Vector3 val_3 = localPosition;
            float val_5 = UnityEngine.Time.deltaTime;
            float val_23 = this.oscillationSpeed;
            val_23 = 0 * val_23;
            float val_6 = UnityEngine.Mathf.Lerp(a:  val_23, b:  val_3.y, t:  0);
            this.lerpYValue = val_4;
            val_23 = this.startGoPiece;
            if(val_23 != 0)
            {
                    if(this.middleGoPiece != 0)
            {
                    UnityEngine.Transform val_9 = this.startGoPiece.transform;
                UnityEngine.Vector3 val_10 = localPosition;
                UnityEngine.Transform val_12 = this.startGoPiece.transform;
                UnityEngine.Vector3 val_13 = localPosition;
                float val_14 = UnityEngine.Time.deltaTime;
                float val_24 = this.oscillationSpeed;
                val_24 = 0 * val_24;
                float val_15 = UnityEngine.Mathf.Clamp01(value:  val_24);
                float val_16 = S20 - val_4;
                float val_17 = val_11 - val_11;
                UnityEngine.Transform val_18 = this.startGoPiece.transform;
                this.startGoPiece.localPosition = new UnityEngine.Vector3() {x = val_11, y = val_4, z = 0f};
                val_23 = this.startSpriteWidth * 0.25f;
                UnityEngine.Transform val_20 = this.middleGoPiece.transform;
                val_24 = this.middleGoPiece;
                val_24.localPosition = new UnityEngine.Vector3() {x = val_23, y = this.lerpYValue, z = 0f};
            }
            
            }
            
            if(this.endGoPiece == 0)
            {
                    return;
            }
            
            val_24 = 0;
            UnityEngine.Transform val_22 = this.endGoPiece.transform;
            val_23 = this.endGoPiece;
            val_23.localPosition = new UnityEngine.Vector3() {x = R1, y = this.lerpYValue, z = 0f};
        }
        private void SetLaserArcVertices(float distancePoint, bool useHitPoint)
        {
            var val_5;
            bool val_6;
            float val_7;
            if(this.laserArcSegments < 2)
            {
                    return;
            }
            
            var val_6 = 1;
            label_6:
            float val_2 = UnityEngine.Random.Range(minInclusive:  UnityEngine.Time.time, maxInclusive:  null);
            float val_3 = UnityEngine.Mathf.Clamp(value:  0, min:  null, max:  1056964608);
            if(R2 == 0)
            {
                goto label_2;
            }
            
            int val_5 = this.laserArcSegments;
            val_5 = val_5 - 1;
            if(val_6 != val_5)
            {
                goto label_2;
            }
            
            val_5 = val_6;
            val_6 = useHitPoint;
            val_7 = 0;
            goto label_4;
            label_2:
            val_5 = val_6;
            val_6 = 1f * 1.2f;
            val_7 = 1f;
            label_4:
            this.laserLineRendererArc.SetPosition(index:  1, position:  new UnityEngine.Vector3() {x = val_6, y = val_7, z = 0f});
            val_6 = val_6 + 1;
            if(val_6 < this.laserArcSegments)
            {
                goto label_6;
            }
        
        }
        private void LateUpdate()
        {
            float val_9;
            float val_10;
            float val_26;
            float val_39;
            var val_85;
            float val_86;
            float val_88;
            int val_1 = UnityEngine.Time.frameCount;
            val_1 = val_1 - 4294967298;
            bool val_2 = UnityEngine.Object.op_Inequality(x:  this.gameObjectCached, y:  0);
            if(val_2 == true)
            {
                    val_2 = this.laserActive;
                goto label_4;
            }
            
            return;
            label_4:
            if(this.startGoPiece == 0)
            {
                    this.InstantiateLaserPart(laserComponent: ref  UnityEngine.GameObject val_4 = 1485559172, laserPart:  this.laserStartPiece);
                UnityEngine.Transform val_5 = this.startGoPiece.transform;
                UnityEngine.Transform val_6 = this.transform;
                this.startGoPiece.parent = 1485559056;
                UnityEngine.Transform val_7 = this.startGoPiece.transform;
                UnityEngine.Vector2 val_8 = UnityEngine.Vector2.zero;
                this.startGoPiece.localPosition = new UnityEngine.Vector3() {x = val_9, y = val_10, z = 0f};
                Weight val_11 = this.laserStartPiece.GetComponent<Weight>();
                UnityEngine.Bounds val_12 = bounds;
                UnityEngine.Vector3 val_13 = size;
                this.startSpriteWidth = val_9;
            }
            
            if(this.middleGoPiece == 0)
            {
                    this.InstantiateLaserPart(laserComponent: ref  UnityEngine.GameObject val_15 = 1485559176, laserPart:  this.laserMiddlePiece);
                UnityEngine.Transform val_16 = this.middleGoPiece.transform;
                UnityEngine.Transform val_17 = this.transform;
                this.middleGoPiece.parent = 1485559056;
                UnityEngine.Transform val_18 = this.middleGoPiece.transform;
                UnityEngine.Vector2 val_19 = UnityEngine.Vector2.zero;
                this.middleGoPiece.localPosition = new UnityEngine.Vector3() {x = val_9, y = val_10, z = 0f};
            }
            
            UnityEngine.Transform val_20 = this.middleGoPiece.transform;
            UnityEngine.Transform val_21 = this.middleGoPiece.transform;
            UnityEngine.Vector3 val_22 = localScale;
            UnityEngine.Transform val_23 = this.middleGoPiece.transform;
            UnityEngine.Vector3 val_24 = localScale;
            float val_25 = this.maxLaserLength - this.startSpriteWidth;
            this.middleGoPiece.localScale = new UnityEngine.Vector3() {x = val_25, y = val_10, z = val_26};
            if(this.oscillateLaser != false)
            {
                    this.OscillateLaserParts(currentLaserDistance:  val_25);
                val_85 = 22713552;
            }
            else
            {
                    if(this.middleGoPiece != 0)
            {
                    UnityEngine.Transform val_28 = this.middleGoPiece.transform;
                float val_85 = 0.25f;
                val_85 = this.startSpriteWidth * val_85;
                this.middleGoPiece.localPosition = new UnityEngine.Vector3() {x = val_85, y = this.lerpYValue, z = 0f};
            }
            
                val_85 = 22713552;
                if(this.endGoPiece != 0)
            {
                    UnityEngine.Transform val_30 = this.endGoPiece.transform;
                this.endGoPiece.localPosition = new UnityEngine.Vector3() {x = this.maxLaserLength, y = 0f, z = 0f};
            }
            
            }
            
            if((this.laserRotationEnabled == false) || (this.targetGo == 0))
            {
                goto label_42;
            }
            
            UnityEngine.Transform val_32 = this.targetGo.transform;
            UnityEngine.Vector3 val_33 = position;
            UnityEngine.Transform val_34 = this.gameObjectCached.transform;
            UnityEngine.Vector3 val_35 = position;
            float val_86 = val_9;
            float val_87 = val_10;
            val_86 = val_9 - val_86;
            val_87 = val_10 - val_87;
            float val_88 = 6.283185f;
            val_88 = val_87 + val_88;
            if(this.gameObjectCached < 0)
            {
                    val_87 = val_88;
            }
            
            this.laserAngle = val_87;
            UnityEngine.Transform val_36 = this.transform;
            UnityEngine.Transform val_37 = this.transform;
            val_87 = val_87 * 57.29578f;
            if(this.lerpLaserRotation == false)
            {
                goto label_48;
            }
            
            UnityEngine.Quaternion val_38 = rotation;
            UnityEngine.Transform val_40 = this.transform;
            UnityEngine.Vector3 val_41 = forward;
            UnityEngine.Quaternion val_42 = UnityEngine.Quaternion.AngleAxis(angle:  val_41.x, axis:  new UnityEngine.Vector3() {x = 1.228348E+15f, y = val_87, z = val_9});
            float val_43 = UnityEngine.Time.deltaTime;
            float val_89 = this.turningRate;
            val_89 = 0 * val_89;
            UnityEngine.Quaternion val_44 = UnityEngine.Quaternion.Slerp(a:  new UnityEngine.Quaternion() {x = 1.228348E+15f, y = val_9, z = val_10, w = val_26}, b:  new UnityEngine.Quaternion() {x = val_39}, t:  val_89);
            this.rotation = new UnityEngine.Quaternion() {x = val_9, y = val_10, z = val_26, w = val_39};
            UnityEngine.Transform val_45 = this.transform;
            UnityEngine.Quaternion val_46 = rotation;
            UnityEngine.Vector3 val_47 = UnityEngine.Vector3.right;
            UnityEngine.Vector3 val_48 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = 1.228348E+15f, y = R4, z = R5, w = R6}, point:  new UnityEngine.Vector3() {x = ???});
            UnityEngine.Transform val_49 = this.transform;
            UnityEngine.Vector3 val_50 = position;
            int val_51 = UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask() {m_Mask = this.mask});
            UnityEngine.RaycastHit2D val_52 = UnityEngine.Physics2D.Raycast(origin:  new UnityEngine.Vector2() {x = 1.228348E+15f, y = val_9}, direction:  new UnityEngine.Vector2() {x = val_10, y = val_9}, distance:  val_50.x, layerMask:  val_10);
            goto label_91;
            label_42:
            UnityEngine.Transform val_53 = this.transform;
            UnityEngine.Vector3 val_54 = position;
            UnityEngine.Transform val_55 = this.transform;
            UnityEngine.Vector3 val_56 = right;
            int val_57 = UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask() {m_Mask = this.mask});
            UnityEngine.RaycastHit2D val_58 = UnityEngine.Physics2D.Raycast(origin:  new UnityEngine.Vector2() {x = 1.228348E+15f, y = val_9}, direction:  new UnityEngine.Vector2() {x = val_10, y = val_9}, distance:  val_56.x, layerMask:  val_10);
            UnityEngine.Transform val_59 = val_58.m_Collider.transform;
            UnityEngine.Vector3 val_60 = position;
            UnityEngine.Transform val_61 = val_58.m_Collider.transform;
            UnityEngine.Vector3 val_62 = right;
            float val_90 = val_10;
            float val_91 = val_26;
            val_86 = val_9 * (val_58.m_Collider + 68);
            val_90 = val_90 * (val_58.m_Collider + 68);
            val_91 = val_91 * (val_58.m_Collider + 68);
            UnityEngine.Debug.DrawRay(start:  new UnityEngine.Vector3() {x = val_9, y = val_10, z = val_26}, dir:  new UnityEngine.Vector3() {x = val_86, y = val_90, z = val_91});
            label_91:
            if((val_58.m_Collider + 49) != 0)
            {
                    val_58.m_Collider.SetLaserBackToDefaults();
                val_58.m_Collider.SetLaserArcVertices(distancePoint:  val_86, useHitPoint:  false);
                val_58.m_Collider.SetLaserArcSegmentLength();
                return;
            }
            
            UnityEngine.Collider2D val_63 = mem[val_58.m_Fraction + (0)].collider;
            if(1485546960 == 0)
            {
                goto label_68;
            }
            
            UnityEngine.Vector2 val_65 = point;
            UnityEngine.Transform val_66 = val_58.m_Collider.transform;
            UnityEngine.Vector3 val_67 = position;
            float val_68 = UnityEngine.Vector2.Distance(a:  new UnityEngine.Vector2() {x = val_9, y = val_10}, b:  new UnityEngine.Vector2() {x = val_9, y = val_10});
            val_88 = 0.25f;
            mem2[0] = val_9;
            val_58.m_Collider.InstantiateLaserPart(laserComponent: ref  val_58.m_Collider + 124, laserPart:  val_58.m_Collider + 20);
            if((val_58.m_Collider + 56) != 0)
            {
                    UnityEngine.Transform val_71 = val_58.m_Collider + 56.transform;
                UnityEngine.Vector2 val_72 = point;
                val_58.m_Collider + 56.position = new UnityEngine.Vector3() {x = val_9, y = val_10, z = 0f};
                val_58.m_Collider + 136.enabled = true;
                UnityEngine.GameObject val_74 = val_58.m_Collider + 56.gameObject;
                val_58.m_Collider + 56.SetActive(value:  true);
            }
            
            bool val_75 = val_58.m_Collider + 24.enabled;
            if((val_58.m_Collider + 92) == 0)
            {
                goto label_78;
            }
            
            if(val_75 != true)
            {
                    val_58.m_Collider + 24.enabled = true;
            }
            
            val_58.m_Collider.SetLaserArcVertices(distancePoint:  val_72.x, useHitPoint:  val_58.m_Collider + 40);
            val_58.m_Collider.SetLaserArcSegmentLength();
            goto label_92;
            label_68:
            val_58.m_Collider.SetLaserBackToDefaults();
            bool val_76 = val_58.m_Collider + 24.enabled;
            if((val_58.m_Collider + 92) == 0)
            {
                goto label_83;
            }
            
            if(val_76 != true)
            {
                    val_58.m_Collider + 24.enabled = true;
            }
            
            val_58.m_Collider.SetLaserArcSegmentLength();
            val_58.m_Collider.SetLaserArcVertices(distancePoint:  val_86, useHitPoint:  false);
            return;
            label_48:
            UnityEngine.Vector3 val_77 = forward;
            UnityEngine.Quaternion val_78 = UnityEngine.Quaternion.AngleAxis(angle:  val_77.x, axis:  new UnityEngine.Vector3() {x = 1.228348E+15f, y = val_87, z = val_9});
            this.rotation = new UnityEngine.Quaternion() {x = R5, y = R6, z = R7, w = val_39};
            UnityEngine.Transform val_79 = this.transform;
            UnityEngine.Vector3 val_80 = position;
            int val_81 = UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask() {m_Mask = this.mask});
            UnityEngine.RaycastHit2D val_82 = UnityEngine.Physics2D.Raycast(origin:  new UnityEngine.Vector2() {x = 1.228348E+15f, y = val_9}, direction:  new UnityEngine.Vector2() {x = val_10, y = val_86}, distance:  val_80.x, layerMask:  val_87);
            goto label_91;
            label_78:
            if(val_75 != false)
            {
                    val_58.m_Collider + 24.enabled = false;
            }
            
            label_92:
            if((val_58.m_Collider + 132) != 0)
            {
                    return;
            }
            
            System.Collections.IEnumerator val_83 = val_58.m_Collider.HitTrigger(triggerInterval:  val_72.x, hit:  new UnityEngine.RaycastHit2D() {m_Centroid = new UnityEngine.Vector2() {x = val_58.m_Collider + 80, y = mem[val_82.m_Normal.y + (0)]}, m_Point = new UnityEngine.Vector2() {x = mem[val_82.m_Normal.y + (4)], y = mem[val_82.m_Normal.y + (8)]}, m_Normal = new UnityEngine.Vector2() {x = mem[val_82.m_Normal.y + (12)], y = mem[val_82.m_Normal.y + (16) + (0)]}, m_Distance = mem[val_82.m_Normal.y + (16) + (4)]});
            UnityEngine.Coroutine val_84 = val_58.m_Collider.StartCoroutine(routine:  val_58.m_Collider);
            return;
            label_83:
            if(val_76 == false)
            {
                    return;
            }
            
            val_58.m_Collider + 24.enabled = false;
        }
        private System.Collections.IEnumerator HitTrigger(float triggerInterval, UnityEngine.RaycastHit2D hit)
        {
            var val_1;
            var val_3;
            int val_4;
            float val_5;
            val_3 = val_1;
            val_4 = hit.m_Collider;
            val_5 = hit.m_Fraction;
            SpriteBasedLaser.<HitTrigger>d__44 val_2 = 536901445;
            val_2 = new SpriteBasedLaser.<HitTrigger>d__44(<>1__state:  0);
            if(val_2 != 0)
            {
                    mem[536901461] = this;
                mem[536901501] = hit.m_Centroid.x;
                val_3 = val_3;
                val_5 = val_5;
                val_4 = hit.m_Collider;
            }
            else
            {
                    mem[16] = this;
                mem[56] = hit.m_Centroid.x;
            }
            
            mem[536901465] = hit.m_Centroid.y;
            mem[536901469] = hit.m_Point.x;
            mem[536901473] = hit.m_Point.y;
            mem[536901477] = hit.m_Normal.x;
            mem[536901481] = hit.m_Normal.y;
            mem[536901485] = hit.m_Distance;
            mem[536901489] = val_5;
            mem[536901493] = val_4;
            mem[536901497] = val_3;
        }
        public void SetLaserState(bool enabledStatus)
        {
            this.laserActive = enabledStatus;
            if(this.startGoPiece != 0)
            {
                    this.startGoPiece.SetActive(value:  enabledStatus);
            }
            
            if(this.middleGoPiece != 0)
            {
                    this.middleGoPiece.SetActive(value:  enabledStatus);
            }
            
            if(this.endGoPiece != 0)
            {
                    this.endGoPiece.SetActive(value:  enabledStatus);
            }
            
            if(this.laserLineRendererArc != 0)
            {
                    this.laserLineRendererArc.enabled = enabledStatus;
            }
            
            if(this.hitSparkParticleSystem == 0)
            {
                    return;
            }
            
            UnityEngine.GameObject val_6 = this.hitSparkParticleSystem.gameObject;
            this.hitSparkParticleSystem.SetActive(value:  enabledStatus);
        }
        private void SetLaserArcSegmentLength()
        {
            int val_1 = UnityEngine.Mathf.Abs(value:  (int)this.maxLaserLength);
            this.laserLineRendererArc.SetVertexCount(count:  val_1);
            this.laserArcSegments = val_1;
        }
        private void SetLaserBackToDefaults()
        {
            UnityEngine.Object.Destroy(obj:  this.endGoPiece);
            this.maxLaserLength = this.startLaserLength;
            if(this.hitSparkParticleSystem == 0)
            {
                    return;
            }
            
            var val_2 = R4 + 136;
            if(val_2.enabled != false)
            {
                    val_2.enabled = false;
            }
            
            UnityEngine.GameObject val_4 = R4 + 56.gameObject;
            R4 + 56.SetActive(value:  false);
        }
        private void InstantiateLaserPart(ref UnityEngine.GameObject laserComponent, UnityEngine.GameObject laserPart)
        {
            float val_8;
            float val_9;
            var val_12;
            DropdownItem val_13;
            UnityEngine.GameObject val_14;
            val_12 = this;
            val_13 = laserPart;
            val_14 = laserComponent;
            if(val_14 != 0)
            {
                    return;
            }
            
            DropdownItem val_2 = UnityEngine.Object.Instantiate<DropdownItem>(original:  val_13);
            laserComponent = val_13;
            UnityEngine.Transform val_3 = laserComponent.transform;
            UnityEngine.GameObject val_4 = this.gameObject;
            UnityEngine.Transform val_5 = this.transform;
            laserComponent.parent = 1486291008;
            val_12 = 0;
            UnityEngine.Transform val_6 = laserComponent.transform;
            UnityEngine.Vector2 val_7 = UnityEngine.Vector2.zero;
            laserComponent.localPosition = new UnityEngine.Vector3() {x = val_8, y = val_9, z = 0f};
            val_14 = 0;
            UnityEngine.Transform val_10 = laserComponent.transform;
            UnityEngine.Vector2 val_11 = UnityEngine.Vector2.zero;
            val_13 = val_9;
            laserComponent.localEulerAngles = new UnityEngine.Vector3() {x = val_8, y = val_13, z = 0f};
        }
        public void DisableLaserGameObjectComponents()
        {
            UnityEngine.Object.Destroy(obj:  this.startGoPiece);
            UnityEngine.Object.Destroy(obj:  this.middleGoPiece);
            UnityEngine.Object.Destroy(obj:  this.endGoPiece);
        }
        public SpriteBasedLaser()
        {
            this.laserArcSegments = 20;
            this.maxLaserLength = 20f;
            this.oscillationSpeed = 1f;
            this.turningRate = 3f;
            this.collisionTriggerInterval = 0.25f;
            this.oscillationThreshold = 0.2f;
        }
    
    }

}
