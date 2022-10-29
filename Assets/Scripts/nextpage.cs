using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextpage : MonoBehaviour
{
 public void onclickloadlevel () {
    SceneManager.LoadScene(1);
 }

    public void onclickexit()
    {
        SceneManager.LoadScene(0);
    }
}
