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

		private static List<Control> listeMenus;
		private void InitListeMenus()
        {
			listeMenus = new List<Control>();
			listeMenus.Add(Control.OpenInventory);
			listeMenus.Add(Control.OpenSpells);
			listeMenus.Add(Control.OpenCharacterInfo);
			listeMenus.Add(Control.OpenQuests);
			listeMenus.Add(Control.OpenFriends);
			listeMenus.Add(Control.OpenGuild);
			listeMenus.Add(Control.OpenParties);
		}

		public static Dictionary<Control, string> GamepadMapping;
		public void ResetDefaultMapping()
        {
			GamepadMapping = new Dictionary<Control, string>();
			GamepadMapping[Control.MoveUp] = "LUp";
			GamepadMapping[Control.MoveDown] = "LDown";
			GamepadMapping[Control.MoveLeft] = "LLeft";
			GamepadMapping[Control.MoveRight] = "LRight";
			GamepadMapping[Control.AttackInteract] = "A";
			GamepadMapping[Control.Block] = "B";
			GamepadMapping[Control.AutoTarget] = "X";
			GamepadMapping[Control.PickUp] = "Y";
			GamepadMapping[Control.Hotkey1] = "DPadDown";
			GamepadMapping[Control.Hotkey2] = "DPadLeft";
			GamepadMapping[Control.Hotkey3] = "DPadUp";
			GamepadMapping[Control.Hotkey4] = "DPadRight";
			GamepadMapping[Control.Hotkey5] = "RDown";
			GamepadMapping[Control.Hotkey6] = "RLeft";
			GamepadMapping[Control.Hotkey7] = "RUp";
			GamepadMapping[Control.Hotkey8] = "RRight";
			GamepadMapping[Control.Hotkey9] = "LBumper";//Cette touche sert à circuler entre les menus <--
			GamepadMapping[Control.Hotkey0] = "RBumper";//Cette touche sert à circuler entre les menus -->
			GamepadMapping[Control.Screenshot] = "Start";
			GamepadMapping[Control.OpenSettings] = "Back";
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

		/// <summary>
		/// Tu fournis en argument le control, et en sortie on te dit si la touche associée est appuyée ou non
		/// </summary>
		private bool ControlKeyDown(Control control, State state)
        {
			int Ly = state.Gamepad.LeftThumbY / MovementDivider;
			int Lx = state.Gamepad.LeftThumbX / MovementDivider;

			int Ry = state.Gamepad.RightThumbY / MovementDivider;
			int Rx = state.Gamepad.RightThumbX / MovementDivider;

			string GamepadKeyString = GamepadMapping[control];
			switch (GamepadKeyString)
            {
				case "LUp":
					return (Math.Abs(Ly) > Math.Abs(Lx) && Ly > seuilJoysticks);

				case "LDown":
					return (Math.Abs(Ly) > Math.Abs(Lx) && Ly < -seuilJoysticks);
					break;

				case "LLeft":
					return (Math.Abs(Lx) > Math.Abs(Ly) && Lx < -seuilJoysticks);
					break;

				case "LRight":
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

				case "RDown":
					return (Math.Abs(Ry) > Math.Abs(Rx) && Ry > seuilJoysticks);

				case "RLeft":
					return (Math.Abs(Rx) > Math.Abs(Ry) && Rx < -seuilJoysticks);

				case "RUp":
					return (Math.Abs(Ry) > Math.Abs(Rx) && Ry < -seuilJoysticks);

				case "RRight":
					return (Math.Abs(Rx) > Math.Abs(Ry) && Rx > seuilJoysticks);

				case "Start":
					return state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.Start);

				case "Back":
					return state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.Back);

				case "LBumper":
					return (state.Gamepad.LeftTrigger > seuilBumpers);

				case "RBumper":
					return (state.Gamepad.RightTrigger > seuilBumpers);

				case "LShoulder":
					return (state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.LeftShoulder));

				case "RShoulder":
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
			return ( ControlKeyDown(Control.OpenSettings, state) && !ControlKeyDown(Control.OpenSettings, LastState) );
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
		public Control AreSwitchMenuKeysUptoDown(State LastState, Control lastControl, bool Reafficher)
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
				return Control.Block;
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
            

			return Control.Block;
        }

		/// <summary>
		/// Cette fonction va donner en sortie tous les controls associés aux boutons appuyés sur la manette
		/// pas utile j'pense
		/// </summary>
		/// <returns></returns>
		public List<Control> GetGamepadControls()
        {
			List<Control> listeControls = new List<Control>();
			_controller.GetState(out var state);

			if( state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.X) )
            {
				listeControls.Add(Control.AutoTarget);
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