using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.XR.Interaction;

public class PieTinSocketManager : MonoBehaviour
{
    public bool _isready;
    [SerializeField] bool[] _ingredientList;

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

    public void Update()
    {
        
    }

    public bool Cookable()
    {
        if (_isready == false)
        {
            if (S_1._hasTarget == true)
                if (S_2._hasTarget == true)
                    if (S_3._hasTarget == true)
                        if (S_4._hasTarget == true)

                            _isready = true;
            return (true);
        }
        else
        {
           
            return (false);
        }
    }
    
    public bool CheckContent()
    {
        if (_isready == false)
        {
             
        }
        return true;
    }
}
