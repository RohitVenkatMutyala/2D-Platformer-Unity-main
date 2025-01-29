using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class load2 : MonoBehaviour
{
    //public Animator anim;
    public PlaySound playSound;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //StartCoroutine("LevelExit");
             SceneManager.LoadScene(6);
           
        }
    }

    IEnumerator LevelExit()
    {
        //anim.SetTrigger("Exit");
        yield return new WaitForSeconds(0.1f);

        UIManager.instance.fadeToBlack = true;

        yield return new WaitForSeconds(2f);
        // Do something after flag anim
        GameManager.instance.LevelComplete();
    }
}
