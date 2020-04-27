using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "PluggableAI/Actions/Search")]
public class SearchAction : Action
{
    public override void Act(StateController controller)
    {
        controller.nav_agent.destination = controller.waypoint_list[controller.next_waypoint].position;
        controller.nav_agent.isStopped = false;

        if (controller.nav_agent.remainingDistance <= controller.nav_agent.stoppingDistance 
            && !controller.nav_agent.pathPending)
        {
            controller.next_waypoint = (controller.next_waypoint + 1) % controller.waypoint_list.Count;
        }
    }
}
