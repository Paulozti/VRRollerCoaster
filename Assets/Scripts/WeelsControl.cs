using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeelsControl : MonoBehaviour
{
    public WheelCollider[] rodas;
    public GameObject CG;
    public Rigidbody rdb;
    public float torque;
    // Start is called before the first frame update
    void Start()
    {
        rdb.centerOfMass = CG.transform.localPosition;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        foreach(WheelCollider roda in rodas)
        {
            roda.motorTorque = torque;
        }
    }
}
