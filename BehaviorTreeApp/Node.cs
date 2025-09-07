namespace BehaviorTree
{
    // Clase base abstracta
    abstract class Node
    {
        // Metodo que todas las subclases deben implementar
        public abstract bool Execute();
    }
}
