using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
//Here I use SceneManagement to make unity refer to my Build settings
// I allso changed line 2, where I removed Generic. (this I don't know why)
//correction. I put back line 3 since this was not working.
//This defenitly did the trick
public class Load : MonoBehaviour
{

    public int scene;

    bool loaded;
    //Here I protect with a bool to make sure it only loades once.
    void OnTriggerEnter2D()
        //this will activate the input event when triggered.
    {

        if (!loaded)
            
        {
            SceneManager.LoadSceneAsync(scene, LoadSceneMode.Additive);

            loaded = true;
                //end of bool
        }


    }
}
