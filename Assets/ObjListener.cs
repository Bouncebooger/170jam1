using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ObjListener : MonoBehaviour
{
    public objMessager objMessager;

    public UnityEvent response;
    // Start is called before the first frame update
    private void OnEnable()
    {
        objMessager.RegisterListener(this);
    }
    private void OnDisable()
    {
        objMessager.UnregisterListener(this);
    }

    public void OnEventRaised()
    {
        response.Invoke();
    }

}
