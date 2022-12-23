using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyshooting : MonoBehaviour
{
    [SerializeField]
    GameObject enemybullet;

    float fireRate;
    float nextFire;

    public float speed = 3;

    void Start()
    {
        fireRate = 0.3f;
        nextFire = Time.time;
    }

    void Update()
    {

        CheckIfTimeToFire();
    }

    void CheckIfTimeToFire()
    {
        if(Time.time > nextFire)
        {
            Instantiate(enemybullet, transform.position, transform.rotation);
            nextFire = Time.time + fireRate;
        }
    }


}
