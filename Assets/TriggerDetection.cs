using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class TriggerDetection : MonoBehaviour
{
    int i = 0;
    Text t;
    public Move m;
    // Start is called before the first frame update
    private void Start()
    {
        t = GameObject.Find("Num").GetComponent<Text>();
        m = GameObject.Find("Player").GetComponent<Move>();
        i = m.i;
    }
    


        // Update is called once per frame
        void Update()
        {

        }
        void OnTriggerEnter(Collider other)
        {
            m.i++;
            t.text = m.i.ToString();
            Debug.Log("wow");
        }
        
    
}
