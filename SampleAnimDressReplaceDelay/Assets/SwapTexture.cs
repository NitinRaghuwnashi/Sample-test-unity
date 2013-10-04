using UnityEngine;
using System.Collections;
using SmoothMoves;

public class SwapTexture : MonoBehaviour {
	
	
	public TextureAtlas searchAtlas;
	public TextureAtlas replaceAtlas;
	public BoneAnimation anim;
	
	
	void Start()
	{ 
		
		
	}
	
	
	void Update () {
		
		
		
		if(Input.GetKeyDown(KeyCode.A))
		{
			Debug.Log("A pressed");
			
				anim.ReplaceBoneTexture("Cloth",searchAtlas,searchAtlas.GetTextureGUIDFromName("Dress2"),searchAtlas,searchAtlas.GetTextureGUIDFromName("Dress3"));
		
		}
		if(Input.GetKeyDown(KeyCode.S))
		{
			Debug.Log("S pressed");
			
			anim.ReplaceBoneTexture("Cloth",searchAtlas,searchAtlas.GetTextureGUIDFromName("Dress2"),searchAtlas,searchAtlas.GetTextureGUIDFromName("Dress4"));
		
			
		}
				
		if(Input.GetKeyDown(KeyCode.W))
		{
			Debug.Log("W pressed");
			
				anim.ReplaceBoneTexture("Cloth",searchAtlas,searchAtlas.GetTextureGUIDFromName("Dress2"),replaceAtlas,replaceAtlas.GetTextureGUIDFromName("Dress1"));
		
		}
		if(Input.GetKeyDown(KeyCode.Q))
		{
			Debug.Log("Q pressed");
			
			anim.ReplaceBoneTexture("Cloth",searchAtlas,searchAtlas.GetTextureGUIDFromName("Dress2"),replaceAtlas,replaceAtlas.GetTextureGUIDFromName("Dress5"));
		
			
		}
		
		
	}
}
