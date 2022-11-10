using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionCheck : MonoBehaviour
{
    [SerializeField] GameObject _target;
    public bool _isSocket;

    private void Awake()
    {
        _isSocket = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject == _target)
        {
            _isSocket = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        
        if (collision.gameObject == _target)
        {
            _isSocket = false;
        }
    }
}
