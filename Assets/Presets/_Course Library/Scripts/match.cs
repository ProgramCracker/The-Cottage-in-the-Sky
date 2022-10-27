using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class match : MonoBehaviour
{
    bool isLit;
    bool isBurnedOut;

    [Header("Plugins")]
    [SerializeField] GameObject flame;
    [SerializeField] GameObject flameCollider;

    [Header("Speed Settings")]
    [SerializeField] float matchSpeed;
    [SerializeField] float speedForLighting;
    [SerializeField] float speedForBurnOut;

    [Header("Burnout Timer")]
    [SerializeField] float flameLifeSpan;

    private void Awake()
    {
        isLit = false;
        isBurnedOut = false;
        flame.SetActive(false);
        flameCollider.SetActive(false);

    }

    void Update()
    {
        StartCoroutine(CheckSpeed());

        if (isLit == true)
        {
            if (matchSpeed >= speedForBurnOut)
            {
                flame.SetActive(false);
                isLit = false;
                isBurnedOut = true;
                Debug.Log("It's Out");
            }
        }

    }


    
    void OnCollisionEnter(Collision collision)
    {
        if (matchSpeed >= speedForLighting)
        {
                LightMatch();

        }
    }
    

    public void BurnOut()
    {

        if (isBurnedOut == false)
        {
            StartCoroutine(FlameTimer());
        }
    }

    public void LightMatch()
    {
        if (isBurnedOut == false)
        {
            flame.SetActive(true);
            flameCollider.SetActive(true);

            isLit = true;

            if (isLit == true)
            {
                BurnOut();
            }
        }
    }

    IEnumerator FlameTimer()
    {
        yield return new WaitForSeconds(flameLifeSpan);

        Debug.Log("burnOut");
        flame.SetActive(false);
        flameCollider.SetActive(false);
        isLit = false;
        isBurnedOut = true;
    }
    IEnumerator CheckSpeed()
    {
        Vector3 prevPos = transform.position;

        yield return new WaitForFixedUpdate();

        matchSpeed = Mathf.RoundToInt(Vector3.Distance(transform.position, prevPos) / Time.deltaTime);
    }
}
