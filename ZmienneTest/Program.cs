string liczby = "0112222343453";


//
int Counter0 = 0;
int Counter1 = 0;
int Counter2 = 0;
int Counter3 = 0;
int Counter4 = 0;
int Counter5 = 0;
int Counter6 = 0;
int Counter7 = 0;
int Counter8 = 0;
int Counter9 = 0;
//...


foreach (char liczba in liczby)
{
    if (liczba == '0')
    {
        Counter0++;
    }
    else if (liczba == '1')
    {
        Counter1++;
    }
    else if (liczba == '2')
    {
        Counter2++;
    }
    else if (liczba == '3')
    {
        Counter3++;
    }
    else if (liczba == '4')
    {
        Counter4++;
    }
    else if (liczba == '5')
    {
        Counter5++;
    }
    else if (liczba == '6')
    {
        Counter6++;
    }
    else if (liczba == '7')
    {
        Counter7++;
    }
    else if (liczba == '8')
    {
        Counter8++;
    }
    else if (liczba == '9')
    {
        Counter9++;
    }
}



// wyswietl wyniki 


Console.WriteLine("Suma liczb 0 wynosi: " + Counter0);
Console.WriteLine("Suma liczb 1 wynosi: " + Counter1);
Console.WriteLine("Suma liczb 2 Wynosi:" + Counter2);
Console.WriteLine("Suma liczb 3 wynosi:" + Counter3);
Console.WriteLine("Suma liczb 4 wynosi:" + Counter4);
Console.WriteLine("Suma liczb 5 wynosi: " + Counter5);
Console.WriteLine("Suma liczb 6 wynosi:" + Counter6);
Console.WriteLine("Suma liczb 7 wynosi:" + Counter7);
Console.WriteLine("Suma liczb 8 wynosi: " + Counter8);
Console.WriteLine("Suma liczb 9 wynosi: " + Counter9);

Console.ReadKey();