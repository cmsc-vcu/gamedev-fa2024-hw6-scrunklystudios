using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManage : MonoBehaviour{
    [SerializeField] private GameObject[] clickables;
    public bool changeScenes;

    private void Start(){
        changeScenes = false;
    }

    private void Update(){
        int j = 0;

        clickables = GameObject.FindGameObjectsWithTag("Trigger");

        foreach(GameObject click in clickables){
            if(click.GetComponent<Trigger>().clicked == true){
                j++;
            }
        }
        if(j == 3){
            changeScenes = true;
        }

        if(changeScenes){
            SceneManager.LoadScene("AccusationScene");
        }
    }
}