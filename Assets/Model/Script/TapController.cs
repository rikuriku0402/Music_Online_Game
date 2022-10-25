using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.EnhancedTouch;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;

public class TapController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Gamepad.current == null) return;

        EnhancedTouchSupport.Enable();
    }
    void DebugTouch(Touch touch)
    {
        // タッチの状況（BeganとかMoveとか）
        UnityEditor.DeviceSimulation.TouchPhase phase = (UnityEditor.DeviceSimulation.TouchPhase)touch.phase;
        // タッチの座標
        Vector2 screenPosition = touch.screenPosition;
        // タッチを始めた座標
        Vector2 startScreenPosition = touch.startScreenPosition;
    }
}
