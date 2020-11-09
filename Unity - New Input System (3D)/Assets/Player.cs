using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour, EventDrivenActions.IPlayerActions
{
	private EventDrivenActions _drivenActions;
	private InputAction Fire;

	private void Awake()
	{
		_drivenActions = new EventDrivenActions();
		_drivenActions.Player.SetCallbacks(this);
	}

	private void OnEnable()
	{
		_drivenActions.Enable();
	}

	private void OnDisable()
	{
		_drivenActions.Disable();
	}

	public void OnMove(InputAction.CallbackContext context)
	{
		Debug.Log($"Moving");
	}

	public void OnLook(InputAction.CallbackContext context)
	{

	}

	public void OnFire(InputAction.CallbackContext context)
	{
		Debug.Log($"Firing");
	}
}
