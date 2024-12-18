using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionScene : MonoBehaviour
{
    [SerializeField]    
    private string sceneToLoad;
   
  public void ChangeScene(){
    SceneManager.LoadScene(sceneToLoad);
  }
}