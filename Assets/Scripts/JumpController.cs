using System;
using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

[RequireComponent(typeof(Rigidbody))]


public class JumpController : MonoBehaviour
{
    [SerializeField] private InputActionReference jumpActionReference;
    [SerializeField] private float jumpForce = 400f;
    [SerializeField] private float forwardjumpForce = 100f;

    private XROrigin _xrRig;
    private CapsuleCollider _collider;
    private Rigidbody _body;


    private bool isGrounded => Physics.Raycast( // => when called it'll run function
        new Vector2(transform.position.x, transform.position.y + 2.0f),
        Vector3.down, 2.0f);

    // Start is called before the first frame update
    void Start()
    {
        _body = GetComponent<Rigidbody>();
        _collider = GetComponent<CapsuleCollider>();
        _xrRig = GetComponent<XROrigin>();

        jumpActionReference.action.performed += OnJump;
    }

    private void OnJump(InputAction.CallbackContext obj)
    {
        //if (!isGrounded) return;
        _body.AddForce(Vector3.up * jumpForce);
        _body.AddForce(Vector3.forward * forwardjumpForce);
    }

    // Update is called once per frame
    void Update()
    {
        HeightAdjust();

        //if(Input.GetKeyUp(KeyCode.Space))
        // {
        //   OnJumpa();
        // }
    }

    private void HeightAdjust()
    {
        var center = _xrRig.CameraInOriginSpacePos;
        _collider.center = new Vector3(center.x, _collider.center.y, center.z);
        _collider.height = _xrRig.CameraInOriginSpaceHeight;
    }
}
