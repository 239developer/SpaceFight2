using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchShips : MonoBehaviour
{
    public static bool flag = false;
    public static float neededAngle = 0f;
    public static int id = 0;
    public float t = 0.5f;
    public int min_id = -1, max_id = 1;
    public GameObject[] ships;

    void Exit()
    {
        playerMovement.mesh = ships[id - min_id].GetComponent<MeshFilter>().mesh;
        SceneManager.LoadScene(Globals.play);
    }

    void Start()
    {
        flag = false;
        neededAngle = 0f;
        transform.Rotate(0f, id * 30f, 0f);
    }

    void Update()
    {
        if(id >= min_id && id <= max_id)
        {
            foreach(GameObject g in ships)
            {
                g.GetComponent<rotater>().y = 0f;
            }
            ships[id - min_id].GetComponent<rotater>().y = 15f;
        }
        else if(id < min_id)
        {
            id += 1;
            neededAngle += 30f;
        }
        else
        {
            id -= 1;
            neededAngle -= 30f;
        }
        var turn = neededAngle / t * Time.deltaTime;
        transform.Rotate(0f, turn, 0f);
        neededAngle -= turn;
        if(flag)
            Exit();
    }
}
