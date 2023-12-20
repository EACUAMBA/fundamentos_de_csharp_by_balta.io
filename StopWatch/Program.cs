// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

static void Start()
{
    int time = 10;

    int currentTime = 0;
    while (currentTime != time)
    {
        Console.Clear();
        currentTime++;

        Console.WriteLine(currentTime);
        Thread.Sleep(1000);
    }
}

Start();