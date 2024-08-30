using System;

namespace LopPoint2DVaPoint3D
{
    class Program
    {
        static void Main(string[] args)
        {
            Point2D point2D = new Point2D();
            point2D.SetXY(3,2);
            Console.WriteLine(point2D.ToString());

            Point3D point3D = new Point3D();
            point3D.SetXYZ(4,3,2);
            Console.WriteLine(point3D.ToString());
            Console.ReadKey();
        }
    }
}