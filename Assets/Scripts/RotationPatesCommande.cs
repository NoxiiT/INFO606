using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationPatesCommande : MonoBehaviour
{
    public GameObject Pate;
    public string AxeName = "Rotation Pates";

    void Update()
    {
        float input = Input.GetAxis(AxeName);
        EtatPates rotationEtat = MoveStateForInput(input);
        RotationPates controller = Pate.GetComponent<RotationPates>();
        controller.rotationEtat = rotationEtat;
    }

    EtatPates MoveStateForInput(float input)
    {
        if (input > 0)
        {
            return EtatPates.Positif;
        }
        else if (input < 0)
        {
            return EtatPates.Negatif;
        }
        else
        {
            return EtatPates.Fixe;
        }
    }
}
