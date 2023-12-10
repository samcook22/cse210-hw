using System;
using System.Collections.Generic;

// Base class for goals
public abstract class Goal
{
    private string name;
    private int points;

    public Goal(string name)
    {
        this.name = name;
        this.points = 0;
    }

    public string Name
    {
        get { return name; }
    }

    public int Points
    {
        get { return points; }
    }

    public void MarkComplete()
    {
        points += CalculatePoints();
    }

    protected abstract int CalculatePoints();
}

// Simple goal class
public class SimpleGoal : Goal
{
    public SimpleGoal(string name) : base(name) { }

    protected override int CalculatePoints()
    {
        return 1000; // Example: 1000 points for completing a marathon
    }
}

// Eternal goal class
public class EternalGoal : Goal
{
    public EternalGoal(string name) : base(name) { }

    protected override int CalculatePoints()
    {
        return 100; // Example: 100 points every time scriptures are read
    }
}

// Checklist goal class
public class ChecklistGoal : Goal
{
    private int targetCount;
    private int completedCount;

    public ChecklistGoal(string name, int targetCount) : base(name)
    {
        this.targetCount = targetCount;
        this.completedCount = 0;
    }

    public int TargetCount
    {
        get { return targetCount; }
    }

    public int CompletedCount
    {
        get { return completedCount; }
    }

    protected override int CalculatePoints()
    {
        int pointsEarned = 50; // Example: 50 points each time for attending the temple
        completedCount++;

        if (completedCount == targetCount)
        {
            pointsEarned += 500; // Bonus points for completing the checklist
            completedCount = 0; // Reset completed count for future rounds
        }

        return pointsEarned;
    }
}

// User class to manage goals and score
public class User
{
    private List<Goal> goals;
    private int score;

    public User()
    {
        goals = new List<Goal>();
        score = 0;
    }

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void RecordEvent(int goalIndex)
    {
        if (goalIndex >= 0 && goalIndex < goals.Count)
        {
            goals[goalIndex].MarkComplete();
            score += goals[goalIndex].Points;
        }
    }

    public void DisplayGoals()
    {
        foreach (var goal in goals)
        {
            Console.Write($"[{(goal.Points > 0 ? 'X' : ' ')}] {goal.Name}");

            if (goal is ChecklistGoal checklistGoal)
            {
                Console.Write($" - Completed {checklistGoal.CompletedCount}/{checklistGoal.TargetCount} times");
            }

            Console.WriteLine();
        }

        Console.WriteLine($"Total Score: {score}");
    }
}

// Main program
class Program
{
    static void Main()
    {
        User user = new User();

        // Create sample goals
        Goal marathonGoal = new SimpleGoal("Run a Marathon");
        Goal scripturesGoal = new EternalGoal("Read Scriptures");
        Goal templeGoal = new ChecklistGoal("Attend the Temple", 10);

        // Add goals to the user
        user.AddGoal(marathonGoal);
        user.AddGoal(scripturesGoal);
        user.AddGoal(templeGoal);

        // Record events to simulate user progress
        user.RecordEvent(0); // Completed marathon
        user.RecordEvent(1); // Read scriptures
        user.RecordEvent(2); // Attend the temple

        // Display user's goals and score
        user.DisplayGoals();
    }
}
