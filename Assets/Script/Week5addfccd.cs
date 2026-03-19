using UnityEngine;

public class Week5addfccd : MonoBehaviour
{
    [SerializeField] private float mass;
    [SerializeField] private float force;
    [SerializeField] private float accel;
    void CalculareForce()
    {
        mass = GetComponent<Rigidbody>().mass;
        force = mass * accel;
        GetComponent<Rigidbody>().AddForce(force, force, 0);

    }
    public void SetAccel250()
    {
        accel = 250;
        CalculareForce();
    }
    public void SetAccel300()
    {
        accel = 300;
        CalculareForce();
    }
    public void SetAccel350()
    {
        accel = 350;
        CalculareForce();
    }
}
