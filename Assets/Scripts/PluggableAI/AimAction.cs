using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "PluggableAI/Actions/Aim")]
public class AimAction : Action
{
    public override void Act(StateController controller)
    {
        controller.nav_agent.isStopped = true;
        Vector3 target = controller.nav_agent.destination - controller.transform.position;
        controller.transform.rotation = Quaternion.Slerp(controller.transform.rotation, 
                                                         Quaternion.LookRotation(target.normalized), 0.2f);
    }
}
