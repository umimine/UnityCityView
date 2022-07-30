using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Bank : MonoBehaviour
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
		string ret = "Bank:";
		if(gameObject.name == "Building10"){
			ret = ret + GetBuilding10Name();
		}else if(gameObject.name == "Building101"){
			ret = ret + GetBuilding101Name();
		}else{
			ret = ret + "Unknown Bank";
		}
		return ret;
	}

	string GetBuilding10Name(){
		return "Eevee Global Bank";
	}
	
	string GetBuilding101Name(){
		return "Lucario's Bank Co.";
	}
}
