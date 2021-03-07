using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class CutsceneCreator : MonoBehaviour
{

    private GameObject cutsceneObject;

    [SerializeField] private PlayableDirector cutSceneTimeLine;


    public void CreateCutscene()
    {
        if(cutsceneObject == null)
        {
            cutSceneTimeLine.gameObject.SetActive(true);
            cutSceneTimeLine.played += DestroyCutsceneOnEnd;
        }
    }

    public void StartCutscene()
    {
        cutsceneObject.GetComponent<PlayableDirector>().Play();
    }
    public void DestroyCutsceneOnEnd(PlayableDirector director)
    {
        Destroy(cutsceneObject);
        Destroy(gameObject);
    }

    private void OnDestroy() 
    {
        cutSceneTimeLine.played -= DestroyCutsceneOnEnd;
    }

    private void OnTriggerEnter(Collider other) 
    {
        if(other.GetComponent<PlayerController>() != null)
        {
            CreateCutscene();
        }
    }
}
