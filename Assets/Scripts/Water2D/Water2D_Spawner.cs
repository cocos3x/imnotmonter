using UnityEngine;

namespace Water2D
{
    public class Water2D_Spawner : MonoBehaviour
    {
        // Fields
        public static Water2D.Water2D_Spawner instance;
        public string Water2DType;
        public Water2D.Water2D_Spawner.EmissionType Water2DEmissionType;
        public Water2D.Water2D_Spawner.FillerColliderType Water2DFillerType;
        public bool FillerColliderMasked;
        public string Water2DRenderType;
        public string Water2DVersion;
        public UnityEngine.GameObject DropObject;
        public UnityEngine.GameObject[] WaterDropsObjects;
        public bool PersistentFluid;
        public float size;
        public bool ScaleDown;
        public float LifeTime;
        public float DelayBetweenParticles;
        public float TrailStartSize;
        public float TrailEndSize;
        public float TrailDelay;
        public UnityEngine.Material WaterMaterial;
        public int Sorting;
        public int ColorScheme;
        public UnityEngine.Color FillColor;
        public UnityEngine.Color StrokeColor;
        public UnityEngine.Color _lastStrokeColor;
        public bool Blending;
        public bool _lastBlending;
        public float AlphaCutOff;
        public float AlphaStroke;
        public UnityEngine.Color TintColor;
        public float Intensity;
        public float Distortion;
        public float DistortionSpeed;
        public UnityEngine.Vector2 initSpeed;
        public float Speed;
        public UnityEngine.PhysicsMaterial2D PhysicMat;
        public float ColliderSize;
        public float LinearDrag;
        public float AngularDrag;
        public float GravityScale;
        public bool FreezeRotation;
        public UnityEngine.Vector2 SpeedLimiterX;
        public UnityEngine.Vector2 SpeedLimiterY;
        public bool SimulateOnAwake;
        public bool SimulateInEditor;
        public bool SimulateInPlayMode;
        public int DropCount;
        public int _lastDropCount;
        public bool Loop;
        public int DropsUsed;
        public bool DynamicChanges;
        public Water2D.Water2DEvents OnValidateShapeFill;
        public UnityEngine.Collider2D ShapeFillCollider2D;
        public float ShapeFillAccuracy;
        public Water2D.Water2DEvents OnCollisionEnterList;
        public Water2D.Water2DEvents OnSpawnerAboutStart;
        public Water2D.Water2DEvents OnSpawnerAboutEnd;
        public Water2D.Water2DEvents OnSpawnerEmitingParticle;
        private int <AllBallsCount>k__BackingField;
        private bool <IsSpawning>k__BackingField;
        public bool isRefractingMaterial;
        private int usableDropsCount;
        private int DefaultCount;
        private bool _breakLoop;
        private UnityEngine.GameObject _parent;
        private string _parentNameID;
        private int _spawnedDrops;
        private UnityEngine.Color _lastFillColor;
        private bool _canInvokeAttheEnd;
        private UnityEngine.Camera fresnelCamera;
        private int _lastSorting;
        private bool _checkOnFillRunning;
        private bool _breakCheckOnFill;
        private bool _checkOnFillComplete;
        
        // Properties
        public int AllBallsCount { get; set; }
        public bool IsSpawning { get; set; }
        
