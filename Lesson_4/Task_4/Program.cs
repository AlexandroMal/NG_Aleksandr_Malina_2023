using Task_4.Interfaces;
using Task_4.Vehicles;

Vehicles car = new Vehicles();
car.StartEngine();

Vehicles motorcycle  = new Vehicles();
motorcycle.StartEngine();

Airplane airplane = new Airplane();
airplane.StartEngine();
airplane.Fly();
