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
        //transform.TransformDirection �� Local->World
        //InverseTransformDirection �� World->Local

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * _speed); //�Ʒ��� ����
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
 * (���� ���� 2����)
    1. ���� ����
    - �Ÿ�(ũ��) ex. magnitude
    - ����
    - ũ�Ⱑ 1�� ���͸� normalized ��� ��
    - ũ��� ����, ���⿡ ���� ������ ���� �� ����

    2. ��ġ ����

    

*/
