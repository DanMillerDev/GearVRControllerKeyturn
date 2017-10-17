using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GearVRKeyturn : MonoBehaviour {

    const float MAX_ROT = 115.0f;

    Transform GearVRController;
    Vector3 CurrentRotation;
    Vector3 TargetPosition;

    void Start()
    {
        GearVRController = this.transform.parent;
    }

    void Update()
    {
        CurrentRotation = GearVRController.transform.eulerAngles;

        if (CurrentRotation.z > 0.0f && CurrentRotation.z < MAX_ROT)
        {
            TargetPosition = new Vector3(0, 0, NormalizeData(CurrentRotation.z));
            this.transform.localPosition = Vector3.Lerp(this.transform.localPosition, TargetPosition, Time.deltaTime * 2);
        }
        else
        {
            this.transform.localPosition = Vector3.Lerp(this.transform.localPosition, Vector3.zero, Time.deltaTime / 2);
        }
    }

    // Normalize Value between 0-1
    float NormalizeData(float currentRotation)
    {
        return (currentRotation / MAX_ROT);
    }
}
