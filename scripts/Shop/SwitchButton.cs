using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchButton : MonoBehaviour
{
    public void ChangeAngle(float angle)
    {
        SwitchShips.neededAngle += angle;
    }
}
