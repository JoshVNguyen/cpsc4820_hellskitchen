﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "PluggableAI/Decisions/Find")]
public class FindDecision : Decision
{
    //TODO: Implement decision
    public override bool Decide(StateController controller)
    {
        if (controller.ItemFound == null) return false;
        else return true;
    }
}