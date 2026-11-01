using System.Runtime.ExceptionServices;
using UnityEngine;
using UnityEngine.Events;

public class vfxLock : MonoBehaviour
{

    public GameObject player;
    public UnityEvent death;

    bool hasExecuted = false;
    void Update()
    {
        transform.position = player.transform.position;

        if (player.gameObject.activeInHierarchy == false)
        {
            if (hasExecuted == false)
            {
                hasExecuted = true;
                death.Invoke();
            }
        }
    }
}
