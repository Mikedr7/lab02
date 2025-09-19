using ClassLibrary4;
using ClassLibrary5;
using System;
using ClassLibrary6;
namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            ExcellentPupil excellentPupil = new();
            GoodPupil goodPupil = new();
            BadPupil badPupil = new();
            Pupil secondExcellentPupil = new ExcellentPupil();
            ClassRoom classRoom = new(excellentPupil, goodPupil, badPupil, secondExcellentPupil);
            classRoom.ShowInfo();
            Console.WriteLine(new string('-', 30));
            Vehicle car = new Car(10_000_000, 150.7, 2025);
            Plane plane = new Plane(100_000_000, 965.4, 1994, 13100, 400);
            Ship ship = new Ship(70_000_000, 35.158, 2020, "Honiara(Solomon Islands)", 2695);
            car.ShowInfo();
            plane.ShowInfo();
            ship.ShowInfo();
            Console.WriteLine(new string('-', 30));
            DocumentWorker documentWorker = new();
            Console.Write("Enter key please or push Enter for free version:   ");
            string key = Console.ReadLine();
            if(key == "pro")
            {
                documentWorker = new ProDocumentWorker();
            }
            else if(key == "exp")
            {
                documentWorker = new ExpertDocumentWorker();
            }
            documentWorker.OpenDocument();
            documentWorker.EditDocument();
            documentWorker.SaveDocument();
        }
    }
}
