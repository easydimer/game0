class Vector{
    public double X{get; private set;}
    public double Y{get; private set;}
    public double Z{get; private set;}

    public Vector(double _x, double _y, double _z){
        X = _x;
        Y = _y;
        Z = _z;
    }

    public Vector(Vector obj){
        X = obj.X;
        Y = obj.Y;
        Z = obj.Z;
    }

    public Vector(){
        X = 0.0;
        Y = 0.0;
        Z = 0.0;
    }
}

