using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatCommande : MonoBehaviour
{
    public GameObject Mat;
    public string axe = "Rotation Mat";

    void Update()
    {
        float input = Input.GetAxis(axe);
        EtatMat moveState = MoveStateForInput(input);
        MatController controller = Mat.GetComponent<MatController>();
        controller.rotationEtat = moveState;
    }

    EtatMat MoveStateForInput(float input)
    {
        if (input > 0)
        {
            return EtatMat.Positif;
        }
        else if (input < 0)
        {
            return EtatMat.Negatif;
        }
        else
        {
            return EtatMat.Fixe;
        }
    }
}
