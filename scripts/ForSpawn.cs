using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForSpawn : MonoBehaviour
{    
    void Update()
    {
        
    }
    void OnTriggerStay()
    {
        Globals.no=true;
    }
    void OnCollisionStay()
    {
        Globals.no=true;
    }
}
