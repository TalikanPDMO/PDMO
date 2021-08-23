using System.Threading;
using WindowsInput;
using SharpDX.XInput;
using System;
using WindowsInput.Native;
using Intersect.Client.Core.Controls;

namespace Intersect.Client.Core.Controls
{
	public class XBoxController
	{
		private const int MovementDivider = 2_000;
		private const int ScrollDivider = 10_000;
		private const int RefreshRate = 60;

		private Timer _timer;
		private Controller _controller;
		private IKeyboardSimulator _keyboardSimulator;

		private bool _wasADown;
		private bool _wasBDown;
		private bool _wasXDown;
		private bool _wasYDown;

		//Touches que la manette va simuler
		private VirtualKeyCode LJoystickUp = VirtualKeyCode.UP;
		private VirtualKeyCode LJoystickDown = VirtualKeyCode.DOWN;
		private VirtualKeyCode LJoystickLeft = VirtualKeyCode.LEFT;
		private VirtualKeyCode LJoystickRight = VirtualKeyCode.RIGHT;

		private VirtualKeyCode ControllerA = VirtualKeyCode.OEM_1;
		private VirtualKeyCode ControllerB = VirtualKeyCode.F14;
		private VirtualKeyCode ControllerX = VirtualKeyCode.F15;
		private VirtualKeyCode ControllerY = VirtualKeyCode.F16;


		public XBoxController()
		{
			_controller = new Controller(UserIndex.One);
			_keyboardSimulator = new InputSimulator().Keyboard;
			_timer = new Timer(obj => Update());
		}

		public void Start()
		{
			_timer.Change(0, 1000 / RefreshRate);
		}

		private void Update()
		{
			_controller.GetState(out var state);
			Movement(state);
			ButtonA(state);
			ButtonB(state);
			ButtonX(state);
			ButtonY(state);
		}

		private void ButtonA(State state)
		{
			var isADown = state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.A);
			if (isADown && !_wasADown) _keyboardSimulator.TextEntry("A");
			if (!isADown && _wasADown) _keyboardSimulator.TextEntry("A");
			//_wasADown = isADown;
		}

		private void ButtonB(State state)
		{
			var isBDown = state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.B);
			if (isBDown && !_wasBDown) _keyboardSimulator.KeyUp(ControllerB);
			if (!isBDown && _wasBDown) _keyboardSimulator.KeyDown(ControllerB);
			_wasBDown = isBDown;
		}

		private void ButtonX(State state)
		{
			var isXDown = state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.X);
			if (isXDown && !_wasXDown) _keyboardSimulator.KeyUp(ControllerX);
			if (!isXDown && _wasXDown) _keyboardSimulator.KeyDown(ControllerX);
			_wasXDown = isXDown;
		}

		private void ButtonY(State state)
		{
			var isYDown = state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.Y);
			if (isYDown && !_wasYDown) _keyboardSimulator.KeyUp(ControllerY);
			if (!isYDown && _wasYDown) _keyboardSimulator.KeyDown(ControllerY);
			_wasYDown = isYDown;
		}

		private void RJoystick(State state)
		{
			var x = state.Gamepad.RightThumbX / ScrollDivider;
			var y = state.Gamepad.RightThumbY / ScrollDivider;
			//_keyboardSimulator.HorizontalScroll(x);
			//_mouseSimulator.VerticalScroll(y);
		}

		private void Movement(State state)
		{
			var x = state.Gamepad.LeftThumbX / MovementDivider;
			var y = state.Gamepad.LeftThumbY / MovementDivider;
			//Console.WriteLine(x);
			//Console.WriteLine(y);
			if (Math.Abs(x) > 2 && Math.Abs(x) > Math.Abs(y))
            {
				if (x < 0)
                {
					_keyboardSimulator.KeyDown(LJoystickLeft);
					_keyboardSimulator.KeyUp(LJoystickRight);
				}
				else
                {
					_keyboardSimulator.KeyDown(LJoystickRight);
					_keyboardSimulator.KeyUp(LJoystickLeft);
				}
            }
			else
            {
				_keyboardSimulator.KeyUp(LJoystickLeft);
				_keyboardSimulator.KeyUp(LJoystickRight);
			}

			if (Math.Abs(y) > 2)
			{
				if (y < 0)
				{
					Controls.KeyDown(Control.MoveUp);
				}
				else
				{
					Controls.KeyDown(Control.MoveDown);
				}
			}
			else
			{
				Controls.KeyUp(Control.MoveUp);
			}
		}

		public void SaveKey(Control control, Int32 key)
        {
			switch (control)
			{
				case Control.MoveUp:
					LJoystickUp = (VirtualKeyCode) key;
					break;
				case Control.MoveDown:
					LJoystickDown = (VirtualKeyCode) key;
					break;
				case Control.MoveLeft:
					LJoystickLeft = (VirtualKeyCode) key;
					break;
				case Control.MoveRight:
					LJoystickRight = (VirtualKeyCode) key;
					break;
				default:
					
					break;
			}
		}

		public bool isKeyDown(Control control)
		{
			_controller.GetState(out var state);
			int y = state.Gamepad.LeftThumbY / MovementDivider; ;
			int x = state.Gamepad.LeftThumbX / MovementDivider;
			switch (control)
			{
				case Control.MoveUp:
					return (Math.Abs(y) > Math.Abs(x) && y > 2);
					break;

				case Control.MoveDown:
					return (Math.Abs(y) > Math.Abs(x) && y < -2);
					break;

				case Control.MoveLeft:
					return (Math.Abs(x) > Math.Abs(y) && x < -2);
					break;

				case Control.MoveRight:
					return (Math.Abs(x) > Math.Abs(y) && x > 2);
					break;

				case Control.AttackInteract:
					return state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.A);

				case Control.Block:
					return state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.B);
					
				case Control.AutoTarget:
					return state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.X);

				case Control.PickUp:
					return state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.Y);
					
				case Control.Hotkey1:
					return state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.DPadDown);
					
				case Control.Hotkey2:
					return state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.DPadLeft);
					
				case Control.Hotkey3:
					return state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.DPadUp);
					
				case Control.Hotkey4:
					return state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.DPadRight);
					
				case Control.OpenSettings:
					return state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.);

				default:
					return false;
					break;
			}
		}
	}
}