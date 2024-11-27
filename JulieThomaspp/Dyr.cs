// 1) Virtual Pet
// Lag en konsoll-applikasjon hvor man kan generere opp flere forskjellige virtuelle kjæledyr.
// Bruk constructor i klassen, og man skal ikke ha lov til å endre data som navn, age eller noen andre egenskaper utenfra klassen. Lag funksjonalitet som gjør at man kan gi dyret mat, kose med dyret eller sjekke om dyret må på do
// Her er et eksempel på hvordan det kan se ut:

namespace hererennamespace {

class Dyr {

    private string name = "Navn";
    private int age = 123;
    private int hunger = 5;
    private int gåpådo = 5;
    private int kose = 5;

    public Dyr(string name, int age) {
        this.name = name;
        this.age = age;
    }

    void mat() {
        Console.WriteLine("Må er jeg mett :D");
        hunger++;
    }

    void kos() {
        Console.WriteLine("Nå har jeg fått nokk kos!");
        kose++;
    }

    void endo() {
        Console.WriteLine("Nå har jeg tåmt ryggen!");
        gåpådo++;
    }

    public void meny() {

        int x;

        do
        {

            Console.WriteLine($"Navn: {name}");
            Console.WriteLine($"Hunger: {hunger}");
            Console.WriteLine($"Do: {gåpådo}");
            Console.WriteLine($"Kos: {kose}");


            Console.WriteLine("1. mat dyret");
            Console.WriteLine("2. kos dyret");
            Console.WriteLine("3. gå på do");
            x = Convert.ToInt32(Console.ReadLine());

            switch (x) {
                case 1:
                    mat();
                    break;
                case 2:
                    kos();
                    break;
                case 3:
                    endo();
                    break;
                default:
                    break;
            }
               

        } while (x != 0);
    }
}
}
