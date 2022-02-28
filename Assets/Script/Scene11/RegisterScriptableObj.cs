using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegisterScriptableObj : ScriptableObject
{
    public List<IObserver> list;
    public delegate void Notifier();
    public Notifier OnNotify;

    public void Register(GameObject obs, State state)
    {
        var obj = obs.GetComponent<IObserver>();
        if (obj == null) return;
        if (state == State.Active)
        {
            list.Add(obj);
            //obj.Observer =
        }
        else
        {
            list.Remove(obj);
        }
    }

    public void NotifyAll()
    {
        foreach(var l in list)
        {
            l.Notify();
        }
    }
}

public enum State
{
    Active,
    Disactive
}
