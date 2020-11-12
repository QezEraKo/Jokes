using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
//added ''.SceneManagement'' in line 3 to make unity use my build settings as refrence

public class loadingfirstscene : MonoBehaviour
{
    // Start is called before the first frame update
    //here in line 16 I change ''Start'' with ''Awake''. This is because ''Awake'' will be called on this object as soon as the game starts, where as ''Start'' is called on this object as soon as it's enabled.
    //if I disable an object, ''Start'' will not be called on that object again. 

    public static loadingfirstscene namewhatever;
    //line 12 shows how to make a static script by refrencing it's own script''loadingfirstscene''and naming it ''namewhatever'' (at least this is what I think it does)
    //making this script referable in other scripts
    bool gameStart;
    //I use line 15 to make sure this only occurs once. I'm unsure if awake is used when other scenes are loaded on unloaded.
    void Awake()
    {
       if (!gameStart)
        {
            namewhatever = this;
            //I think he says line 21 makes this script non variable. (honestly no idea) 
            SceneManager.LoadSceneAsync(1, LoadSceneMode.Additive);
            //line 23 makes the first scene load by refering to ''1'' in the build settings. ''Async'' lets me choose when to unload a scene.
            gameStart = true;
            //this is a continuance of bool.
        }
    }

    //public void UnloadScene(int scene)
    //{
      //  StartCoroutine(Unload(scene));
    //}
    
    //IEnumerator Unload(int scene)
    //{
      //  yield return null;

        //SceneManager.UnloadScene(scene);
    //}
}
