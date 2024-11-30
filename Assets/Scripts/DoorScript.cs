using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TempScript : MonoBehaviour
{
    public PlayableDirector timeline;


    private void OnTriggerEnter(Collider other)
    {

        timeline.Play();

    }
}
