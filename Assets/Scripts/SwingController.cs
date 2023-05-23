using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwingController : MonoBehaviour
{
  //  public GameObject Rope;
  //  public GameObject Player;
   // private Vector3 ropePosition;
   // private Vector3 playerPosition;



    public LineRenderer lineRenderer;

    [Header("Initializing Rope Appearance")]
    [SerializeField] private LineRenderer[] lineRenderers;

    [SerializeField] private float startWidth = 0.1f;

    [SerializeField] private float EndWidth = 0.1f;

    [Header("Rope Variables")]
    private bool isSwinging;

    [SerializeField] Transform ropeTransform;
    [SerializeField] Transform playerTransform;
    private Vector3 previousPlayerPosition;
    private Vector3 previousRopePosition;

    [SerializeField] public float swingForce = 10f;
    [SerializeField] private Rigidbody playerRigidBody;

    // Start is called before the first frame update
    void Start()
    {
        // Initialize Rope Render
        lineRenderer.SetWidth(startWidth, EndWidth);

        // Initialize the previous positions with the initial positions
        previousPlayerPosition = playerTransform.position;
        previousRopePosition = ropeTransform.position;

        playerRigidBody = playerTransform.GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Check if the player or rope positions have changed
        if (playerTransform.position != previousPlayerPosition || ropeTransform.position != previousPlayerPosition)
        {
            // Player or rope position has changed, update the previous positions and perform necessary actions
            previousPlayerPosition = playerTransform.position;
            previousRopePosition = ropeTransform.position;


            //if (isSwinging)
            //{
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    Vector3 swingDirection = CalculateSwingDirection(ropeTransform, playerTransform);
                    playerRigidBody.AddForce(swingDirection * swingForce, ForceMode.Impulse);
                }
            //}

        }

    }

    private Vector3 CalculateSwingDirection(Transform player, Transform rope)
    {
        return rope.position - player.position;
    }

    // private Vector3 CalculateSwingDirection(Transform playerTransform, Transform ropeTransform)
    // {
    // return Rope.position - Player.position;
    // }
}
