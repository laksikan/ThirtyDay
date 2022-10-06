using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlotController : MonoBehaviour
{   
    [SerializeField] GameObject slot1,slot2,slot3,slot4,slot5;
    public Text Name1,Name2,Name3,Name4,Name5;
    public Text Mass1,Mass2,Mass3,Mass4,Mass5;
    public Text Value1,Value2,Value3,Value4,Value5;
    public Text Q1,Q2,Q3,Q4,Q5,ttMass;
    public float TotalMass = 0;
    public int count=0,i=0,a,b,c,d,e;
    public string[] NameMaterial = {"Token","Wood","Scrap metal","Concrete","Tool","Cloth"};
    public float[] MassMaterial =  {1f,5f,5f,6f,5f,1f};
    public float[] ValueMaterial = {20f,20f,4f,4f,5f,16,1};
    public int[]   QuantityMaterial = {1,1,0,0,0,0};
    //
    public string[] NameConsumed = {"Meat","Bread","Vegetable","Simple meal","Fine meal","Salad","Medicine","Vaccine","Map"};
    public float[] MassConsumed = {2.5f,2.5f,1f,4f,4f,2f,5f,6f,1f};
    public float[] ValueConsumed = {6f,4f,3f,10f,13f,6f,25f,40,0.5f};
    public int[]   QuantityConsumed = {0,0,0,0,0,0,0,0,0};
    //
    public string[] NameWeapon = {"Baseball bat","Bloc.17","Assault rifle","Shotgun"};
    public float[] MassWeapon = {10f,15f,30f,35f};
    public float[] ValueWeapon = {10f,20f,45f,50f};
    public int[] QuantityWeapon = {0,0,0,0};
    //
    public string[] NameApparel = {"Gas Mask","Fire Suit","Bulletproof Armor"};
    public float[] MassApparel = {1f,5f,10f};
    public float[] ValueApparel = {20f,50f,80f};
    public int[] QuantityApparel = {0,0,0};
    public void Start()
    {
        CheckingMaterialSlot();
    }

    
    void Update()
    {
        
    }
    void CheckingMaterialSlot(){
        for(int i=0;i<QuantityMaterial.Length;i++){           
            a = QuantityMaterial[i];
            if(a>0&&count==0){
                slot1.SetActive(true);
                Name1.text=NameMaterial[i];
                Q1.text = QuantityMaterial[i].ToString();
                Mass1.text=MassMaterial[i].ToString();
                Value1.text=ValueMaterial[i].ToString();
                ++count;
                TotalMass += MassMaterial[i];                
                ttMass.text = "Mass : "+TotalMass+"/50"; 
                       
            }

        }

    }
}
