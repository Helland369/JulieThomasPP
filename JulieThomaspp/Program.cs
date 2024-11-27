// 1) Virtual Pet
// Lag en konsoll-applikasjon hvor man kan generere opp flere forskjellige virtuelle kjæledyr.
// Bruk constructor i klassen, og man skal ikke ha lov til å endre data som navn, age eller noen andre egenskaper utenfra klassen. Lag funksjonalitet som gjør at man kan gi dyret mat, kose med dyret eller sjekke om dyret må på do
// Her er et eksempel på hvordan det kan se ut:
using hererennamespace;

class Program {

    static void Main() {

        Dyr dyr1 = new Dyr("Per", 30, "Gul", "Elefant");
        Dyr dyr2 = new Dyr("Bolla", 67, "Brun", "Piggsvin");
        Dyr dyr3 = new Dyr("Petrine", 4, "Hvit og sort", "Hest");

        Console.WriteLine("Hei! Velg et dyr du ønsker å henge med");
        Console.WriteLine("1. Per\n2. Bolla\n3. Petrine");
        var chosenAnimal = Console.ReadLine();

        switch (chosenAnimal)
        {
            case "1":
                dyr1.meny();
                break;
            case "2":
                dyr2.meny();
                break;
            case "3":
                dyr3.meny();
                break;
            default:
                Console.WriteLine("Du valgte ikke et dyr, ta dæ sammen");
                Thread.Sleep(500);
                Main();
                break;
        }

        
    }
}
