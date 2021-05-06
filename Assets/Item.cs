using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
   public enum ItemType
    {
        Flashlight, 
        MedicalKit
    }

    public ItemType itemType;
    public int amount;

    public Sprite GetSprite()
    {
        switch (itemType)
        {
            default:
            case ItemType.Flashlight: return ItemAssets.Instance.FlashlightSprite;
            case ItemType.MedicalKit: return ItemAssets.Instance.MedicalKitSprite;
        }
    }
}
