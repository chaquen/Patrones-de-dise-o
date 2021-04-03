using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            LicorLeaft tequila = new LicorLeaft("Tequila",1000, 10);
            LicorLeaft ron = new LicorLeaft("Ron",1500, 15);
            LicorLeaft vino = new LicorLeaft("Vino",100, decimal.Parse("0.5"));
            CoctelComposite coctel = new CoctelComposite("Coctel base de tequila y ron");
            coctel.Add(tequila);
            coctel.Add(ron);
            coctel.Add(vino);
            Console.WriteLine("El coctel ["+coctel.Name+"] tiene ["+coctel.GetAlcoholGrade()+"] grados de alcohol, y tiene un precio de ["+coctel.GetPrice()+"]");
            Console.WriteLine("Además el coctel ["+coctel.Name+"] tiene ["+coctel.GetListLicors()+"]");
        }
    }
}
