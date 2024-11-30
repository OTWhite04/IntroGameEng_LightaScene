using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class ToxicWasteTrigger : MonoBehaviour
{
    public PlayableDirector timeline;
    public PlayableDirector timeline2;

    private void OnTriggerEnter(Collider other)
    {
        timeline.Play();
        timeline2.Play();
    }
}
