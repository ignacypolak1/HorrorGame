using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flaslight : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       // audioSource = GetComponent<AudioSource>();

    }

    public bool isOn = false;
   // public AudioSource audioSource;
    public GameObject spotLight;

void Update()
    {
     if (Input.GetKeyDown(KeyCode.F)) 
        { 
          isOn = !isOn;
        }
  
        if (isOn)
            spotLight.SetActive(true);

        if (!isOn)
            spotLight.SetActive(false);

    }
}