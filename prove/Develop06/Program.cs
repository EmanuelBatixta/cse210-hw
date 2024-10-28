using System;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> _goals = new List<Goal>();
        GoalManager _manager = new GoalManager(_goals);
        
        _manager.Start();
    }
}