using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UImenu : MonoBehaviour
{

    public void Options()
    {
        SceneManager.LoadScene("options");
    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void BTNStart()
    {

    }

    public void ReturnMenu()
    {
        SceneManager.LoadScene("Menu");
    }

}
