using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorScript : MonoBehaviour
{
    ReflectionProbe prode;

    // Start is called before the first frame update
    void Start()
    {
        this.prode = GetComponent<ReflectionProbe>();
    }

    // Update is called once per frame
    void Update()
    {
        // y‚É1‚ð‚©‚¯‚Ä‹t‘¤‚É”z’u
        this.prode.transform.position = new Vector3(Camera.main.transform.position.x,
            Camera.main.transform.position.y * -1,
            Camera.main.transform.position.z);
        prode.RenderProbe();
    }
}
