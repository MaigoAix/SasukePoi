using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwingController : MonoBehaviour
{
    public GameObject Rope;
    public GameObject Player;
    private Vector3 ropePosition;
    private Vector3 playerPosition;


    public LineRenderer lineRenderer;

    [SerializeField]
    private LineRenderer[] lineRenderers;

    [SerializeField]
    private float startWidth = 0.1f;

    [SerializeField]
    private float EndWidth = 0.1f;

    private bool isSwinging;

    // Start is called before the first frame update
    void Start()
    {
        lineRenderer.SetWidth(startWidth, EndWidth);

        //ropePosition = Rope.position;
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(isSwinging)
        {
           // Vector3 swingDirection = CalculateSwingDirection(playerTransform, ropeTransform);
        }
    }

   // private Vector3 CalculateSwingDirection(Transform playerTransform, Transform ropeTransform)
   // {
       // return Rope.position - Player.position;
   // }
}
