using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxRotate : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(10, 30, 40), 10);
    }
}
