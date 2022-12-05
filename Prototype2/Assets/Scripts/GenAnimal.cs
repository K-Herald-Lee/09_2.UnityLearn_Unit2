using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenAnimal : MonoBehaviour
{
    public GameObject[] _animal;
    private int _index = 0;
    private float _xMin = -15.0f;
    private float _xMax = 15.0f;
    private Vector3 _position;
    private float _startDelay = 2;
    private float _spawnInterval = 1.5f;
    
    private void Start() 
    {
       InvokeRepeating("SpawnRandomAnimal", _startDelay, _spawnInterval); 
        
    }
    void SpawnRandomAnimal()
    {
        _index = (int)Random.Range(0,3);
        _position = new Vector3(Random.Range(_xMin, _xMax), transform.position.y, transform.position.z);
        Instantiate(_animal[_index], _position, _animal[_index].transform.rotation);
    }
}
