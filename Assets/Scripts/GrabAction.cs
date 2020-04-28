using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "PluggableAI/Actions/Grab")]
public class GrabAction : Action
{
    public override void Act(StateController controller)
    {
        if (controller.ItemFound != null)
        {
            controller.nav_agent.destination = controller.ItemFound.transform.position;
        }
        controller.nav_agent.isStopped = false;
    }
}
