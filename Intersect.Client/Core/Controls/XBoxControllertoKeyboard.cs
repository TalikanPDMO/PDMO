using System.Threading;
using SharpDX.XInput;
using System;
using Intersect.Client.Core.Controls;
using System.Collections.Generic;


//Fichier entier codé par Moussmous pour les controles manette
namespace Intersect.Client.Core.Controls
{
	public class XBoxController
	{
		private const int MovementDivider = 2_000;
        private const int RefreshRate = 60;

		private const int seuilBumpers = 150;
		private const int seuilJoysticks = 2;

		private static List<ControlGamepad> listeMenus;
		private void InitListeMenus()
        {
			listeMenus = new List<ControlGamepad>();
			listeMenus.Add(ControlGamepad.OpenInventory);
			listeMenus.Add(ControlGamepad.OpenSpells);
			listeMenus.Add(ControlGamepad.OpenCharacterInfo);
			listeMenus.Add(ControlGamepad.OpenQuests);
			listeMenus.Add(ControlGamepad.OpenFriends);
			listeMenus.Add(ControlGamepad.OpenGuild);
			listeMenus.Add(ControlGamepad.OpenParties);
		}

		public static Dictionary<ControlGamepad, string> GamepadMapping;
		public void ResetDefaultMapping()
        {
			GamepadMapping = new Dictionary<ControlGamepad, string>();
			GamepadMapping[ControlGamepad.MoveUp] = "LJoystickUp";
			GamepadMapping[ControlGamepad.MoveDown] = "LJoystickDown";
			GamepadMapping[ControlGamepad.MoveLeft] = "LJoystickLeft";
			GamepadMapping[ControlGamepad.MoveRight] = "LJoystickRight";
			GamepadMapping[ControlGamepad.AttackInteract] = "A";
			GamepadMapping[ControlGamepad.Block] = "B";
			GamepadMapping[ControlGamepad.AutoTarget] = "X";
			GamepadMapping[ControlGamepad.PickUp] = "Y";
			GamepadMapping[ControlGamepad.Hotkey1] = "DPadDown";
			GamepadMapping[ControlGamepad.Hotkey2] = "DPadLeft";
			GamepadMapping[ControlGamepad.Hotkey3] = "DPadUp";
			GamepadMapping[ControlGamepad.Hotkey4] = "DPadRight";
			GamepadMapping[ControlGamepad.Hotkey5] = "RJoystickDown";
			GamepadMapping[ControlGamepad.Hotkey6] = "RJoystickLeft";
			GamepadMapping[ControlGamepad.Hotkey7] = "RJoystickUp";
			GamepadMapping[ControlGamepad.Hotkey8] = "RJoystickRight";
			GamepadMapping[ControlGamepad.Hotkey9] = null;
			GamepadMapping[ControlGamepad.Hotkey0] = null;
			GamepadMapping[ControlGamepad.SwitchMenuLeft] = "LTrigger";//Cette touche sert à circuler entre les menus <--
			GamepadMapping[ControlGamepad.SwitchMenuRight] = "RTrigger";//Cette touche sert à circuler entre les menus -->
			GamepadMapping[ControlGamepad.Screenshot] = "Start";
			GamepadMapping[ControlGamepad.OpenSettings] = "Back";
			GamepadMapping[ControlGamepad.OpenMenu] = null;
			GamepadMapping[ControlGamepad.OpenInventory] = null;
			GamepadMapping[ControlGamepad.OpenQuests] = null;
			GamepadMapping[ControlGamepad.OpenCharacterInfo] = null;
			GamepadMapping[ControlGamepad.OpenParties] = null;
			GamepadMapping[ControlGamepad.OpenSpells] = null;
			GamepadMapping[ControlGamepad.OpenGuild] = null;
			GamepadMapping[ControlGamepad.OpenFriends] = null;
		}
		public Dictionary<ControlGamepad, string> getGamepadMapping()
        {
			return GamepadMapping;
        }

		private Timer _timer;
		private Controller _controller;


		public XBoxController()
		{
			_controller = new Controller(UserIndex.One);
			_timer = new Timer(obj => Update());

			ResetDefaultMapping();

			InitListeMenus();
		}

		public void Start()
		{
			_timer.Change(0, 1000 / RefreshRate);
		}

		private void Update()
		{
			_controller.GetState(out var state);
		}

		public State getState()
        {
			_controller.GetState(out var state);
			return state;
        }

		/*
		public ControlGamepad ControlToControlGamepad(Control control)
        {
			valeurEntier = (int)control;
			if 
        }*/

