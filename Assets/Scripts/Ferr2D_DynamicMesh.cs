using UnityEngine;
public class Ferr2D_DynamicMesh
{
    // Fields
    private System.Collections.Generic.List<UnityEngine.Vector3> mVerts;
    private System.Collections.Generic.List<int> mIndices;
    private System.Collections.Generic.List<UnityEngine.Vector2> mUVs;
    private System.Collections.Generic.List<UnityEngine.Vector2> mUV2s;
    private System.Collections.Generic.List<UnityEngine.Vector4> mTans;
    private System.Collections.Generic.List<UnityEngine.Vector3> mNorms;
    
    // Properties
    public int VertCount { get; }
    
    // Methods
    public int get_VertCount()
    {
        if(this.mVerts != 0)
        {
                return (int)true;
        }
        
        return (int)true;
    }
    public Ferr2D_DynamicMesh()
    {
        System.Collections.Generic.List<UnityEngine.Vector3> val_1 = 536878517;
        val_1 = new System.Collections.Generic.List<UnityEngine.Vector3>();
        this.mVerts = val_1;
        536878507 = new System.Collections.Generic.List<UnityEngine.Vector2>();
        this.mUVs = 536878507;
        536877987 = new System.Collections.Generic.List<System.Int32>();
        this.mIndices = 536877987;
        536878527 = new System.Collections.Generic.List<UnityEngine.Vector4>();
        this.mTans = 536878527;
        System.Collections.Generic.List<UnityEngine.Vector3> val_5 = 536878517;
        val_5 = new System.Collections.Generic.List<UnityEngine.Vector3>();
        this.mNorms = val_5;
    }
    public void Clear()
    {
        var val_3;
        var val_4;
        val_3 = 22739760;
        this.mVerts.Clear();
        this.mIndices.Clear();
        val_4 = 22739684;
        this.mUVs.Clear();
        this.mTans.Clear();
        this.mNorms.Clear();
        if(UnityEngine.Application.isEditor != false)
        {
                mem2[0] = 0;
        }
        
        if(this.mUV2s.SyncRoot == 0)
        {
                return;
        }
        
        this.mUV2s.SyncRoot.Clear();
    }
    public void Build(ref UnityEngine.Mesh aMesh, bool aCalculateTangents)
    {
        System.Collections.Generic.List<UnityEngine.Vector3> val_1;
        aMesh.Clear();
        aMesh.SetVertices(inVertices:  this.mVerts);
        aMesh.SetUVs(channel:  0, uvs:  this.mUVs);
        aMesh.SetTriangles(triangles:  this.mIndices, submesh:  0);
        aMesh.SetNormals(inNormals:  this.mNorms);
        if(this.mUV2s != 0)
        {
                aMesh.SetUVs(channel:  1, uvs:  this.mUV2s);
        }
        
        val_1 = this.mNorms;
        if(aMesh == 0)
        {
                val_1 = aMesh;
            val_1.RecalculateNormals();
        }
        
        if(aCalculateTangents != false)
        {
                if(val_1 == 0)
        {
            goto label_13;
        }
        
        }
        
        aMesh.tangents = null;
        label_17:
        aMesh.RecalculateBounds();
        return;
        label_13:
        aMesh.RecalculateTangents();
        goto label_17;
    }
    public void ExtrudeZ(float aDist, bool aInverted)
    {
        var val_13;
        var val_14;
        var val_15;
        int val_16;
        int val_17;
        int val_18;
        var val_19;
        if(this.mUVs != 0)
        {
                T[] val_1 = this.mUVs.ToArray();
            val_14 = this.mUVs;
        }
        else
        {
                T[] val_2 = 0.ToArray();
            val_14 = 0;
        }
        
        this.mUVs.AddRange(collection:  0);
        if(R6 >= 1)
        {
                val_15 = this.mIndices;
            var val_18 = 0;
            var val_17 = 0;
            do
        {
            if(this.mUVs <= val_17)
        {
                var val_15 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_15 = val_15 + val_18;
            float val_16 = (0 + 0) + 24;
            val_16 = val_16 - (aInverted * 0.5f);
            this.mVerts.set_Item(index:  0, value:  new UnityEngine.Vector3() {x = (0 + 0) + 16, y = (0 + 0) + 20, z = val_16});
            val_17 = val_17 + 1;
            val_18 = val_18 + 12;
        }
        while(R6 != val_17);
        
            val_13 = val_15;
            if(R6 >= 1)
        {
                var val_23 = 0;
            do
        {
            if(this.mVerts <= 0)
        {
                var val_19 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_19 = val_19 + val_23;
            float val_20 = (0 + 0) + 16;
            float val_21 = (0 + 0) + 20;
            float val_22 = (0 + 0) + 24;
            val_20 = val_20 + 0f;
            val_21 = val_21 + 0f;
            val_22 = val_22 + aInverted;
            this.mVerts.Add(item:  new UnityEngine.Vector3() {x = val_20, y = val_21, z = val_22});
            val_15 = 0 + 1;
            val_23 = val_23 + 12;
        }
        while(R6 != val_15);
        
        }
        
        }
        
        if(val_13 >= 1)
        {
                var val_27 = 0;
            do
        {
            if(this.mVerts <= (val_27 + 2))
        {
                var val_24 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_24 = val_24 + 0;
            this.mIndices.Add(item:  ((0 + 0) + 24) + R6);
            if(this.mIndices <= (val_27 + 1))
        {
                var val_25 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_25 = val_25 + 0;
            this.mIndices.Add(item:  ((0 + 0) + 20) + R6);
            if(this.mIndices <= val_27)
        {
                var val_26 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_26 = val_26 + 0;
            this.mIndices.Add(item:  ((0 + 0) + 16) + R6);
            val_27 = val_27 + 3;
        }
        while(val_27 < val_13);
        
        }
        
        int val_9 = R6 - 1;
        if(val_9 >= 1)
        {
                do
        {
            if((???) != 0)
        {
                int val_10 = 0 + R6;
            int val_12 = 0 + 1;
            this.AddFace(aV1:  0, aV2:  val_10, aV3:  val_10 + 1, aV4:  val_12);
            val_16 = val_12;
        }
        else
        {
                int val_13 = 0 + R6;
            val_16 = 0 + 1;
            this.AddFace(aV1:  val_16, aV2:  val_13 + 1, aV3:  val_13, aV4:  0);
        }
        
        }
        while(val_16 != val_9);
        
        }
        
        val_17 = val_9 + R6;
        if((???) != 0)
        {
                val_18 = val_17;
            val_19 = val_9;
            val_17 = R6;
        }
        else
        {
                val_19 = 0;
            val_18 = R6;
        }
        
        this.AddFace(aV1:  0, aV2:  val_18, aV3:  val_17, aV4:  val_9);
    }
    public void RemoveFaces(UnityEngine.Vector3 aFacing, float aDegreesTolerance)
    {
        float val_7;
        float val_8;
        var val_6;
        var val_7;
        var val_8;
        val_6 = this;
        val_7 = 0;
        goto label_1;
        label_22:
        if(0 <= 1)
        {
                var val_10 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_10 = val_10 + 4;
        if(val_10 <= ((0 + 4) + 16))
        {
                var val_11 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_11 = val_11 + ((((0 + 4) + 16) + (((0 + 4) + 16) << 1)) << 2);
        float val_18 = (0 + (((0 + 4) + 16 + ((0 + 4) + 16) << 1)) << 2) + 16;
        float val_17 = (0 + (((0 + 4) + 16 + ((0 + 4) + 16) << 1)) << 2) + 20;
        float val_16 = (0 + (((0 + 4) + 16 + ((0 + 4) + 16) << 1)) << 2) + 24;
        if(val_11 <= val_7)
        {
                var val_12 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_12 = val_12 + 0;
        if(val_12 <= ((0 + 0) + 16))
        {
                var val_13 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_13 = val_13 + ((((0 + 0) + 16) + (((0 + 0) + 16) << 1)) << 2);
        if(val_13 <= 2)
        {
                var val_14 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_14 = val_14 + 8;
        if(val_14 <= ((0 + 8) + 16))
        {
                var val_15 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_15 = val_15 + ((((0 + 8) + 16) + (((0 + 8) + 16) << 1)) << 2);
        if(val_15 <= val_7)
        {
                var val_19 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_16 = val_16 - ((0 + (((0 + 0) + 16 + ((0 + 0) + 16) << 1)) << 2) + 24);
        val_17 = val_17 - ((0 + (((0 + 0) + 16 + ((0 + 0) + 16) << 1)) << 2) + 20);
        val_18 = val_18 - ((0 + (((0 + 0) + 16 + ((0 + 0) + 16) << 1)) << 2) + 16);
        val_19 = val_19 + 0;
        if(val_19 <= ((0 + 0) + 16))
        {
                var val_20 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_20 = val_20 + ((((0 + 0) + 16) + (((0 + 0) + 16) << 1)) << 2);
        float val_21 = (0 + (((0 + 0) + 16 + ((0 + 0) + 16) << 1)) << 2) + 16;
        float val_22 = (0 + (((0 + 0) + 16 + ((0 + 0) + 16) << 1)) << 2) + 20;
        float val_23 = (0 + (((0 + 0) + 16 + ((0 + 0) + 16) << 1)) << 2) + 24;
        val_21 = ((0 + (((0 + 8) + 16 + ((0 + 8) + 16) << 1)) << 2) + 16) - val_21;
        val_22 = ((0 + (((0 + 8) + 16 + ((0 + 8) + 16) << 1)) << 2) + 20) - val_22;
        val_23 = ((0 + (((0 + 8) + 16 + ((0 + 8) + 16) << 1)) << 2) + 24) - val_23;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.Cross(lhs:  new UnityEngine.Vector3() {x = 3.547186E-23f, y = val_18, z = val_17}, rhs:  new UnityEngine.Vector3() {x = val_16, y = val_21, z = val_22});
        val_8.Normalize();
        float val_9 = UnityEngine.Vector3.Angle(from:  new UnityEngine.Vector3() {x = val_8, y = 0f, z = val_7}, to:  new UnityEngine.Vector3() {x = aFacing.x, y = aFacing.y, z = aFacing.z});
        if(val_19 < 0)
        {
                val_6 = val_6;
            this.mIndices.RemoveRange(index:  0, count:  3);
            val_8 = val_7 - 3;
        }
        else
        {
                val_6 = val_6;
            val_8 = val_7;
        }
        
        val_7 = 3;
        label_1:
        if(val_7 < val_8)
        {
            goto label_22;
        }
    
    }
    public int[] GetCurrentTriangleList(int aStart = 0)
    {
        var val_1;
        var val_2;
        val_1 = aStart;
        aStart = aStart - val_1;
        val_2 = 0;
        goto label_2;
        label_8:
        if(536882065 <= val_1)
        {
                var val_1 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_1 = val_1 + (val_1 << 2);
        mem[536882081] = (0 + (aStart) << 2) + 16;
        val_1 = val_1 + 1;
        val_2 = 1;
        label_2:
        if(val_1 < mem[536882077])
        {
            goto label_8;
        }
    
    }
    public UnityEngine.Vector3 GetVert(int aIndex)
    {
        if((aIndex + 8 + 12) <= R2)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_2 = aIndex + 8 + 8;
        val_2 = val_2 + ((R2 + (R2 << 1)) << 2);
        this.mVerts = (aIndex + 8 + 8 + ((R2 + (R2) << 1)) << 2) + 24;
        this = (aIndex + 8 + 8 + ((R2 + (R2) << 1)) << 2) + 16;
        return new UnityEngine.Vector3();
    }
    public int AddVertex(float aX, float aY, float aZ, float aU, float aV)
    {
        float val_1;
        float val_2;
        return (int)this.AddVertex(aPos:  new UnityEngine.Vector3(), aUV:  new UnityEngine.Vector3() {x = val_1, y = val_2, z = 0f});
    }
    public int AddVertex(UnityEngine.Vector3 aVert)
    {
        return (int)this.AddVertex(aPos:  new UnityEngine.Vector3() {x = aVert.x, y = aVert.y, z = aVert.z}, aUV:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
    }
    public int AddVertex(UnityEngine.Vector2 aVert, float aZ, UnityEngine.Vector2 aUV)
    {
        float val_1;
        return (int)this.AddVertex(aPos:  new UnityEngine.Vector3() {x = aVert.x, y = aVert.y, z = aUV.x}, aUV:  new UnityEngine.Vector3() {x = aUV.y, y = val_1, z = 0f});
    }
    public int AddVertex(UnityEngine.Vector3 aPos, UnityEngine.Vector3 aUV)
    {
        float val_2 = aPos.x;
        this.mVerts.Add(item:  new UnityEngine.Vector3() {x = val_2, y = aPos.y, z = aPos.z});
        this.mUVs.Add(item:  new UnityEngine.Vector2() {x = aUV.x, y = aUV.y});
        if(this.mUV2s != 0)
        {
                this.mUV2s.Add(item:  new UnityEngine.Vector2() {x = 0f, y = 0f});
        }
        
        if(this.mUV2s != 0)
        {
                this.mNorms.Add(item:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 1f});
        }
        
        if(this.mNorms != 0)
        {
                UnityEngine.Vector4 val_1 = new UnityEngine.Vector4(x:  null, y:  null, z:  null, w:  null);
            val_2 = -1073711307;
            System.Collections.Generic.List<UnityEngine.Vector4> val_2 = this.mTans;
            val_2.Add(item:  new UnityEngine.Vector4() {x = val_1.x, y = val_1.y, z = val_1.z, w = val_1.w});
        }
        
        val_2 = val_2 - 1;
        return (int)val_2;
    }
    public void CheckAllVerts()
    {
        goto label_1;
        label_3:
        this.CheckVert(i:  0);
        0 = 1;
        label_1:
        if(0 < this)
        {
            goto label_3;
        }
    
    }
    private void CheckVert(int i)
    {
        var val_6;
        System.Collections.Generic.List<UnityEngine.Vector3> val_7;
        if(true <= i)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        int val_1 = i + (i << 1);
        var val_2 = 0 + (val_1 << 2);
        val_2 = val_2 + 16;
        Ferr2D_DynamicMesh.BadVertCheck(aVert:  new UnityEngine.Vector3() {x = mem[((0 + ((i + (i) << 1)) << 2) + 16) + (0)], y = mem[((0 + ((i + (i) << 1)) << 2) + 16) + (4)], z = mem[((0 + ((i + (i) << 1)) << 2) + 16) + (8)]});
        if((mem[((0 + ((i + (i) << 1)) << 2) + 16) + (0)]) <= i)
        {
                var val_6 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_6 = 0;
        val_6 = val_6 + (i << 3);
        Ferr2D_DynamicMesh.BadVertCheck(aVert:  new UnityEngine.Vector3() {x = (0 + (i) << 3) + 16, y = mem[((0 + ((i + (i) << 1)) << 2) + 16) + (4)], z = 0f});
        if(this.mUV2s != 0)
        {
                if(((0 + (i) << 3) + 16) <= i)
        {
                var val_7 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_6 = 0;
            val_7 = val_7 + (i << 3);
            Ferr2D_DynamicMesh.BadVertCheck(aVert:  new UnityEngine.Vector3() {x = (0 + (i) << 3) + 16, y = mem[((0 + ((i + (i) << 1)) << 2) + 16) + (4)], z = 0f});
        }
        
        val_7 = this.mNorms;
        if(((0 + (i) << 3) + 16) != 0)
        {
                val_7 = this.mNorms;
            if(((0 + (i) << 3) + 16) <= i)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_3 = 0 + (val_1 << 2);
            val_3 = val_3 + 16;
            Ferr2D_DynamicMesh.BadVertCheck(aVert:  new UnityEngine.Vector3() {x = mem[((0 + ((i + (i) << 1)) << 2) + 16) + (0)], y = mem[((0 + ((i + (i) << 1)) << 2) + 16) + (4)], z = mem[((0 + ((i + (i) << 1)) << 2) + 16) + (8)]});
        }
        
        if((mem[((0 + ((i + (i) << 1)) << 2) + 16) + (0)]) == 0)
        {
                return;
        }
        
        if((mem[((0 + ((i + (i) << 1)) << 2) + 16) + (0)]) <= i)
        {
                var val_8 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_7 = 0;
        val_8 = val_8 + (i << 4);
        var val_4 = val_8 + 16;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector4() {x = 3.882916E-23f, y = mem[((0 + (i) << 4) + 16) + (0)], z = mem[((0 + (i) << 4) + 16) + (4)], w = mem[((0 + (i) << 4) + 16) + (8)]});
        Ferr2D_DynamicMesh.BadVertCheck(aVert:  new UnityEngine.Vector3());
    }
    private static void BadVertCheck(UnityEngine.Vector3 aVert)
    {
        if((System.Single.IsInfinity(f:  null)) != true)
        {
                if((System.Single.IsInfinity(f:  null)) != true)
        {
                if((System.Single.IsInfinity(f:  null)) == false)
        {
            goto label_3;
        }
        
        }
        
        }
        
        UnityEngine.Debug.Log(message:  -1610607431);
        label_3:
        if((System.Single.IsNaN(f:  null)) != true)
        {
                if((System.Single.IsNaN(f:  null)) != true)
        {
                if((System.Single.IsNaN(f:  null)) == false)
        {
                return;
        }
        
        }
        
        }
        
        UnityEngine.Debug.Log(message:  -1610606173);
    }
    public void AddFace(int aV1, int aV2, int aV3)
    {
        this.mIndices.Add(item:  aV1);
        this.mIndices.Add(item:  aV2);
        this.mIndices.Add(item:  aV3);
    }
    public void AddFace(int aV1, int aV2, int aV3, int aV4)
    {
        this.mIndices.Add(item:  aV3);
        this.mIndices.Add(item:  aV2);
        this.mIndices.Add(item:  aV1);
        this.mIndices.Add(item:  aV4);
        this.mIndices.Add(item:  aV3);
        this.mIndices.Add(item:  aV1);
    }
    private void SetupNormals()
    {
        var val_2;
        if(this.mUV2s == 0)
        {
                536878507 = new System.Collections.Generic.List<UnityEngine.Vector2>();
            this.mUV2s = 536878507;
        }
        
        val_2 = 0;
        goto label_2;
        label_5:
        this.mUV2s.Add(item:  new UnityEngine.Vector2() {x = 0f, y = 0f});
        val_2 = 1;
        label_2:
        if(val_2 < this.mUV2s)
        {
            goto label_5;
        }
    
    }

}
