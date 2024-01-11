using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityEventSubscriber : MonoBehaviour
{

    public UnityEventPublisher publisher;
    public string debugMessage;

    public void OnEnable()
    {
        // イベントにサブスクライブ
        if (publisher)
        {
            publisher.Published += DebugResponse;
        }
    }
    public void OnDisable()
    {   // イベントのサブスクリプションを解除
        if (publisher)
        {
            publisher.Published -= DebugResponse;
        }
    }

}