		/// <summary>
		/// Tu fournis en argument le control, et en sortie on te dit si la touche associée est appuyée ou non
		/// </summary>
		private bool ControlKeyDown(ControlGamepad control, State state)
        {
			int Ly = state.Gamepad.LeftThumbY / MovementDivider;
			int Lx = state.Gamepad.LeftThumbX / MovementDivider;

			int Ry = state.Gamepad.RightThumbY / MovementDivider;
			int Rx = state.Gamepad.RightThumbX / MovementDivider;

			string GamepadKeyString = GamepadMapping[control];
			switch (GamepadKeyString)
            {
				case "LJoystickUp":
					return (Math.Abs(Ly) > Math.Abs(Lx) && Ly > seuilJoysticks);

				case "LJoystickDown":
					return (Math.Abs(Ly) > Math.Abs(Lx) && Ly < -seuilJoysticks);
					break;

				case "LJoystickLeft":
					return (Math.Abs(Lx) > Math.Abs(Ly) && Lx < -seuilJoysticks);
					break;

				case "LJoystickRight":
					return (Math.Abs(Lx) > Math.Abs(Ly) && Lx > seuilJoysticks);
					break;

				case "A":
					return state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.A);

				case "B":
					return state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.B);

				case "X":
					return state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.X);

				case "Y":
					return state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.Y);

				case "DPadDown":
					return state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.DPadDown);

				case "DPadLeft":
					return state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.DPadLeft);

				case "DPadUp":
					return state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.DPadUp);

				case "DPadRight":
					return state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.DPadRight);

				case "RJoystickDown":
					return (Math.Abs(Ry) > Math.Abs(Rx) && Ry > seuilJoysticks);

				case "RJoystickLeft":
					return (Math.Abs(Rx) > Math.Abs(Ry) && Rx < -seuilJoysticks);

				case "RJoystickUp":
					return (Math.Abs(Ry) > Math.Abs(Rx) && Ry < -seuilJoysticks);

				case "RJoystickRight":
					return (Math.Abs(Rx) > Math.Abs(Ry) && Rx > seuilJoysticks);

				case "Start":
					return state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.Start);

				case "Back":
					return state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.Back);

				case "LTrigger":
					return (state.Gamepad.LeftTrigger > seuilBumpers);

				case "RTrigger":
					return (state.Gamepad.RightTrigger > seuilBumpers);

				case "LBumper":
					return (state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.LeftShoulder));

				case "RBumper":
					return (state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.RightShoulder));
			}

			return false;
        }

		//-------- Ce bloc intéragit avec Monoinput.cs
		/// <summary>
		/// Regarde si une touche du gamepad a été actionnée
		/// </summary>
		/// <param name="lastState">L'état de la manette juste avant</param>
		public bool StateChanged(State lastState)
        {
			_controller.GetState(out var state);
			bool a = state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.A) && !lastState.Gamepad.Buttons.HasFlag(GamepadButtonFlags.A);
			bool b = state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.B) && !lastState.Gamepad.Buttons.HasFlag(GamepadButtonFlags.B);
			bool x = state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.X) && !lastState.Gamepad.Buttons.HasFlag(GamepadButtonFlags.X);
			bool y = state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.Y) && !lastState.Gamepad.Buttons.HasFlag(GamepadButtonFlags.Y);
			bool start = state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.Start) && !lastState.Gamepad.Buttons.HasFlag(GamepadButtonFlags.Start);
			bool back = state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.Back) && !lastState.Gamepad.Buttons.HasFlag(GamepadButtonFlags.Back);

			//Check des bumpers
			var lastLeft = lastState.Gamepad.LeftTrigger;
			var lastRight = lastState.Gamepad.RightTrigger;
			var newLeft = state.Gamepad.LeftTrigger;
			var newRight = state.Gamepad.RightTrigger;
			bool isLeftUpToDown = (lastLeft < seuilBumpers) && (newLeft > seuilBumpers);
			bool isRightUpToDown = (lastRight < seuilBumpers) && (newRight > seuilBumpers);

			int Ly = state.Gamepad.LeftThumbY / MovementDivider;
			int Lx = state.Gamepad.LeftThumbX / MovementDivider;


			int Ry = state.Gamepad.RightThumbY / MovementDivider;
			int Rx = state.Gamepad.RightThumbX / MovementDivider;

			return (a || b || x || y || start || back || isLeftUpToDown || isRightUpToDown);
		}


		//-------- Ce bloc ça intéragit avec input.cs
		public bool IsEscapeKeyUptoDown(State LastState)
		{
			_controller.GetState(out var state);
			return ( ControlKeyDown(ControlGamepad.OpenSettings, state) && !ControlKeyDown(ControlGamepad.OpenSettings, LastState) );
        }

		public bool IsMenuKeyDown()
		{
			_controller.GetState(out var state);
			return state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.Start);
		}

		public bool IsBlockKeyUptoDown(State LastState)
        {
			_controller.GetState(out var state);
			return (state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.B) && !LastState.Gamepad.Buttons.HasFlag(GamepadButtonFlags.B));
		}

		public bool IsAutotargetKeyUptoDown(State LastState)
		{
			_controller.GetState(out var state);
			return (state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.X) && !LastState.Gamepad.Buttons.HasFlag(GamepadButtonFlags.X));
		}

		public bool IsPickupKeyUptoDown(State LastState)
		{
			_controller.GetState(out var state);
			return (state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.Y) && !LastState.Gamepad.Buttons.HasFlag(GamepadButtonFlags.Y));
		}

		/// <summary>
		/// Ici ça va checker si un des bumpers est actionné et ça va envoyer à quel menu switcher
		/// Si aucun bumper n'est actionné / y'a une erreur alors on renvoie Control.Block
		/// </summary>
		public ControlGamepad AreSwitchMenuKeysUptoDown(State LastState, ControlGamepad lastControl, bool Reafficher)
        {
			var lastLeft = LastState.Gamepad.LeftTrigger;
			var lastRight = LastState.Gamepad.RightTrigger;
			_controller.GetState(out var state);
			var newLeft = state.Gamepad.LeftTrigger;
			var newRight = state.Gamepad.RightTrigger;

			bool isLeftUpToDown = (lastLeft < seuilBumpers) && (newLeft > seuilBumpers);
			bool isRightUpToDown = (lastRight < seuilBumpers) && (newRight > seuilBumpers);

			if ( (isLeftUpToDown && isRightUpToDown) || (!isLeftUpToDown && !isRightUpToDown) ) //Au cas où on presse les deux bumpers en même temps
			{
				return ControlGamepad.Block;
			}

			int indexControl = listeMenus.IndexOf(lastControl);
			if (indexControl < 0)
            {
				indexControl = 0;
            }
			
			if (Reafficher)
            {
				return listeMenus[indexControl];
            } else
            {
				if (isLeftUpToDown)
                {
					if (indexControl > 0)
                    {
						return listeMenus[indexControl - 1];
                    }
					else
                    {
						return listeMenus[6];
                    }
                } else if (isRightUpToDown)
                {
					if (indexControl < 6)
					{
						return listeMenus[indexControl + 1];
					}
					else
					{
						return listeMenus[0];
					}
				}
            }
            

			return ControlGamepad.Block;
        }

		/// <summary>
		/// Cette fonction va donner en sortie tous les controls associés aux boutons appuyés sur la manette
		/// pas utile j'pense
		/// </summary>
		/// <returns></returns>
		public List<ControlGamepad> GetGamepadControls()
        {
			List<ControlGamepad> listeControls = new List<ControlGamepad>();
			_controller.GetState(out var state);

			if( state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.X) )
            {
				listeControls.Add(ControlGamepad.AutoTarget);
            }

			return listeControls;
		}

		//------------- Ce qui a après intéragit avec le fichier controls.cs

		public bool isKeyDown(Control control)
		{
			_controller.GetState(out var state);
			int Ly = state.Gamepad.LeftThumbY / MovementDivider;
			int Lx = state.Gamepad.LeftThumbX / MovementDivider;

			int Ry = state.Gamepad.RightThumbY / MovementDivider;
			int Rx = state.Gamepad.RightThumbX / MovementDivider;
			switch (control)
			{
				case Control.MoveUp:
					return (Math.Abs(Ly) > Math.Abs(Lx) && Ly > 2);
					break;

				case Control.MoveDown:
					return (Math.Abs(Ly) > Math.Abs(Lx) && Ly < -2);
					break;

				case Control.MoveLeft:
					return (Math.Abs(Lx) > Math.Abs(Ly) && Lx < -2);
					break;

				case Control.MoveRight:
					return (Math.Abs(Lx) > Math.Abs(Ly) && Lx > 2);
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

				case Control.Hotkey5:
					return (Math.Abs(Ry) > Math.Abs(Rx) && Ry > 2);

				case Control.Hotkey6:
					return (Math.Abs(Rx) > Math.Abs(Ry) && Rx < -2);

				case Control.Hotkey7:
					return (Math.Abs(Ry) > Math.Abs(Rx) && Ry < -2);

				case Control.Hotkey8:
					return (Math.Abs(Rx) > Math.Abs(Ry) && Rx > 2);

				default:
					return false;
					break;
			}
		}
	}
}