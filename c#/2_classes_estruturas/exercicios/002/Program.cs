/* Crie a estrutura (struct) fração, que representa uma fração matemática. Esta estrutura deve ser capaz de armazenar o numerador e o denominador da fração. Ela ainda deve ter um
método que recebe uma fração como parâmetro, multiplica ambas as frações, e retorna uma nova fração como resultado. Crie um programa simples que instancia duas frações, define
seus valores, calcula o valor da multiplicação entre elas e mostra o resultado. */

Fracao f1 = new Fracao();
f1.DefinirValores(10, 5);
		
Fracao f2 = new Fracao();
f2.DefinirValores(2, 4);
		
Fracao f3 = f1.Multiplicar(f2);
		
Console.WriteLine(f3.ObterFracao());
		
Console.WriteLine(f3.CalcularValor());


public struct Fracao
{
	double numerador;

	double denominador;

	public double CalcularValor()
	{
		if (denominador == 0)
		{
			return 0;
		}
		return numerador / denominador;
	}

	public Fracao Multiplicar(Fracao f)
	{
		Fracao result = new Fracao();

		result.numerador = numerador * f.numerador;
		result.denominador = denominador * f.denominador;

		return result;
	}

	public void DefinirValores(double numerador, double denominador)
	{
		this.numerador = numerador;
		this.denominador = denominador;
	}

	public string ObterFracao()
	{
		return numerador + "/" + denominador;
	}
}
