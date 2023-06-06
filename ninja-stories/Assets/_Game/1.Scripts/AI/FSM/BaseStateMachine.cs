using System;
using System.Collections.Generic;
using UnityEngine;

	
/// <summary>
/// 
/// </summary>
public class BaseStateMachine : MonoBehaviour
{
    [Header("Configuration")]
	[SerializeField] private BaseState initialState;

    private Dictionary<Type, Component> cachedComponents;

    public BaseState CurrentState { get; set; }
    public BaseState PreviousState { get; set; }

    public bool IsNewState { get; set; }

    private void Awake()
    {
        CurrentState = initialState;
        cachedComponents = new Dictionary<Type, Component>();
    }

    private void Start()
    {
        IsNewState = true;
    }

    private void Update()
    {
        if (IsNewState)
        {
            CurrentState.OnEnterState(this);
            IsNewState = false;
        }

        CurrentState.OnUpdate(this);
    }

    public void ChangeState(BaseState newState)
    {
        CurrentState.OnExitState(this);
        PreviousState = CurrentState;
        CurrentState = newState;
        IsNewState = true;

    }

    public new T GetComponent<T>() where T: Component
    {
        if (cachedComponents.ContainsKey(typeof(T)))
            return cachedComponents[typeof(T)] as T;

        var component = base.GetComponent<T>();

        if (component != null)
            cachedComponents.Add(typeof(T), component);

        return component;
    }
}
