using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCollider : MonoBehaviour
{
    // ����
    // 1) �ڽ� Ȥ�� ������ RigidBody�� �־�� �Ѵ� (IsKinematic : off)
    // 2) �ڽ��� Collider�� �־�� �Ѵ� (IsTrigger : off)
    // 3) ������� Collider�� �־�� �Ѵ� (IsTrigger : off)
    private void OnCollisionEnter(Collision collision) // �ٸ� rigidbody, collider�� ���˵Ǳ� �����ϸ� ȣ��Ǵ� �̺�Ʈ
    {
        // ��� ���� : ���� ���� �Ѿ��� ���濡�� �¾Ҵ��� üũ
        Debug.Log($" collision @ {collision} !");
    }

    // ����
    // 1) �� �� Collider�� �־�� �Ѵ�.
    // 2) �� �� �ϳ��� IsTrigger : on �̾�� �Ѵ�.
    // 3) �� �� �ϳ��� RigidBody�� �־�� �Ѵ�.
    private void OnTriggerEnter(Collider other) // � Collider 'other'�� Ʈ���Ű� �� �� ȣ��Ǵ� �̺�Ʈ
    {
        // ��� ���� : �˿� Collider�� �ٿ� �ֵθ� �� �ε������� üũ, �����̵�... Ư������ �������� �� �޼��� ���..
        Debug.Log($" trigger @ {other} !");
    }
    void Start()
    {
        
    }

    void Update()
    {
        // 1. Ŭ���� ������ ���� ��ǥ ���ϱ�
        Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 3));
    }
}
