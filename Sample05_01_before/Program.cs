using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample05_01_before
{
    class Program
    {
        static void Main(string[] args)
        {
            // インスタンスの生成
            Pencil p1 = new Pencil("黄","細い",100.0);
            Pencil p2 = new Pencil("緑","太い",50.0);
            Pencil p3 = new Pencil();


            // 線を引いたり色を塗ったりする
            double lead;
            int len = p1.Draw(out lead);
            Console.WriteLine("長さ ＝ {0} 残りの芯の量 = {1}\n", len, lead);
            int area = p2.Fill(out lead);
            Console.WriteLine("面積 ＝ {0} 残りの芯の量 = {1}\n", area, lead);
            len = p3.Draw(out lead);
            Console.WriteLine("長さ ＝ {0} 残りの芯の量 = {1}\n", len, lead);

            area = p1.Fill(2, 3, out lead);
            Console.WriteLine("面積 ＝ {0} 残りの芯の量 = {1}\n", area, lead);
            len = p2.Draw(30, out lead);
            Console.WriteLine("長さ ＝ {0} 残りの芯の量 = {1}\n", len, lead);
            int w = 5, h = 8;
            area = p3.Fill(w, h, out lead);
            Console.WriteLine("面積 ＝ {0} 残りの芯の量 = {1}\n", area, lead);
        }
    }
}

