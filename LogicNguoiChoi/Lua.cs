using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicNguoiChoi
{
    internal class Lua
    {
        public int X;
        public int Y;
        public int Width = 20;
        public int Height = 20;
        public bool ConSong = true; //lửa chạm quái thì mất cục lửa

        public Lua(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void CapNhatViTri(int dx)
        {
            X += dx; // di chuyển sang phải
        }
    }
}
