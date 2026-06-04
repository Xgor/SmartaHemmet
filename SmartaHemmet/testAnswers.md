// Till lärarna, Om ni undrar om vad betyder [[]], Det är länkar till andra saker i mina antäckningar i Obsidian så jag kan lättare titta tillbaka på svaren eller min egen dokumentering om de språken t.ex. [[Rust]]
# Frågor
## Del 1
1. Varför behövde du kontrollera vilken typ varje objekt hade?

För att [[CSharp|C#]] är noga med Data Typerna vilket gör att du är inte tillåtet att kalla en parameter eller funktion även om du vet att variablen har det till skillnad från t.ex. [[Javascript]] och [[Python]]

2. Vad händer om du lägger till en ny klass CoffeeMachine?

Behöver skriva om allt med liknande fuktioner men de fungerar inte med sig själv

3. Vilka metoder måste du ändra om du lägger till CoffeeMachine?

Måste ändra i alla metoder för jag behöver göra cast för varje av dem

4. Vad är problemet med att listan är `List<object>`?

Du kan lägga in allting, även om de inte passar in för vad vi vill göra

5. Vad händer om du råkar glömma en apparattyp i ReportAllEnergy()?

Då skulle den apparaten inte köras och även om den finns i listan skulle inte all energi rapporteras

## Del 2
1. Hur många ställen i koden behövde du ändra för att systemet skulle fungera med CoffeeMachine?

när jag la till CoffeeMachine i koden behövde jag ändra på 3 ställen.  
Skapa upp den, casta den innan jag sätter på och av och casta när jag kollar energi
tog 30 rader kod= 22 rader för klass + 9 i program
## Del 5 frågor
1. Varför fungerar device.TurnOn() trots att device har typen Appliance?

Genom Polymorphism

2. Vilken metod körs om objektet egentligen är en RobotVacuum?

RobotVaccum.TurnOn()

3. Vad blev bättre jämfört med `List<object>`?

Kan lätt skapa nya Appliances utan att behöva ändra på massa saker. Så länge jag lägger in den nya klassen i listad kan jag kalla på de tidigare metoder vi använde

## Del 9 frågor (casta till interfacet)
- [x] Kommentera varför ScheduleAllDevicesWrong inte fungerar
1. Varför kan vi inte anropa Schedule() direkt på en variabel av typen Appliance?

Eftersom alla appliances har inte Schedule() så det inte är tillåtet

2. Varför fungerar det efter att vi castar till ISchedulable?

För interfacet ISchedulable har sagt att "jag har kontraktet som säger att jag måste ha  Schedule(DateTime time)" så vi vet att det fungerar

3. Vad betyder det att RobotVacuum både är en Appliance och en ISchedulable?

RobotVaccum ärver Appliance och har kontraktet ISchedulable vilket betyder att den kan castas som båda och har

4. Varför ska inte Schedule() ligga direkt i Appliance?

För att alla maskiner behöver det inte så ingen ide att tvinga på

5. Vad är skillnaden mellan arv och interface i det här exemplet?

Arv har med en massa klasser och parametrar inbyggt och kan fungera att ärva utan göra några större skillnader (Och kan bara ärva från en)
Interface är en ritning som säger "Detta måste du ha" och alla dessa måste sättas in manuellt.

## Del 10 (virtual och override)
1. Vad säger kompilatorn i dina child classes där du använder override?

`Oven.cs(12, 26): [CS0506] 'Oven.TurnOn()': cannot override inherited member 'Appliance.TurnOn()' because it is not marked virtual, abstract, or override`

2. Vad föreslår C# att du ska använda om du tar bort override?

Får `The keyword 'new' is required on 'TurnOn' because it hides method 'void SmartaHemmet.Appliances.Appliance.TurnOn()'`. Dock kan ha varit för jag kör Rider och att den föreslår shadowing innan override vilket känner mer naturligt
   Kör just nu basklass `TurnOn()` istället för barnets egna implementation även om den finns