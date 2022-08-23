// See https://aka.ms/new-console-template for more information
int i = 10;
double d = i; // Casting Implícito
Console.WriteLine(d);

short s = 5;
long l = s; // Casting Implícito
Console.WriteLine(l);

double d2 = 3.5;
int i2 = (int)d2; // Casting Explícito
Console.WriteLine(i2);

long l2 = 25;
int i3 = (int)l2; // Casting Explícito
Console.WriteLine(i3);

long l3 = 101982734278917;
int i4 = (int)l3; // Casting Explícito (truncou os bytes - inverteu o sinal)
Console.WriteLine(i4);
