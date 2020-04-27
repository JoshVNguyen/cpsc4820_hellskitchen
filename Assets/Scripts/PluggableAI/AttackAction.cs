using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "PluggableAI/Actions/Attack")]
public class AttackAction : Action
{
    public override void Act(StateController controller)
    {
        controller.nav_agent.destination = controller.player.transform.position;
        controller.nav_agent.isStopped = false;
    }
}
