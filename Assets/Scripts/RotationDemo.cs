using UnityEngine;

public class RotationDemo : MonoBehaviour
{
    [ContextMenu("Rotasi sumbu X")]
    void RotX() { transform.Rotate(45f, 0f, 0f); LogRotation(); }

    [ContextMenu("Rotasi sumbu Y")]
    void RotY() { transform.Rotate(0f, 45f, 0f); LogRotation(); }

    [ContextMenu("Rotasi sumbu Z")]
    void RotZ() { transform.Rotate(0f, 0f, 45f); LogRotation(); }

    [ContextMenu("Euler: set eulerAngles")]
    void SetEuler()
    {
        transform.eulerAngles = new Vector3(30f, 60f, 90f);
        LogRotation();
    }

    [ContextMenu("Quaternion: set rotation")]
    void SetQuaternion()
    {
        transform.rotation = Quaternion.Euler(30f, 60f, 90f);
        LogRotation();
    }

    // Gimbal lock: pitch (X) = 90 derajat membuat sumbu Y dan Z berimpit pada representasi Euler.
    [ContextMenu("Gimbal lock (Euler X = 90)")]
    void GimbalLock()
    {
        transform.eulerAngles = new Vector3(90f, 0f, 0f);
        transform.eulerAngles += new Vector3(0f, 30f, 0f);   // niat: putar Y, hasilnya terasa seperti putar Z
        LogRotation();
    }

    // Menghindari gimbal lock: gabungkan rotasi dengan quaternion.
    [ContextMenu("Hindari gimbal lock (Quaternion)")]
    void AvoidGimbalLock()
    {
        transform.rotation = Quaternion.Euler(90f, 0f, 0f);
        transform.rotation = Quaternion.AngleAxis(30f, Vector3.up) * transform.rotation;
        LogRotation();
    }

    void LogRotation()
    {
        Debug.Log("eulerAngles = " + transform.eulerAngles);
        Debug.Log("rotation (quaternion) = " + transform.rotation);
    }
}
