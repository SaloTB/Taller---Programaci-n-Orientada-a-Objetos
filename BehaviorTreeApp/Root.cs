namespace BehaviorTree
{
    class Root : Node
    {
        private Node child;  // Solo un hijo

        // Constructor: recive el hijo que se va a ejecutar
        public Root(Node child)
        {
            this.child = child;
        }

        // Ejecuta el hijo y devuelve su resultado
        public override bool Execute()
        {
            if (child == null)
                return false; // Si no hay hijo devuelve fallo

            return child.Execute();
        }
    }
}
