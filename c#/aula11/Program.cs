// Conversões de tipos (typecast)

int n1 = 10;
float n2 = n1; // Conversão Implícita/segura
Console.WriteLine(n2); 

float n3 = 20.5f;
int n4 = (int)n3; // Conversão Explícita (typecast)
Console.WriteLine(n4); 

int vInt1 = 30;
long vLong1 = vInt1; // Conversão Implícita/segura
Console.WriteLine(vLong1); 

int vInt2 = 30;
short vShort1 = (short)vInt2; // Conversão Explícita (typecast)
Console.WriteLine(vShort1); 