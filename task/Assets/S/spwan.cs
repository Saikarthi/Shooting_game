using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spwan : MonoBehaviour
{
    public GameObject ballprefab;
    GameObject ballclone;




    // Use this for initialization
    void Start()
    {
        InvokeRepeating("LaunchProjectile", 0f, 4.5f);
    }

    // Update is called once per frame
    void Update()
    {
        

           // spawn();
          //  Destroy(ballclone, 3);

        
    }

    void spawn()
    {
        Instantiate(ballprefab, this.transform.position, this.transform.rotation);
    }
    void LaunchProjectile()
    {
        spawn();
    }


}

