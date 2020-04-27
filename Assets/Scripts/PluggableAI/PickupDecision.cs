using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "PluggableAI/Decisions/Pickup")]
public class PickupDecision : Decision
{
    public override bool Decide(StateController controller)
    {
        return controller.PickupItem();
    }
}
