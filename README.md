# OOP-Labb-3
Theo Esberg, SUT22
Campus Varberg

# Om uppgiften
I denna uppgift kommer du öva på att använda Polymorphism inom objektorientering. Uppgiften handlar till stor del om att tänka ut en struktur för Polymorphism .

# Todo

- [x]  Du ska skapa en klass som ska vara ParentClass till de andra klasserna som ska ärva från den. Klassen ska heta Geometri`{ }` och den ska en metod som heter `Area()` och `return` typ är en double.
- [x]  Du ska skapa tre klasser till som ska ärva från Geometriklassen och klasserna ska heta `Rektangel`, `Fyrkant` och `Cirkel.` Alla klasser ska ha en metod som heter `Area().`
- [x]  Varje klass ska ha minst en egenskap, till exempel:
    
    ```csharp
    public class Cirkel{
         public double Radius {get; set;}
    }
    ```
    
- [x]  I alla ChildClasses ska vi overrida metoden `Area()` med olika implementeringar. Eftersom arean för en cirkel inte räknas ut på samma sätt som arean för en fyrkant.
- [x]  Alla ChildClasses måste ha en Constructor för att ge värde till egenskaper och vi ska ge den ett fast värde i konstruktorn. Till Exempel:
    
    ```csharp
    public Cirkel{
          Radius = 4;
    }
    ```
    
- [x]  I Main-metoden ska du skapa object reference från Geometriklassen och den ska peka till ett objekt av varje klass.

## Output :
![Output Image](https://qlok.notion.site/image/https%3A%2F%2Fs3-us-west-2.amazonaws.com%2Fsecure.notion-static.com%2F702b907e-d446-4ed1-a4db-397a410c2f99%2FOutput.png?table=block&id=6039dde1-e9d1-4d3e-8a86-43d835da9d67&spaceId=76ff052e-5519-4c95-9c8a-d50fbda370ef&width=680&userId=&cache=v2)
