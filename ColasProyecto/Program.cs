namespace ColasProyecto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Colas cola = new Colas(3);

            cola.Agregar("A");
            cola.Agregar("B");
            cola.Agregar("C");

            Console.WriteLine("Estado inicial (Llena):");
            Console.WriteLine(cola.ObtenerDatos());

            cola.Eliminar();
            Console.WriteLine("Después de eliminar el primero:");
            Console.WriteLine(cola.ObtenerDatos());

            cola.Agregar("D");
            Console.WriteLine("Después de agregar un elemento nuevo:");
            Console.WriteLine(cola.ObtenerDatos());
        }
    }
}