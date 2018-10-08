using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckWin : MonoBehaviour {

   

    public void win(int a1, int a2, int a3, int a4, int a5, int a6, int a7, int a8, int a9)
    {
        
        if (a1 == 1 && a4 == 1 && a7 == 1 || a1 == 1 && a5 == 1 && a9 == 1 || a2 == 1 && a5 == 1 && a8 == 1 || a3 == 1 && a6 == 1 && a9 == 1 || a3 == 1 && a5 == 1 && a7 == 1 || a4 == 1 && a5 == 1 && a6 == 1 || a7 == 1 && a8 == 1 && a9 == 1)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else if (a1 == 2 && a4 == 2 && a7 == 2 || a1 == 2 && a5 == 2 && a9 == 2 || a2 == 2 && a5 == 2 && a8 == 2 || a3 == 2 && a6 == 2 && a9 == 2 || a3 == 2 && a5 == 2 && a7 == 2 || a4 == 2 && a5 == 2 && a6 == 2 || a1 == 2 && a2 == 2 && a3 == 2)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        }
    }

    public void playerChange()
    {
        for(; ; )
        {

        }
    }
}
