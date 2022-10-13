using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="ObjEvent")]
public class objMessager : ScriptableObject 
{
    public List<ObjListener> listeners = new List<ObjListener>();
    // Start is called before the first frame update
public void Raise()
    {
        for (int i = 0; i < listeners.Count; i++)
        {
            listeners[i].OnEventRaised();
        }

    }
    public void RegisterListener(ObjListener listener)
    {
        if (!listeners.Contains(listener))
            listeners.Add(listener);
    }
    public void UnregisterListener(ObjListener listener)
    {
        if (listeners.Contains(listener))
            listeners.Remove(listener);

    }

}