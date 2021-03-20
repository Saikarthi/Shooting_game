using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class health : MonoBehaviour
{
    public float Health = 100f, score = 0f;
    public Slider s;
    public TextMeshProUGUI t;
    public GameObject a;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        s.value = Health;
        t.SetText(score.ToString());
        if (Health<=0)
        {
            a.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

        }
        
    }
}
