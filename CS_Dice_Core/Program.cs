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

    }
    else
    {

    }

}
else
{

}





Console.ReadKey();

