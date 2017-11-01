using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    void OnTriggerEnter (Collider other)
    {
        // Si "other" à le tag enemy lors d'une collision, alors je fais EndGame du GameManager.
        if (other.tag == "enemy")
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
