namespace SimpleStateMachine;

public class InvalidTransitionException(Type enumType, Enum currentValue, Enum expectedValue)
    : Exception("Invalid State Transition")
{
    public Type EnumType { get; } = enumType;
    public Enum CurrentValue { get; } = currentValue;
    public Enum ExpectedValue { get; } = expectedValue;
}