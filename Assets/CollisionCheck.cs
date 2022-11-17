using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionCheck : MonoBehaviour
{
    [SerializeField] string _targetTag;
    [SerializeField] string _alternativeTag;
    public bool _hasTarget;
    public GameObject _targetObject;

    private void Awake()
    {
        _hasTarget = false;
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("I see it");
        _hasTarget = true;

        if (other.gameObject.CompareTag(_targetTag) || other.gameObject.CompareTag(_alternativeTag))
        {
            //Debug.Log("I have it");
            _hasTarget = true;
            _targetObject = other.gameObject;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag(_targetTag) || other.gameObject.CompareTag(_alternativeTag))
        {
            
        }
    }

    /*
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject == _target || collision.gameObject == _alternative)
        {
            _hasTarget = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        
        if (collision.gameObject == _target || collision.gameObject == _alternative)
        {
            _hasTarget = false;
        }
    }
    */
}
