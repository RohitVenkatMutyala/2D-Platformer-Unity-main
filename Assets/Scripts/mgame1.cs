using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mgame1 : MonoBehaviour
{
    public void PlayGame(){
        SceneManager.LoadSceneAsync(3);
    }
}
