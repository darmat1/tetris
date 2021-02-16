using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris
{
    interface IDrawer
    {
       void DrawPoint(int x, int y);
       void DrawEmpty(int x, int y);
    }
}
