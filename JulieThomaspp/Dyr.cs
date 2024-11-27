// 1) Virtual Pet
// Lag en konsoll-applikasjon hvor man kan generere opp flere forskjellige virtuelle kjæledyr.
// Bruk constructor i klassen, og man skal ikke ha lov til å endre data som navn, age eller noen andre egenskaper utenfra klassen. Lag funksjonalitet som gjør at man kan gi dyret mat, kose med dyret eller sjekke om dyret må på do
// Her er et eksempel på hvordan det kan se ut:

namespace hererennamespace {

class Dyr {

    private string name = "Navn";
    private int age = 123;
    private string colour = "Blå";
    private string type = "Rhinosorous";


    private int hunger = 5;
    private int gåpådo = 5;
    private int kose = 5;

    public Dyr(string name, int age, string colour, string type) {
        this.name = name;
        this.age = age;
        this.colour = colour;
        this.type = type;
    }

    void mat() {
        Console.WriteLine("Må er jeg mett :D");
        hunger++;
        Thread.Sleep(500);
    }

    void kos() {
        Console.WriteLine("Nå har jeg fått nokk kos!");
        kose++;
        Thread.Sleep(500);
        }

        void endo() {
        Console.WriteLine("Nå har jeg tåmt ryggen!");
        gåpådo++;
        Thread.Sleep(500);
    }

    public void meny() {

        int x;

        do
        {

            Console.WriteLine($"Navn: {name}");
            Console.WriteLine($"Hunger: {hunger}");
            Console.WriteLine($"Kos: {kose}");
            Console.WriteLine($"Do: {gåpådo}");



            Console.WriteLine("1. Mat dyret");
            Console.WriteLine("2. Kos dyret");
            Console.WriteLine("3. Gå på do");
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
