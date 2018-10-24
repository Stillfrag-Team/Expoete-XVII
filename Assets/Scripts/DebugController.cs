using UnityEngine;

public class DebugController : MonoBehaviour {

    public bool debugIsActive;
    
    public GameObject Ghost;

    void Start() { Ghost.SetActive(false); }

    void Update ()
    {
        if (Input.GetKeyUp(KeyCode.D))
        {
            debugIsActive = !debugIsActive;
        }
    }

    private void FixedUpdate()
    {
        if (debugIsActive)
        { ActiveDebug(); }
        else
        { DesactiveDebug(); }
    }
    
    public void ActiveDebug() { Ghost.SetActive(true);}

    public void DesactiveDebug() { Ghost.SetActive(false);}
}