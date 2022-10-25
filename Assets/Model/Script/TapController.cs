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
        // �^�b�`�̏󋵁iBegan�Ƃ�Move�Ƃ��j
        UnityEditor.DeviceSimulation.TouchPhase phase = (UnityEditor.DeviceSimulation.TouchPhase)touch.phase;
        // �^�b�`�̍��W
        Vector2 screenPosition = touch.screenPosition;
        // �^�b�`���n�߂����W
        Vector2 startScreenPosition = touch.startScreenPosition;
    }
}
