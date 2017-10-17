using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GearVRGrab : MonoBehaviour
{
    private const float GRAB_RADIUS = 0.1f;
    private const string HAND_ANIM = "Grip";

    private OVRInput.Controller controller;
    private RaycastHit hitInfo;
    private List<GameObject> GrabbedObjects;
    private float animVal = 0.0f;

    public Transform GrabRoot;
    public Animator Anim;

    

    void Start()
    {
        GrabbedObjects = new List<GameObject>();

        // hide hand model on non active controller
        controller = GetComponentInParent<OVRGearVrController>().m_controller;
        bool controllerConnected = OVRInput.IsControllerConnected(controller);
        if (!controllerConnected)
        {
            Anim.gameObject.SetActive(false);
            
        }
    }

	
    void Update()
    {
        // is player using a controller?
        if (OVRInput.GetActiveController() == OVRInput.Controller.LTrackedRemote ||
            OVRInput.GetActiveController() == OVRInput.Controller.RTrackedRemote)
        {
            // Touchpad button
            if (OVRInput.GetDown(OVRInput.Button.PrimaryTouchpad))
            {
                Grab();
            }

            if (OVRInput.GetUp(OVRInput.Button.PrimaryTouchpad))
            {
                Release();
            }

            if (Anim)
            {
                animVal = OVRInput.Get(OVRInput.Button.PrimaryTouchpad) ? 1.0f : 0.0f;
                Anim.SetFloat(HAND_ANIM, animVal);
            }   
        }

        // editor debug keys
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Grab();
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            Release();
        }

       
    }

    void Grab()
    {
        Collider[] hitColliders = Physics.OverlapSphere(GrabRoot.position, GRAB_RADIUS);

        for (int i = 0; i < hitColliders.Length; i++)
        {
            hitColliders[i].transform.GetComponent<Rigidbody>().isKinematic = true;
            hitColliders[i].transform.parent = GrabRoot.transform;
            GrabbedObjects.Add(hitColliders[i].gameObject);
        }
    }

    void Release()
    {
        for(int i = 0; i < GrabbedObjects.Count; i++)
        { 
            GrabbedObjects[i].transform.parent = null;
            GrabbedObjects[i].GetComponent<Rigidbody>().isKinematic = false;
        }

        GrabbedObjects.Clear();
    }
}
