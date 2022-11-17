using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create : MonoBehaviour
{
    [SerializeField] GameObject _object;
    [SerializeField] Transform _spawnLocation;

    public void CreateObject()
    {
        Instantiate(_object, _spawnLocation);
    }
}
