using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target : MonoBehaviour
{
    public float health = 50f;
    public float movment = 5;
    public ParticleSystem ex;
    public health h;

    public Rigidbody rb;

    private void Start()
    {
        GameObject gameControllerObject = GameObject.FindGameObjectWithTag("h");
        h = gameControllerObject.GetComponent<health>();
    }
    private void Update()
    {
        transform.Translate(0f, 0f, movment * Time.deltaTime);
        
    }

    public void takedamage(float amount)
    {
        health -= amount;
        if(health<=0f)
        {
            h.score += 1;
            
            ex.Play();
            Invoke("die", 0.5f);
        }
    }
    void die()
    {
        // Instantiate(ex, transform.position, Quaternion.identity);
        
        Destroy(gameObject);
    }
}
