using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ControllTouch : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public bool pulsar;
    // Start is called before the first frame update
    public void OnPointerDown(PointerEventData eventData)
    {
        pulsar = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        pulsar = false;
    }
}
