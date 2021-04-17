using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float health = 25f;
    public GameObject particles;
    public static float timeToDeath = 0.1f;
    private float enterTime = 0f, startTime;

    void Start()
    {
        startTime = Time.time;
    }
     
    void Update()
    {
        if(health <= 0f)
        {
            var x = GameObject.Instantiate(particles, transform.position, transform.rotation);
            Destroy(gameObject);
            Destroy(x, 2.5f);
            Debug.Log("DED");
        }
        if(Time.time - startTime > timeToDeath)
            GetComponent<MeshRenderer>().enabled = true;
    }

    void OnTriggerStay(Collider other)
    {
        if(other.tag == "Enemy" && gameObject.name != "rocket" && other.name != "rocket")
        {
            if(enterTime == 0f)
                enterTime = Time.time;
            else if(Time.time - enterTime >= Time.fixedDeltaTime && Time.time - startTime < timeToDeath)
            {
                Destroy(gameObject);
                Debug.Log(other.name);
            }
        }
    }
}
