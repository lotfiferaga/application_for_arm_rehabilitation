using System.Diagnostics;
using System.Collections;
using UnityEngine;
using System;
using UnityEngine.XR;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
public class DoorScript : MonoBehaviour
{   public AudioSource doorSound;
    public AudioClip doorOpenSound;
    private InputDevice targetDevice;
    public HingeJoint doorHinge; // Assign the door's hinge joint in the inspector
    public Rigidbody doorRigidbody; // Assign the door's rigidbody in the inspector
    public float openForce = 3f; // The force applied to open the door
    public float closeForce = 3f; // The force applied to close the door
    public float vibrationAmplitude = 3f; // The amplitude of the vibration
    public float vibrationFrequency = 1f; // The frequency of the vibration
    public GameObject door;
     void Start()
    {
       List<InputDevice> devices=new List<InputDevice>() ;
       InputDeviceCharacteristics rightControllerCharacteristics=InputDeviceCharacteristics.Right |InputDeviceCharacteristics.Controller;
       InputDevices.GetDevicesWithCharacteristics(rightControllerCharacteristics,devices);
       if (devices.Count>0){
        targetDevice=devices[0];
        
        }
       
    }
    void Update()
    {
        targetDevice.TryGetFeatureValue(CommonUsages.primaryTouch,out bool primaryButtonValue);
        // OVRInput.Update();
        door.transform.Rotate(90.0f, 0.0f, 0.0f, Space.World);
        // Check if the player is pressing the A button on the Oculus Quest controller
        if (primaryButtonValue)
        {
            // Open the door by applying a force to the hinge joint
            
            doorRigidbody.AddForceAtPosition(transform.forward * openForce, doorHinge.transform.position);
            doorSound.PlayOneShot(doorOpenSound);
            // Set the vibration on the controller
            OVRInput.SetControllerVibration(vibrationFrequency, vibrationAmplitude, OVRInput.Controller.RTouch); 
            Console.Write("Button One Clicked");
        }

        // Check if the player is pressing the B button on the Oculus Quest controller
       /* if (OVRInput.Get(OVRInput.Button.Two))
        {
            /* // Close the door by applying a force to the hinge joint
            doorRigidbody.AddForceAtPosition(transform.forward * -closeForce, doorHinge.transform.position);
            doorSound.PlayOneShot(doorOpenSound);
            // Set the vibration on the controller
            OVRInput.SetControllerVibration(vibrationFrequency, vibrationAmplitude, OVRInput.Controller.RTouch); */
            //Console.Write("Button One Clicked");
        //}
    }
}
