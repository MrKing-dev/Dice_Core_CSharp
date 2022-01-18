List<int> diceList = new List<int>();
List<int> highlightList = new List<int>();
int highlightLength = 0;
//Input values
int sides = 10;
int quan = 10;
bool highlight = false;
bool explode = false;
bool combine = false;


CS_Dice_Core.Dice d = new CS_Dice_Core.Dice();

Console.Write("How many dice to roll?: ");
quan = Console.Read();
Console.Write("How many sides should the dice have?: ");
sides = Console.Read();
Console.WriteLine("Should I highlight successes??: ");
string shouldHighlight = Console.ReadLine();
shouldHighlight = shouldHighlight.ToLower();
if(shouldHighlight == "true")
{
    highlight = true;
}
else if(shouldHighlight == "false")
{
    highlight= false;
}
else
{
    Console.WriteLine("Invalid selection.");
}
Console.WriteLine("Should I explode high rolls?: ");
string shouldExplode = Console.ReadLine();
if (shouldExplode == "true")
{
    explode = true;
}
else if (shouldExplode == "false")
{
    explode = false;
}
else
{
    Console.WriteLine("Invalid selection.");
}
Console.WriteLine("Should I combine all rolls into a single result?: ");
string shouldCombine = Console.ReadLine();
if (shouldCombine == "true")
{
    combine = true;
}
else if (shouldCombine == "false")
{
    combine = false;
}
else
{
    Console.WriteLine("Invalid selection.");
}
Console.WriteLine("Press enter to roll.");
Console.ReadKey();



if (explode == true)
{
    diceList = d.Roll(sides, quan);
    List<int> high = diceList.FindAll(x => x == sides);
    int highRoll = high.Count();
    List<int> e = d.Roll(sides, highRoll);
    diceList.AddRange(e);
}
else
{
    diceList = d.Roll(sides, quan);
}

if(highlight == true)
{
    if(sides == 10)
    {
        List<int> x = diceList.FindAll(n => n >= 8);
        highlightList.AddRange(x);

    }
    else if(sides == 20)
    {
        List<int> x = diceList.FindAll(n => n == 10);
        highlightList.AddRange(x);

    }
    else
    {
        Console.WriteLine("Invalid Type!");

    }
    highlightLength = highlightList.Count;

}

if(combine == true)
{
    int diceSum = 0;
    foreach(int dice in diceList)
    {
        diceSum += dice;
    }
    diceList.Clear();
    diceList.Add(diceSum);
}

string result = String.Join(", ", diceList);

if(highlight == true)
{
    Console.WriteLine($"Results: {result} | Total Rolled: {diceList.Count} | Successes: {highlightLength}");
}
else
{
    Console.WriteLine($"Results: {result}");
}





Console.ReadKey();

