﻿// 1) Virtual Pet
// Lag en konsoll-applikasjon hvor man kan generere opp flere forskjellige virtuelle kjæledyr.
// Bruk constructor i klassen, og man skal ikke ha lov til å endre data som navn, age eller noen andre egenskaper utenfra klassen. Lag funksjonalitet som gjør at man kan gi dyret mat, kose med dyret eller sjekke om dyret må på do
// Her er et eksempel på hvordan det kan se ut:
using hererennamespace;

class Program {

    static void Main() {

        Dyr dyr1 = new Dyr("Per", 30);

        dyr1.meny();
    }
}
