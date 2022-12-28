// Argumento out

static int divide(int dividendo, int divisor, out int resto)
{
    int quociente = dividendo / divisor;
    resto = dividendo % divisor;
    return quociente;
}

int divid, divis, quoc, rest;
divid = 10;
divis = 3;
quoc = divide(divid, divis, out rest);

Console.WriteLine("{0}/{1} \nQuociente = {2} \nResto = {3} ", divid, divis, quoc, rest);
