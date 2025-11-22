Car<ElectricEngine> car1 = new Car<ElectricEngine>();

abstract class Engine { }
abstract class CarPart { }
class Battery: CarPart { }
class Differential: CarPart { }
class Wheel: CarPart { }

class ElectricEngine: Engine { }
class GasEngine: Engine { }
abstract class Car<TEngine> where TEngine : Engine
{
    public TEngine Engine;
    public abstract void ChangePart<TPart>(TPart newPart) where TPart : CarPart;

}

class ElectricCar: Car<ElectricEngine> 
{
    public override void ChangePart<TPart>(TPart newPart)
    {
        
    }
}
class GasCar: Car<GasEngine> 
{
    public override void ChangePart<TPart>(TPart newPart)
    {

    }
}

