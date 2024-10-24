using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DialogueTrigger : MonoBehaviour
{
    [Header("Visual Cue")]
    [SerializeField] private GameObject visualCue;

    private bool playerInRange;
    [SerializeField] string nextScene;

    private void Awake(){
        playerInRange = false;
        visualCue.SetActive(false);
    }

    private void Update(){
        if(playerInRange){
            visualCue.SetActive(true);
            if(Input.GetMouseButtonDown(0)){
                Debug.Log("GameObject was clicked");
                SceneManager.LoadScene(nextScene);
                Debug.Log("Scene was changed");
            }
        }else{
            visualCue.SetActive(false);
        }
    }

    private void OnMouseOver(){
        playerInRange = true;
    }

    private void OnMouseExit(){
        playerInRange = false;
    }
}
