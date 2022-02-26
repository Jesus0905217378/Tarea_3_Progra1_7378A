static void ejercicio1Tarea3()
{
    int C200, C100, C50, C20, C10, C5, C1, C50c, C25c, C10c, C5c, C1c;
    C200= C100= C50= C20= C10= C5= C1= C50c= C25c= C10c= C5c = C1c =0;
    float CAN;
    string linea;

    Console.WriteLine("Ingresa una cantidad");
    linea = Console.ReadLine();
    CAN = float.Parse(linea);


    switch (CAN)
    {
        case >= 200:
            C200 = ((int)CAN / 200);
            CAN = CAN - (C200 * 200);
            break;
    }//200
    switch (CAN)
    {
        case >= 100:
            C100 = ((int)CAN / 100);
            CAN = CAN - (C100 * 100);
            break;
    }//100
    switch (CAN)
    {
        case >= 50:
            C50 = ((int)CAN / 50);
            CAN = CAN - (C50 * 50);
            break;
    }//50
    switch (CAN)
    {
        case >= 20:
            C20 = ((int)CAN / 20);
            CAN = CAN - (C20 * 20);
            break;
    }//20
    switch (CAN)
    {
        case >= 10:
            C10 = ((int)CAN / 10);
            CAN = CAN - (C10 * 10);
            break;
    }//10
    switch (CAN)
    {
        case >= 5:
            C5 = ((int)CAN / 5);
            CAN = CAN - (C5 * 5);
            break;
    }//5
    switch (CAN)
    {
        case >= 1:
            C1 = ((int)CAN / 1);
            CAN = CAN - (C1 * 1);
            break;
    }//1
    if ((CAN >= 0.5))
    {
        C50c = (int)(CAN / 0.5);
        CAN = CAN - (float)(C50c * 0.5);
    }//50c
    if ((CAN >= 0.25))
    {
        C25c = (int)(CAN / 0.25);
        CAN = CAN - (float)(C25c * 0.25);
    }//25c
    if ((CAN >= 0.10))
    {
        C10c = (int)(CAN / 0.10);
        CAN = CAN - (float)(C10c * 0.10);
    }//10c
    if ((CAN >= 0.05))
    {
        C5c = (int)(CAN / 0.05);
        CAN = CAN - (float)(C5c * 0.05);
    }//5c
    if ((CAN >= 0.01))
    {
        C1c = (int)Math.Round(CAN / 0.01);
        CAN = CAN - (float)(C1c * 0.01);
        
    }//1c

    Console.WriteLine($"BILLETES DE 200: {C200}");
    Console.WriteLine($"BILLETES DE 100: {C100}");
    Console.WriteLine($"BILLETES DE  50: {C50}");
    Console.WriteLine($"BILLETES DE  20: {C20}");
    Console.WriteLine($"BILLETES DE  10: {C10}");
    Console.WriteLine($"BILLETES DE   5: {C5}");
    Console.WriteLine($"MONEDAS  DE   1: {C1}");
    Console.WriteLine($"MONEDAS  DE 50c: {C50c}");
    Console.WriteLine($"MONEDAS  DE 25c: {C25c}");
    Console.WriteLine($"MONEDAS  DE 10c: {C10c}");
    Console.WriteLine($"MONEDAS  DE  5c: {C5c}");
    Console.WriteLine($"MONEDAS  DE  1c: {C1c}");
} // fin Ejercicio 1
//ejercicio1Tarea3();

static void ejercicio2Tarea3()
{
    int C200, C100, C50, C20, C10, C5, C1, C50c, C25c, C10c, C5c, C1c;
    C200 = C100 = C50 = C20 = C10 = C5 = C1 = C50c = C25c = C10c = C5c = C1c = 0;
    float CAN, Dolar;
    string linea;

    Console.WriteLine("Ingresa una cantidad Dolar");
    linea = Console.ReadLine();
    Dolar = float.Parse(linea);
    CAN = Convert.ToSingle(Dolar*7.70);


    switch (CAN)
    {
        case >= 200:
            C200 = ((int)CAN / 200);
            CAN = CAN - (C200 * 200);
            break;
    }//200
    switch (CAN)
    {
        case >= 100:
            C100 = ((int)CAN / 100);
            CAN = CAN - (C100 * 100);
            break;
    }//100
    switch (CAN)
    {
        case >= 50:
            C50 = ((int)CAN / 50);
            CAN = CAN - (C50 * 50);
            break;
    }//50
    switch (CAN)
    {
        case >= 20:
            C20 = ((int)CAN / 20);
            CAN = CAN - (C20 * 20);
            break;
    }//20
    switch (CAN)
    {
        case >= 10:
            C10 = ((int)CAN / 10);
            CAN = CAN - (C10 * 10);
            break;
    }//10
    switch (CAN)
    {
        case >= 5:
            C5 = ((int)CAN / 5);
            CAN = CAN - (C5 * 5);
            break;
    }//5
    switch (CAN)
    {
        case >= 1:
            C1 = ((int)CAN / 1);
            CAN = CAN - (C1 * 1);
            break;
    }//1
    if ((CAN >= 0.5))
    {
        C50c = (int)(CAN / 0.5);
        CAN = CAN - (float)(C50c * 0.5);
    }//50c
    if ((CAN >= 0.25))
    {
        C25c = (int)(CAN / 0.25);
        CAN = CAN - (float)(C25c * 0.25);
    }//25c
    if ((CAN >= 0.10))
    {
        C10c = (int)(CAN / 0.10);
        CAN = CAN - (float)(C10c * 0.10);
    }//10c
    if ((CAN >= 0.05))
    {
        C5c = (int)(CAN / 0.05);
        CAN = CAN - (float)(C5c * 0.05);
    }//5c
    if ((CAN >= 0.01))
    {
        C1c = (int)Math.Round(CAN / 0.01);
        CAN = CAN - (float)(C1c * 0.01);

    }//1c

    Console.WriteLine($"BILLETES DE 200: {C200}");
    Console.WriteLine($"BILLETES DE 100: {C100}");
    Console.WriteLine($"BILLETES DE  50: {C50}");
    Console.WriteLine($"BILLETES DE  20: {C20}");
    Console.WriteLine($"BILLETES DE  10: {C10}");
    Console.WriteLine($"BILLETES DE   5: {C5}");
    Console.WriteLine($"MONEDAS  DE   1: {C1}");
    Console.WriteLine($"MONEDAS  DE 50c: {C50c}");
    Console.WriteLine($"MONEDAS  DE 25c: {C25c}");
    Console.WriteLine($"MONEDAS  DE 10c: {C10c}");
    Console.WriteLine($"MONEDAS  DE  5c: {C5c}");
    Console.WriteLine($"MONEDAS  DE  1c: {C1c}");
} // fin Ejercicio 2
ejercicio2Tarea3();


