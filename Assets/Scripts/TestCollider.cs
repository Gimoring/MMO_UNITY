using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCollider : MonoBehaviour
{
    // 조건
    // 1) 자신 혹은 상대방이 RigidBody가 있어야 한다 (IsKinematic : off)
    // 2) 자신이 Collider가 있어야 한다 (IsTrigger : off)
    // 3) 상대한테 Collider가 있어야 한다 (IsTrigger : off)
    private void OnCollisionEnter(Collision collision) // 다른 rigidbody, collider에 접촉되기 시작하면 호출되는 이벤트
    {
        // 사용 예시 : 총을 쏴서 총알이 상대방에게 맞았는지 체크
        Debug.Log($" collision @ {collision} !");
    }

    // 조건
    // 1) 둘 다 Collider가 있어야 한다.
    // 2) 둘 중 하나는 IsTrigger : on 이어야 한다.
    // 3) 둘 중 하나는 RigidBody가 있어야 한다.
    private void OnTriggerEnter(Collider other) // 어떤 Collider 'other'가 트리거가 될 때 호출되는 이벤트
    {
        // 사용 예시 : 검에 Collider를 붙여 휘두를 때 부딛혔는지 체크, 순간이동... 특정지역 입장했을 때 메세지 출력..
        Debug.Log($" trigger @ {other} !");
    }
    void Start()
    {
        
    }

    void Update()
    {
        // 1. 클릭한 지점의 월드 좌표 구하기
        Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 3));
    }
}
