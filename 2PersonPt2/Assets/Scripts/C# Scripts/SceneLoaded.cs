using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoaded : MonoBehaviour
{
    [Header("Ink JSON")]
    [SerializeField] private TextAsset inkJSON;
    private bool playerInRange;

    public void Awake(){
        playerInRange = false;
    }

    public void Update(){
        if(playerInRange){
            DialogueManager.GetInstance().EnterDialogueMode(inkJSON);
        }
    }

    private void OnMouseOver(){
        playerInRange = true;
    }

}
