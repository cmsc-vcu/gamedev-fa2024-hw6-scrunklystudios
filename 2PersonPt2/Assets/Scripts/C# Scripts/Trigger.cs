using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trigger : MonoBehaviour
{
    [Header("Visual Cue")]
    [SerializeField] private GameObject visualCue;

    private bool playerInRange;

    [Header("Ink JSON")]
    [SerializeField] private TextAsset inkJSON;

    //[Header("Other Speakers")]
    //[SerializeField] GameObject s1;
    //[SerializeField] GameObject s2;

    private void Awake(){
        playerInRange = false;
        visualCue.SetActive(false);
        //s1.SetActive(true);
        //s2.SetActive(true);
    }

    private void Update(){
        if(playerInRange){
            visualCue.SetActive(true);
            if(Input.GetMouseButtonDown(0)){
                Debug.Log("GameObject was clicked");
                DialogueManager.GetInstance().EnterDialogueMode(inkJSON);
                //s1.SetActive(false);
                //s2.SetActive(false);
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
