using UnityEngine;

using UnityEngine.EventSystems;				//to use pointer

public class ObjektuParvietosana : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{  //intefraces to recognize gestures

    public Canvas canvas;                   //canvas that have an UI element
    RectTransform rectTransform;     //component, that will move the object

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    public void OnPointerDown(PointerEventData e)
    {
        Debug.Log("Izdarits kreisais klikskis uz velkama objekta");
    }

    public void OnBeginDrag(PointerEventData e)
    {
        Debug.Log("uzsakta vilksana");
    }
    public void OnDrag(PointerEventData e)
    {
        Debug.Log("Notiek objekta vilksana!");
        rectTransform.anchoredPosition += e.delta / canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData e)
    {
        Debug.Log("Veikta objekta vilksana...");
    }
}

