using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectiveFollow : MonoBehaviour
{
    public Transform cam;
    public Vector3 offset = new Vector3(0, 0.2f, 2f);

    void Start()
    {
        if (cam == null)
            cam = Camera.main.transform;
    }

    void Update()
    {
        transform.position = cam.position + cam.forward * offset.z + cam.up * offset.y;
        transform.rotation = Quaternion.LookRotation(transform.position - cam.position);
    }
}
