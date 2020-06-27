using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpulseCall : MonoBehaviour
{
    public bool brake = false;
    public bool WeakBrake = false;
    public AudioSource sound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
       

        if (other.CompareTag("Player"))
        {
            if (sound)
                sound.Play();

            if (brake)
            {
                if (WeakBrake)
                {
                    other.SendMessageUpwards("WeakBrake");
                }
                else
                {
                    other.SendMessageUpwards("Brake");
                }
            }
            other.SendMessageUpwards("ImpulseOn");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.SendMessageUpwards("ImpulseOff");
        }
    }
}
