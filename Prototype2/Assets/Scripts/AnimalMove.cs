using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalMove : MonoBehaviour
{
    private float _speed = 10.0f;
    private float _bottomBound = -10.0f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * _speed);

        if(transform.position.z < _bottomBound) {
            Destroy(gameObject);
            Debug.Log("Game over");
        }
    }
}
