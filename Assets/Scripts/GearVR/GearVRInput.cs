using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GearVRInput : MonoBehaviour {

    void Update()
    {
        // is player using a controller?
        if (OVRInput.GetActiveController() == OVRInput.Controller.LTrackedRemote ||
           OVRInput.GetActiveController() == OVRInput.Controller.RTrackedRemote)
        {
            // trigger button
            if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
            {
                Debug.Log("trigger button clicked");
            }

            // touch pad as a button
            if (OVRInput.GetDown(OVRInput.Button.PrimaryTouchpad))
            {
                Debug.Log("touchpad button clicked");
            }

            // touch pad as a touch input
            if (OVRInput.Get(OVRInput.Touch.PrimaryTouchpad))
            {
                // touch pad as a button
                if (OVRInput.GetUp(OVRInput.Button.PrimaryTouchpad))
                {
                    // touch position on the touchpad
                    Vector2 touchPosition = OVRInput.Get(OVRInput.Axis2D.PrimaryTouchpad);
                    Debug.Log("touchpad button clicked at "+touchPosition.ToString());
                }
            }

            if(OVRInput.Get(OVRInput.Button.DpadDown))
            {
                Debug.Log("touch pad swipe down");
            }

            if (OVRInput.Get(OVRInput.Button.DpadLeft))
            {
                Debug.Log("touch pad swipe Left");
            }

            // back button
            if (OVRInput.GetDown(OVRInput.Button.Back))
            {
                Debug.Log("back button clicked");
            }
        }
    }
}
