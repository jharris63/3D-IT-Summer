using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cpuRotate : MonoBehaviour {

    public Animator animator;
    public bool insert;

    private string rotate = "rotate";
    private string inserts = "insert";
    private int rotation = 0;
    private int inserter = 0;
    public bool correctRotation;

    public bool Finished = false;

    public void OnClick()
    {
        rotation += 1;

        if (rotation > 4)
        {
            rotation = 1;
        }

        animator.SetBool((rotate + rotation), true);
    }

    public void Button()
    {
        StartCoroutine("Inserter");
    }

    // Update is called once per frame
    void Update ()
    {
        //animator.SetBool((rotate + rotation), true);

        if(rotation == 1)
        {
            animator.SetBool("rotate4", false);
        }
        else
        if(rotation == 2)
        {
            animator.SetBool("rotate1", false);
        }
        else
        if (rotation == 3)
        {
            animator.SetBool("rotate2", false);
        }
        else
        if (rotation == 4)
        {
            animator.SetBool("rotate3", false);
        }

        if (animator.GetCurrentAnimatorStateInfo(0).IsName("idle3Fin"))
        {
            Finished = true;
        }
    }

    IEnumerator Inserter()
    {
        animator.SetBool((inserts + rotation), true);
        yield return new WaitForSeconds(1);
        animator.SetBool((inserts + rotation), false);
    }
}
