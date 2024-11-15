string duel = Console.ReadLine();

int jinx = 0;
int charm = 0;

int ancientMagic = 0;
int protectiveMagic = 0;

int curses = 0;

for (int i = 0; i < duel.Length; i++)
{
    if (duel[i] == '/')
    {
        jinx++;
    }
    else if (duel[i] ==  '\\')
    {
        charm++;
    }
    else if (duel[i] == '!') 
    {
        curses++;
    }
    else if (duel[i] == '<') 
    {
        ancientMagic++;
    }
    else if (duel[i] == '>')
    {
        protectiveMagic++;
    }
}

if (curses % 2 == 0 && jinx == charm && ancientMagic == protectiveMagic)
{
    Console.WriteLine("Epic");
}
else
{
    Console.WriteLine("Not Epic");
}