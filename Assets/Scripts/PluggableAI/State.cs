using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "PluggableAI/State")]
public class State : ScriptableObject
{
    public Action[] actions;
    public Transition[] transitions;
    public Color sceneGizmoColor = Color.grey;

    public void UpdateState(StateController controller)
    {
        this.DoActions(controller);
        this.CheckTransitions(controller);
    }

    private void DoActions(StateController controller)
    {
        for (uint i = 0; i < this.actions.Length; ++i)
        {
            this.actions[i].Act(controller);
        }
    }

    private void CheckTransitions(StateController controller)
    {
        for (uint i = 0; i < this.transitions.Length; ++i)
        {
            bool decisionSucceded = this.transitions[i].decision.Decide(controller);

            if (decisionSucceded) controller.TransitionToState(this.transitions[i].trueState);
            else controller.TransitionToState(this.transitions[i].falseState);
        }
    }
}
