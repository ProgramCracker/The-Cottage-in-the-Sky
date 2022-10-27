using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flamable : MonoBehaviour
{
    [SerializeField] Collider ignitionPoint;
    [SerializeField] GameObject flame;
    

    private void Awake()
    {
        flame.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "igniter")
        {
            flame.SetActive(true);
        }
    }
}
