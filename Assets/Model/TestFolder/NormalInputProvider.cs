using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalInputProvider : IInputProbider
{
    public bool IsTouch()
    {
        return Input.GetMouseButton(0);
    }
}
