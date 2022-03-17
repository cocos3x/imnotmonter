using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D
{
    public class ShakeExample : MonoBehaviour
    {
        // Fields
        private bool _constantShaking;
        
        // Methods
        private void OnGUI()
        {
            bool val_18;
            string val_19;
            UnityEngine.Rect val_1 = new UnityEngine.Rect(x:  null, y:  null, width:  null, height:  null);
            val_18 = mem[536887392];
            if((val_18 & true) == 0)
            {
                    val_18 = mem[536887321];
            }
            
            val_19 = -1610604615;
            if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_1.m_XMin, m_YMin = val_1.m_YMin, m_Width = val_1.m_Width, m_Height = val_1.m_Height}, text:  val_19)) != false)
            {
                    Com.LuisPedroFonseca.ProCamera2D.ProCamera2DShake val_3 = Com.LuisPedroFonseca.ProCamera2D.ProCamera2DShake.Instance;
                Com.LuisPedroFonseca.ProCamera2D.ProCamera2DShake val_4 = Com.LuisPedroFonseca.ProCamera2D.ProCamera2DShake.Instance;
                int val_5 = UnityEngine.Random.Range(minInclusive:  0, maxExclusive:  1591816191);
                if(1591816191 <= val_5)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_18 = 870424608;
                val_18 = val_18 + (val_5 << 2);
                val_19 = mem[(870424608 + (val_5) << 2) + 16];
                val_19 = (870424608 + (val_5) << 2) + 16;
                string val_6 = val_19.name;
                string val_7 = -1610604611(-1610604611) + val_19;
                UnityEngine.Debug.Log(message:  -1610604611);
                Com.LuisPedroFonseca.ProCamera2D.ProCamera2DShake val_8 = Com.LuisPedroFonseca.ProCamera2D.ProCamera2DShake.Instance;
                0.Shake(preset:  val_19);
            }
            
            UnityEngine.Rect val_9 = new UnityEngine.Rect(x:  null, y:  null, width:  null, height:  null);
            if(this._constantShaking == false)
            {
                    22793632 = 22783888;
            }
            
            if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_9.m_XMin, m_YMin = val_9.m_YMin, m_Width = val_9.m_Width, m_Height = val_9.m_XMin}, text:  -1610609229)) == false)
            {
                    return;
            }
            
            if(this._constantShaking != false)
            {
                    this._constantShaking = false;
                Com.LuisPedroFonseca.ProCamera2D.ProCamera2DShake val_11 = Com.LuisPedroFonseca.ProCamera2D.ProCamera2DShake.Instance;
                0.StopConstantShaking(duration:  null);
                return;
            }
            
            this._constantShaking = true;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2DShake val_12 = Com.LuisPedroFonseca.ProCamera2D.ProCamera2DShake.Instance;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2DShake val_13 = Com.LuisPedroFonseca.ProCamera2D.ProCamera2DShake.Instance;
            int val_14 = UnityEngine.Random.Range(minInclusive:  0, maxExclusive:  65576);
            if(65576 <= val_14)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_19 = 196608;
            val_19 = val_19 + (val_14 << 2);
            string val_15 = (196608 + (val_14) << 2) + 16.name;
            string val_16 = -1610609227(-1610609227) + (196608 + (val_14) << 2) + 16((196608 + (val_14) << 2) + 16);
            UnityEngine.Debug.Log(message:  -1610609227);
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2DShake val_17 = Com.LuisPedroFonseca.ProCamera2D.ProCamera2DShake.Instance;
            0.ConstantShake(preset:  (196608 + (val_14) << 2) + 16);
        }
        public ShakeExample()
        {
        
        }
    
    }

}
