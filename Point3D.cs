namespace LopPoint2DVaPoint3D
{
    class Point3D : Point2D
    {
        private float Z;
        public Point3D(float X,float Y,float _Z):base(X,Y)
        {
            Z = _Z;
        }
        public Point3D()
        {

        }
        public float GetZ()
        {
            return Z;
        }
        public void SetZ(float _Z)
        {
            Z = _Z;
        }
        public void SetXYZ(float _X, float _Y, float _Z)
        {
            SetX(_X);
            SetY(_Y);
            Z = _Z;
        }
        public float[] GetXYZ()
        {
            float[] xyz = new float[3] { GetX(), GetY(), Z };
            return xyz;
        }
        public override string ToString()
        {
            return "X = " + GetX() + " Y = " + GetY() + " Z = "+GetZ()+" (X,Y,Z) = " + string.Join(',', GetXYZ());
        }
    }
}