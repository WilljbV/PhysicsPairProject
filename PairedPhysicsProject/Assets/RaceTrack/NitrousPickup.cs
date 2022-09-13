using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NitrousPickup : MonoBehaviour
{
    public float NitrousAmount = 10f;

    private void OnTriggerEnter(Collider other)
    {
        print("enter trigger");

        //if player, then take player and give nitrous
        if (other.TryGetComponent<RacingController>(out RacingController rc))
        {
            rc.nitroFuel += NitrousAmount;
        }
    }
}
