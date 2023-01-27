using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Hotel : MonoBehaviour
{
    // Start is called before the first frame update
	GameObject label;

    void Start()
    {
        GameObject player = GameObject.Find("Player");
		label = player.transform.GetChild(1).gameObject;                
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	public void showlabel(){
		label.GetComponent<TextMeshPro>().text = GetLabel();
	}
	
	public string GetLabel(){
		string ret = "Hotel:";
		if(gameObject.name == "Building5"){
			ret = ret + GetBuilding5Name();
		}else{
			ret = ret + "Unknown Hotel";
		}
		return ret;
	}

	string GetBuilding5Name(){
		return "Udon Hotel";
	}
	
}
