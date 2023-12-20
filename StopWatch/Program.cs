// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

static void Menu()
{
    Console.Clear();
    Console.WriteLine("S = Segundo => 10s -> 10 segundos");
    Console.WriteLine("M = Minuto => 10m-> 10 minutos");
    Console.WriteLine("0 = Sair");
    Console.WriteLine("Quanto tempo deseja contar?");

    string data = Console.ReadLine().ToLower();
    if(data == "0")
    {
        System.Environment.Exit(0);
    }
    char type = char.Parse(data.Substring(data.Length - 1, 1));
    int time = int.Parse(data.Substring(0, data.Length - 1));
    int multiplier = 1;

    if(type == 'm')
    {
        multiplier = 60;
    }

    

    PreStart(time * multiplier);
}

Menu();

static void PreStart(int time){
    Console.Clear();
    Console.WriteLine("Ready");
    Thread.Sleep(1000);
    Console.WriteLine("Set");
    Thread.Sleep(1000);
    Console.WriteLine("Go");
    Thread.Sleep(1000);
    Start(time);
}

static void Start(int time)
{
    int currentTime = 0;
    while (currentTime != time)
    {
        Console.Clear();
        currentTime++;

        Console.WriteLine(currentTime);
        Thread.Sleep(1000);
    }

    Console.Clear();
    Console.WriteLine("StopWatch ended!");
    Thread.Sleep(25000);
    Menu();
}