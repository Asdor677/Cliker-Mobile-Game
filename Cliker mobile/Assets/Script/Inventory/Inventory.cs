using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Inventory : MonoBehaviour
{
   public List<ItemIventory> item = new List<ItemIventory>();

   public GameObject gameObjShow; 

   public GameObject InventoryMainObject;
   public int maxCount;

   public void AddGraphics()
    {
        for (int i = 0; i < maxCount; i++)
        {
            GameObject newItem = Instantiate(gameObjShow, InventoryMainObject.transform) as GameObject;

            newItem.name = i.ToString();

            ItemIventory ii = new ItemIventory();
            ii.itemGameObj = newItem;

            RectTransform rt = newItem.GetComponent<RectTransform>();
            rt.localPosition = new Vector3(0, 0, 0);
            rt.localScale = new Vector3(1, 1, 1);
            newItem.GetComponentInChildren<RectTransform>().localScale = new Vector3(1, 1, 1);

            Button tempButton = newItem.GetComponentInChildren<Button>();
            item.Add(ii);
        }
    }   
}

[System.Serializable]

public class ItemIventory
{
    public int id;
    public GameObject itemGameObj;

    public int count;
}
