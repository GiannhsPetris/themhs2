using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using Course.Saving;

 namespace Course.Cinematics
 {

    public class CinematicTrigger : MonoBehaviour, ISaveable
    {
        [SerializeField] bool alreadyTriggered = false;

        


        private void OnTriggerEnter(Collider other) 
        {
            if (!alreadyTriggered && other.gameObject.tag == "Player")
            {
                GetComponent<PlayableDirector>().Play();
                alreadyTriggered = true;
            }
        }

        public object CaptureState()
        {
            return alreadyTriggered;
        }

        public void RestoreState(object state)
        {
            alreadyTriggered = (bool)state;
        }
    }
 }
