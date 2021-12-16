using System;

namespace OOPcar
{
    class Program
    {
        class Car
        {
            string markname;
            string modelname;
            string regnumber;
            string color;
            int odometer;
            int fueltank;
            public Car(string _markname, string _modelname, string _regnumber, string _color)
            {
                markname = _markname;
                modelname = _modelname;
                regnumber = _regnumber;
                color = _color;
                odometer = 0;
                fueltank = 60;
                Console.WriteLine($"The car {modelname} has been created");
            }
            public string Markname
            {
                get { return markname; }
            }
            public string Modelname
            {
                get { return modelname; }
            }
            public string Regnumber
            {
                get { return regnumber; }
            }
            public string Color
            {
                get { return color; }
            }
            public int Odometer
            {
                get { return odometer; }
            }
            public int Fueltank
            {
                get { return fueltank; }
            }
            public void Drive()
            {
                Console.WriteLine("vroom vroom");
                odometer += 100;
                fueltank -= 5;
            }
            public void ShowCarData()
            {
                Console.WriteLine($"markname: {markname}; modelname: {modelname}; registration {regnumber}; color {color}; odometer {odometer}, fuel {fueltank}");
            }
        }
        static void Main(string[] args)
        {
            Car newCar = new Car("Mitsubishi", "Evo9", "TLS358", "blue");
            Console.WriteLine(newCar.Markname);
            Console.WriteLine(newCar.Modelname);
            Console.WriteLine(newCar.Regnumber);
            Console.WriteLine(newCar.Color);
            Console.WriteLine(newCar.Odometer);
            Console.WriteLine(newCar.Fueltank);

            while (newCar.Fueltank != 0)
            {
                newCar.Drive();
            }
            Console.WriteLine("The ride is over");
            newCar.ShowCarData();
        }
    }
}
