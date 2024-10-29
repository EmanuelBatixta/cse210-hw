using System;

// I added a exception in the load file to overcome problems
class Program
{
    static void Main(string[] args)
    {
        List<Goal> _goals = new List<Goal>();
        GoalManager _manager = new GoalManager(_goals);
        
        _manager.Start();
    }
}