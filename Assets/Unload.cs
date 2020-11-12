using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
// I am not using scenemanager here because it will freeze. (not aware of any fix here)
// Here I remove the entierty of previous line 2
// I went back on my work and added til I got the 4 Using I had in Load.cs
public class Unload : MonoBehaviour
{
    //public int scene;

    //public static bool UnloadScene(int scene);
    public static bool UnloadScene(string scene1;)
    //bool unloaded;

    void OntriggerEnter2D()
    {
        if (!unloadScene)
            //I try changing !unloaded with !unloadScene
        {
            unloaded = true;
            //this sets the bool to make sure it get's unloaded (Tho this probably doesn't really matter)
            //-loadingfirstscene.namewhatever.UnloadScene(scene);
            //This is a command that is different from my load. it does not utilize the scenemanager. 
            //This did not work, so I will try to use scenemanagement, and use an opposite of load.
            //-SceneManager.UnloadSceneAsync(scene, UnloadSceneMode.Additive);- UnloadSceneMode is not a command. and other unload scene options can't have additive.
            

        }
    }
    

    
}
