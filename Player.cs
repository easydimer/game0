class Player{
public const double DEFAULT_SPEED = 5.0;
public const double MAX_SPEED = 100.0;
public const string DEFAULT_NAME = "Player";


  private static int LAST_ID = 0; 
  public int ID{get; private set;}
  double SPEED{get; set;}
  public string NAME{get; private set;}
  public Vector POS{get; private set;}
  public Vector DIR{get; private set;}
  
  public Player(string _name){
   if(_name.Length > 20)NAME = DEFAULT_NAME; 
   NAME = _name;
   SPEED = DEFAULT_SPEED;
   POS = new Vector();
   DIR = new Vector();
   ID = LAST_ID;
   LAST_ID++;
  }

  public void ChangeName(string _name){
    if(NAME.Length < 20 && this.NAME != _name){
       this.NAME = _name;
    }
  }

  public void ChangePOS(Vector pos){
     POS = new Vector(pos.X, pos.Y, pos.Z);
  }
  public void ChangeDIR(Vector dir){
    DIR = new Vector(dir.X, dir.Y, dir.Z);
  }
  public void ChangeSPEED(double newspeed){
    SPEED = newspeed;
  }

}