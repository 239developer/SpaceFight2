using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camicadze : MonoBehaviour
{
    public float speed = 1f;
    public GameObject particles;
    private GameObject player;
    private Rigidbody rb;
    private float startTime;

    void Start()
    {
        startTime = Time.time;
        player = GameObject.Find("Player");
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if(Time.time - startTime > EnemyHealth.timeToDeath)
        {
            Vector3 targ = Target();
            rb.velocity = targ / targ.magnitude * speed;
        }
    }

    void Update()
    {
        if(Time.time - startTime > EnemyHealth.timeToDeath)
            transform.position += new Vector3(0f, 0f, playerMovement.speedForv * Time.deltaTime);
    }

    Vector3 Target()
    {
        Vector3 targ = Vector3.zero;

        targ = player.transform.position - transform.position;

        return targ;
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag != "Enemy" && other.name != "laser 2(Clone)")
        {
            GameObject x = GameObject.Instantiate(particles, other.gameObject.transform.position + Vector3.forward * 2f, transform.rotation);
            Destroy(x, 2.5f);
            Destroy(gameObject);
            if(other.name == "Player")
            {
                playerMovement.health -= playerMovement.explosionDmg;
            }
        }
    }
}
