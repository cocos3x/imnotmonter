using UnityEngine;
[Serializable]
public class ResolutionInfor
{
    // Fields
    public string Name;
    public float Aspect;
    public float CamSize;
    public float PerspectiveSize;
    public float Scaler;
    
    // Methods
    public ResolutionInfor()
    {
        this.CamSize = 5f;
        this.PerspectiveSize = 60f;
        this.Scaler = 0.5f;
    }

}
