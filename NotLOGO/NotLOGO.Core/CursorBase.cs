using System;
using System.Collections.Generic;
using System.Text;

namespace NotLOGO.Core
{
    public abstract class CursorBase<TRepresentation>
    {
        public abstract int XCoordinate { get; }
        public abstract int YCoordinate { get; }
        public abstract int Rotation { get; }
        public bool IsPenDown { get; set; }
        public TRepresentation Representation { get; private set; }  

        public CursorBase(TRepresentation representation)
        {
            Representation = representation;
            IsPenDown = true;
        }

        public abstract void MoveForward(int pixels);
        public abstract void MoveBackward(int pixels);
        public abstract void RotateLeft(int degrees);
        public abstract void RotateRight(int degrees);

    }
}
