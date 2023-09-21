using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    float _speed = 10.0f;

    void Start()
    {
        Managers.Input.KeyAction -= OnKeyboard;
        Managers.Input.KeyAction += OnKeyboard;
    }

    float _yAngle = 0.0f;

    void Update()
    {
        
     
    }

    void OnKeyboard()
    {
        _yAngle += Time.deltaTime * _speed;
        // 절대 회전값
        //transform.eulerAngles = new Vector3(0.0f, _yAngle, 0.0f);
        //+- delta
        //transform.Rotate(new Vector3(0.0f, Time.deltaTime * 100.0f, 0.0f));
        //Quaternion
        //transform.rotation = Quaternion.Euler(new Vector3(0.0f, _yAngle, 0.0f));


        //transform.TransformDirection 은 Local->World
        //InverseTransformDirection 은 World->Local
        if (Input.GetKey(KeyCode.W))
        {
            //transform.rotation = Quaternion.LookRotation(Vector3.forward); //해당 방향으로 쳐다보기
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.forward), 0.2f); //자연스럽게 쳐다보기 (0~1)
            transform.Translate(Vector3.forward * Time.deltaTime * _speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.back), 0.2f);
            transform.Translate(Vector3.forward * Time.deltaTime * _speed);
            //transform.position -= transform.TransformDirection(Vector3.back * Time.deltaTime * _speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.left), 0.2f);
            transform.Translate(Vector3.forward * Time.deltaTime * _speed);
            //transform.position -= transform.TransformDirection(Vector3.left * _speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.right), 0.2f);
            transform.Translate(Vector3.forward * Time.deltaTime * _speed);
            //transform.position += transform.TransformDirection(Vector3.right * Time.deltaTime * _speed);
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
