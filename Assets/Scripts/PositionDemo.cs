using UnityEngine;

public class PositionDemo : MonoBehaviour
{
    [ContextMenu("Log position vs localPosition")]
    void LogPosition()
    {
        Debug.Log("position (world)      = " + transform.position);
        Debug.Log("localPosition (local) = " + transform.localPosition);
    }

    [ContextMenu("Translate (Space.World)")]
    void TranslateWorld()
    {
        transform.Translate(Vector3.forward, Space.World);
        LogPosition();
    }

    [ContextMenu("Translate (Space.Self)")]
    void TranslateSelf()
    {
        transform.Translate(Vector3.forward, Space.Self);
        LogPosition();
    }
}
