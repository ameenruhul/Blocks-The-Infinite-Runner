using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSceneController : MonoBehaviour {

	public Text gameText;

     private float safeArea =25;
     private float gamePointer;
    public GameObject [ ] blockPrefabs;
    public Player player;
	public Camera gameCamera; 
	// Use this for initialization
	void Start () 
	{
		//Instantiate (blockPrefabs[0]);
		gamePointer= 7;
	}
	
	// Update is called once per frame
	void Update ()
	 {
		if(player!=null)
		{
		gameCamera.transform.position = new Vector3( player.transform.position.x,
		                             gameCamera.transform.position.y,gameCamera.transform.position.z);

		   gameText.text= "Score:  " +Mathf.Floor(player.transform.position.x);
		}

		while(player!= null && gamePointer<player.transform.position.x+safeArea)
		{
			         int blockIndex=Random.Range(0,blockPrefabs.Length);
                       GameObject blockObject= Instantiate(blockPrefabs[blockIndex]);
					   blockObject.transform.SetParent(this.transform);

             Block block =blockObject.GetComponent<Block>();
               blockObject.transform.position = new Vector2(gamePointer+block.size/2,0);
               gamePointer+= block.size;
	     }

	 }
}