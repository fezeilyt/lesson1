using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class fly_Body_up : MonoBehaviour
{
    Rigidbody rigiStarship;
    public float forceStrength = 10f;
    AudioSource audioStarship;
    public GameObject newStarship;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("ten", 1f);
        Invoke("nine", 2f);
        Invoke("eight", 3f);
        Invoke("seven", 4f);
        Invoke("six", 5f);
        Invoke("five", 6f);
        Invoke("four", 7f);
        Invoke("three", 8f);
        Invoke("two", 9f);
        Invoke("one", 10f);
        Invoke("start", 11f);

        audioStarship = GetComponent<AudioSource>();
        rigiStarship = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        RotationInput();
        Launch();
    }
    void Launch()
    {

        if (Input.GetKey(KeyCode.Space))
        {
            rigiStarship.AddRelativeForce(Vector3.up * forceStrength);
            if (!audioStarship.isPlaying)
            {
                audioStarship.Play();
            }

        }
        else
        {
            audioStarship.Pause();
        }
    }
    void RotationInput()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rigiStarship.AddRelativeTorque(new Vector3(0, 0, -3));
        }
        if (Input.GetKey(KeyCode.A))
        {
            rigiStarship.AddRelativeTorque(new Vector3(0, 0, 3));
        }
        if (Input.GetKey(KeyCode.S))
        {
            //rigiStarship.freezeRotation = true;
            rigiStarship.AddRelativeTorque(new Vector3(-3, 0, 0));
        }
        if (Input.GetKey(KeyCode.W))
        {
            //rigiStarship.freezeRotation = true;
            rigiStarship.AddRelativeTorque(new Vector3(3, 0, 0));
        }

    }
    void cloneObject()
    {
        Instantiate(newStarship, new Vector3(0, 10, 0), Quaternion.identity);
    }
    void ten()
    {
        print(10);
    }
    void nine()
    {
        print(9);
    }
    void eight()
    {
        print(8);
    }
    void seven()
    {
        print(7);
    }
    void six()
    {
        print(6);
    }
    void five()
    {
        print(5);
    }
    void four()
    {
        print(4);
    }
    void three()
    {
        print(3);
    }
    void two()
    {
        print(2);
    }
    void one()
    {
        print(1);
    }
    void start()
    {
        print("START");
    }

    void Countdown()
    {
        for (int n = 10; n >= 1; n--)
        {
            print(n);
            if (n == 0)
            {
                break;
            }
        }
        print("START");
    }
}