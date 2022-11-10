using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stove : MonoBehaviour
{
    [SerializeField] CollisionCheck _stoveSocket;
    [SerializeField] PieTinSocketManager _pieTin;

    [SerializeField] GameObject Pie;


    public void bake()
    {
        if (_stoveSocket._isSocket == true)
        {
           if(_pieTin.Cook())
            {
                _pieTin.gameObject.SetActive(false);
                Instantiate(Pie, transform);
            }
        }
    }
}
