// Till lärarna, Om ni undrar om vad betyder [[]], Det är länkar till andra saker i mina antäckningar i Obsidian så jag kan lättare titta tillbaka på svaren eller min egen dokumentering om de språken t.ex. [[Rust]]
# Frågor
## Del 1
1. Varför behövde du kontrollera vilken typ varje objekt hade?

För att [[CSharp|C#]] är noga med Data Typerna vilket gör att du är inte tillåtet att kalla en parameter eller funktion även om du vet att variablen har det till skillnad från t.ex. [[Javascript]] och [[Python]]

2. Vad händer om du lägger till en ny klass CoffeeMachine?

Om jag vill ha den i device listan behöver jag skriva om alla delar i program.cs som går igenom alla devices 

3. Vilka metoder måste du ändra om du lägger till CoffeeMachine?

Måste ändra i alla metoder för jag gör casts för varje av dem och i Main behöver jag lägga in den

4. Vad är problemet med att listan är `List<object>`?

Du kan lägga in allting, även om de inte passar in för vad vi vill göra

5. Vad händer om du råkar glömma en apparattyp i ReportAllEnergy()?

Då skulle den apparaten inte köras och även om den finns i listan skulle inte all energi rapporteras

## Del 2
- [x] Hur många ställen i koden behövde du ändra för att systemet skulle fungera med CoffeeMachine? Kommentera Svaret.
## Del 5 frågor
1. Varför fungerar device.TurnOn() trots att device har typen Appliance?

Genom Polymorphism, Eftersom den har virtual metod vet vi att det kan bli overridad. Om den inte blir det skulle fortfarande bas metoden köras

2. Vilken metod körs om objektet egentligen är en RobotVacuum?

RobotVaccum.TurnOn()

3. Vad blev bättre jämfört med `List<object>`?

Kan lätt skapa nya Appliances utan att behöva ändra på massa saker. Så länge jag lägger in den nya klassen i listad kan jag kalla på de tidigare metoder vi använde

## Del 9 frågor (casta till interfacet)
- [x] Kommentera varför ScheduleAllDevicesWrong inte fungerar
1. Varför kan vi inte anropa `Schedule()` direkt på en variabel av typen Appliance?

Eftersom klassen Appliance har inte funkionen `Schedule()` även om del av barnen har det så tillåter cSharp dig inte at tköra det det inte är tillåtet

2. Varför fungerar det efter att vi castar till `ISchedulable`?

För interfacet ISchedulable har sagt att "jag har kontraktet som säger att jag måste ha  Schedule(DateTime time)" så vi vet att det fungerar

3. Vad betyder det att RobotVacuum både är en Appliance och en ISchedulable?

RobotVaccum ärver Appliance och har kontraktet ISchedulable vilket betyder att den kan castas som båda och har

4. Varför ska inte `Schedule()` ligga direkt i Appliance?

För att alla maskiner behöver det inte så ingen ide att tvinga på

5. Vad är skillnaden mellan arv och interface i det här exemplet?

Arv har med en massa klasser och parametrar inbyggt och kan fungera att ärva utan göra några större skillnader (Och kan bara ärva från en)
Interface är en ritning som säger "Detta måste du ha" och alla dessa måste sättas in manuellt.

## Del 10 (virtual och override)
1. Vad säger kompilatorn i dina child classes där du använder override?

`Oven.cs(12, 26): [CS0506] 'Oven.TurnOn()': cannot override inherited member 'Appliance.TurnOn()' because it is not marked virtual, abstract, or override`

Får inte använda override om metod inte är markerat att tillåta det.

2. Vad föreslår C# att du ska använda om du tar bort override?

Får `The keyword 'new' is required on 'TurnOn' because it hides method 'void SmartaHemmet.Appliances.Appliance.TurnOn()'`. 

Dock kan ha varit för jag kör Rider och att den föreslår shadowing innan override vilket känner mer naturligt
Kör just nu basklass `TurnOn()` istället för barnets egna implementation även om den finns

## Del 11 (new)
1. Blir utskriften samma?

Nej

2. Vilken metod körs när variabeln har typen SmartLamp?

Den kör `TurnOn()` implementationen i SmartLamp

3. Vilken metod körs när variabeln har typen Appliance?

Kör bas implementationen i Appliance

4. Varför är detta farligt eller förvirrande?

Eftersom polymorphism är förväntat så kan andra kodare förvänta sig att använda Appliance för att köra `TurnOn()` funktionaliteten så korrekt som möjligt medans köra med `new` kommer kräva att casta den för att få det korrekt.

5. Vad händer om du byter new till override?

Kommer alltid köra metoden `TurnOn()` i SmartLamp oavsätt om den är castad eller inte

## Del 12 (sealed)
1. Vad säger kompilatorn?

`  PizzaOven.cs(5, 26): [CS0239] 'PizzaOven.TurnOn()': cannot override inherited member 'Oven.TurnOn()' because it is sealed`

2. Varför får PizzaOven inte override:a TurnOn()?

Vi har sagt att den inte får overrida pga den är `sealed`

3. När kan det vara rimligt att använda sealed override?

När vi vet att implementationen för den klassens implementation är extremt viktig för att få allt att fungera rätt men vi vill fortfarande att saker ska ärva den. T.ex. att vi har en `TakeDamage` som var overridad från en objekt klass men vi vill att alla fiender ska agera samma när de tar skada så vi sätter `sealed override` på `Enemy` klassen.

4. Vad kan PizzaOven fortfarande göra i stället? Kan den override:a någon annan metod?

Vi kan fortfarande ärva av Appliances. Vi kan också använda `new` för att tvinga in impementering om nödvändigt.
Annars alla andra funktioner som `TurnOff()`  `SetInfo` och `GetDailyEnergyUsage()` kan overridas

## Del 13 (filtrera med interface)
1. Fråga: Varför kan listan vara `List<ISchedulable>` även om objekten egentligen är olika klasser?

Eftersom vi vet att de har samma kontrakt så kan vi veta att de är kompatibla att köra den funktionaliteten som kontraktet säger att de har

# Checklista
- [x] Appliance
- [x] minst fem child classes
- [x] minst en extra egen apparat
- [x] virtual
- [x] override
- [x] new
- [x] sealed override
- [x] ISchedulable
- [x] casting till interface
- [x] `List<Appliance>`
- [x] `List<ISchedulable>` i extrautmaningen
- [x] SmartHomeController