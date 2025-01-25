namespace SimpleStateMachine;

public class StateMachine<TEnum>(HashSet<(TEnum, TEnum)> transitions) : IStateMachine<TEnum>
    where TEnum : Enum
{

    public TEnum ChangeState(TEnum initialState, TEnum nextState)
    {
        if (transitions.Contains((initialState, nextState)))
        {
            return nextState;
        }

        throw new InvalidTransitionException(typeof(TEnum), initialState, nextState);
    }
}