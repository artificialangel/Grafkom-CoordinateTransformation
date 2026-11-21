using UnityEngine;

public class CoordinateSystemDemo : MonoBehaviour
{
    public float length = 5f;

    void Start()
    {
        Debug.Log("Sumbu X (right)   = " + Vector3.right);
        Debug.Log("Sumbu Y (up)      = " + Vector3.up);
        Debug.Log("Sumbu Z (forward) = " + Vector3.forward);
        Debug.Log("Unity: left-handed, Y up. Cross(X, Y) = " + Vector3.Cross(Vector3.right, Vector3.up));
    }

    void Update()
    {
        Vector3 o = transform.position;
        Debug.DrawRay(o, Vector3.right * length, Color.red);     // X
        Debug.DrawRay(o, Vector3.up * length, Color.green);      // Y
        Debug.DrawRay(o, Vector3.forward * length, Color.blue);  // Z
    }
}
