using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Tags : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "start":
                print("START");
                break;
            case "checkpoint":
                print("SpawnPointSet");
                break;
            case "Finish":
                print("END");
                break;
            case "BOOOOOOOM":
                print("BABACH");
                break;
            default:
                print("?");
                break;
        }
        
    }
}
