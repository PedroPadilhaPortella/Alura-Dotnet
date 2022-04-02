namespace listas
{
    public class Program
    {
        public static void Main()
        {
            List<int> numeros = new List<int> { 1, 3, 2, 5, 4, 8, 9 };
            numeros.Add(6);
            numeros.Add(7);
            numeros.Remove(2);

            numeros.Sort();
            numeros.RemoveAt(numeros.Count - 1);
            Print<int>(numeros);

            numeros.Reverse();
            Print<int>(numeros);

            // Console.WriteLine($"Primeiro valor: {numeros[0]}");
            Console.WriteLine($"Primeiro valor: {numeros.First()}");

            // Console.WriteLine($"Ultimo valor: {numeros[numeros.Count - 1]}");
            Console.WriteLine($"Ultimo valor: {numeros.Last()}");


            List<string> alunos = new List<string> { "pedro", "samuel", "daniel", "pedro", "samuel", "daniel"} ;
            
            Console.WriteLine($"Primeiro ...el : {alunos.First(aluno => aluno.Contains("el"))}");
            Console.WriteLine($"Ultimo ...el : {alunos.Last(aluno => aluno.Contains("el"))}");

            // Cria uma cópia da Lista
            List<string> alunosCopia = alunos.GetRange(0, alunos.Count);
            Print<string>(alunosCopia);
            
            // Cria um clone da Lista
            List<string> alunosClone = new List<string>(alunos);
            Print<string>(alunosClone);



            //Lista de Objetos
            Pessoa pessoa1 = new Pessoa("Samuel", 24);
            Pessoa pessoa2 = new Pessoa("Pedro", 20);
            Pessoa pessoa3 = new Pessoa("Daniel", 13);

            List<Pessoa> pessoas = new List<Pessoa>();

            pessoas.Add(pessoa1);
            pessoas.Add(pessoa2);
            pessoas.Add(pessoa3);

            pessoas.Sort((pessoa, other) => pessoa.idade.CompareTo(other.idade));

            Print<Pessoa>(pessoas);
        }

        // Metodo Print
        static void Print<T>(List<T> dados)
        {
            dados.ForEach(item => {
                Console.Write($"{item}, ");
            });
            Console.WriteLine();
        }
    }
}
