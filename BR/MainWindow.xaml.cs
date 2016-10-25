using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BR
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public abstract class Train
        {
            public int Track { get; set; }
            public string Name { get; set; }
            public string Route { get; set; }
            public int Departure { get; set; }
            public int Arrival { get; set; }
            public int NumberOfCar { get; set; }
            public Train() { }
            
            public Train(int Track1, string Name1, string Route1, int Departure1, int Arrival1, int NumberOfCar1)
            {
                    Track = Track1;
                    Name = Name1;
                    Route = Route1;
                    Departure = Departure1;
                    Arrival = Arrival1;
                    NumberOfCar = NumberOfCar1;
            }
        }
        public class Cargo : Train
        {
            public string TypeOfCargo { get; set; }
            public int AmountOfCars { get; set; }
            public Cargo() { }
            public Cargo(int Track1, string Name1, string Route1, int Departure1, int Arrival1, int NumberOfCar1, string TypeOfCargo1, int AmountOfCars1)
                : base(Track1, Name1, Route1, Departure1, Arrival1, NumberOfCar1)
            {
                TypeOfCargo = TypeOfCargo1;
                AmountOfCars = AmountOfCars1; 
            }
        }
        public class Passenger : Train
            {
                public double Price { get; set; }
                public bool FreePlaces { get; set; }

                public Passenger() { }
                public Passenger(int Track1, string Name1, string Route1, int Departure1, int Arrival1, int NumberOfCar1, double Price1, bool FreePlaces1)
                    : base(Track1, Name1, Route1, Departure1, Arrival1, NumberOfCar1)
                {
                    Price = Price1;
                    FreePlaces = FreePlaces1;
                }
            }
    
            public class Suburban : Passenger
            {
                public bool Privilege { get; set; }
                public Suburban() { }
                public Suburban(int Track1, string Name1, string Route1, int Departure1, int Arrival1, int NumberOfCar1, double Price1,bool FreePlaces1, bool Privilege1)
                    : base(Track1, Name1, Route1, Departure1, Arrival1, NumberOfCar1, Price1, FreePlaces1)
                {
                    Privilege = Privilege1;
                   
                }
            }
            public class Distant : Passenger
            {
                public string TypeOfPlaces { get; set; }
                public Distant() { }
                public Distant(int Track1, string Name1, string Route1, int Departure1, int Arrival1, int NumberOfCar1,  double Price1, bool FreePlaces1, string TypeOfPlaces1)
                    : base(Track1, Name1, Route1, Departure1, Arrival1, NumberOfCar1, Price1, FreePlaces1)
                {
                   
                    TypeOfPlaces = TypeOfPlaces1;
                }
            }
            public MainWindow()
            {
                InitializeComponent();
            }

    }

}
