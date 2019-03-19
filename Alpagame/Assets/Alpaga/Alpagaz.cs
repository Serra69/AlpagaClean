using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alpagaz : MonoBehaviour {

    public GameObject alpagaz;
    public GameObject m_parent;

    private float pos;

    private void Start()
    {

    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("prout");
            Build();


        }
	}

    public void Build()
    {
        Instantiate(alpagaz, new Vector3(0, 0, pos), Quaternion.identity, m_parent.transform);

        pos = pos + alpagaz.transform.localScale.z;
    }
}
