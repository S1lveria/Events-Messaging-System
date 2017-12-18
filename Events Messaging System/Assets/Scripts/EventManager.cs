using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventManager : MonoBehaviour
{
    private Dictionary<string, UnityEvent> eventDictionary;

    private static EventManager eventManager; 

    public static EventManager instance
    {
        get
        {
            if(!eventManager)
            {
                eventManager = FindObjectOfType(typeof(EventManager)) as EventManager;
                if(!eventManager)
                {
                    Debug.Log("There needs to be one active EventManager script on a GameObject in your scene");
                }
                else
                {
 //                   eventManager, Initialize this
                }
            }
        }
    }
}
