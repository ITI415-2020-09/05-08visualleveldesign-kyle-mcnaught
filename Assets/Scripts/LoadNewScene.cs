using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNewScene : MonoBehaviour
{

    public void LoadTerrainScene()
    	{
    		SceneManager.LoadScene("Scene_0");
    	}
    	
     public void LoadInteriorScene()
    	{
    		SceneManager.LoadScene("Scene_1");
    	}
    
}
