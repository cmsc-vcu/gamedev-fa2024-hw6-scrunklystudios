using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour
{
    [Header("Visual Cue")]
    [SerializeField] private GameObject visualCue;

    private bool playerInRange;

    public bool isGuilty;
    public string SucessScene;
    public string BadScene;

    private void Awake(){
        playerInRange = false;
        visualCue.SetActive(false);
    }

    private void Update(){
        if(playerInRange){
            visualCue.SetActive(true);
            if(Input.GetMouseButtonDown(0)){
                Debug.Log("GameObject was clicked");
                WhichEnd();
            }
        }else{
            visualCue.SetActive(false);
        }
    }

    private void WhichEnd(){
        if(isGuilty){
            SceneManager.LoadScene(SucessScene);
        }else{
            SceneManager.LoadScene(BadScene);
        }
    }

    private void OnMouseEnter(){
        playerInRange = true;
    }
    private void OnMouseExit(){
        playerInRange = false;
    }
}
