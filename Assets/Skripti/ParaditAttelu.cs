using UnityEngine;
using UnityEngine.UI;

public class ParaditAttelu : MonoBehaviour
{
    public GameObject bean;
    public GameObject teddy;
    public GameObject lady;
    public GameObject car;

    public GameObject turnRight;
    public GameObject turnLeft;
    public GameObject currentPicture;
    public Sprite[] pictures;
    public GameObject sizeSlider;
    public GameObject rotationSlider;

    public void Rotate()
    {
        float rotationBefore = rotationSlider.GetComponent<Slider>().value;
        currentPicture.transform.localRotation = Quaternion.Euler(0, 0, rotationBefore * 360);
    }

    public void ChangeSize()
    {
        float sizeBefore = sizeSlider.GetComponent<Slider>().value;
        currentPicture.transform.localScale = new Vector2(3.5f * sizeBefore, 3.5f * sizeBefore);
    }
    public void Dropdown(int indekss)
    {
        if (indekss == 0)
        {
            currentPicture.GetComponent<Image>().sprite = pictures[0];
        }
        else if (indekss == 1)
        {
            currentPicture.GetComponent<Image>().sprite = pictures[1];
        }
        else if (indekss == 2)
        {
            currentPicture.GetComponent<Image>().sprite = pictures[2];
        }
    }
    public void leftBean()
    {
        bean.transform.localScale = new Vector2(1, 1);
    }
    public void rightBean()
    {
        bean.transform.localScale = new Vector2(-1, 1);
    }
    void Start()
    {
        bean.SetActive(false);
        teddy.SetActive(false);
        lady.SetActive(false);
        car.SetActive(false);
        turnLeft.GetComponent<Toggle>().interactable = false;
        turnRight.GetComponent<Toggle>().interactable = false;
    }

    public void bearImage(bool b)
    {
        teddy.SetActive(b);
    }
    public void beanImage(bool b)
    {
        bean.SetActive(b);
        turnLeft.GetComponent<Toggle>().interactable = b;
        turnRight.GetComponent<Toggle>().interactable = b;
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
