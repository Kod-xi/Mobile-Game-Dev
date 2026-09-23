using UnityEngine;

[RequireComponent(typeof(RectTransform))]
public class SafeArea : MonoBehaviour
{
    RectTransform _rt;
    Rect _applied;

    void Awake()
    {
        _rt = GetComponent<RectTransform>();
        Apply();
    }

    // Update is called once per frame
    void Update()
    {
        if (Screen.safeArea != _applied)
        {
            Apply();
        }
    }

    void Apply(){
        _applied = Screen.safeArea;
        Vector2 min = _applied.position;
        Vector2 max = _applied.position + _applied.size;
        min.x /= Screen.width;
        max.x /= Screen.width;
        min.y /= Screen.height;
        max.y /= Screen.height;
        _rt.anchorMin = min;
        _rt.anchorMax = max;
        _rt.offsetMin = Vector2.zero;
        _rt.offsetMax = Vector2.zero;
    }
}
