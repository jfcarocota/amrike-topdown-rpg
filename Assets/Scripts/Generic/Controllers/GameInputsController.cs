using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameInputsController : MonoBehaviour
{
    public Vector2 Axis => Gamemanager.Instance.GameInputs.Gameplay.Axis.ReadValue<Vector2>();
    public InputAction AxisAction => Gamemanager.Instance.GameInputs.Gameplay.Axis;
}
