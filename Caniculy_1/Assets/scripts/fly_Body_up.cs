using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.WSA;

public class fly_Body_up : MonoBehaviour
{
    Rigidbody rigiStarship;
    public float forceStrength = 10f;
    public AudioSource audioStarship;
    public AudioClip checkpoint;
    public AudioClip finish;
    public AudioClip BOOOM;
    public GameObject newStarship;
    // Start is called before the first frame update
    void Start()
    {
        audioStarship = GetComponent<AudioSource>();
        rigiStarship = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        RotationInput();
        Invoke("LoadScene1", 2);
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
    private void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "start":
                print("START");
                break;
            case "checkpoint":
                print("SpawnPointSet");
                audioStarship.PlayOneShot(checkpoint);
                break;
            case "Finish":
                print("END");
                audioStarship.PlayOneShot(finish);
                Invoke("LoadScene2", 3f);
                break;
            case "BOOOOOOOM":
                print("BABACH");
                audioStarship.PlayOneShot(BOOOM);
                Invoke("LoadScene1", 3f);
                break;
            default:
                print("?");
                break;
        }

    }
    void LoadScene1 ()
    {
        SceneManager.LoadScene(1);
    }
    void LoadScene2()
    {
        SceneManager.LoadScene(2);
    }
}