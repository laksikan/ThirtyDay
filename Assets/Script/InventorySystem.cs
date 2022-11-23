using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySystem : MonoBehaviour
{
    public static InventorySystem Instance;
    public List<Resource> Resource = new List<Resource>();
    public Transform ResourceContent;
    public GameObject Item;

    private void Awake()
    {
        Instance = this;
    }
    public void Add(Resource item)
    {
        Resource.Add(item);
    }
    public void Remove(Resource item)
    {
        Resource.Remove(item);
    }
    public void ListItem(){
        
        //Clean content before
        foreach(Transform Resource in ResourceContent){
            Destroy(Resource.gameObject);
        }

        foreach(var item in Resource){
            GameObject obj = Instantiate(Item,ResourceContent);
            //var itemName = obj.transform.Find("Name").GetComponent<Text>();
            var itemIcon = obj.transform.Find("Artwork").GetComponent<Image>();
            //var itemMass = obj.transform.Find("Mass").GetComponent<Text>();
            //var itemValue = obj.transform.Find("Value").GetComponent<Text>();
            //var itemQuantity = obj.transform.Find("Quantity").GetComponent<Text>();
            //itemName.text = item.displayName;
            itemIcon.sprite = item.artwork;             
            //itemQuantity.text = item.Quantity.ToString();
            //itemMass.text = item.Mass.ToString();
            //itemValue.text = item.Value.ToString();
            
        }
        
        
    }
}
    
    

