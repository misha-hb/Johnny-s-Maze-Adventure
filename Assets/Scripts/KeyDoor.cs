using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyDoor : MonoBehaviour
{
    public GameObject KeyOnPlayer;

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player" && Variables.KeyCount>0) {
                Variables.KeyCount--;
                Destroy (gameObject);
                if (Variables.KeyCount == 0) {
                    KeyOnPlayer.SetActive(false);
            }
        }
    }
}
