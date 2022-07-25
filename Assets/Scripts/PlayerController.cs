using System.Collections;
using System.Collections.Generic;
using UnityEngine;

struct MyVector
{
    public float x;
    public float y;
    public float z;


    //           +
    //      +
    // +---------+
    public float magnitude { get { return Mathf.Sqrt(x * x + y * y + z * z); } } // ũ��(�Ÿ�)
    public MyVector normalized { get { return new MyVector(x/magnitude, y/magnitude, z/magnitude); } } // ���⿡ ���� ����, 1;


    public MyVector (float x, float y, float z) { this.x = x; this.y = y; this.z = z; }

    public static MyVector operator +(MyVector a, MyVector b)
    {
        return new MyVector(a.x + b.x, a.y + b.y, a.z + b.z);
    }
    public static MyVector operator -(MyVector a, MyVector b)
    {
        return new MyVector(a.x - b.x, a.y - b.y, a.z - b.z);
    }
    public static MyVector operator *(MyVector a, float d)
    {
        return new MyVector(a.x *d, a.y * d, a.z * d);
    }

}

public class PlayerController : MonoBehaviour
{
    [SerializeField] // <- �ٿ��ָ� private �ӿ��� �ұ��ϰ� �����Ϳ� ����ȴ�.
    int _speed = 8;
    void Start()
    {

        MyVector to = new MyVector(10.0f, 0.0f, 0.0f);
        MyVector from = new MyVector(5.0f, 0.0f, 0.0f);
        MyVector dir = to - from; // (5.0f, 0.0f, 0.0f)

        dir = dir.normalized; // (1.0f, 0.0f, 0.0f) ����

        MyVector newPos = from + dir * _speed; // ���ο� ��ġ�� ��������� ���ϴ� �������� ���ǵ� ��ŭ �̵�.

        // ���� ����
            // 1. �Ÿ�(ũ��)    5 magnitude
            // 2. ���� ����     

    }
    //GameObject �ֻ���
    //  - Transform
    //  - Player Controller
    void Update()
    {
        // transforms Local space to World space 
        // transform.TransformDirection(v3) 

        // World space to Local space
        // transforms transform.InverseTransformDirection(v3)

        if (Input.GetKey(KeyCode.W))
            transform.Translate(Vector3.forward * Time.deltaTime * _speed); // ���� ���, �ð�*�ӷ��� �̿��� �������� �̵�
        if (Input.GetKey(KeyCode.S))
            transform.Translate(Vector3.back * Time.deltaTime * _speed);
        if (Input.GetKey(KeyCode.A))
            transform.Translate(Vector3.left * Time.deltaTime * _speed);
        if (Input.GetKey(KeyCode.D))
            transform.Translate(Vector3.right * Time.deltaTime * _speed);
    }
}