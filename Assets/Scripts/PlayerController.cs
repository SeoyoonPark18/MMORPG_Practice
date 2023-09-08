using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    float _speed = 10.0f;

    void Start()
    {
        
    }

    void Update()
    {
        //transform.TransformDirection 은 Local->World
        //InverseTransformDirection 은 World->Local

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * _speed); //아래와 동일
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.TransformDirection(Vector3.back * Time.deltaTime * _speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.TransformDirection(Vector3.left * _speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.TransformDirection(Vector3.right * Time.deltaTime * _speed);
        }
    }
}

/* 
 * (벡터 사용법 2가지)
    1. 방향 벡터
    - 거리(크기) ex. magnitude
    - 방향
    - 크기가 1인 벡터를 normalized 라고 함
    - 크기는 무시, 방향에 대한 정보를 얻을 수 있음

    2. 위치 벡터

    

*/
