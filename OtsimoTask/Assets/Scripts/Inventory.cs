using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class Inventory : MonoBehaviour, IHasChanged
{
    [SerializeField] Transform slots;
    [SerializeField] Text inventoryText;
    private void Start()
    {
        HasChanged();
    }
    #region IHasChanged Implementation
    public void HasChanged()
    {
        System.Text.StringBuilder builder = new System.Text.StringBuilder();
        builder.Append(" - ");
        foreach(Transform slotTransform in slots)
        {
            GameObject item = slotTransform.GetComponent<Slot>().item;
            if (item)
            {
                builder.Append(item.name);
                builder.Append(" - ");
            }
        }

        inventoryText.text = builder.ToString();
    }
    #endregion
}

namespace UnityEngine.EventSystems
{
    public interface IHasChanged: IEventSystemHandler
    {
        void HasChanged();
    }
}