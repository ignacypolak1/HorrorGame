using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class light : MonoBehaviour
{
public float lightStep = 10;
public UnityEngine.UI.Image flashlightBar;
public float fillAmount;
public float Bl = 0.00025f;
public GameObject fireLight;
 
 
void Update()
    {


        fireLight.GetComponent<Light>().intensity -= lightStep;
        flashlightBar.fillAmount = (flashlightBar.fillAmount - Bl);



    }
}
