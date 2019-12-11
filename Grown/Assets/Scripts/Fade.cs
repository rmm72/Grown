using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fade : MonoBehaviour
{
    public Animator animator;
    private int leveltoLoad;
    public static bool moveLevel = false;

    public static Fade instance = null;
    public static Fade Instance

    {
        get { return instance; }
    }
    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }
    
    public void FadetoLevel(int levelIndex)
    {
        leveltoLoad = levelIndex;
        animator.SetTrigger("FadeOut");
        //moveLevel = false;
        Debug.Log("Fading...");
    }

    void Update()
    {
        if (LoadSceneOnClick.nextClick == true && moveLevel == false)
        {
            FadetoLevel(1);
            //FadetoNextLevel();
            animator.SetTrigger("FadeIn");
            LoadSceneOnClick.nextClick = false;
            moveLevel = true;
            Debug.Log("FADE TO PACK");
        }
        else if (Timer.moveNext == true && moveLevel == false)
        {
            FadetoLevel(2);
            animator.SetTrigger("FadeIn");
            Timer.moveNext = false;
            moveLevel = true;
            Debug.Log("FADE TO WALK");
        }
        else if (MoveCharacter.walk1 == true && moveLevel == false)
        {
            FadetoLevel(3);
            animator.SetTrigger("FadeIn");
            MoveCharacter.walk1 = false;
            moveLevel = true;
            Debug.Log("FADE TO DRIVE");
        }
        else if (CarDrag.drive1 == true && moveLevel == false)
        {
            FadetoLevel(4);
            animator.SetTrigger("FadeIn");
            CarDrag.drive1 = false;
            moveLevel = true;
            Debug.Log("FADE TO DORM");
        }
        else if (Timer2.moveNext2 == true && moveLevel == false)
        {
            FadetoLevel(5);
            animator.SetTrigger("FadeIn");
            Timer2.moveNext2 = false;
            moveLevel = true;
            Debug.Log("FADE TO DRIVE BACK");
        }
    }

    

    public void FadetoNextLevel()
    {
        FadetoLevel(SceneManager.GetActiveScene().buildIndex + 1);
        animator.SetTrigger("FadeIn");
    }

    public void OnFadeComplete()
    {
        SceneManager.LoadScene(leveltoLoad);
    }
}
