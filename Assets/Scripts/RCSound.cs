/*  this script, RCText.cs, Unity project and Wwise project are made by Ressa Schwarzwald, for "Ressa & the Robotic Orchestra" project in 2021.
    I'm not sorry if it looks lame, because it is lame. Have fun! */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RCSound : MonoBehaviour
{
    public AK.Wwise.Event playEvent;
    public float axisPullPush;
    public float axisKey;

    private float scaleX;
    private float rotateX;

    public string buttonPressed;

    void Start()
    {
        AkSoundEngine.PostEvent(playEvent.Name, this.gameObject);
        buttonPressed = "C";
    }

    
   
    void Update()
    {
       // bellows simulation
       axisPullPush = Input.GetAxis("PullPushX");
       AkSoundEngine.SetRTPCValue("PullPush", axisPullPush, gameObject);
    
       // visualize pulling and pushing on the ringcon
       scaleX = axisPullPush + 2f;
       gameObject.transform.localScale = new Vector3(2, 0.2f, scaleX);
       
        // switch the scale (major/minor)
        axisKey = Input.GetAxis("AxisKey");
        rotateX = axisKey;
        gameObject.transform.localRotation = new Quaternion(0, 0, -rotateX, 2f);

        AkSoundEngine.SetRTPCValue("RingScale", axisKey, gameObject);



        // buttons for the key switches
        if (Input.GetKeyDown(KeyCode.JoystickButton7))
        {
            AkSoundEngine.SetRTPCValue("RingKey", 1, gameObject);
            AkSoundEngine.PostEvent("RCButton", this.gameObject);
            buttonPressed = "C";
        }

        if (Input.GetKeyDown(KeyCode.JoystickButton8))
        {
            AkSoundEngine.SetRTPCValue("RingKey", 2, gameObject);
            AkSoundEngine.PostEvent("RCButton", this.gameObject);
            buttonPressed = "D";
        }

        if (Input.GetKeyDown(KeyCode.JoystickButton3))
        {
            AkSoundEngine.SetRTPCValue("RingKey", 3, gameObject);
            AkSoundEngine.PostEvent("RCButton", this.gameObject);
            buttonPressed = "E";
        }

        if (Input.GetKeyDown(KeyCode.JoystickButton1))
        {
            AkSoundEngine.SetRTPCValue("RingKey", 4, gameObject);
            AkSoundEngine.PostEvent("RCButton", this.gameObject);
            buttonPressed = "F";
        }

        if (Input.GetKeyDown(KeyCode.JoystickButton2))
        {
            AkSoundEngine.SetRTPCValue("RingKey", 5, gameObject);
            AkSoundEngine.PostEvent("RCButton", this.gameObject);
            buttonPressed = "G";
        }

        if (Input.GetKeyDown(KeyCode.JoystickButton0))
        {
            AkSoundEngine.SetRTPCValue("RingKey", 6, gameObject);
            AkSoundEngine.PostEvent("RCButton", this.gameObject);
            buttonPressed = "A";
        }

       

    }

   
   
}
