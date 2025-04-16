public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public int Bonus => _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public override int RecordEvent()
    {
        _amountCompleted++;
        Console.WriteLine($"You earned {_points} points!");
        int total = _points;
        if (_amountCompleted == _target)
        {
            Console.WriteLine($"Bonus! You earned {_bonus} extra points!");
            total += _bonus;
        }
        return total;
    }

    public override bool IsComplete() => _amountCompleted >= _target;

    public override string GetDetailsString()
    {
        return $"{_shortName}: {_description} (Completed {_amountCompleted}/{_target})";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{_shortName}|{_description}|{_points}|{_bonus}|{_target}|{_amountCompleted}";
    }

    public void SetAmountCompleted(int value)
    {
        _amountCompleted = value;
    }
}
