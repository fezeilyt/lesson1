using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class workingDays : MonoBehaviour
{
    public string word = "1";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch(word)
        {
            case "1":
                print("Δευτέρα");
                break;
            case "2":
                print("Τρίτη");
                break;
            case "3":
                print("Τετάρτη");
                break;
            case "4":
                print("Πέμπτη");
                break;
            case "5":
                print("Παρασκευή");
                break;
            case "6":
                print("Σάββατο");
                break;
            case "7":
                print("Κυριακή");
                break;
            default:
                print("?");
                break;

        }
    }
}
