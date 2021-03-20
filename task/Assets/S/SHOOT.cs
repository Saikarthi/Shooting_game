using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SHOOT : MonoBehaviour
{
    public GameObject fps;
    public float damage = 10f, range = 100f;
    Vector3 ennpos = Vector3.zero;
    public ParticleSystem MuzzleFlash;
    public float firerate = 4f;
    public GameObject a;

   private float nexttimefire=0;

    // Update is called once per frame
    void Update()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        if(Input.GetButton("Fire1") && Time.time >= nexttimefire)
        {
            nexttimefire = Time.time + 1f / firerate;
            shoot();
        }

    }

    public void shoot()
    {
        MuzzleFlash.Play();
       
        RaycastHit hit;
        //Instantiate(muzzle, a.gameObject.transform.position, Quaternion.identity);
       if(  Physics.Raycast(fps.transform.position,fps.transform.forward,out hit,range))
        {
            Debug.Log(hit.transform.name);
            

            target Target = hit.transform.GetComponent<target>();
            if(Target!=null)
            {
                Target.takedamage(damage);
            }
            target1 Target1 = hit.transform.GetComponent<target1>();
            if (Target1 != null)
            {
                Target1.takedamage(damage);
            }
            target2 Target2 = hit.transform.GetComponent<target2>();
            if (Target2 != null)
            {
                Target2.takedamage(damage);
            }
            GameObject im= Instantiate(a, hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(im, 2f);
        }
      

    }
}
