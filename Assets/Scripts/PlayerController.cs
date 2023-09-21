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
        // ���� ȸ����
        //transform.eulerAngles = new Vector3(0.0f, _yAngle, 0.0f);
        //+- delta
        //transform.Rotate(new Vector3(0.0f, Time.deltaTime * 100.0f, 0.0f));
        //Quaternion
        //transform.rotation = Quaternion.Euler(new Vector3(0.0f, _yAngle, 0.0f));


        //transform.TransformDirection �� Local->World
        //InverseTransformDirection �� World->Local
        if (Input.GetKey(KeyCode.W))
        {
            //transform.rotation = Quaternion.LookRotation(Vector3.forward); //�ش� �������� �Ĵٺ���
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.forward), 0.2f); //�ڿ������� �Ĵٺ��� (0~1)
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
 * (���� ���� 2����)
    1. ���� ����
    - �Ÿ�(ũ��) ex. magnitude
    - ����
    - ũ�Ⱑ 1�� ���͸� normalized ��� ��
    - ũ��� ����, ���⿡ ���� ������ ���� �� ����

    2. ��ġ ����

    

*/
