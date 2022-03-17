using UnityEngine;
public class screenshot : MonoBehaviour
{
    // Fields
    public bool TakeAShot;
    
    // Methods
    private void Update()
    {
        if(UnityEngine.Application.isPlaying != false)
        {
                if((UnityEngine.Input.GetKeyDown(key:  32)) == false)
        {
                return;
        }
        
            this.TakeAShot = false;
        }
        else
        {
                if(this.TakeAShot == false)
        {
                return;
        }
        
            this.TakeAShot = false;
        }
        
        float val_3 = UnityEngine.Time.time;
        string val_4 = 0.ToString();
        string val_5 = -1610598247(-1610598247) + 870400796 + -1610611745(-1610611745);
        UnityEngine.ScreenCapture.CaptureScreenshot(filename:  -1610598247, superSize:  2);
    }
    public screenshot()
    {
    
    }

}
