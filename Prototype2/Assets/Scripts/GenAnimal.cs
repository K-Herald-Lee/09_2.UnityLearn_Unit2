using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenAnimal : MonoBehaviour
{
    public GameObject _animal1;
    public GameObject _animal2;
    public GameObject _animal3;
    private int _index = 0;
    private float _x = 0.0f;
    private Vector3 _position;
    private float _timer;
    
    // Update is called once per frame
    void Update()
    {
        _timer += Time.deltaTime;
        _index = (int)Random.Range(0,3);
        _x = Random.Range(-15.0f, 15.0f);
        _position = new Vector3(_x, transform.position.y, transform.position.z);

        if (_timer > 1.0f) {
            if (_index == 0) {
                Instantiate(_animal1, _position, _animal1.transform.rotation);
            } else if (_index == 1) {
                Instantiate(_animal2, _position, _animal2.transform.rotation);
            } else {
                Instantiate(_animal3, _position, _animal3.transform.rotation);
            }
            _timer = 0.0f;
        }
    }
}
