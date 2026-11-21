using UnityEngine;

public class HierarchyDemo : MonoBehaviour
{
    public Transform child;

    [ContextMenu("Geser parent")]
    void MoveParent() { transform.Translate(1f, 0f, 0f, Space.World); LogChild(); }

    [ContextMenu("Putar parent 45 derajat (Y)")]
    void RotateParent() { transform.Rotate(0f, 45f, 0f); LogChild(); }

    [ContextMenu("Scale parent x2")]
    void ScaleParent() { transform.localScale *= 2f; LogChild(); }

    void LogChild()
    {
        Debug.Log("child.position      = " + child.position);
        Debug.Log("child.localPosition = " + child.localPosition + " (tidak berubah)");
    }
}
