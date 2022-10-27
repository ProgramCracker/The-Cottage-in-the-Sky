using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class apple : MonoBehaviour
{
    [Header("Whole Apple")]
    [SerializeField] GameObject _apple;
    [SerializeField] AudioSource _audio;

    [Header("Apple Drops")]
    [SerializeField] GameObject slice1;
    [SerializeField] GameObject slice2;
    [SerializeField] GameObject slice3;
    [SerializeField] GameObject slice4;

    private void Awake()
    {
        slice1.SetActive(false);
        slice2.SetActive(false);
        slice3.SetActive(false);
        slice4.SetActive(false);
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "blade")
        {
            GetComponent<Collider>().enabled = false;
            GetComponent<XRGrabInteractable>().enabled = false;
            _apple.SetActive(false);
            _audio.Play();

            slice1.SetActive(true);
            slice2.SetActive(true);
            slice3.SetActive(true);
            slice4.SetActive(true);
        }
    }
}
