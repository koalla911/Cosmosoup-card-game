using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace CosmoSoup
{
	public class BarView : MonoBehaviour
	{
		public Slider slider;

		private void Awake()
		{
			if (slider == null)
			{
				slider = GetComponentInParent<Slider>();
			}
		}
		
		private void Start()
		{
			slider.value = slider.minValue;
		}

		public void UpdateSliderValue(float value)
		{
			slider.value += value;

			if (slider.value > slider.maxValue)
			{
				slider.value = slider.minValue;
			}
		}
		
	}
}
