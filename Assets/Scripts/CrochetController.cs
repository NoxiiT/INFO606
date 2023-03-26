using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EtatCrochet { Fixe = 0, Positif = 1, Negatif = -1 };

public class CrochetController : MonoBehaviour
{

    public EtatCrochet translationEtat = EtatCrochet.Fixe;
    public float crochetSpeed = 0.01f;
    public float crochetInitialPos = 0f;

    public GameObject crochet;

    private ArticulationBody articulation;

    void FixedUpdate()
    {
        modifierCrochet(translationEtat);
    }

    void modifierCrochet(EtatCrochet translationEtat) {
        ArticulationBody articulation = crochet.GetComponent<ArticulationBody>();
        
        if (translationEtat == EtatCrochet.Fixe) {
            return;
        }

        float newPos = crochetInitialPos + (translationEtat == EtatCrochet.Negatif ? -crochetSpeed : crochetSpeed) * Time.fixedDeltaTime;
        if (newPos > 4f) {
            newPos = 4f;
        }

        crochetInitialPos = newPos;

        var xDrive = articulation.xDrive;
        xDrive.target = newPos;
        xDrive.upperLimit = newPos;
        xDrive.lowerLimit = newPos;
        articulation.xDrive = xDrive;
    }
}