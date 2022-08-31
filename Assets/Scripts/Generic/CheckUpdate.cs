using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class CheckUpdate : MonoBehaviour
{
    [SerializeField] private UnityEvent OnUpdated;

    private void Update()
    {
        OnUpdated?.Invoke();
    }
}
