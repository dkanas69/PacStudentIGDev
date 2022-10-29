using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class move : MonoBehaviour
{
     private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
          anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
         anim.Play("Base Layer.movedown", 0, 0.25f);
          anim.Play("Base Layer.moveDevil5", 0, 0.25f);
    }
}
