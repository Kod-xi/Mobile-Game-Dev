using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;
using TouchPhase = UnityEngine.InputSystem.TouchPhase;

public class TapSwipeInput : MonoBehaviour
{
    public float swipeDp = 50f;
    public float tapmax = 0.3f;


    void OnEnable() => EnhancedTouchSupport.Enable();
    
    void OnDisable() => EnhancedTouchSupport.Disable();
    
    void Update()
    {
        if (LifecycleGuard.IsPaused) return;
        foreach(var t in Touch.activeTouches){
            if (t.phase != TouchPhase.Ended) continue;
            float px = swipeDp * Mathf.Max(Screen.dpi, 160f) / 160f;
            Vector2 d = t.screenPosition - t.startScreenPosition;
            if (d.magnitude >= px){ 
                Debug.Log("Dash " + d.normalized); 
                Haptics.Pulse();
            }
            else if(t.time - t.startTime < tapmax) Debug.Log("Jump");
        }
    }
}
