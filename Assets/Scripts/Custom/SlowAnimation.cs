using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlowAnimation : MonoBehaviour
{
    public Slider timeSlider;
    public float step;

    Animator m_Animator;
    float m_MySliderValue = 0;

	void Start()
	{
		m_Animator = gameObject.GetComponent<Animator>();
        m_Animator.speed = 0;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && m_MySliderValue < 1)
            m_MySliderValue += 0.25f;
        
        if (Input.GetMouseButtonDown(1) && m_MySliderValue > 0)
            m_MySliderValue -= 0.25f;

        if (timeSlider.value != m_MySliderValue)
        {
            timeSlider.value = Mathf.Lerp(timeSlider.value, m_MySliderValue, Time.deltaTime * 5);
            m_Animator.speed = Mathf.Lerp(timeSlider.value, m_MySliderValue, Time.deltaTime * 5);
        }
    }
}