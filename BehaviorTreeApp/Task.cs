namespace BehaviorTree
{
    class Task : Node
    {
        private string actionName;

        // Constructor
        public Task(string actionName)
        {
            this.actionName = actionName;
        }

        // Ejecuta la tarea (De mentiritas)
        public override bool Execute()
        {
            Console.WriteLine($"Ejecutando tarea: {actionName}");
            return true; // Siempre cumple la tarea
        }
    }
}
