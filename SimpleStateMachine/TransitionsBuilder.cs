namespace SimpleStateMachine;

public class TransitionsBuilder<TEnum> where TEnum : Enum
{
    private readonly HashSet<(TEnum, TEnum)> _transitions = new();

    public TransitionsBuilder<TEnum> AddTransition(TEnum from, TEnum to)
    {
        _transitions.Add((from, to));
        return this;
    }
    
    public HashSet<(TEnum, TEnum)> Build() => _transitions;
}