using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterCollision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Water"))
        {
            EndGame();
        }
    }

    private void EndGame()
    {
        // Add your game over logic here
        Debug.Log("Game Over");
        // You can also load a game over scene, show a game over UI, etc.
    }
}