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
			GamepadMapping[ControlGamepad.Screenshot] = null;
			GamepadMapping[ControlGamepad.OpenSettings] = "Start";
			GamepadMapping[ControlGamepad.OpenMenu] = null;
			GamepadMapping[ControlGamepad.OpenInventory] = null;
			GamepadMapping[ControlGamepad.OpenQuests] = null;
			GamepadMapping[ControlGamepad.OpenCharacterInfo] = null;
			GamepadMapping[ControlGamepad.OpenParties] = null;
			GamepadMapping[ControlGamepad.OpenSpells] = null;
			GamepadMapping[ControlGamepad.OpenGuild] = null;
			GamepadMapping[ControlGamepad.OpenFriends] = null;
		}
		public void assignationMapping(ControlGamepad control, string toucheGamepad)
        {
			GamepadMapping[control] = toucheGamepad;
		}
		public Dictionary<ControlGamepad, string> getGamepadMapping()
        {
			return GamepadMapping;
        }
		public string getButtonOfControl(ControlGamepad control)
        {
			return GamepadMapping[control];
        }
		public ControlGamepad getControlOfButton (string bouton)
        {
			foreach (ControlGamepad control in Enum.GetValues(typeof(ControlGamepad)))
            {
				if (GamepadMapping[control].Equals(bouton))
                {
					return control;
                }
            }
			return 0;
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
			bool LBumper = state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.LeftShoulder);
			bool RBumper = state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.RightShoulder);
			bool DPadDown = state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.DPadDown);
			bool DPadLeft = state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.DPadLeft);
			bool DPadUp = state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.DPadUp);
			bool DPadRight = state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.DPadRight);

			//Check des bumpers
			var lastLeft = lastState.Gamepad.LeftTrigger;
			var lastRight = lastState.Gamepad.RightTrigger;
			var newLeft = state.Gamepad.LeftTrigger;
			var newRight = state.Gamepad.RightTrigger;
			bool isLeftUpToDown = (lastLeft < seuilBumpers) && (newLeft > seuilBumpers);
			bool isRightUpToDown = (lastRight < seuilBumpers) && (newRight > seuilBumpers);

			int Ly = state.Gamepad.LeftThumbY / MovementDivider;
			int Lylast = lastState.Gamepad.RightThumbY / MovementDivider;
			int Lx = state.Gamepad.LeftThumbX / MovementDivider;
			int Lxlast = lastState.Gamepad.RightThumbX / MovementDivider;
			bool isLeftJoystickUsed = (Ly > seuilJoysticks && Lylast < seuilJoysticks) | (Lx > seuilJoysticks && Lxlast < seuilJoysticks);


			int Ry = state.Gamepad.RightThumbY / MovementDivider;
			int Rylast = lastState.Gamepad.RightThumbY / MovementDivider;
			int Rx = state.Gamepad.RightThumbX / MovementDivider;
			int Rxlast = lastState.Gamepad.RightThumbX / MovementDivider;
			bool isRightJoystickUsed = (Ry > seuilJoysticks && Rxlast < seuilJoysticks) | (Rx > seuilJoysticks && Rylast < seuilJoysticks);

			return (a || b || x || y || start || back || isLeftUpToDown || isRightUpToDown || isLeftJoystickUsed || isRightJoystickUsed || LBumper || RBumper || DPadDown || DPadLeft || DPadUp || DPadRight);
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
			return ControlKeyDown(ControlGamepad.OpenMenu, state);
		}

		public bool IsBlockKeyUptoDown(State LastState)
        {
			_controller.GetState(out var state);
			return (ControlKeyDown(ControlGamepad.Block, state) && !ControlKeyDown(ControlGamepad.Block, LastState));
		}

		public bool IsAutotargetKeyUptoDown(State LastState)
		{
			_controller.GetState(out var state);
			return (ControlKeyDown(ControlGamepad.AutoTarget, state) && !ControlKeyDown(ControlGamepad.AutoTarget, LastState));
		}

		public bool IsPickupKeyUptoDown(State LastState)
		{
			_controller.GetState(out var state);
			return (ControlKeyDown(ControlGamepad.PickUp, state) && !ControlKeyDown(ControlGamepad.PickUp, LastState));
		}

		//Ouverture des menus :
		public bool IsOpenInventoryKeyUptoDown (State LastState)
        {
			_controller.GetState(out var state);
			return (ControlKeyDown(ControlGamepad.OpenInventory, state) && !ControlKeyDown(ControlGamepad.OpenInventory, LastState));
		}

		public bool IsOpenQuestsKeyUptoDown(State LastState)
		{
			_controller.GetState(out var state);
			return (ControlKeyDown(ControlGamepad.OpenQuests, state) && !ControlKeyDown(ControlGamepad.OpenQuests, LastState));
		}

		public bool IsOpenCharacterInfoKeyUptoDown(State LastState)
		{
			_controller.GetState(out var state);
			return (ControlKeyDown(ControlGamepad.OpenCharacterInfo, state) && !ControlKeyDown(ControlGamepad.OpenCharacterInfo, LastState));
		}

		public bool IsOpenPartiesKeyUptoDown(State LastState)
		{
			_controller.GetState(out var state);
			return (ControlKeyDown(ControlGamepad.OpenParties, state) && !ControlKeyDown(ControlGamepad.OpenParties, LastState));
		}

		public bool IsOpenSpellsKeyUptoDown(State LastState)
		{
			_controller.GetState(out var state);
			return (ControlKeyDown(ControlGamepad.OpenSpells, state) && !ControlKeyDown(ControlGamepad.OpenSpells, LastState));
		}

		public bool IsOpenFriendsKeyUptoDown(State LastState)
		{
			_controller.GetState(out var state);
			return (ControlKeyDown(ControlGamepad.OpenFriends, state) && !ControlKeyDown(ControlGamepad.OpenFriends, LastState));
		}

		public bool IsOpenOpenGuildKeyUptoDown(State LastState)
		{
			_controller.GetState(out var state);
			return (ControlKeyDown(ControlGamepad.OpenGuild, state) && !ControlKeyDown(ControlGamepad.OpenGuild, LastState));
		}

		/// <summary>
		/// Ici ça va checker si un des bumpers est actionné et ça va envoyer à quel menu switcher
		/// Si aucun bumper n'est actionné / y'a une erreur alors on renvoie Control.Block
		/// </summary>
		public ControlGamepad AreSwitchMenuKeysUptoDown(State LastState, ControlGamepad lastControl, bool Reafficher)
        {
			_controller.GetState(out var state);

			bool isLeftUpToDown = (ControlKeyDown(ControlGamepad.SwitchMenuLeft, state) && !ControlKeyDown(ControlGamepad.SwitchMenuLeft, LastState));
			bool isRightUpToDown = (ControlKeyDown(ControlGamepad.SwitchMenuRight, state) && !ControlKeyDown(ControlGamepad.SwitchMenuRight, LastState));

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

		//------------- Intéragit avec le fichier controls.cs
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
					return ControlKeyDown(ControlGamepad.MoveUp, state);
					break;

				case Control.MoveDown:
					return ControlKeyDown(ControlGamepad.MoveDown, state);
					break;

				case Control.MoveLeft:
					return ControlKeyDown(ControlGamepad.MoveLeft, state);
					break;

				case Control.MoveRight:
					return ControlKeyDown(ControlGamepad.MoveRight, state);
					break;

				case Control.AttackInteract:
					return ControlKeyDown(ControlGamepad.AttackInteract, state);
					
				case Control.Hotkey1:
					return ControlKeyDown(ControlGamepad.Hotkey1, state);
					
				case Control.Hotkey2:
					return ControlKeyDown(ControlGamepad.Hotkey2, state);
					
				case Control.Hotkey3:
					return ControlKeyDown(ControlGamepad.Hotkey3, state);
					
				case Control.Hotkey4:
					return ControlKeyDown(ControlGamepad.Hotkey4, state);

				case Control.Hotkey5:
					return ControlKeyDown(ControlGamepad.Hotkey5, state);

				case Control.Hotkey6:
					return ControlKeyDown(ControlGamepad.Hotkey6, state);

				case Control.Hotkey7:
					return ControlKeyDown(ControlGamepad.Hotkey7, state);

				case Control.Hotkey8:
					return ControlKeyDown(ControlGamepad.Hotkey8, state);

				case Control.Hotkey9:
					return ControlKeyDown(ControlGamepad.Hotkey9, state);

				case Control.Hotkey0:
					return ControlKeyDown(ControlGamepad.Hotkey0, state);

				default:
					return false;
					break;
			}
		}

		// Intéragit avec OptionWindow.cs 
		public bool SaveKey(ControlGamepad controlAModifier)
        {
			_controller.GetState(out var state);
			int Ly = state.Gamepad.LeftThumbY / MovementDivider;
			int Lx = state.Gamepad.LeftThumbX / MovementDivider;

			int Ry = state.Gamepad.RightThumbY / MovementDivider;
			int Rx = state.Gamepad.RightThumbX / MovementDivider;

			ControlGamepad controlAModifierConsequence;
			string stringBoutonChoisi = getButtonOfControl(controlAModifier);
			string stringBoutonConsequence;

			if (Math.Abs(Ly) > Math.Abs(Lx) && Ly > seuilJoysticks)
            {
				stringBoutonConsequence = "LJoystickUp";
			} else if (Math.Abs(Ly) > Math.Abs(Lx) && Ly < -seuilJoysticks)
			{
				stringBoutonConsequence = "LJoystickDown";
			} else if (Math.Abs(Lx) > Math.Abs(Ly) && Lx < -seuilJoysticks)
            {
				stringBoutonConsequence = "LJoystickLeft";
			} else if (Math.Abs(Lx) > Math.Abs(Ly) && Lx > seuilJoysticks)
			{
				stringBoutonConsequence = "LJoystickRight";
			} else if (state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.A))
            {
				stringBoutonConsequence = "A";
			} else if (state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.B))
            {
				stringBoutonConsequence = "B";
			} else if (state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.X))
            {
				stringBoutonConsequence = "X";
			} else if (state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.Y))
            {
				stringBoutonConsequence = "Y";
			} else if (state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.DPadDown))
            {
				stringBoutonConsequence = "DPadDown";
			} else if (state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.DPadLeft))
            {
				stringBoutonConsequence = "DPadLeft";
			} else if(state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.DPadUp))
            {
				stringBoutonConsequence = "DPadUp";
			} else if (state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.DPadRight))
            {
				stringBoutonConsequence = "DPadRight";
			} else if (Math.Abs(Ry) > Math.Abs(Rx) && Ry > seuilJoysticks)
            {
				stringBoutonConsequence = "RJoystickDown";
			} else if (Math.Abs(Rx) > Math.Abs(Ry) && Rx < -seuilJoysticks)
            {
				stringBoutonConsequence = "RJoystickLeft";
			} else if (Math.Abs(Ry) > Math.Abs(Rx) && Ry < -seuilJoysticks)
            {
				stringBoutonConsequence = "RJoystickUp";
			} else if (Math.Abs(Rx) > Math.Abs(Ry) && Rx > seuilJoysticks)
            {
				stringBoutonConsequence = "RJoystickRight";
			} else if (state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.Start))
            {
				stringBoutonConsequence = "Start";
			} else if (state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.Back))
            {
				stringBoutonConsequence = "Back";
			} else if (state.Gamepad.LeftTrigger > seuilBumpers)
            {
				stringBoutonConsequence = "LTrigger";
			} else if (state.Gamepad.RightTrigger > seuilBumpers)
            {
				stringBoutonConsequence = "RTrigger";
			} else if (state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.LeftShoulder))
            {
				stringBoutonConsequence = "LBumper";
			} else if (state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.RightShoulder))
            {
				stringBoutonConsequence = "RBumper";
			} else
            {
				return false;
            }

			controlAModifierConsequence = getControlOfButton(stringBoutonConsequence); //On enregistre le controle qui était associé à la touche qu'on a press

			GamepadMapping[controlAModifier] = stringBoutonConsequence;
			GamepadMapping[controlAModifierConsequence] = stringBoutonChoisi;

			return true;
        }
	}
}