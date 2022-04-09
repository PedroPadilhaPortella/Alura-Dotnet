namespace queue 
{
    public class Program
    {
        static Queue<string> pedagio = new Queue<string>();
        public static void Main()
        {
            pedagio.Enqueue("Caminhão");
            pedagio.Enqueue("Moto");
            pedagio.Enqueue("Van");
            pedagio.Enqueue("Carro");

            foreach (var veiculo in pedagio)
            {
                Console.WriteLine(veiculo);
            }
            
            Console.WriteLine("Passou: " + pedagio.Dequeue());
            Console.WriteLine("Passou: " + pedagio.Dequeue());
            Console.WriteLine("Passou: " + pedagio.Dequeue());
            Console.WriteLine("Passou: " + pedagio.Dequeue());
        }
    }
}