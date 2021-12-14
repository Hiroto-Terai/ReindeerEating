using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonClick : MonoBehaviour
{
  public Text CountText;
  public int Cnt = 0;

  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {

  }

  public void OnClick(int number)
  {
    switch (number)
    {
      case 0:
        {
          Cnt--;
          CountText.text = "カウント: " + Cnt;
          break;
        }
      case 1:
        {
          Cnt++;
          CountText.text = "カウント: " + Cnt;
          break;
        }
      default:
        break;
    }
  }
}
