using UnityEngine;

namespace WrappingRopeLibrary.Model
{
    public class PieceInfo
    {
        // Fields
        private UnityEngine.Vector3 <FrontBandPoint>k__BackingField;
        private UnityEngine.Vector3 <BackBandPoint>k__BackingField;
        private UnityEngine.Vector3 <PrevFrontBandPoint>k__BackingField;
        private UnityEngine.Vector3 <PrevBackBandPoint>k__BackingField;
        private WrappingRopeLibrary.Scripts.Piece <Piece>k__BackingField;
        
        // Properties
        public UnityEngine.Vector3 FrontBandPoint { get; set; }
        public UnityEngine.Vector3 BackBandPoint { get; set; }
        public UnityEngine.Vector3 PrevFrontBandPoint { get; set; }
        public UnityEngine.Vector3 PrevBackBandPoint { get; set; }
        public WrappingRopeLibrary.Scripts.Piece Piece { get; set; }
        
        // Methods
        public UnityEngine.Vector3 get_FrontBandPoint()
        {
            this.<FrontBandPoint>k__BackingField = R1 + 16;
            this = R1 + 8;
            return new UnityEngine.Vector3();
        }
        public void set_FrontBandPoint(UnityEngine.Vector3 value)
        {
        
        }
        public UnityEngine.Vector3 get_BackBandPoint()
        {
            this.<FrontBandPoint>k__BackingField = R1 + 28;
            this = R1 + 20;
            return new UnityEngine.Vector3();
        }
        public void set_BackBandPoint(UnityEngine.Vector3 value)
        {
        
        }
        public UnityEngine.Vector3 get_PrevFrontBandPoint()
        {
            this.<FrontBandPoint>k__BackingField = R1 + 40;
            this = R1 + 32;
            return new UnityEngine.Vector3();
        }
        public void set_PrevFrontBandPoint(UnityEngine.Vector3 value)
        {
        
        }
        public UnityEngine.Vector3 get_PrevBackBandPoint()
        {
            this.<FrontBandPoint>k__BackingField = R1 + 52;
            this = R1 + 44;
            return new UnityEngine.Vector3();
        }
        public void set_PrevBackBandPoint(UnityEngine.Vector3 value)
        {
        
        }
        public WrappingRopeLibrary.Scripts.Piece get_Piece()
        {
        
        }
        public void set_Piece(WrappingRopeLibrary.Scripts.Piece value)
        {
            this.<Piece>k__BackingField = value;
        }
        public PieceInfo()
        {
        
        }
        public PieceInfo(WrappingRopeLibrary.Scripts.Piece piece)
        {
            this.<Piece>k__BackingField = piece;
            if(piece.BackBandPoint != 0)
            {
                    return;
            }
        
        }
    
    }

}
