using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SynchronizerData;

public class SubTowerController : MonoBehaviour
{
    // pulse flag so enemy objects can check for radius
    bool activeFlag;

    private BeatObserver beatObserver;

    public GameObject radi;

    void Start()
    {
        beatObserver = GetComponent<BeatObserver>();
        radi.SetActive(false);
    }

    void Update()
    {
        if ((beatObserver.beatMask & BeatType.DownBeat) == BeatType.DownBeat)
        {
            radi.SetActive(true);
        }
        if ((beatObserver.beatMask & BeatType.UpBeat) == BeatType.UpBeat)
        {
            radi.SetActive(false);
        }
    }


}
