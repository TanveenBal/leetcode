int counter;
bool keepGoing;

counter = 1;
keepGoing = true;


while (keepGoing)
{
    Console.WriteLine(counter);
    if (counter == 100)
    {
        keepGoing = false;
    }
    counter++;
}
