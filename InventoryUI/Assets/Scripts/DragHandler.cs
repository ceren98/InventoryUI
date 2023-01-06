using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class DragHandler : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public static GameObject itemBeingDragged;
    Vector3 startPosition;
    Transform startParent;

    #region IBeginDragHandler Implementation
    public void OnBeginDrag(PointerEventData eventData)
    {
        itemBeingDragged = gameObject;
        startPosition = transform.position;

       // startPosition = Camera.main.WorldToScreenPoint(transform.position);
        startParent = transform.parent;
        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }

    #endregion

    #region IDragHandler Implementation
    public void OnDrag(PointerEventData eventData)
    {
       transform.position = Input.mousePosition;
      
    }

    #endregion

    #region IEndDragHandler Impleentation
    public void OnEndDrag(PointerEventData eventData)
    {
        itemBeingDragged = null;
        GetComponent<CanvasGroup>().blocksRaycasts = true;
        if (transform.parent==startParent)
        {
            transform.position = startPosition;
          //  transform.position = Camera.main.ScreenToWorldPoint(startPosition);
        }
        
    }

    #endregion
}
