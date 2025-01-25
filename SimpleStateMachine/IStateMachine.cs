namespace SimpleStateMachine;

public interface IStateMachine<TEnum> where TEnum : Enum
{
    TEnum ChangeState(TEnum initialState, TEnum nextState);
}