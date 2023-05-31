using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

[RequireComponent(typeof(Rigidbody))]

public class GrabController : XRBaseInteractable
{
    //[SerializeField] private InputActionReference grabActionReference;

    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        Debug.Log("Select Enter");

        base.OnSelectEntered(args);



    }

    protected override void OnSelectExiting(SelectExitEventArgs args)
    {
        Debug.Log("Select Exit");
        base.OnSelectExiting(args);


    }




    // Start is called before the first frame update
    // void Start()
    // {
    //      grabActionReference.action.performed += grab ();
    //}

    // private Action<InputAction.CallbackContext> grab()
    // {
    //    throw new NotImplementedException();
    // }


}
