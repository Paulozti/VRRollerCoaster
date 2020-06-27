using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Speed : MonoBehaviour
{
    public Rigidbody cart;
    private Text speedText;
    
    private void Start()
    {
        speedText = GetComponent<Text>();
        
    }
    void Update()
    {
        speedText.text = $"{Convert.ToInt32(cart.velocity.magnitude)}km/h";
    }
}
