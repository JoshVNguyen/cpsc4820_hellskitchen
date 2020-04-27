using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "PluggableAI/Decisions/Wait")]
public class WaitDecision : Decision
{
    //TODO: Implement decision
    public override bool Decide(StateController controller)
    {
        return (controller.state_time_elapsed >= 1.0f);
    }
}
