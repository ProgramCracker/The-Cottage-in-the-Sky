using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionCheck : MonoBehaviour
{
    [SerializeField] GameObject _target;
    bool _isSocket;

    private void Awake()
    {
        _isSocket = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Collision collider = _target.GetComponent<Collision>();
        if (collision == collider)
        {
            _isSocket = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        Collision collider = _target.GetComponent<Collision>();
        if (collision == collider)
        {
            _isSocket = false;
        }
    }
}
