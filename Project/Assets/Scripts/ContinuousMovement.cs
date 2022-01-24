using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class ContinuousMovement : MonoBehaviour
{
    public float speed = 1;
    public XRNode inputSource;
    public float gravity = -9.81f;
    public LayerMask groundlayer;
    public float additionalHeight = 0.2f;

    private float fallingSpeed;
    private XRRig rig;
    private Vector2 inputAxis;
    private bool mainMenu;
    bool isMenuActivated;
    [SerializeField]
    GameObject Menu;
    [SerializeField]
    GameObject XRRig;
    private CharacterController character;

    float tempTime;
    // Start is called before the first frame update
    void Start()
    {
        character = GetComponent<CharacterController>();
        rig = GetComponent<XRRig>();
    }

    // Update is called once per frame
    void Update()
    {
        InputDevice device = InputDevices.GetDeviceAtXRNode(inputSource);
        device.TryGetFeatureValue(CommonUsages.primary2DAxis, out inputAxis);
        device.TryGetFeatureValue (CommonUsages.menuButton, out mainMenu);

        if (mainMenu)
        {
            if (tempTime >= 0.2f)
            {
                if (isMenuActivated)
                {
                    Time.timeScale = 1;
                    Menu.SetActive(false);
                    isMenuActivated = false;
                }
                else
                {
                    Time.timeScale = 0;
                    Menu.transform.position = XRRig.transform.localPosition + new Vector3(-0.2f, 1.5f, 0f);
                    //Menu.transform.rotation = VRcamera.transform.rotation;
                    Menu.SetActive(true);
                    isMenuActivated = true;
                }
                tempTime = 0;
            }
            else
            {
                tempTime += Time.unscaledDeltaTime;
            }
        }

    }

    private void FixedUpdate()
    {

        CapsuleFollowHeadset();

        Quaternion headYaw = Quaternion.Euler(0, rig.cameraGameObject.transform.eulerAngles.y, 0);
        Vector3 direction = headYaw * new Vector3(inputAxis.x, 0, inputAxis.y);

        character.Move(direction * Time.fixedDeltaTime * speed);

        //gravity
        bool isGrounded = CheckIfGrounded();
        if (isGrounded)
            fallingSpeed = 0;
        else
            fallingSpeed += gravity * Time.fixedDeltaTime;
        character.Move(Vector3.up * fallingSpeed * Time.fixedDeltaTime);


    }

    void CapsuleFollowHeadset()
    {
        character.height = rig.cameraInRigSpaceHeight + additionalHeight;
        Vector3 capsuleCenter = transform.InverseTransformPoint(rig.cameraGameObject.transform.position);
        character.center = new Vector3(capsuleCenter.x, character.height / 2 + character.skinWidth, capsuleCenter.z);
    }
    bool CheckIfGrounded()
    {
        //tells us if on ground
        Vector3 raystart = transform.TransformPoint(character.center);
        float raylenght = character.center.y + 0.01f;
        bool hasHit = Physics.SphereCast(raystart, character.radius, Vector3.down, out RaycastHit hitInfo, raylenght, groundlayer);
        return hasHit;
    }



}