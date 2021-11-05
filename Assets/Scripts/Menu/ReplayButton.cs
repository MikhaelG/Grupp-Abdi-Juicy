using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ReplayButton : MonoBehaviour
{
    //Saga, en kod som g�r s� att replayButton inte finns hela tiden utan efter att animationen �r klar
    public GameObject replayButton;
    public Animator diedAnim;
    public Animator replayAnim;
    public AnimationClip diedClip;

    void Update()
    {
        //Fundera ut hur man g�r det h�r
        if(diedClip.length == 0.5f) //Om animation klippet �r 0.5f d� ska den s�tta boolen till true
        {
            replayButton.SetActive(true);
            Function();
        }
        Function();

    }

    public void Function()
    {
        if (Input.GetButtonDown("Submit"))
        {
            replayAnim.SetBool("Maybe", false);
            replayAnim.SetBool("Selected", true);
            SceneManager.LoadScene(0); //Laddas tillbaka till menyn
        }
    }
}
