using LSL;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LSLStreamItem : MonoBehaviour
{

    [SerializeField]
    private TMP_Text text_streamName;

    [SerializeField]
    private TMP_Text text_streamDescription;

    StreamInfo info;

    public void SetInfo(StreamInfo info) {
        this.info = info;

        text_streamName.SetText(info.name());
        text_streamDescription.SetText(info.type() + ": " + info.channel_count() + " Channels");
    }

    public void SelectStream() {
        if (info != null) {
            LSLStreamManager.instance.SelectStream(info.name());
        }
    }
}
