using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSelection : MonoBehaviour
{
    private int selectedCourse = 1;

    // [SerializeField] private GameObject Course1;
    // [SerializeField] private GameObject Course2;
    // [SerializeField] private GameObject Course3;

    [SerializeField] private GameObject menuToShow;

    private bool menuisShowing = false;

    void Update()
    {
        
        if (Input.GetButtonDown("Submit"))
        {
            LoadScene(selectedCourse);
        }
        if (Input.GetButtonDown("Horizontal"))
        {
            if(Input.GetAxis("Horizontal") > 0)
            {
                if (selectedCourse < 3)
                    selectedCourse++;
            }
            else
            {
                if (selectedCourse > 1)
                    selectedCourse--;
            }
            //ChangeSelected();
        }
        
    }

    public void LoadScene(int sceneCode)
    {
        SceneManager.LoadScene(sceneCode);
    }

    public void ShowMenu()
    {
        if (!menuisShowing)
        {
            menuToShow.SetActive(true);
            menuisShowing = true;
        }
        else
        {
            menuisShowing = false;
            HideMenu();
        }
        
    }

    public void HideMenu()
    {
        menuToShow.SetActive(false);
    }
    /*
    private void ChangeSelected()
    {
        switch (selectedCourse)
        {
            case 1:
                Course1.SetActive(true);
                Course2.SetActive(false);
                Course3.SetActive(false);
                break;
            case 2:
                Course1.SetActive(false);
                Course2.SetActive(true);
                Course3.SetActive(false);
                break;
            case 3:
                Course1.SetActive(false);
                Course2.SetActive(false);
                Course3.SetActive(true);
                break;
        }
    }
    */
}
