using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityEventSubscriber : MonoBehaviour
{

    public UnityEventPublisher publisher;
    public string debugMessage;

    public void OnEnable()
    {
        // �C�x���g�ɃT�u�X�N���C�u
        if (publisher)
        {
            publisher.Published += DebugResponse;
        }
    }
    public void OnDisable()
    {   // �C�x���g�̃T�u�X�N���v�V����������
        if (publisher)
        {
            publisher.Published -= DebugResponse;
        }
    }

}
