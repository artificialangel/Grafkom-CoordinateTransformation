using UnityEngine;

public class ScaleDemo : MonoBehaviour
{
    [ContextMenu("Log localScale vs lossyScale")]
    void LogScale()
    {
        Debug.Log("localScale = " + transform.localScale);
        Debug.Log("lossyScale = " + transform.lossyScale);
    }

    [ContextMenu("Scale sumbu X saja")]
    void ScaleX() { transform.localScale = new Vector3(2f, 1f, 1f); LogScale(); }

    [ContextMenu("Scale sumbu Y saja")]
    void ScaleY() { transform.localScale = new Vector3(1f, 2f, 1f); LogScale(); }

    [ContextMenu("Scale sumbu Z saja")]
    void ScaleZ() { transform.localScale = new Vector3(1f, 1f, 2f); LogScale(); }

    [ContextMenu("Reset scale")]
    void ResetScale() { transform.localScale = Vector3.one; LogScale(); }
}
