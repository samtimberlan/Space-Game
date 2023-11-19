using UnityEngine;

public class TimedDestroy : MonoBehaviour 
{
	public float DestroyTime = 200f;

	void Start ()
	{
		Destroy(gameObject, DestroyTime);
	}
}