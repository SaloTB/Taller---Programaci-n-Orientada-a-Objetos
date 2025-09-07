using System;

namespace BehaviorTree
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear una tarea
            Task t1 = new Task("Mover hacia adelante");

            // Crear la raiz con esa tarea como hijo
            Root root = new Root(t1);

            // Ejecutar todo
            bool result = root.Execute();

            Console.WriteLine("Resultado del arbol: " + result);
        }
    }
}