        // Methods
        private void Awake()
        {
            var val_3 = 22716604;
            if(mem[536896983] != 0)
            {
                    return;
            }
            
            mem2[0] = this;
        }
        private System.Collections.IEnumerator Start()
        {
            536902365 = new Water2D_Spawner.<Start>d__59(<>1__state:  0);
            mem[536902381] = this;
        }
        private static void RunSpawner()
        {
            mem[536896983].Spawn(count:  mem[536896983] + 292);
        }
        private static void StopSpawner()
        {
            mem[536896983].Restore();
        }
        public int get_AllBallsCount()
        {
            return (int)this.<AllBallsCount>k__BackingField;
        }
        private void set_AllBallsCount(int value)
        {
            this.<AllBallsCount>k__BackingField = value;
        }
        public bool get_IsSpawning()
        {
            return (bool)this.<IsSpawning>k__BackingField;
        }
        private void set_IsSpawning(bool value)
        {
            this.<IsSpawning>k__BackingField = value;
        }
        public void SetupParticles()
        {
            float val_12;
            float val_13;
            float val_14;
            float val_20;
            float val_21;
            Water2D.Water2D_Spawner val_44;
            UnityEngine.GameObject[] val_45;
            bool val_46;
            var val_47;
            var val_48;
            var val_49;
            val_44 = this;
            bool val_1 = UnityEngine.Object.op_Equality(x:  this._parent, y:  0);
            if(val_1 != false)
            {
                    if(val_1 == true)
            {
                goto label_4;
            }
            
            }
            
            label_89:
            if(this._parent != 0)
            {
                    UnityEngine.Object.DestroyImmediate(obj:  this._parent);
            }
            
            UnityEngine.GameObject val_3 = this.gameObject;
            string val_5 = this.GetInstanceID().ToString();
            string val_6 = this._parentNameID + 934413644;
            UnityEngine.GameObject val_7 = 536887303;
            val_7 = new UnityEngine.GameObject(name:  this._parentNameID);
            mem2[0] = val_7;
            UnityEngine.Transform val_8 = this._parent.transform;
            this._parent.hideFlags = 1;
            val_45 = this.WaterDropsObjects;
            this.WaterDropsObjects = 536881957;
            goto label_13;
            label_79:
            UnityEngine.GameObject val_9 = this.gameObject;
            UnityEngine.Transform val_10 = this.DropObject.transform;
            UnityEngine.Vector3 val_11 = position;
            UnityEngine.Quaternion val_15 = new UnityEngine.Quaternion(x:  val_11.x, y:  val_11.y, z:  val_11.z, w:  null);
            val_46 = mem[536891408];
            if((val_46 & true) == 0)
            {
                    val_46 = mem[536891337];
            }
            
            object val_16 = UnityEngine.Object.Instantiate<System.Object>(original:  this.DropObject, position:  new UnityEngine.Vector3() {x = val_12, y = val_13, z = val_14}, rotation:  new UnityEngine.Quaternion() {x = val_15.x, y = val_15.y, z = val_15.z, w = val_15.w});
            val_44 = val_44;
            mem2[0] = this.DropObject;
            Weight val_17 = this.WaterDropsObjects + 16.GetComponent<Weight>();
            this.WaterDropsObjects + 16.Active = false;
            Weight val_18 = this.WaterDropsObjects + 16.GetComponent<Weight>();
            UnityEngine.Vector2 val_19 = UnityEngine.Vector2.zero;
            this.WaterDropsObjects + 16.velocity = new UnityEngine.Vector2() {x = val_20, y = val_21};
            UnityEngine.Transform val_22 = this.WaterDropsObjects + 16.transform;
            UnityEngine.Transform val_23 = this._parent.transform;
            this.WaterDropsObjects + 16.SetParent(p:  this._parent);
            UnityEngine.Transform val_24 = this.WaterDropsObjects + 16.transform;
            this.WaterDropsObjects + 16.localScale = new UnityEngine.Vector3() {x = mem[1152921509836240032], y = mem[1152921509836240032], z = 1f};
            this.WaterDropsObjects + 16.layer = this.WaterDropsObjects + 16.layer;
            UnityEngine.Color val_26 = UnityEngine.Color.white;
            val_47 = mem[1152921509836240068];
            if(val_47 == 1)
            {
                    UnityEngine.Color val_27 = new UnityEngine.Color(r:  val_26.r, g:  val_26.g, b:  val_26.b);
                val_47 = mem[1152921509836240068];
            }
            
            if(val_47 == 2)
            {
                    UnityEngine.Color val_28 = new UnityEngine.Color(r:  val_26.r, g:  val_26.g, b:  val_26.b);
                val_47 = mem[1152921509836240068];
            }
            
            if(val_47 == 3)
            {
                    UnityEngine.Color val_29 = new UnityEngine.Color(r:  val_26.r, g:  val_26.g, b:  val_26.b);
            }
            
            if((System.String.op_Equality(a:  mem[1152921509836239996], b:  -1610604997)) != true)
            {
                    if((System.String.op_Equality(a:  mem[1152921509836239996], b:  -1610605017)) == false)
            {
                goto label_49;
            }
            
            }
            
            label_49:
            Weight val_32 = this.WaterDropsObjects + 16.GetComponent<Weight>();
            this.WaterDropsObjects + 16.color = new UnityEngine.Color() {r = val_29.r, g = val_29.g, b = val_29.b, a = val_29.a};
            Weight val_33 = this.WaterDropsObjects + 16.GetComponent<Weight>();
            this.WaterDropsObjects + 16.startColor = new UnityEngine.Color() {r = val_29.r, g = val_29.g, b = val_29.b, a = val_29.a};
            Weight val_34 = this.WaterDropsObjects + 16.GetComponent<Weight>();
            this.WaterDropsObjects + 16.endColor = new UnityEngine.Color() {r = val_29.r, g = val_29.g, b = val_29.b, a = val_29.a};
            val_45 = val_45;
            Weight val_35 = this.WaterDropsObjects + 16.GetComponent<Weight>();
            mem2[0] = mem[1152921509836240120];
            Weight val_36 = this.WaterDropsObjects + 16.GetComponent<Weight>();
            if((this.WaterDropsObjects + 16) <= 0)
            {
                goto label_70;
            }
            
            this.WaterDropsObjects + 16.enabled = true;
            if((this.WaterDropsObjects + 16) == 0)
            {
                goto label_71;
            }
            
            this.WaterDropsObjects + 16.startWidth = val_26.r;
            this.WaterDropsObjects + 16.endWidth = val_26.r;
            val_48 = mem[1152921509836240056];
            goto label_72;
            label_70:
            this.WaterDropsObjects + 16.enabled = false;
            goto label_73;
            label_71:
            this.WaterDropsObjects + 16.startWidth = val_26.r;
            this.WaterDropsObjects + 16.endWidth = val_26.r;
            val_48 = mem[1152921509836240056];
            label_72:
            this.WaterDropsObjects + 16.time = val_26.r;
            label_73:
            Weight val_37 = this.WaterDropsObjects + 16.GetComponent<Weight>();
            mem2[0] = val_44;
            label_13:
            val_49 = val_45;
            if(val_45 == null)
            {
                    val_49 = mem[this.WaterDropsObjects];
                val_49 = val_45;
            }
            
            if(1 < (this.WaterDropsObjects + 12))
            {
                goto label_79;
            }
            
            mem[1152921509836240264] = this.WaterDropsObjects + 12;
            if(mem[1152921509836240000] == 0)
            {
                    mem[1152921509836240000] = 0;
                mem[1152921509836240292] = mem[1152921509836240000];
                mem[1152921509836240228] = mem[1152921509836240000];
            }
            
            System.Collections.IEnumerator val_38 = this._restoreCheckingFillShapeEnum();
            UnityEngine.Coroutine val_39 = this.StartCoroutine(routine:  934425712);
            return;
            label_4:
            if(this.WaterDropsObjects[0] == 0)
            {
                goto label_89;
            }
            
            UnityEngine.GameObject val_45 = this.WaterDropsObjects[0];
            UnityEngine.Transform val_41 = val_45.transform;
            UnityEngine.Transform val_42 = val_45.parent;
            UnityEngine.GameObject val_43 = val_45.gameObject;
            mem2[0] = val_45;
            goto label_89;
        }
        public void Spawn()
        {
            this.Spawn(count:  this.DefaultCount);
        }
        public void Spawn(int count)
        {
            this.DropsUsed = 0;
            if()
            {
                    this.SpawnAll();
                return;
            }
            
            UnityEngine.GameObject val_1 = this.gameObject;
            UnityEngine.Transform val_2 = this.transform;
            UnityEngine.Vector3 val_3 = position;
            System.Collections.IEnumerator val_4 = this.loop(_pos:  new UnityEngine.Vector3() {x = 2.182249E-05f, y = 1.401298E-45f}, _initSpeed:  new UnityEngine.Vector2() {x = this.initSpeed, y = this}, count:  0, delay:  val_3.x, waitBetweenDropSpawn:  false);
            UnityEngine.Coroutine val_5 = this.StartCoroutine(routine:  934743920);
        }
        public void SpawnAll()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            UnityEngine.Transform val_2 = this.transform;
            UnityEngine.Vector3 val_3 = position;
            this.SpawnAllParticles(_pos:  new UnityEngine.Vector3() {x = 2.202622E-05f, y = this.DefaultCount}, _initSpeed:  new UnityEngine.Vector2() {x = this.initSpeed, y = this}, count:  this.DefaultCount, delay:  val_3.x);
        }
        public void Spawn(int count, UnityEngine.Vector3 pos)
        {
            System.Collections.IEnumerator val_1 = this.loop(_pos:  new UnityEngine.Vector3() {x = count, y = 1.401298E-45f, z = 0f}, _initSpeed:  new UnityEngine.Vector2() {x = this.initSpeed, y = count}, count:  0, delay:  null, waitBetweenDropSpawn:  false);
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  934967920);
        }
        public void Spawn(int count, UnityEngine.Vector3 pos, UnityEngine.Vector2 InitVelocity, float delay = 0)
        {
            float val_1;
            System.Collections.IEnumerator val_2 = this.loop(_pos:  new UnityEngine.Vector3() {x = InitVelocity.y, y = 1.401298E-45f, z = pos.y}, _initSpeed:  new UnityEngine.Vector2() {x = InitVelocity.x, y = InitVelocity.y}, count:  0, delay:  val_1, waitBetweenDropSpawn:  val_1);
            UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  935079920);
        }
        public void StopSpawning()
        {
            this.<IsSpawning>k__BackingField = false;
            this._breakLoop = true;
        }
        public void Restore()
        {
            var val_5;
            this._breakLoop = true;
            val_5 = 4;
            this.<IsSpawning>k__BackingField = false;
            this.DropsUsed = false;
            goto label_1;
            label_21:
            if(this.WaterDropsObjects[0] != 0)
            {
                    UnityEngine.GameObject val_7 = this.WaterDropsObjects[0];
                Weight val_2 = val_7.GetComponent<Weight>();
                if(val_7 != 0)
            {
                    UnityEngine.GameObject val_8 = this.WaterDropsObjects[0];
                Weight val_3 = val_8.GetComponent<Weight>();
                val_8.Active = false;
            }
            
                UnityEngine.GameObject val_9 = this.WaterDropsObjects[0];
                Weight val_4 = val_9.GetComponent<Weight>();
                mem2[0] = false;
            }
            
            val_5 = 5;
            label_1:
            if((val_5 - 4) < val_9)
            {
                goto label_21;
            }
            
            this.usableDropsCount = this.<AllBallsCount>k__BackingField;
            this.DefaultCount = this.<AllBallsCount>k__BackingField;
        }
        private void loop_editor(UnityEngine.Vector3 _pos, UnityEngine.Vector2 _initSpeed, int count = -1, float delay = 0, bool waitBetweenDropSpawn = True)
        {
            float val_14;
            float val_15;
            float val_16;
            float val_32;
            UnityEngine.GameObject[] val_40;
            var val_41;
            UnityEngine.GameObject val_42;
            float val_43;
            var val_44;
            var val_45;
            float val_46;
            var val_47;
            float val_48;
            float val_49;
            UnityEngine.PhysicsMaterial2D val_50;
            float val_51;
            float val_52;
            float val_53;
            if(UnityEngine.Application.isPlaying == true)
            {
                    return;
            }
            
            if(this.Water2DEmissionType != 1)
            {
                    this.Water2DEmissionType = this.SimulateInEditor;
            }
            
            if(this.Water2DEmissionType != true)
            {
                    return;
            }
            
            val_40 = this.WaterDropsObjects;
            if((val_40 == null) || (this.Water2DEmissionType < true))
            {
                goto label_4;
            }
            
            val_41 = 4;
            goto label_5;
            label_31:
            if(this.WaterDropsObjects[0] == 0)
            {
                    return;
            }
            
            UnityEngine.GameObject val_41 = this.WaterDropsObjects[0];
            Weight val_3 = val_41.GetComponent<Weight>();
            val_42 = val_41;
            val_43 = 0;
            bool val_4 = System.String.op_Equality(a:  this.Water2DType, b:  -1610605017);
            if(val_4 == false)
            {
                goto label_14;
            }
            
            if(val_4 != true)
            {
                    UnityEngine.GameObject val_5 = val_42.gameObject;
                Weight val_6 = val_42.GetComponent<Weight>();
                val_43 = val_42;
                val_42.color = new UnityEngine.Color() {r = this.FillColor, g = val_43, b = 4.036775E-38f, a = val_42};
                val_42 = val_42;
                val_44 = ???;
            }
            
            this.SetRefractingWaterparams(intensity:  delay, mag:  null, speed:  null);
            goto label_28;
            label_14:
            bool val_7 = System.String.op_Equality(a:  this.Water2DType, b:  -1610603379);
            if(val_7 == false)
            {
                goto label_20;
            }
            
            val_44 = R6;
            this.SetToonWaterparams(fill:  new UnityEngine.Color() {r = mem[this.FillColor + (0)], g = mem[this.FillColor + (4)], b = mem[this.FillColor + (8)], a = val_7}, stroke:  new UnityEngine.Color() {r = this.StrokeColor, g = ???, b = val_41, a = 4.036775E-38f}, alphaCutoff:  this.AlphaCutOff, alphaStroke:  null);
            goto label_22;
            label_20:
            val_45 = 0;
            val_46 = -1610604997;
            bool val_8 = System.String.op_Equality(a:  this.Water2DType, b:  -1610604997);
            if(val_8 == false)
            {
                goto label_22;
            }
            
            if(val_8 != true)
            {
                    UnityEngine.GameObject val_9 = val_42.gameObject;
                Weight val_10 = val_42.GetComponent<Weight>();
                val_46 = this.FillColor;
                val_45 = 22713552;
                val_42.color = new UnityEngine.Color() {r = val_46, g = 4.014704E-38f, b = 4.036775E-38f, a = ???};
                val_42 = val_42;
                val_44 = ???;
            }
            
            this.SetRegularWaterparams(fill:  new UnityEngine.Color() {r = val_46, g = 4.014704E-38f, b = 4.036775E-38f, a = ???}, fresnel:  new UnityEngine.Color() {r = 0f, g = ???, b = val_41, a = 4.036775E-38f}, alphaCutoff:  this.AlphaCutOff, multiplier:  null);
            goto label_28;
            label_22:
            label_28:
            if(this == 0)
            {
                goto label_29;
            }
            
            val_40 = this.WaterDropsObjects;
            val_41 = 5;
            label_5:
            if(1 < this)
            {
                goto label_31;
            }
            
            return;
            label_4:
            this.SetupParticles();
            return;
            label_29:
            this._canInvokeAttheEnd = true;
            if(this > 0)
            {
                    -1f = this.LifeTime;
            }
            
            mem2[0] = -1f;
            UnityEngine.GameObject val_42 = this.WaterDropsObjects[0];
            UnityEngine.Transform val_11 = val_42.transform;
            UnityEngine.Transform val_12 = this.transform;
            UnityEngine.Vector3 val_13 = position;
            val_42.position = new UnityEngine.Vector3() {x = val_14, y = val_15, z = val_16};
            val_42.Active = true;
            mem2[0] = 0;
            UnityEngine.Vector2 val_17 = UnityEngine.Vector2.zero;
            UnityEngine.Transform val_18 = val_42.transform;
            val_47 = 1065353216;
            val_42.localScale = new UnityEngine.Vector3() {x = this.size, y = this.size, z = 1f};
            UnityEngine.GameObject val_43 = this.WaterDropsObjects[0];
            Weight val_19 = val_43.GetComponent<Weight>();
            if(val_43 <= 0)
            {
                goto label_43;
            }
            
            val_43.enabled = true;
            if(val_43 == 0)
            {
                goto label_44;
            }
            
            val_43.startWidth = val_17.x;
            val_43.endWidth = val_17.x;
            val_48 = this.TrailDelay;
            goto label_45;
            label_43:
            val_43.enabled = false;
            goto label_46;
            label_44:
            val_43.startWidth = val_17.x;
            val_43.endWidth = val_17.x;
            val_48 = this.TrailDelay;
            label_45:
            val_43.time = val_17.x;
            label_46:
            mem2[0] = val_48;
            mem2[0] = this.SpeedLimiterX;
            mem2[0] = val_48;
            mem2[0] = this.SpeedLimiterY;
            UnityEngine.Transform val_20 = val_42.GetComponent<UnityEngine.Transform>();
            if(val_42 != 0)
            {
                    val_42.sharedMaterial = this.PhysicMat;
                val_42.drag = val_17.x;
                val_42.angularDrag = val_17.x;
                val_49 = this.GravityScale;
            }
            else
            {
                    val_42.sharedMaterial = this.PhysicMat;
                val_42.drag = val_17.x;
                val_42.angularDrag = val_17.x;
                val_49 = this.GravityScale;
            }
            
            val_42.gravityScale = val_17.x;
            if(this.FreezeRotation != false)
            {
                    val_42.constraints = 4;
            }
            
            UnityEngine.Transform val_21 = val_42.GetComponent<UnityEngine.Transform>();
            val_50 = this.PhysicMat;
            val_42.sharedMaterial = val_50;
            UnityEngine.Transform val_22 = val_42.GetComponent<UnityEngine.Transform>();
            val_42.radius = val_17.x;
            val_51 = 0;
            mem2[0] = this.ScaleDown;
            bool val_23 = System.String.op_Equality(a:  this.Water2DType, b:  -1610605017);
            if(val_23 != false)
            {
                    if(val_23 != true)
            {
                    UnityEngine.GameObject val_24 = val_42.gameObject;
                Weight val_25 = val_42.GetComponent<Weight>();
                val_50 = val_42;
                val_51 = val_42;
                val_50.color = new UnityEngine.Color() {r = this.FillColor, g = val_51, b = 5.605194E-45f, a = val_42};
            }
            
                this.SetRefractingWaterparams(intensity:  val_17.x, mag:  val_17.y, speed:  val_13.z);
            }
            else
            {
                    bool val_26 = System.String.op_Equality(a:  this.Water2DType, b:  -1610603379);
                if(val_26 != false)
            {
                    this.SetToonWaterparams(fill:  new UnityEngine.Color() {r = mem[this.FillColor + (0)], g = mem[this.FillColor + (4)], b = mem[this.FillColor + (8)], a = val_26}, stroke:  new UnityEngine.Color() {r = this.StrokeColor, g = val_50, b = val_42, a = val_42}, alphaCutoff:  this.AlphaCutOff, alphaStroke:  val_17.y);
            }
            else
            {
                    val_52 = 0;
                val_53 = -1610604997;
                if((System.String.op_Equality(a:  this.Water2DType, b:  -1610604997)) != false)
            {
                    if(this._lastFillColor == 0)
            {
                    UnityEngine.GameObject val_28 = val_42.gameObject;
                Weight val_29 = val_42.GetComponent<Weight>();
                val_50 = val_42;
                val_53 = this.FillColor;
                val_52 = val_42;
                val_47 = val_41;
                val_50.color = new UnityEngine.Color() {r = val_53, g = val_52, b = 5.605194E-45f, a = val_42};
            }
            
                this.SetRegularWaterparams(fill:  new UnityEngine.Color() {r = val_53, g = val_52, b = 5.605194E-45f, a = val_42}, fresnel:  new UnityEngine.Color() {r = 0f, g = val_50, b = val_42, a = val_42}, alphaCutoff:  this.AlphaCutOff, multiplier:  val_17.y);
            }
            
            }
            
            }
            
            UnityEngine.Transform val_30 = this.transform;
            UnityEngine.Quaternion val_31 = localRotation;
            UnityEngine.Vector2 val_33 = UnityEngine.Vector2.down;
            UnityEngine.Vector3 val_34 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = 2.425227E-05f, y = R5, z = R6, w = R7}, point:  new UnityEngine.Vector3() {x = val_32, y = val_14, z = val_15});
            UnityEngine.Transform val_35 = val_42.GetComponent<UnityEngine.Transform>();
            float val_44 = this.Speed;
            val_44 = val_14 * val_44;
            val_42.velocity = new UnityEngine.Vector2() {x = val_44, y = val_15 * val_44};
            int val_45 = this.DropsUsed;
            val_45 = val_45 + 1;
            this.DropsUsed = val_45;
            this._spawnedDrops = this._spawnedDrops + 1;
            UnityEngine.GameObject val_38 = this.gameObject;
            this.InvokeOnSpawnerEmittinEachParticle(obj:  936091760);
            if(this._spawnedDrops < this.DropCount)
            {
                    return;
            }
            
            if(this.Loop == false)
            {
                    this.Loop = false;
                this.SimulateInEditor = this.Loop;
            }
            
            if(this._canInvokeAttheEnd != false)
            {
                    UnityEngine.GameObject val_39 = this.gameObject;
                this.InvokeOnSpawnerEnd(obj:  936091760);
                this._canInvokeAttheEnd = false;
            }
            
            this._spawnedDrops = 0;
        }
        private System.Collections.IEnumerator loop(UnityEngine.Vector3 _pos, UnityEngine.Vector2 _initSpeed, int count = -1, float delay = 0, bool waitBetweenDropSpawn = True)
        {
            var val_1;
            Water2D_Spawner.<loop>d__88 val_2 = 536902371;
            val_2 = new Water2D_Spawner.<loop>d__88(<>1__state:  0);
            if(val_2 != 0)
            {
                    mem[536902387] = this;
                mem[536902395] = _initSpeed.x;
                mem[536902399] = _initSpeed.y;
                mem[536902391] = waitBetweenDropSpawn;
            }
            else
            {
                    mem[16] = this;
                mem[24] = _initSpeed.x;
                mem[28] = _initSpeed.y;
                mem[20] = waitBetweenDropSpawn;
            }
            
            mem[536902403] = val_1;
        }
        private void SpawnAllParticles(UnityEngine.Vector3 _pos, UnityEngine.Vector2 _initSpeed, int count = -1, float delay = 0)
        {
            float val_5;
            Water2D.Water2D_Spawner val_16;
            float val_17;
            var val_18;
            float val_19;
            float val_20;
            float val_21;
            float val_22;
            float val_23;
            val_16 = this;
            val_17 = _initSpeed.y;
            this.<IsSpawning>k__BackingField = true;
            val_18 = 4;
            val_19 = _initSpeed.x;
            goto label_1;
            label_34:
            UnityEngine.GameObject val_16 = this.WaterDropsObjects[0];
            Weight val_1 = val_16.GetComponent<Weight>();
            val_20 = val_16;
            if(val_16 != 0)
            {
                goto label_31;
            }
            
            mem2[0] = this.LifeTime;
            UnityEngine.GameObject val_17 = this.WaterDropsObjects[0];
            UnityEngine.Transform val_2 = val_17.transform;
            UnityEngine.Transform val_3 = this.transform;
            UnityEngine.Vector3 val_4 = val_19.position;
            val_17.position = new UnityEngine.Vector3() {x = val_19, y = ???, z = val_5};
            val_20.Active = true;
            mem2[0] = 0;
            UnityEngine.Vector2 val_6 = UnityEngine.Vector2.zero;
            float val_18 = val_17;
            float val_19 = val_19;
            val_18 = val_18 - (???);
            val_19 = val_19 - val_19;
            val_18 = val_18 * val_18;
            if(val_17 < 0)
            {
                     = this.initSpeed;
            }
            
            val_16 = val_16;
            val_18 = val_18;
            if(mem[1152921509838490728] == false)
            {
                goto label_21;
            }
            
            UnityEngine.Transform val_7 = val_20.transform;
            val_21 = 1065353216;
            val_20.localScale = new UnityEngine.Vector3() {x = mem[1152921509838490528], y = mem[1152921509838490528], z = 1f};
            if((System.String.op_Equality(a:  mem[1152921509838490492], b:  -1610605017)) == false)
            {
                goto label_14;
            }
            
            this.SetRefractingWaterparams(intensity:  val_18, mag:  val_6.y, speed:  val_19);
            if(val_16 != 0)
            {
                goto label_21;
            }
            
            UnityEngine.GameObject val_9 = val_20.gameObject;
            Weight val_10 = val_20.GetComponent<Weight>();
            val_20 = mem[1152921509838490568];
            val_20.color = new UnityEngine.Color() {r = val_20, g = mem[1152921509838490572], b = mem[1152921509838490576], a = mem[1152921509838490580]};
            val_19 = mem[this.initSpeed + (0)];
            val_17 = mem[this.initSpeed + (4)];
            val_18 = val_18;
            goto label_21;
            label_14:
            if((System.String.op_Equality(a:  mem[1152921509838490492], b:  -1610603379)) != false)
            {
                    this.SetToonWaterparams(fill:  new UnityEngine.Color(), stroke:  new UnityEngine.Color() {b = mem[1152921509838490592], a = mem[1152921509838490596]}, alphaCutoff:  mem[1152921509838490620], alphaStroke:  val_6.y);
            }
            else
            {
                    val_22 = 0;
                val_23 = -1610604997;
                bool val_12 = System.String.op_Equality(a:  mem[1152921509838490492], b:  -1610604997);
                if(val_12 != false)
            {
                    if(val_12 != true)
            {
                    UnityEngine.GameObject val_13 = val_20.gameObject;
                Weight val_14 = val_20.GetComponent<Weight>();
                val_20 = mem[1152921509838490568];
                val_23 = val_20;
                val_22 = mem[1152921509838490572];
                val_21 = mem[1152921509838490576];
                val_20.color = new UnityEngine.Color() {r = val_23, g = val_22, b = val_21, a = mem[1152921509838490580]};
                val_19 = mem[this.initSpeed + (0)];
                val_17 = mem[this.initSpeed + (4)];
                val_18 = val_18;
            }
            
                this.SetRegularWaterparams(fill:  new UnityEngine.Color() {r = val_23, g = val_22, b = val_21, a = mem[1152921509838490580]}, fresnel:  new UnityEngine.Color() {r = 0f, b = mem[1152921509838490592], a = mem[1152921509838490596]}, alphaCutoff:  mem[1152921509838490620], multiplier:  val_6.y);
            }
            
            }
            
            label_21:
            UnityEngine.GameObject val_20 = this.WaterDropsObjects[0];
            Weight val_15 = val_20.GetComponent<Weight>();
            val_20.velocity = new UnityEngine.Vector2() {x = val_19, y = val_17};
            if(count >= 0)
            {
                    if(1 < count)
            {
                
            }
            else
            {
                    if(mem[1152921509838490720] == false)
            {
                    return;
            }
            
            }
            
            }
            
            label_31:
            val_18 = val_18 + 1;
            label_1:
            val_20 = val_18 - 4;
            if(val_20 < mem[1152921509838490720])
            {
                goto label_34;
            }
        
        }
        public void InvokeOnShapeFill(UnityEngine.GameObject obj, UnityEngine.GameObject results)
        {
            if(this.OnValidateShapeFill == 0)
            {
                    return;
            }
            
            this.OnValidateShapeFill.Invoke(arg0:  obj, arg1:  0);
        }
        public void InvokeOnCollisionEnter2D(UnityEngine.GameObject obj, UnityEngine.GameObject other)
        {
            this.OnCollisionEnterList.Invoke(arg0:  obj, arg1:  other);
        }
        public void InvokeOnSpawnerStart(UnityEngine.GameObject obj)
        {
            if(this.OnSpawnerAboutStart == 0)
            {
                    return;
            }
            
            this.OnSpawnerAboutStart.Invoke(arg0:  obj, arg1:  0);
        }
        public void InvokeOnSpawnerEnd(UnityEngine.GameObject obj)
        {
            this.OnSpawnerAboutEnd.Invoke(arg0:  obj, arg1:  0);
        }
        public void InvokeOnSpawnerEmittinEachParticle(UnityEngine.GameObject obj)
        {
            this.OnSpawnerEmitingParticle.Invoke(arg0:  obj, arg1:  0);
        }
        public void SetRegularWaterparams(UnityEngine.Color fill, UnityEngine.Color fresnel, float alphaCutoff, float multiplier)
        {
            var val_4;
            this.WaterMaterial.SetFloat(name:  -1610601921, value:  alphaCutoff);
            this.WaterMaterial.SetFloat(name:  -1610601925, value:  alphaCutoff);
            if((UnityEngine.Color.op_Inequality(lhs:  new UnityEngine.Color() {r = mem[this._lastStrokeColor + (0)], g = mem[this._lastStrokeColor + (4)], b = mem[this._lastStrokeColor + (8)], a = mem[this._lastStrokeColor + (12)]}, rhs:  new UnityEngine.Color() {r = mem[this.StrokeColor + (0)], g = mem[this.StrokeColor + (4)], b = mem[this.StrokeColor + (8)], a = mem[this.StrokeColor + (12)]})) != false)
            {
                    val_4 = 0;
                Water2D.MultiColorManager.SetFresnelColor(StrokeColor:  new UnityEngine.Color() {r = mem[this.StrokeColor + (0)], g = mem[this.StrokeColor + (4)], b = mem[this.StrokeColor + (8)], a = mem[this.StrokeColor + (12)]});
            }
            
            if(this._lastSorting == this.Sorting)
            {
                    return;
            }
            
            this._lastSorting = this.Sorting;
            Water2D.MultiColorManager.SetSorting(sortingID:  this.Sorting);
        }
        public void SetToonWaterparams(UnityEngine.Color fill, UnityEngine.Color stroke, float alphaCutoff, float alphaStroke)
        {
            this.WaterMaterial.SetColor(name:  -1610602151, value:  new UnityEngine.Color() {r = fill.r, g = fill.g, b = fill.b, a = fill.a});
            this.WaterMaterial.SetColor(name:  -1610602025, value:  new UnityEngine.Color() {r = stroke.r, g = stroke.g, b = stroke.b, a = fill.r});
            this.WaterMaterial.SetFloat(name:  -1610602139, value:  alphaCutoff);
            this.WaterMaterial.SetFloat(name:  -1610601953, value:  alphaCutoff);
            this.WaterMaterial.SetFloat(name:  -1610602027, value:  alphaCutoff);
            Water2D.MultiColorManager.SetColorScheme(scheme:  this.ColorScheme, material:  this.WaterMaterial, fillColor:  new UnityEngine.Color() {r = fill.r, g = fill.g, b = fill.b, a = fill.a}, strokeColor:  new UnityEngine.Color() {r = stroke.r, g = stroke.g, b = stroke.b, a = fill.r}, AlphaCutoff:  alphaCutoff, AlphaStroke:  alphaStroke);
            if(this._lastSorting == this.Sorting)
            {
                    return;
            }
            
            this._lastSorting = this.Sorting;
            Water2D.MultiColorManager.SetSorting(sortingID:  this.Sorting);
        }
        public void SetRefractingWaterparams(float intensity, float mag, float speed)
        {
            var val_4;
            this.WaterMaterial.SetFloat(name:  -1610602173, value:  intensity);
            this.WaterMaterial.SetFloat(name:  -1610602095, value:  R2 * 10f);
            this.WaterMaterial.SetFloat(name:  -1610602041, value:  R3 * 10f);
            if((UnityEngine.Color.op_Inequality(lhs:  new UnityEngine.Color() {r = mem[this._lastStrokeColor + (0)], g = mem[this._lastStrokeColor + (4)], b = mem[this._lastStrokeColor + (8)], a = mem[this._lastStrokeColor + (12)]}, rhs:  new UnityEngine.Color() {r = this.StrokeColor})) != false)
            {
                    val_4 = 0;
                Water2D.MultiColorManager.SetFresnelColor(StrokeColor:  new UnityEngine.Color() {r = mem[this.StrokeColor + (0)], g = mem[this.StrokeColor + (4)], b = mem[this.StrokeColor + (8)], a = mem[this.StrokeColor + (12)]});
            }
            
            if(this._lastSorting == this.Sorting)
            {
                    return;
            }
            
            this._lastSorting = this.Sorting;
            Water2D.MultiColorManager.SetSorting(sortingID:  this.Sorting);
        }
        private System.Collections.IEnumerator UpdateQuietParticleProperties()
        {
            536902367 = new Water2D_Spawner.<UpdateQuietParticleProperties>d__100(<>1__state:  0);
            mem[536902383] = this;
        }
        public UnityEngine.Material GetCurrentMaterial()
        {
        
        }
        private void StartCheckingFillShape()
        {
            if(this._checkOnFillRunning == false)
            {
                    this._checkOnFillRunning = this._checkOnFillComplete;
            }
            
            if(this._checkOnFillRunning == true)
            {
                    return;
            }
            
            System.Collections.IEnumerator val_1 = R4.CheckOnFill(shapeCollider:  R4 + 256, accuracy:  null);
            UnityEngine.Coroutine val_2 = R4.StartCoroutine(routine:  R4);
        }
        private void RestoreCheckingFillShape()
        {
            System.Collections.IEnumerator val_1 = this._restoreCheckingFillShapeEnum();
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  938302832);
        }
        private System.Collections.IEnumerator _restoreCheckingFillShapeEnum()
        {
            536902369 = new Water2D_Spawner.<_restoreCheckingFillShapeEnum>d__104(<>1__state:  0);
            mem[536902385] = this;
        }
        private System.Collections.IEnumerator CheckOnFill(UnityEngine.Collider2D shapeCollider, float accuracy = 0.8)
        {
            Water2D_Spawner.<CheckOnFill>d__108 val_1 = 536902363;
            val_1 = new Water2D_Spawner.<CheckOnFill>d__108(<>1__state:  0);
            if(val_1 != 0)
            {
                    mem[536902379] = this;
                mem[536902383] = shapeCollider;
            }
            else
            {
                    mem[16] = this;
                mem[20] = shapeCollider;
            }
            
            mem[536902387] = R2;
        }
        private void OnDestroy()
        {
            UnityEngine.Object.DestroyImmediate(obj:  this._parent);
        }
        public Water2D_Spawner()
        {
            this.Water2DType = -1610612735;
            this.Water2DRenderType = -1610612735;
            this.Water2DVersion = -1610611583;
            this.size = 0.45f;
            this.TrailDelay = 0.1f;
            UnityEngine.Color val_1;
            this.ColorScheme = 1;
            val_1 = new UnityEngine.Color(r:  null, g:  null, b:  null);
            UnityEngine.Color val_2 = new UnityEngine.Color(r:  null, g:  null, b:  null);
            mem[1152921509840581604] = val_2.r;
            UnityEngine.Color val_3 = new UnityEngine.Color(r:  null, g:  null, b:  null);
            this.AlphaCutOff = 0.2f;
            this.AlphaStroke = 0.2f;
            UnityEngine.Color val_4 = new UnityEngine.Color(r:  null, g:  null, b:  null);
            this.Intensity = 0.5f;
            this.Distortion = 0.5f;
            this.DistortionSpeed = 0.5f;
            this.initSpeed = 1065353216;
            mem[1152921509840581668] = 3219547750;
            this.Speed = 20f;
            this.ColliderSize = 1.5f;
            this.GravityScale = 1065353216;
            this.SimulateOnAwake = 1;
            this.DropCount = 100;
            this._lastDropCount = 100;
            this.Loop = 1;
            this.DynamicChanges = 1;
            this.ShapeFillAccuracy = 1f;
            this._parentNameID = -1610602577;
            this._canInvokeAttheEnd = 1;
        }
    
    }

}
