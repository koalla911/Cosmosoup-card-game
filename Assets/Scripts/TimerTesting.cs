using System.Collections;
using UnityEngine;

namespace CosmoSoup
{
	public class TimerTesting : MonoBehaviour
	{
		public float timer = 3f;
		private float timeCount;
		private bool isPaused = false;

		private void Update()
		{
			if (isPaused == false)
			{
				timeCount -= Time.deltaTime;
				if (timeCount < 0)
				{
					Debug.Log("timer");
					timeCount = timer;
				}
			}
		}

		public void TimerPaused()
		{
			isPaused = !isPaused;
		}
	}
}