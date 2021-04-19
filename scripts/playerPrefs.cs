using System;
using UnityEngine;

[System.Serializable]
public class PlayerPreference 
{
    public string name;
    public float dmg;
    public float explosionDmg;
    public float laserDPS;
    public float rocketDmg;
    public float laserDmg;
    public float maxHealth;
    public float speed;
    public float speedForv;
    public float maxFireTime;
    public float sleep;
    public float laserBias;
    public Vector3 scale;
    public Mesh mesh;
    public GameObject bullet;

    public PlayerPreference(string nm)
    {
        name = nm;
    }

    public PlayerPreference(string name_, float dmg_, float explosionDmg_, float laserDPS_, float rocketDmg_, float laserDmg_, float maxHealth_, float speed_, float speedForv_, float maxFireTime_, float sleep_, float laserBias_, Vector3 scale_, Mesh mesh_, GameObject bullet_)
    {
        name = name_;
        dmg = dmg_;
        explosionDmg = explosionDmg_;
        laserDPS = laserDPS_;
        rocketDmg = rocketDmg_;
        laserDmg = laserDmg_;
        maxHealth = maxHealth_;
        speed = speed_;
        speedForv = speedForv_;
        maxFireTime = maxFireTime_;
        sleep = sleep_;
        laserBias = laserBias_;
        scale = scale_;
        mesh = mesh_;
        bullet = bullet_;
    }
}