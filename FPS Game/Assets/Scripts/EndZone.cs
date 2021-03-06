using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndZone : MonoBehaviour
{
    EndZoneManager endZoneManager;

    void Awake()
    {
        endZoneManager = GetComponentInParent<EndZoneManager>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        print(other.gameObject);
        var playerPhotonView = other.gameObject.GetComponent<PlayerController>()?.PV.Controller;
        if (playerPhotonView != null) endZoneManager.onPlayerDetected(playerPhotonView);
        
    }
}
