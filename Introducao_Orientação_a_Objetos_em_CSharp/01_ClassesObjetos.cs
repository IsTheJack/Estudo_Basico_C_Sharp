//Documento de Consulta para iniciantes criado por Roberto Oliveira (github.com/RobertoOll)

//Este documento contém:
//	--> Definição de Classe / Objeto
//	-->	Definição de Atributo / Método
//	--> Exemplo prático de uso de Atributo e Método

//Classe:
//	--> O mundo é cercado por objetos com características e ações
//	peculiares. Classes são declarações de objetos.
//	A grosso modo: Antes de construirmos uma casa (objeto) devemos 
//	criar uma 'planta' ou projeto especificando todas as suas características (atributos) e 
//	ações (métodos) de maneira geral. Com base nisso e que tudo que vemos são objetos,
//	podemos criar 'plantas' pra todos os tipos de objetos usando as classes.
//	(apenas deixando claro que a explicação acima é a grosso modo). Vejamos o exemplo:

//Classe AnimalMamifero
public class AnimalMamifero
{
	//Definição de Atributos:
	//	-->	Os Atributos são as características que definem os objetos.
	//	Exemplos de atributos para animais mamíferos são:
	public string especie;
	public string cor;
	public int idade;
	public double peso;
	public string sexo;
	//	Entre outros...
	//	A sintaxe básica da declaração de um atributo é [acesso] tipo nomeDoAtributo, 
	//	como visto acima.
	//	*	Acesso indica o nível de proteção do atributo.
	//		caso seja omitido, o atributo será considerado private.
	//	Os tipos de acesso em C# são:
	//	--> private: O atributo só pode ser acessado dentro da classe a qual
	//		foi declarado.
	//	-->	public: O atributo pode ser acessado de qualquer outra classe.
	//	-->	protected: O atributo só pode ser acessado da própria classe
	//		e de classes derivadas.
	//	-->	internal: O atributo pode ser acessado de qualquer classe
	//		(a não ser as classes fora do 'Assembly' onde foi definido).
	//	-->	protected internal: O atributo só pode ser acessado da própria classe
	//		e de classes derivadas. (a não ser as classes fora do 'Assembly' onde 
	//		foi definido).
	//
	//	*	Tipo é o seu tipo de dado (C# é uma linguagem fortemente tipada, se faz
	//	necessário indicar qual tipo de dado cada atributo pertence).
	//	--> Para saber mais sobre tipos: 
	//		http://msdn.microsoft.com/pt-br/library/ms173104.aspx
	//	

	//Definição de Método:
	//	-->	Os Métodos são as ações que os objetos podem executar.
	//	Exemlos de métodos para animais mamíferos são:
	public void Andar()
	{
		System.Console.WriteLine("O(a) {0} está andando.", especie);
	}
	public void Comer()
	{
		System.Console.WriteLine("O(a) {0} está comendo.", especie);
	}
	public int Envelhecer(int quantidadeDeAnos)
	{
		if(idade <= 100)
		{
			System.Console.WriteLine("O(a) {0} está com {1} ano(s) de idade.", especie, idade + quantidadeDeAnos);
		}
		else
		{
			Morrer();
		}
		return idade + quantidadeDeAnos;
	}
	public void Morrer()
	{
		System.Console.WriteLine("O(a) {0} morreu. :(", especie);
	}
	//	Entre muitos outros... (repare que os nomes dos métodos são verbos infinitivos)
	//	A sintaxe básica da declaração de um método é:
	//	acesso tipoDeRetorno NomeDoMetodo(tipoDeArgumento nomeDoArgumento)
	//	{
	//		//conteúdo do método	
	//	}
	//	Vide os exemplos práticos dos métodos Andar, Comer, Envelhecer e Morrer.
	//	*	Acesso de método funciona como acesso dos atributos
	//		caso seja omitido, o método será considerado private.
	//
	//	*	O tipo de retorno indica o tipo de dado que o método vai retornar ao ser chamado e é seguido
	//		pelo nome do método.
	//	*	O tipo de retorno void indica que o método não retorna nenhum dado.
	//	-->	Vide Métodos Andar(), Comer() e Morrer():
	//
	//	-->	Vide o Método Envelhecer():
	//		O retorno do método é do tipo int, na qual retorna a soma da idade com a quantidade 
	//		de anos (que é um argumento).
	//
	//	*	O tipo de argumento é o tipo de dado do argumento de entrada e é seguido pelo nome do argumento.
	//	--> Vide o Método Envelhecer():
	//		Quando este método é chamado, ele recebe como valor de argumento a quantidade
	//		de anos a se acrescentar a idade.
}
//	A sintaxe básica de uma classe é: 
//	acesso class NomeDaClasse
//	{
//		//conteúdo da classe
//	} 
//	*	acesso representa o nível de proteção da classe.
//		caso seja omitido, a classe será considerada internal.
//	Os tipos de acesso em C# são:
//	-->	internal: A classe só pode ser acessada a partir do mesmo Assembly onde se encontra deficida.
//	--> public: A classe pode ser acessada de qualquer lugar pro código.

class ClassesObjetos
{
	public static void Main(string[] args)
	{
		//	Abaixo está instanciado a classe, criando-se um objeto.
		AnimalMamifero Cavalo = new AnimalMamifero();
		//	O acesso ao atributo é feito escrevendo o nome do objeto, colocando o carácter "."
		//	e em seguida o nome do atributo ( Objeto.Atributo ).
		//	Abaixo, os atributos do objeto Cavalo recebem os valores:
		Cavalo.especie = "Cavalo";
		Cavalo.cor = "Marrom";
		Cavalo.idade = 3;
		Cavalo.peso = 170.50;
		Cavalo.sexo = "Macho";
		System.Console.WriteLine("Pressione 'ENTER'.");
		System.Console.ReadLine();
		System.Console.WriteLine("Espécie: {0}.\nCor: {1}.\nIdade: {2}.\nPeso: {3}.\nSexo: {4}",
								Cavalo.especie, Cavalo.cor, Cavalo.idade, Cavalo.peso, Cavalo.sexo);

		//	O acesso ao método é feito escrevendo o nome do objeto, colocando o carácter "."
		//	e em seguida o nome do método com os 'Parênteses' para os argumentos ( Objeto.Metodo() ).
		//	caso o método precise de argumentos ( Objeto.Metodo(argumento))
		//	Abaixo, os atributos do objeto Cavalo recebem os valores:
		System.Console.WriteLine("Pressione 'ENTER'.");
		System.Console.ReadLine();
		Cavalo.Andar();
		System.Console.WriteLine("Pressione 'ENTER'.");
		System.Console.ReadLine();
		Cavalo.Comer();
		System.Console.WriteLine("Pressione 'ENTER'.");
		System.Console.ReadLine();
		System.Console.WriteLine("O {0} envelhecerá até morrer.", Cavalo.especie);
		System.Console.WriteLine("Pressione 'ENTER'.");
		System.Console.ReadLine();
		for (int i = 1; i <= 60; i += 10)
		{
			Cavalo.idade = Cavalo.Envelhecer(i);
		}
		System.Console.ReadLine();
	}
}
