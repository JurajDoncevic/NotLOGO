using NotLOGO.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace NotLOGO.GUI
{
    public class NotLOGOCanvasEngine : INotLOGOEngine
    {
        private CanvasCursor _canvasCursor; 
        public NotLOGOCanvasEngine(CanvasCursor canvasCursor) : base()
        {
            _canvasCursor = canvasCursor;
        }

        public void Bd_CommandExecute(int pixels)
        {
            throw new NotImplementedException();
        }

        public void Fd_CommandExecute(int pixels)
        {
            throw new NotImplementedException();
        }

        public void Lt_CommandExecute(int degrees)
        {
            _canvasCursor.RotateLeft(degrees);
        }

        public void Pencolor_CommandExecute()
        {
            throw new NotImplementedException();
        }

        public void Pendown_CommandExecute()
        {
            throw new NotImplementedException();
        }

        public void Penup_CommandExecute()
        {
            throw new NotImplementedException();
        }

        public void Rt_CommandExecute(int degrees)
        {
            _canvasCursor.RotateRight(degrees);
        }
    }
}
