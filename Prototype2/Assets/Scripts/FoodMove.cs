using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodMove : MonoBehaviour
{
    private float _speed = 10.0f;
    private float _timeOffset = 0.0f;
    private float _topBound = 30.0f;

    // Update is called once per frame
    void Update()
    {
        _timeOffset += Time.deltaTime;
        transform.Translate(Vector3.forward * Time.deltaTime * _speed);

        if(transform.position.z > _topBound) {
            Destroy(gameObject);
        }
    }
}
