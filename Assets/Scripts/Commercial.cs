using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Commercial : MonoBehaviour
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
		string ret = "Commercial:";
		if(gameObject.name == "Building6"){
			ret = ret + GetBuilding6Name();
		}else if(gameObject.name == "Building61"){
			ret = ret + GetBuilding61Name();
		}else if(gameObject.name == "Building7"){
			ret = ret + GetBuilding7Name();
		}else{
			ret = ret + "Unknown Commercial";
		}
		return ret;
	}

	string GetBuilding6Name(){
		return "Pokemon Shopping Center";
	}
	
	string GetBuilding61Name(){
		return "Kaiseki Restaurant";
	}

	string GetBuilding7Name(){
		return "Totoro Theater";
	}

}
