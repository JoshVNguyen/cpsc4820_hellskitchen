using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "PluggableAI/Actions/Throw")]
public class ThrowAction : Action
{
    public override void Act(StateController controller)
    {
        controller.ThrowItem();

    }
}
