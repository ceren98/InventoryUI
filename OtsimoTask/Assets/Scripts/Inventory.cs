using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class Inventory : MonoBehaviour, IHasChanged
{
    [Header("Slots")]
    [SerializeField] Transform slots;
    //[SerializeField] Text inventoryText;

    [Header("Texts")]
    [SerializeField] Text bottomText;
    [SerializeField] Text upText;
    [SerializeField] Text leftText;
    [SerializeField] Text rightText;
    private void Start()
    {
        HasChanged();
    }
    #region IHasChanged Implementation
    public void HasChanged()
    {
      
       // builder.Append("  ");
        foreach(Transform slotTransform in slots)
        {
            System.Text.StringBuilder builder = new System.Text.StringBuilder();
            GameObject item = slotTransform.GetComponent<Slot>().item;
           
            if (slotTransform.name == "SlotBottom")
            {
                if (item)
                {
                    builder.Append(item.name);
                    //builder.Append("  ");
                   
                    bottomText.text = builder.ToString();
                }
                else
                {
                  
                    bottomText.text = "";

                }
            }
            else if (slotTransform.name == "SlotUp")
            {
                if (item)
                {
                    builder.Append(item.name);
                    upText.text = builder.ToString();
                }
                else
                {
                   
                    upText.text = "";
                }
            }
            else if(slotTransform.name == "SlotLeft")
            {
                if(item)
                {
                    builder.Append(item.name);
                    leftText.text = builder.ToString();
                }
                else
                {
                    leftText.text = "";
                }
            }
            else if(slotTransform.name == "SlotRight")
            {
                if (item)
                {
                    builder.Append(item.name);
                    rightText.text = builder.ToString();
                }
                else
                {
                    rightText.text = "";
                   // builder.Append("  ");
                }
            }

        } 
        
        // inventoryText.text = builder.ToString();
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