using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ParaditAttelu : MonoBehaviour {
    public GameObject bean;
    public GameObject teddy;
    public GameObject lady;
    public GameObject car;

    void Start ()
    {
        bean.SetActive(false);
        teddy.SetActive(false);
        lady.SetActive(false);
        car.SetActive(false);
    }

    public void bearImage(bool b)
    {
        teddy.SetActive(b);
    }
    public void beanImage(bool b)
    {
        bean.SetActive(b);
    }
    public void ladyImage(bool b)
    {
        lady.SetActive(b);
    }
    public void carImage(bool b)
    {
        car.SetActive(b);
    }

}
