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
    private float _timer;
    private float _timerLimit = 1.0f;
    
    // Update is called once per frame
    void Update()
    {
        _timer += Time.deltaTime;
        _index = (int)Random.Range(0,3);
        _position = new Vector3(Random.Range(_xMin, _xMax), transform.position.y, transform.position.z);

        if (_timer > _timerLimit) {
            Instantiate(_animal[_index], _position, _animal[_index].transform.rotation);
            _timer = 0.0f;
        }
    }
}
