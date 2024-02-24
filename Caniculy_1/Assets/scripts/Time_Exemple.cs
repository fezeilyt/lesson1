using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Time_Exemple : MonoBehaviour
{
    public float timer, coolDown;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        if (timer <= 0 && Input.GetMouseButtonDown(0))
        {
            print("shoot");
            timer = coolDown;
            transform.position += new Vector3(0, 1, 0);
        }
    }
}
