using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionCheck : MonoBehaviour
{
    [SerializeField] GameObject _target;
    [SerializeField] GameObject _alternative;
    public bool _hasTarget;

    private void Awake()
    {
        _hasTarget = false;
        _alternative = null;
    }

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
}
