using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class temp : MonoBehaviour
{
    public Vector3 movePosition;
    public float moveSpeed;
    Vector3 startPosition;
    [SerializeField][Range(0, 1)] float moveProgress;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        moveProgress = Mathf.PingPong(Time.time + moveSpeed, 1);
        transform.position = startPosition + (movePosition * moveProgress);
    }
}
