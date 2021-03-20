using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class col : MonoBehaviour
{
    public float hit = 50f;
    public health h;
    public Image i;
    public float a = 0f, b = 0.5f, c = 1f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            i.color = new Color(1, 1, 1, b);
            Invoke("red", 0.1f);
            h.Health -= hit;
            Destroy(collision.gameObject,0.4f);
        }
    }
    public void red()
    {
        i.color = new Color(1, 1, 1, c);
        Invoke("red1", 0.1f);
    }
    public void red1()
    {
        i.color = new Color(1, 1, 1, a);
    }
}