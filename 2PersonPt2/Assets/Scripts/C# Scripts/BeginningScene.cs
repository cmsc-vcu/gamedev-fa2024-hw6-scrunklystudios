using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BeginningScene : MonoBehaviour
{
    [SerializeField] GameObject otherBackground;
    public string sceneName;
    int buttonClick;

    private void Start(){
        buttonClick = 0;
    }

    private void Update(){
         if(Input.GetKeyDown(KeyCode.Space)){
                otherBackground.SetActive(false);
                buttonClick++;
            }
            if(buttonClick == 2){
                SceneManager.LoadScene(sceneName);
            }
    }
}
