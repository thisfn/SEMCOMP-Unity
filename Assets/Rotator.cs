using UnityEngine;

public class Rotator : MonoBehaviour
{
	public float value;
	public float increase;

	private void Update()
	{
		value = value + (Time.deltaTime * increase);
		transform.Rotate(0, 0, value * Time.deltaTime);
	}
}