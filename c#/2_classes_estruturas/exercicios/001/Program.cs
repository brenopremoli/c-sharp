/*
Crie as classes Relogio e Ponteiro e escreva um método Main() para treinar a chamada aos
métodos e fields.

Fields da classe Relogio:
• ponteiroHora (tipo Ponteiro)
• ponteiroMinuto (tipo Ponteiro)
• ponteiroSegundo (tipo Ponteiro)

Métodos da classe Relogio:
• AcertarRelogio(int, int, int): Acerta o relógio, posicionando adequadamente cada
ponteiro do relógio. Os parâmetros passados são hora, minuto e segundo.
• LerHora(): retorna a hora atual do relógio.
• LerMinuto(): retorna o minuto atual do relógio.
• LerSegundo(): retorna o segundo atual do relógio.

Fields da classe Ponteiro:
• posicao(int): indica em qual posição está o ponteiro (1, 2, 3, 4, etc.).
*/

Relogio r1 = new Relogio();
		
	r1.AcertarRelogio(3, 30, 50);
	Console.WriteLine("Posição da hora: " + r1.ponteiroHora.posicao);
	Console.WriteLine("Posição do minuto: " + r1.ponteiroMinuto.posicao);
	Console.WriteLine("Posição do segundo: " + r1.ponteiroSegundo.posicao); 		

    int hora = r1.LerHora();
	int minuto = r1.LerMinuto();
	int segundo = r1.LerSegundo();
		
	Console.WriteLine("\nHora: " + hora);
	Console.WriteLine("Minuto: " + minuto);
	Console.WriteLine("Segundo: " + segundo);
    Console.WriteLine(hora+":"+minuto+":"+segundo);

	Relogio r2 = new Relogio();
	r2.AcertarRelogio(22, 0, 0);
	Console.WriteLine("\nHora do segundo relógio: " + r2.LerHora());

class Ponteiro{
    public int posicao;
}
class Relogio{
    public Ponteiro ponteiroHora = new Ponteiro();
    public Ponteiro ponteiroMinuto = new Ponteiro();
    public Ponteiro ponteiroSegundo = new Ponteiro();
    public void AcertarRelogio(int hora, int minuto, int segundo)
    {
        hora = hora % 12;

        ponteiroHora.posicao = hora;
        ponteiroMinuto.posicao = minuto / 5;
		ponteiroSegundo.posicao = segundo / 5;
    }
    	public int LerHora()
	{
		return ponteiroHora.posicao;
	}
	public int LerMinuto()
	{
		return ponteiroMinuto.posicao * 5;
	}
	public int LerSegundo()
	{
		return ponteiroSegundo.posicao * 5;
	}
}
