using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeelsControl : MonoBehaviour
{
    public WheelCollider[] rodas;
    public GameObject CG;
    public Rigidbody rdb;
    public float torque;
    public float brake;
    public AudioSource audiobrake;
    public AudioSource audiowheel;
    // Start is called before the first frame update
    void Start()
    {
        rdb.centerOfMass = CG.transform.localPosition;
        Continue();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        foreach(WheelCollider roda in rodas)
        {
            roda.motorTorque = torque;
            roda.brakeTorque = brake;
        }
        audiowheel.pitch = rdb.velocity.magnitude*0.03f;
    }

    public void ImpulseOn()
    {
        torque = 1000;

    }

    public void ImpulseOff()
    {
        torque = 000.0001f;

    }
    public void Brake()
    {
        torque = 000.0001f;
        brake = 8000;
        audiobrake.Play();
        Invoke("Continue", 10);
    }

    void Continue()
    {
        torque = 10f;
        brake = 000;
    }
}
