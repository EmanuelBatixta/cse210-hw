using System.Threading.Channels;

class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager(List<Goal> goal)
    {
        _goals = goal;
        _score = 0;
    }
    public void Start()
    {
        string option;
        do 
        {
        Console.Clear();
        DisplayPlayerInfo();
        Console.WriteLine($"Menu Options:");
        Console.WriteLine($"\t1. Create new goal");
        Console.WriteLine($"\t2. List Goals");
        Console.WriteLine($"\t3. Save Goals");
        Console.WriteLine($"\t4. Load Goals");
        Console.WriteLine($"\t5. Record Event");
        Console.WriteLine($"\t6. Quit");
        Console.Write($"Select a choice from menu: ");
        option = Console.ReadLine();

        if(option == "1")
        {
            CreateGoal();
        }
        else if(option == "2")
        {
            if(_goals.Count() > 0)
            {
                ListGoalDetails();
            }
            else
            {
                Console.WriteLine("\tnone");
            }
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();
        }
        else if(option == "3")
        {
            SaveGoals();
        }
        else if(option == "4")
        {
            LoadGoals();
        }
        else if(option == "5")
        {
            RecordEvent();
        }
        }while(option != "6");
    

    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.\n");
    }
    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            string content = _goals[i].GetDetailsString();
            string[] check = content.Split("] ");
            string[] nD = check[1].Split("(");
            string name = nD[0].Trim();
            Console.WriteLine($"{i + 1}. {name}");
        }
    }
    public void ListGoalDetails()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }
    public void CreateGoal()
    {
        Console.Clear();
        Console.WriteLine("The types of goal are:");
        Console.WriteLine("\t1. Simple Goal");
        Console.WriteLine("\t2. Eternal Goal");
        Console.WriteLine("\t3. Checklist Goal");
        Console.Write("What is the type of your new goal? (Type the number) ");
        int goaltype = int.Parse(Console.ReadLine());
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is the short description of your goal? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount associated with this goal? ");
        string points = Console.ReadLine();
        
        Goal _goal = null;

        if(goaltype == 1 )
        {
            _goal = new SimpleGoal(name,description,points);
        }
        else if(goaltype == 2 )
        {
            _goal = new EternalGoal(name,description,points);
        }
        else
        {
            Console.Write("How many times does this goal need to be accomplished to recive the bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            _goal = new ChecklistGoal(name,description,points,target,bonus);
        }

        _goals.Add(_goal);
    }
    public void RecordEvent()
    {
        Console.Clear();
        Console.WriteLine("\nThe goals are:\n");
        ListGoalNames();
        Console.Write("\nWhich goal did you accoplish? ");
        int goalIndex = int.Parse(Console.ReadLine()) - 1 ;

        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            _goals[goalIndex].RecordEvent();
            if(_goals[goalIndex].IsComplete())
            {
                _score += int.Parse(_goals[goalIndex].GetPoints());
            }
            Console.WriteLine("Event recorded successfully!\n Press enter to continue");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Invalid goal!");
        }
    }
    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_score);
            foreach(Goal g in _goals)
            {
                outputFile.WriteLine(g.GetStringRepresentation());
            }
        }        
    }
    public void LoadGoals()
    {
        _goals.Clear();
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        try
        {
            string[] lines = System.IO.File.ReadAllLines(filename);
            if(lines.Count() > 0)
            {
                _score = int.Parse(lines[0]);
                
                for (int i=1;i<lines.Length;i++)
                {
                    string line = lines[i];
                    string[] parts = line.Split(":");
                    string goalType = parts[0].Trim();
                    string[] details = parts[1].Trim().Split(",");

                    string _name = details[0];
                    string _description = details[1];
                    string _points = details[2];

                    Goal goal = null; 
                    
                    if(goalType == "ChecklistGoal")
                    {
                        int _bonus = int.Parse(details[3]);
                        int _target = int.Parse(details[4]);
                        int _amount = int.Parse(details[5]);

                        goal = new ChecklistGoal(_name,_description,_points,_target,_bonus);

                        for(int j = 0; j < _amount; j++)
                        {
                            goal.RecordEvent();
                        }
                    }
                    else if(goalType == "EternalGoal")
                    {
                        goal = new EternalGoal(_name,_description,_points);
                    }
                    else{
                        goal = new SimpleGoal(_name,_description,_points);
                    }
                    
                    if(goal != null)
                    {
                        _goals.Add(goal);
                    }
                }
                
            } 
        }

        catch (Exception)
        {
            Console.WriteLine($"The file is not found.\nPress enter to continue");
            Console.ReadLine();
        }

    }      
}
