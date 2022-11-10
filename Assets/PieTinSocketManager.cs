using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieTinSocketManager : MonoBehaviour
{
    public bool _isready;

    [Header("Managed Sockets")]

    [SerializeField] CollisionCheck S_1;
    [SerializeField] CollisionCheck S_2;
    [SerializeField] CollisionCheck S_3;
    [SerializeField] CollisionCheck S_4;
    //[SerializedField] CollisionCheck S_1;

    private void Awake()
    {
        _isready = false;
    }

    public bool Cook()
    {
        if (_isready == false)
        {
            if (S_1._isSocket == true)
                if (S_2._isSocket == true)
                    if (S_3._isSocket == true)
                        if (S_4._isSocket == true)

                            _isready = true;
            return (true);
        }
        else
        {
           
            return (false);
        }
    }
}
