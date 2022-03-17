using UnityEngine;
public class ParticleScaler : MonoBehaviour
{
    // Fields
    public float particleScale;
    public bool alsoScaleGameobject;
    private float prevScale;
    
    // Methods
    private void Start()
    {
        this.prevScale = this.particleScale;
    }
    private void ScaleShurikenSystems(float scaleFactor)
    {
    
    }
    private void ScaleLegacySystems(float scaleFactor)
    {
    
    }
    private void ScaleTrailRenderers(float scaleFactor)
    {
        var val_8;
        var val_9;
        T[] val_1 = this.GetComponentsInChildren<UnityEngine.TrailRenderer>();
        val_8 = 0;
        goto label_1;
        label_6:
        if((this.alsoScaleGameobject + 0) != 0)
        {
                float val_2 = this.alsoScaleGameobject + 0.startWidth;
            float val_8 = this.alsoScaleGameobject + 0;
            val_8 = val_8 * R1;
            this.alsoScaleGameobject + 0.startWidth = val_8;
            float val_3 = this.alsoScaleGameobject + 0.endWidth;
            val_9 = this.alsoScaleGameobject + 0;
        }
        else
        {
                float val_4 = 0.startWidth;
            float val_5 = 0 * R1;
            0.startWidth = 0;
            float val_6 = 0.endWidth;
            val_9 = 0;
        }
        
        this.alsoScaleGameobject + 0.endWidth = val_9 * R1;
        val_8 = 1;
        label_1:
        if(val_8 < this.particleScale)
        {
            goto label_6;
        }
    
    }
    public ParticleScaler()
    {
        this.alsoScaleGameobject = true;
        this.particleScale = 1f;
    }

}
