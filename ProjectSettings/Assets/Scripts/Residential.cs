using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Residential : MonoBehaviour
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
		string ret = "Residential:";
		if(gameObject.name == "Building1"){
			ret = ret + GetBuilding1Name();
		}else if(gameObject.name == "Building2"){
			ret = ret + GetBuilding2Name();
		}else if(gameObject.name == "Building3"){
			ret = ret + GetBuilding3Name();
		}else if(gameObject.name == "Building4"){
			ret = ret + GetBuilding4Name();
		}else if(gameObject.name == "Building41"){
			ret = ret + GetBuilding41Name();
		}else if(gameObject.name == "Building42"){
			ret = ret + GetBuilding42Name();
		}else{
			ret = ret + "Unknown Apartment";
		}
		return ret;
	}

	string GetBuilding1Name(){
		return "Saru Apartment";
	}
	
	string GetBuilding2Name(){
		return "Usagi Apartment";
	}

	string GetBuilding3Name(){
		return "Kumo Apartment";
	}

	string GetBuilding4Name(){
		return "Neko Apartment";
	}

	string GetBuilding41Name(){
		return "Inu Apartment";
	}

	string GetBuilding42Name(){
		return "Tora Apartment";
	}
}
