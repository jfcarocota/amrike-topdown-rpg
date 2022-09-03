using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class Movement2D : MonoBehaviour
{
    [SerializeField] private GameInputsController _gameInputsController;
    [SerializeField][Range(0.1f, 100f)] private float _moveSpeed;
    [SerializeField] UnityEvent<Vector2> OnMoved;
    [SerializeField] UnityEvent<Vector2> OnStopped;

    private void Start()
    {
        _gameInputsController.AxisAction.performed += Moved;
        _gameInputsController.AxisAction.canceled += Stopped;
    }

    private void OnEnable()
    {
        if(Gamemanager.Instance)
        {
            _gameInputsController.AxisAction.performed += Moved;
            _gameInputsController.AxisAction.canceled += Stopped;
        }
    }

    private void OnDisable()
    {
        _gameInputsController.AxisAction.performed -= Moved;
        _gameInputsController.AxisAction.canceled -= Stopped;
    }

    //public void Hello() => Debug.Log(_gameInputsController.Axis);

    private void Moved(InputAction.CallbackContext context) => OnMoved?.Invoke(context.ReadValue<Vector2>());
    private void Stopped(InputAction.CallbackContext context) => OnStopped?.Invoke(context.ReadValue<Vector2>());

    public void TranslateXY() => transform.Translate(_gameInputsController.Axis * _moveSpeed * Time.deltaTime);
}
