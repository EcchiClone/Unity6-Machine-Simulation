
using UnityEngine;

public class GearRotation : MonoBehaviour
{
    public float torque = 10f; // 회전력을 조절하는 변수
    public float angularSpeedIncrement = 10f; // 각속도 증가량
    public Rigidbody rb;

    void Start()
    {
        if (rb == null)
        {
            rb = GetComponent<Rigidbody>();
        }
    }

    void Update()
    {
        // Q 키를 누르면 반시계 방향으로 가속
        if (Input.GetKey(KeyCode.Q))
        {
            rb.AddTorque(-transform.right * torque);
        }

        // E 키를 누르면 시계 방향으로 가속
        if (Input.GetKey(KeyCode.E))
        {
            rb.AddTorque(transform.right * torque);
        }

        //// Q 키를 누르면 반시계 방향으로 가속
        //if (Input.GetKey(KeyCode.Q))
        //{
        //    IncreaseAngularVelocity(-transform.right);
        //}

        //// E 키를 누르면 시계 방향으로 가속
        //if (Input.GetKey(KeyCode.E))
        //{
        //    IncreaseAngularVelocity(transform.right);
        //}
    }

    // 각속도를 강제로 증가시키는 함수
    void IncreaseAngularVelocity(Vector3 direction)
    {
        rb.angularVelocity += direction * angularSpeedIncrement * Time.deltaTime;
    }
}
