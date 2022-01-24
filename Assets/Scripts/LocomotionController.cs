﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class LocomotionController : MonoBehaviour
{
    [SerializeField]
    private XRController rightTeleportRay;
    [SerializeField]
    private InputHelpers.Button teleportActivationButton;
    [SerializeField]
    private float activationTreshold = 0.1f;


    public XRRayInteractor leftInteractorRay;
    public XRRayInteractor rightInteractorRay;
    public bool EnableRightTeleport { get; set; } = true;

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = new Vector3();
        Vector3 norm = new Vector3();
        int index = 0;
        bool validTarget = false;

        //if (rightTeleportRay)
        //{
        //    bool isRightInteractorRayHovering = leftInteractorRay.TryGetHitInfo(ref pos, ref norm, ref index, ref validTarget); 
        //    rightTeleportRay.gameObject.SetActive(EnableRightTeleport && CheckIfActivated(rightTeleportRay)&& !isRightInteractorRayHovering);
        //}  

    }
    bool CheckIfActivated(XRController controller)
    {
        InputHelpers.IsPressed(controller.inputDevice, teleportActivationButton, out bool isActivated, activationTreshold);
        return isActivated;
    }
}
