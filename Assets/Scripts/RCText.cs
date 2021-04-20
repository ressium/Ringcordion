using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class RCText : MonoBehaviour
{
    TextMeshProUGUI rcData;
    GameObject sphere;

    float scaleValue;
    string scaleName;

    void Start()
    {
        rcData = gameObject.GetComponent<TextMeshProUGUI>();
        sphere = GameObject.Find("MainRing");

       

       // keyVar = sphere.
    }

    // Update is called once per frame
    void Update()
    {

        scaleValue = sphere.GetComponent<RCSound>().axisKey;

        rcData.text = "Key: " + sphere.GetComponent<RCSound>().buttonPressed + "\n\nScale: " + scaleName;

        if (scaleValue > 0)
            scaleName = "major";


        else scaleName = "minor";





    } 


}
