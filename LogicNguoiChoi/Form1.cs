using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
namespace LogicNguoiChoi
{
    public partial class Form1 : Form
    {
        NhanVat NguoiChoi;
        int[] ViTriY;  //Y của 5 hàng, hàng 0 trên cùng, hàng 4 dưới cùng

        List<Lua> DanhSachLua = new List<Lua>();
        int TocDoLua = 3; // tốc độ bay của lửa
        int DemHoiChieu = 50;    //mỗi lần bắn, reset về 0 và tăng đến khi bằng ThoiGianHoiChieu thì mới được bắn lại
        int ThoiGianHoiChieu = 50;  // 50 tick * 20ms (interval) = 1 giây

        Image SpriteNhanVat;
        Image SpriteLua;

        public Form1()
        {
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
            this.KeyPreview = true;
            this.DoubleBuffered = true;          
            this.ActiveControl = null;

            NguoiChoi = new NhanVat();
            NguoiChoi.Hang = 2;   //spawn nhân vật ở hàng giữa            
            NguoiChoi.X = 50;

            // Mảng chứa tọa độ Y của 5 hàng
            ViTriY = new int[5];

            // load sprite
            SpriteNhanVat = Image.FromFile(@"Sprites\wizard.jpg");
            SpriteLua = Image.FromFile(@"Sprites\fire.png");

            timer1.Interval = 20; // update mỗi 20ms      
            timer1.Start();

        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            TinhToaDoHang();
        }

        void TinhToaDoHang()
        {
            int soHang = 5;
            int chieuCaoHang = this.ClientSize.Height / soHang;

            for (int i = 0; i < soHang; i++)
            {
                ViTriY[i] = i * chieuCaoHang + (chieuCaoHang - NguoiChoi.Cao) / 2;
            }

            CapNhatViTriNhanVat();
        }

        void CapNhatViTriNhanVat()
        {
            NguoiChoi.Y = ViTriY[NguoiChoi.Hang];
            this.Invalidate();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                if (NguoiChoi.Hang > 0) //ko phải hàng trên cùng thì nhích lên 1 hàng
                    NguoiChoi.Hang--;
                CapNhatViTriNhanVat();
            }

            if (e.KeyCode == Keys.Down)
            {
                if (NguoiChoi.Hang < 4) //ko phải hàng dưới cùng thì tụt xuống 1 hàng
                    NguoiChoi.Hang++;
                CapNhatViTriNhanVat();
            }

            if (e.KeyCode == Keys.A && DemHoiChieu >= ThoiGianHoiChieu)
            {            
                int xLua = NguoiChoi.X + NguoiChoi.Rong; // lửa bắt đầu từ sát phải nhân vật
                int yLua = NguoiChoi.Y + NguoiChoi.Cao / 2 - 10;    // lửa bay ở độ cao chính giữa nhân vật, 10=(chiều cao lửa)/2 sửa nếu cần

                Lua LuaMoi = new Lua(xLua, yLua);
                DanhSachLua.Add(LuaMoi);
                DemHoiChieu = 0; // reset đếm
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = DanhSachLua.Count - 1; i >= 0; i--)    //cập nhật vị trí lửa
            {
                Lua l = DanhSachLua[i];
                l.CapNhatViTri(TocDoLua);

                if (l.X > this.ClientSize.Width)    //cục lửa bay ra khỏi màn hình
                    DanhSachLua.RemoveAt(i);
            }
            if (DemHoiChieu < ThoiGianHoiChieu)
                DemHoiChieu++; //đếm hồi chiêu
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // vẽ nhân vật
            e.Graphics.DrawImage(SpriteNhanVat, NguoiChoi.X, NguoiChoi.Y, NguoiChoi.Rong, NguoiChoi.Cao);

            // vẽ lửa
            foreach (var l in DanhSachLua)
                e.Graphics.DrawImage(SpriteLua, l.X, l.Y, l.Width, l.Height);
        }
    }


}