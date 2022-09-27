using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeDeadPreview : MonoBehaviour
{
    void Start()
    {
        gameObject.GetComponent<Animator>().Play("TreeDead");
    }

}
