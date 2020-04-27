using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "PluggableAI/Decisions/Always")]
public class AlwaysDecision : Decision
{
    public override bool Decide(StateController controller)
    {
        return true;
    }
}
