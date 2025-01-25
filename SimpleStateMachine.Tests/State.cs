namespace SimpleStateMachine.Tests;

public enum State
{
    StateA,
    StateB,
    StateC
}

public static class StateTransitions
{
    public static HashSet<(State, State)> Transitions => new TransitionsBuilder<State>()
        .AddTransition(State.StateA, State.StateB)
        .AddTransition(State.StateB, State.StateC)
        .AddTransition(State.StateC, State.StateA)
        .Build();
}