using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    [SerializeField] private Transform atransformTarget;
    public float offsetForward;
    public float offsetUp;
    public Quaternion rotationAngle;
    private Transform atransform;
    void Start()
    {
        atransform = GetComponent<Transform>();
    }


    // Update is called once per frame
    void Update()
    {
        var directionVertical = atransform.forward * Input.GetAxisRaw("Vertical");
        var directionHorizontal = atransform.right * Input.GetAxisRaw("Horizontal");
        atransform.position += (directionHorizontal + directionVertical) * 3f * Time.deltaTime;
        atransformTarget.position = atransform.position + (atransform.forward * offsetForward) + (atransform.up * offsetUp);
        atransformTarget.rotation = atransform.rotation * rotationAngle;
    }
}
