using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample05_01_before
{
    class Pencil
    {
        private string thickness;
        private double lead;

        public Pencil(string color,string thickness, double lead)
        {
            Color = color;
            this.thickness = thickness;
            this.lead = lead;
        }
        public Pencil()
        {
            Color = "青";
            this.thickness = "普通";
            this.lead = 30.0;
        }

        public string Color { get; set; }
        public string Thickness
        {
            get { return thickness; }
            set {
                if (value == "細い" || value == "普通" || value == "太い")
                {
                    thickness = value;
                } else
                {
                    thickness = "普通";
                }
            }
        }
        public double Lead
        {
            get { return lead; }
            set
            {
                if (value >= 0.0)
                {
                    lead = value;
                }
                else
                {
                    lead = 100;
                }
            }
        }
        // メソッド
        // 線を引く
        // 戻り値：線の長さ
        public int Draw(out double lead)
        {
            Console.WriteLine("{0} {1}", Color, Thickness);
            Line(10);
            Lead -= 0.1;
            lead = Lead;
            return 10;
        }
        // 仮引数　length : 長さ　lead：芯の残量
        // 戻り値：線の長さ
        public int Draw(int length, out double lead)
        {
            Console.WriteLine("{0} {1}", Color, Thickness);
            Line(length);
            Lead -= 0.01 * length;
            lead = Lead;
            return length;
        }
        // 線を描く　length : 長さ
        private void Line(int length)
        {
            for (int i = 1; i <= length; i++)
            {
                Console.Write("－");
            }
            Console.WriteLine();
        }

        // 色を塗る
        // 仮引数　lead：芯の残量
        // 戻り値：塗りつぶした面積
        public int Fill(out double lead)
        {
            Console.WriteLine("{0} {1}", Color, Thickness);
            Rectangle(5, 1);

            Lead -= 0.1 * 5;
            lead = Lead;
            return 5;
        }

        // 仮引数　width : 幅height : 高さ　lead：芯の残量
        // 戻り値：塗りつぶした面積
        public int Fill(int width, int height, out double lead)
        {
            Console.WriteLine("{0} {1}", Color, Thickness);
            Rectangle(width, height);

            Lead -= 0.1 * width * height;
            lead = Lead;
            return width * height;
        }
        // 長方形を描く　width : 幅　height : 高さ
        private void Rectangle(int width, int height)
        {
            for (int i = 1; i <= height; i++)
            {
                for (int j = 1; j <= width; j++)
                {
                    Console.Write("■");
                }
                Console.WriteLine();
            }
        }
    }
}
