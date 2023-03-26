using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CableController : MonoBehaviour
{
    public Transform moufle;
    public Transform crochet;
    LineRenderer line;

    // Start is called before the first frame update
    void Start()
    {
        line = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mouflePos = moufle.position;
        float distance = Vector3.Distance(mouflePos, crochet.position);
        line.positionCount = 2;

        line.SetPosition(0, mouflePos);
        line.SetPosition(1, crochet.position);

        line.startWidth = 0.015f;
        line.endWidth = 0.015f;
        line.widthMultiplier = distance / 2;
    }
}
