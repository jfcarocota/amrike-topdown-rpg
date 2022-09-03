using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class StateMachineController : MonoBehaviour
{
    [SerializeField] Animator _animator;
    [SerializeField] GameInputsController _gameInputsController;

    public void SetTriggerParameter(AnimationParameter trigger) => _animator.SetTrigger(trigger.name);
    public void SetFloatParameter(FloatParameter floatParameter) => _animator.SetFloat(floatParameter.ParamaterName, floatParameter.Value);
    public void SetIntegerParameter(IntegerParameter integerParameter) => _animator.SetInteger(integerParameter.ParamaterName, integerParameter.Value);
    public void SetHorizontalValue(string horizontalName) => _animator.SetFloat(horizontalName, _gameInputsController.Axis.x);
    public void SetVerticallValue(string verticalName) => _animator.SetFloat(verticalName, _gameInputsController.Axis.y);
}
