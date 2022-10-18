using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InventoryManeger : MonoBehaviour
{
    public static InventoryManeger Instance;
    public List<Material> Materials = new List<Material>();
    public Transform MaterialContent;
    public GameObject MaterialItem;

    private void Awake(){
        Instance = this;
    }
    public void Add(Material material){
        Materials.Add(material);
    }
    public void Remove(Material material){
        Materials.Remove(material);
    }
    public void ListMaterials(){
        foreach(Transform material in MaterialContent){
            Destroy(material.gameObject);
        }

        foreach(var material in Materials){
            GameObject obj = Instantiate(MaterialItem,MaterialContent);
            var materialName = obj.transform.Find("name").GetComponent<Text>();
            var materialIcon = obj.transform.Find("artwork").GetComponent<Image>();
            var materialMass = obj.transform.Find("Mass").GetComponent<Text>();
            var materialValue = obj.transform.Find("Value").GetComponent<Text>();
            var materialQuantity = obj.transform.Find("Quantity").GetComponent<Text>();
            materialName.text = material.name;
            materialIcon.sprite = material.artwork;             
            materialQuantity.text = material.Quantity.ToString();
            materialMass.text = material.Mass.ToString();
            materialValue.text = material.Value.ToString();
            
        }
        
        
    }
}
