using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocketship : MonoBehaviour
{
    public Vector3 rocketBias = new Vector3(0f, 0.55f, 0f);
    public static float reloadTime = 3f;
    public GameObject rocket, particles;
    private bool isFiring;
    private float lastShotTime = 0f, startTime = ;
    private GameObject laser;

    void Start()
    {
        startTime = Time.time;
    }

    void Fire()
    {
        if(Time.time - lastShotTime >= reloadTime)
        {
            lastShotTime = Time.time;
            var x = GameObject.Instantiate(rocket, transform.position + rocketBias, rocket.transform.rotation);
            Destroy(x, 5f);
        }
    }

    void Update()
    {
        if(Time.time - startTime > EnemyHealth.timeToDeath)
        {
            transform.Translate(0f, 0f, -playerMovement.speedForv * Time.deltaTime);
            Fire();  
        }                                                       
    }
}
