using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour, IObserver
{
    protected RegisterScriptableObj _obj;
    protected State _state;

    public GameObject Observer { get; set; }

    private void Start()
    {
        _obj = GetComponent<RegisterScriptableObj>();
    }

    private void OnEnable()
    {
        _state = State.Active;
        Notify();
        _obj.Register(gameObject, _state);
        //_obj.OnNotify += Notify();
    }

    private void OnDisable()
    {
        _state = State.Active;
        Notify();
        _obj.Register(gameObject, _state);
    }

    public void Notify()
    {
        Debug.Log("notified");
    }
}
