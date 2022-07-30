using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Government : MonoBehaviour
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
		label.GetComponent<TextMeshPro>().text = GetLabel().Substring(0, 20);
	}
	
	string GetLabel(){
		string ret = "Government:";
		if(gameObject.name == "Building8"){
			ret = ret + GetBuilding8Name();
		}else if(gameObject.name == "Building9"){
			ret = ret + GetBuilding9Name();
		}else if(gameObject.name == "Building91"){
			ret = ret + GetBuilding91Name();
		}else{
			ret = ret + "Unknown Department";
		}
		return ret;
	}

	string GetBuilding8Name(){
		return "Town Hall";
	}
	
	string GetBuilding9Name(){
		return "Police Department";
	}

	string GetBuilding91Name(){
		return "Financial Department";
	}
	
}
