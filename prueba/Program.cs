using System;
using System.Linq;

namespace prueba
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(OverlappingRectangles(new int[]  { 2, 1, 3, 4 }, new int[] { 3, 2, 2, 5 }));
		}
		public static int OverlappingRectangles(int[] rect1, int[] rect2)
		{

			//rec1[0] x cercano cuadro 1  ,  rec2[0] x cercano cuadro 2
			//esquina x1 cercano superposicion
			int x1 = Math.Max(rect1[0], rect2[0]);
            Console.WriteLine(x1);

			//rec1[1] y cercano cuadro 1  ,  rec2[1] y cercano cuadro 2
			//esquina y1 cercano superposicion 
			int y1 = Math.Max(rect1[1], rect2[1]);
			Console.WriteLine(y1);


			//rec1[0] + rec1[3] x lejano cuadro 1  ,  rec2[0] + rec2[3] x lejano cuadro 2
			//esquina x2 lejano superposicion
			int x2 = Math.Min(rect1[0] + rect1[2], rect2[0] + rect2[2]);
			Console.WriteLine(x2);

			//rec1[0] + rec1[3] x lejano cuadro 1  ,  rec2[0] + rec2[3] x lejano cuadro 2
			//esquina y2 lejano superposicion
			int y2 = Math.Min(rect1[1] + rect1[3], rect2[1] + rect2[3]);
			Console.WriteLine(y2);


			//w el ancho de superposicion
			int w = x2 - x1;
			Console.WriteLine(w);

			//h el alto de superposicion
			int h = y2 - y1;
			Console.WriteLine(h);

			//Si no hay superposicion
			if (w < 0 || h < 0) return 0;
			//si hay devolver area
			return w * h;
		}
        
    }
}
