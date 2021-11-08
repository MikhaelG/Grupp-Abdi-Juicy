using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ReplayButton : MonoBehaviour
{
    //Saga, en kod som gör så att replayButton inte finns hela tiden utan efter att animationen är klar
    public GameObject replayButton;
    public Animator diedAnim;
    public Animator replayAnim;

    void Update()
    {
        if(diedAnim.GetBool("Replay") == true)
        {
            replayButton.SetActive(true);

            if (Input.GetButtonDown("Submit"))
            {
                print("Replay");
                replayAnim.SetBool("Maybe", false);
                replayAnim.SetBool("Selected", true);
                SceneManager.LoadScene(0); //Laddas tillbaka till menyn
            }
        }
        
    }
    public void Function()
    {
        diedAnim.SetBool("Replay", true);
        //replayButton.SetActive(true);

    }
}
