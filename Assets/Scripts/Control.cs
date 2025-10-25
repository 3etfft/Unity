using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Control : MonoBehaviour
{
    public Animator animator;
    public Button Nextbutton;
    public Button Prevbutton;
    public GameObject Next;
    public GameObject Prev;
    

    void OnEnable()
    {
        if (animator != null)
        {
            animator.SetTrigger("play");
        }
    }
    void Start()
    {
        if (Nextbutton != null)
        {
            Nextbutton.onClick.AddListener(next);

        }
        if (Prevbutton != null)
        {
            Prevbutton.onClick.AddListener(prev);
        }
    }
    void next()
    {
        gameObject.SetActive(false);
        Next.SetActive(true);
    }
    void prev()
    {
        gameObject.SetActive(false);
        Prev.SetActive(true);
    }

    public void Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

}
