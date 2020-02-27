using System;
using System.Collections.Generic;
using System.Text;

namespace NotLOGO.Core
{
    public interface INotLOGOEngine
    {
        public void Penup_CommandExecute();
        public void Pendown_CommandExecute();
        public void Fd_CommandExecute(int pixels);
        public void Bd_CommandExecute(int pixels);
        public void Lt_CommandExecute(int degrees);
        public void Rt_CommandExecute(int degrees);
        public void Pencolor_CommandExecute();

    }
}
