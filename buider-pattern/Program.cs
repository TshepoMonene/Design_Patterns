// See https://aka.ms/new-console-template for more information
namespace Buider{
public class Vehicle{
    int wheels;
    string type;
    string model;

       
}

public interface IBuilder{

   public int setWheels;
    public string setType;
    public string setModel;
       public IBuilder(int wheels,string type,string model){
        this.setWheels = wheels;
        this.setType = type;
        this.setModel = model;
    }

    void Display(){
     Console.WriteLine("Type:"+setType+"Model:"+setModel+"Wheels:"+se);
    } 
}

public interface IMotorCycleBuilder:IBuilder{
   
       void DisplayVehicle(){
      Console.WriteLine("This is a motor cycle");
    }

}
public interface ICarBuilder:IBuilder{

       void DisplayVehicle(){
      Console.WriteLine("This is a car");
    }
}
 
  public class Buider{
    public Vehicle vehicle = new Vehicle();
    
    public static void CreateMotorcycle(){
       IMotorCycleBuilder motorCycle = new IMotorCycleBuilder(wheels,type,model);
       motorCycle.DisplayVehicle();
       motorCycle.Display();
    }

    public static void CreateCar(int wheels,string type,string model){
        ICarBuilder Car = new ICarBuilder(wheels,type,model);
       Car.DisplayVehicle();
       Car.Display();
    }
  }

  public static void main(string[] args){
    Buider.CreateCar(4,"Bmw","1998");
    Buider.CreateMotorcycle(2,"yamaha","1999");
  }

}


//Console.WriteLine("Hello, World!");
