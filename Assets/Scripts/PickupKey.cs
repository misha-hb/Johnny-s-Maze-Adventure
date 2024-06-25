using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupKey : MonoBehaviour
{

    public GameObject KeyOnPlayer;

    void Start()
    {
        KeyOnPlayer.SetActive(false);
    }

    private void OnTriggerStay(Collider other) {
        if (other.gameObject.tag == "Player") {
                Variables.KeyCount = Variables.KeyCount + 1;
                this.gameObject.SetActive(false);
                KeyOnPlayer.SetActive(true);
        }
    }

    
}
