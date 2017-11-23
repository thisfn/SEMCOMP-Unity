using UnityEngine;

public class Rotator : MonoBehaviour
{
	public float value;

	private void Update()
	{
		transform.Rotate(0, 0, value);
	}
}