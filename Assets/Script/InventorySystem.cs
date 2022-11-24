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
    public StatusSystem status;
    

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

    public void ConsumedItem(Resource item,float nutrition,float heal)
    {
        status.addStravation(nutrition);
        status.addHealth(heal);
        Remove(item);
    }

    public void ListItem(){
        
        //Clean content before
        foreach(Transform Resource in ResourceContent){
            Destroy(Resource.gameObject);
        }

        foreach(var item in Resource){
            GameObject obj = Instantiate(Item,ResourceContent);
            
            
            var itemIcon = obj.transform.Find("Artwork").GetComponent<Image>();
            itemIcon.sprite = item.artwork;
            var itemName = obj.transform.Find("DetailPopup/DeatailBox/ItemTitle(UI)").GetComponent<Text>();
            itemName.text = item.displayName;
            var itemDetail = obj.transform.Find("DetailPopup/DeatailBox/ItemDetail(UI)").GetComponent<Text>();
            itemDetail.text = item.description;

            var itemMass = obj.transform.Find("DetailPopup/DeatailBox/Mass/MassUI").GetComponent<Text>();
            var itemValue = obj.transform.Find("DetailPopup/DeatailBox/Value/ValueUI").GetComponent<Text>();
            
            itemMass.text = item.Mass.ToString();
            itemValue.text = item.Value.ToString();

            //Item nutrition cant find :( maybe need to edit class
            //var itemNutrition = obj.transform.Find("DetailPopup/DeatailBox/Nutrition/NutritionUI").GetComponent<Text>(); 
            //itemNutrition.text = item.Nutrition.ToString();
            
             
        }

    }

    
    
}
    
    

