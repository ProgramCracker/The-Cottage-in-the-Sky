using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stove : MonoBehaviour
{
    [SerializeField] CollisionCheck _stoveSocket;
    [SerializeField] PieTinSocketManager _pieTin;

    [SerializeField] GameObject Pie;
    [SerializeField] Vector3 _spawnLocation;

    private void Awake()
    {
        Pie.SetActive(false);
    }
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
        
        //_pieTin.DestroyIngredients();
        _pieTin.gameObject.SetActive(false);
        Pie.SetActive(true);
    }
}
