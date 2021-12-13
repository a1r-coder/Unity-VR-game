using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    public GameObject glass;
    public float detectRange = 3f;
    private Vector3 oldRotation;

    // Update is called once per frame
    void Update()
    {
        Vector3 delta = transform.eulerAngles - oldRotation;
        Debug.Log(delta.magnitude);

        if (delta.magnitude >= detectRange)
        {
            glass.SetActive(true);
        }
        oldRotation = transform.eulerAngles;
    }
}
