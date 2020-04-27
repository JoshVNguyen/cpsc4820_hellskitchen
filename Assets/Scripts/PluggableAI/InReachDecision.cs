using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "PluggableAI/Decisions/InReach")]
public class InReachDecision : Decision
{

    public override bool Decide(StateController controller)
    {
        Vector3 distance = controller.transform.position - controller.player.transform.position;
        return (distance.sqrMagnitude < (controller.distance_goal * controller.distance_goal));
    }
}
