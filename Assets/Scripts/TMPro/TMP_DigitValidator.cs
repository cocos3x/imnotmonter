using UnityEngine;

namespace TMPro
{
    [Serializable]
    public class TMP_DigitValidator : TMP_InputValidator
    {
        // Methods
        public override char Validate(ref string text, ref int pos, char ch)
        {
            if(((uint)(ch - 48) & 65535) > 9)
            {
                    return 0;
            }
            
            string val_2 = ch.ToString();
            string val_3 = text + 940361206;
            text = text;
            int val_4 = pos;
            val_4 = val_4 + 1;
            pos = val_4;
            0 = ch;
            return 0;
        }
        public TMP_DigitValidator()
        {
        
        }
    
    }

}
