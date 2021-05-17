using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SwitchButton : MonoBehaviour
{
    public void ChangeAngle(float angle)
    {
        SwitchShips.neededAngle += angle;
        SwitchShips.id += Math.Sign(angle);
    }

    public void Exit()
    {
        SwitchShips.flag = true;
    }
}
