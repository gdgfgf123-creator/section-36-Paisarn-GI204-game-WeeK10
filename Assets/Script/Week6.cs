using UnityEngine;

public class Week6 : MonoBehaviour
{
    //t = mg + c = m(g + a) 
    public float tension;
    public float mass;
    public float accel;

    private Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        mass = rb.mass;
    }

    // Update is called once per frame
    void Update()
    {
        // T = mg + ma = m(g + a)
        tension = mass * (-Physics.gravity.y + accel);
        rb.AddForce(Vector3.up * tension);
    }
}
