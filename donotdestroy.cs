using UnityEngine;
using System.Collections;

public class donotdestroy : MonoBehaviour {

    void Awake() {
        DontDestroyOnLoad(gameObject);
            }

    

}
