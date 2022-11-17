using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Experimental.XR.Interaction;

public class PieTinSocketManager : MonoBehaviour
{
    public bool _isready;
    [SerializeField] bool[] _ingredientList;
    [Header("Managed Sockets")]
    [SerializeField] public CollisionCheck[] _collisionCheckList;
    public GameObject[] _objectList;

    

    //[SerializeField] CollisionCheck S_1;
    //[SerializeField] CollisionCheck S_2;
    //[SerializeField] CollisionCheck S_3;
    //[SerializeField] CollisionCheck S_4;
    //[SerializedField] CollisionCheck S_1;

    private void Awake()
    {
        _isready = false;
        _ingredientList = new bool[_collisionCheckList.Length];
    }

    public bool Cookable()
    {
        if (CheckContent() == true)
        {
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
        int num = _collisionCheckList.Length;

        for (int i = 0; i < num; i++)
        {
           IngredientsReady(i);    
        }

        bool missingIngredient = false;
        for (int i = 0; i < num; i++)
        {
            if (CheckIngredientList(i) == false)
            {
                missingIngredient = true;  
            }
        }

        if (missingIngredient == true)
        {
            return false;
        }
        else
        {
            return true;
        }

    }

    public void DestroyIngredients()
    {

        int num = _collisionCheckList.Length;

        for (int i = 0; i < num; i++)
        {
            _objectList[i].SetActive(false);
        }

    }

    public void IngredientsReady(int num)
    {
       if ( _collisionCheckList[num]._hasTarget == true)
        {
            _ingredientList[num] = true;
            //_objectList[num] = _collisionCheckList[num]._targetObject;
        }
    }

    public bool CheckIngredientList(int num)
    {
        if (_ingredientList[num] == true)
        {
            
            return true;
        }
        else
        {
            
            return false;
        }
    }

}
