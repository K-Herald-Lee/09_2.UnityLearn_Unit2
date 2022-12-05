using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public GameObject _food;
    private float _horizontalInput;
    private float _verticalInput;
    private float _speed = 10f;
    private float _xBoundary = 15f;
    private float _zTopBoundary = 10f;
    private float _zBottomBoundary = 0f;
   
    // Update is called once per frame
    void Update()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        _verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * Time.deltaTime * _horizontalInput * _speed);
        transform.Translate(Vector3.forward * Time.deltaTime * _verticalInput * _speed);  

        if (transform.position.x < -_xBoundary) {
            transform.position = new Vector3(-_xBoundary, transform.position.y, transform.position.z);
        }      
        if (transform.position.x > _xBoundary) {
            transform.position = new Vector3(_xBoundary, transform.position.y, transform.position.z);
        }
        if (transform.position.z > _zTopBoundary) {
            transform.position = new Vector3(transform.position.x, transform.position.y, _zTopBoundary);
        }
        if (transform.position.z < _zBottomBoundary) {
            transform.position = new Vector3(transform.position.x, transform.position.y, _zBottomBoundary);
        }

        if(Input.GetKeyDown(KeyCode.F)){
            Instantiate(_food, transform.position, _food.transform.rotation);
        }
    }
}
