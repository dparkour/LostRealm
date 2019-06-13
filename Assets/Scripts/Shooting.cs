using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shooting : MonoBehaviour
{
    public Transform Player;
    public LayerMask mask;
    public Image cursor;
    public GameObject shooting_missile;
    public Transform shootposition;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))

        {
            GameObject missile = Instantiate(shooting_missile, shootposition.position, Player.transform.rotation);
        }
        cursor.color = new Color(255,255,255);
        RaycastHit hit;
            {
                if (Physics.Raycast(transform.position, transform.forward, out hit, 10, mask))
               
                {
                    if (hit.collider.gameObject.GetComponent<Crystal>())
                    {
                        Crystal c = hit.collider.gameObject.GetComponent<Crystal>();

                        cursor.color = new Color(255, 0, 0);

                        if (!c.activated)
                        if (Input.GetMouseButtonDown(0))

                        {
                            c.activated = true;
                            GameObject missile = Instantiate(shooting_missile, shootposition.position, transform.rotation);
                        }
                    }
                }
            }
        }
    }