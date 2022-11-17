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
        if (_stoveSocket._hasTarget == true)
        {
            CheckStatus();
        }
    }

    public void CheckStatus()
    {
        if (_pieTin.Cookable() == true)
        {
            MakePie();
        }
    }

    public void MakePie()
    {
        _pieTin.gameObject.SetActive(false);
        Instantiate(Pie, transform);
    }
}
