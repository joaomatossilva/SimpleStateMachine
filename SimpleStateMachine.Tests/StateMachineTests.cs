namespace SimpleStateMachine.Tests;

public class StateMachineTests
{
    private readonly StateMachine<State> stateMachine;
    
    public StateMachineTests()
    {
        stateMachine = new StateMachine<State>(StateTransitions.Transitions);
    }
    
    [Fact]
    public void ChangeState_ValidTransition_StateIsTransitioned()
    {
        var state = State.StateA;

        var newState = stateMachine.ChangeState(state, State.StateB);
        
        Assert.Equal(State.StateB, newState);
    }
    
    [Fact]
    public void ChangeState_InValidTransition_InvalidStateIsThrown()
    {
        var state = State.StateA;

        Action action = () => stateMachine.ChangeState(state, State.StateC);

        Assert.Throws<InvalidTransitionException>(action);
    }
}