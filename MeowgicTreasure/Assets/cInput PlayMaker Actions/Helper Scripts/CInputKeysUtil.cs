/// <summary>Easy access to KeyCode strings required by cInput</summary>
public class CInputKeysUtil {

    public static string GetStringForKey(CInputKeys key)
    {
     
        #region Keyboard input values

        #region Numbers
        switch(key)
        {
            case CInputKeys.Alpha0: return "Alpha0"; break;
            case CInputKeys.Alpha1 : return "Alpha1"; break;
            case CInputKeys.Alpha2 : return "Alpha2"; break;
            case CInputKeys.Alpha3 : return "Alpha3"; break;
            case CInputKeys.Alpha4 : return "Alpha4"; break;
            case CInputKeys.Alpha5 : return "Alpha5"; break;
            case CInputKeys.Alpha6 : return "Alpha6"; break;
            case CInputKeys.Alpha7 : return "Alpha7"; break;
            case CInputKeys.Alpha8 : return "Alpha8"; break;
            case CInputKeys.Alpha9 : return "Alpha9"; break;

            #endregion //Numbers

            #region English alphabet

            case CInputKeys.A : return "A"; break;
            case CInputKeys.B : return "B"; break;
            case CInputKeys.C : return "C"; break;
            case CInputKeys.D : return "D"; break;
            case CInputKeys.E : return "E"; break;
            case CInputKeys.F : return "F"; break;
            case CInputKeys.G : return "G"; break;
            case CInputKeys.H : return "H"; break;
            case CInputKeys.I : return "I"; break;
            case CInputKeys.J : return "J"; break;
            case CInputKeys.K : return "K"; break;
            case CInputKeys.L : return "L"; break;
            case CInputKeys.M : return "M"; break;
            case CInputKeys.N : return "N"; break;
            case CInputKeys.O : return "O"; break;
            case CInputKeys.P : return "P"; break;
            case CInputKeys.Q : return "Q"; break;
            case CInputKeys.R : return "R"; break;
            case CInputKeys.S : return "S"; break;
            case CInputKeys.T : return "T"; break;
            case CInputKeys.U : return "U"; break;
            case CInputKeys.V : return "V"; break;
            case CInputKeys.W : return "W"; break;
            case CInputKeys.X : return "X"; break;
            case CInputKeys.Y : return "Y"; break;
            case CInputKeys.Z : return "Z"; break;

            #endregion //English alphabet

            #region Function keys

            case CInputKeys.F1 : return "F1"; break;
            case CInputKeys.F2 : return "F2"; break;
            case CInputKeys.F3 : return "F3"; break;
            case CInputKeys.F4 : return "F4"; break;
            case CInputKeys.F5 : return "F5"; break;
            case CInputKeys.F6 : return "F6"; break;
            case CInputKeys.F7 : return "F7"; break;
            case CInputKeys.F8 : return "F8"; break;
            case CInputKeys.F9 : return "F9"; break;
            case CInputKeys.F10 : return "F10"; break;
            case CInputKeys.F11 : return "F11"; break;
            case CInputKeys.F12 : return "F12"; break;
            case CInputKeys.F13 : return "F13"; break;
            case CInputKeys.F14 : return "F14"; break;
            case CInputKeys.F15 : return "F15"; break;

            #endregion //Function keys

            #region Keypad (Numpad) keys

            case CInputKeys.Keypad0 : return "Keypad0"; break;
            case CInputKeys.Keypad1 : return "Keypad1"; break;
            case CInputKeys.Keypad2 : return "Keypad2"; break;
            case CInputKeys.Keypad3 : return "Keypad3"; break;
            case CInputKeys.Keypad4 : return "Keypad4"; break;
            case CInputKeys.Keypad5 : return "Keypad5"; break;
            case CInputKeys.Keypad6 : return "Keypad6"; break;
            case CInputKeys.Keypad7 : return "Keypad7"; break;
            case CInputKeys.Keypad8 : return "Keypad8"; break;
            case CInputKeys.Keypad9 : return "Keypad9"; break;
            /// <summary>Alternative for and equivalent to Keys.KeypadMultiply</summary>
            case CInputKeys.KeypadAsterisk : return "KeypadMultiply"; break;
            case CInputKeys.KeypadDivide : return "KeypadDivide"; break;
            case CInputKeys.KeypadEnter : return "KeypadEnter"; break;
            case CInputKeys.KeypadEquals : return "KeypadEquals"; break;
            case CInputKeys.KeypadMinus : return "KeypadMinus"; break;
            case CInputKeys.KeypadMultiply : return "KeypadMultiply"; break;
            case CInputKeys.KeypadPeriod : return "KeypadPeriod"; break;
            case CInputKeys.KeypadPlus : return "KeypadPlus"; break;
            /// <summary>Alternative for and equivalent to Keys.KeypadDivide</summary>
            case CInputKeys.KeypadSlash : return "KeypadDivide"; break;

            #endregion //Keypad (Numpad) keys

            #region Other keys

            case CInputKeys.None : return "None"; break;
            case CInputKeys.AltGr : return "AltGr"; break;
            case CInputKeys.Ampersand : return "Ampersand"; break;
            /// <summary>Alternative for and equivalent to Keys.Quote</summary>
            case CInputKeys.Apostrophe : return "Quote"; break;
            /// <summary>Alternative for and equivalent to Keys.DownArrow</summary>
            case CInputKeys.ArrowDown : return "DownArrow"; break;
            /// <summary>Alternative for and equivalent to Keys.LeftArrow</summary>
            case CInputKeys.ArrowLeft : return "LeftArrow"; break;
            /// <summary>Alternative for and equivalent to Keys.RightArrow</summary>
            case CInputKeys.ArrowRight : return "RightArrow"; break;
            /// <summary>Alternative for and equivalent to Keys.UpArrow</summary>
            case CInputKeys.ArrowUp : return "UpArrow"; break;
            case CInputKeys.Asterisk : return "Asterisk"; break;
            case CInputKeys.AtSymbol : return "At"; break;
            case CInputKeys.BackQuote : return "BackQuote"; break;
            case CInputKeys.Backslash : return "Backslash"; break;
            case CInputKeys.Backspace : return "Backspace"; break;
            case CInputKeys.Break : return "Break"; break;
            case CInputKeys.CapsLock : return "CapsLock"; break;
            case CInputKeys.Caret : return "Caret"; break;
            case CInputKeys.Clear : return "Clear"; break;
            case CInputKeys.Colon : return "Colon"; break;
            case CInputKeys.Comma : return "Comma"; break;
            case CInputKeys.Delete : return "Delete"; break;
            case CInputKeys.Dollar : return "Dollar"; break;
            case CInputKeys.DoubleQuote : return "DoubleQuote"; break;
            case CInputKeys.DownArrow : return "DownArrow"; break;
            case CInputKeys.End : return "End"; break;
            /// <summary>Alternative for and equivalent to Keys.Return</summary>
            case CInputKeys.Enter : return "Return"; break;
            case CInputKeys.EqualSign : return "Equals"; break;
            case CInputKeys.Escape : return "Escape"; break;
            case CInputKeys.Exclaim : return "Exclaim"; break;
            /// <summary>Alternative for and equivalent to Keys.Exclaim</summary>
            case CInputKeys.ExclamationMark : return "Exclaim"; break;
            /// <summary>Alternative for and equivalent to Keys.Slash</summary>
            case CInputKeys.ForwardSlash : return "Slash"; break;
            /// <summary>Alternative for and equivalent to Keys.Greater</summary>
            case CInputKeys.GreaterThan : return "Greater"; break;
            case CInputKeys.Greater : return "Greater"; break;
            case CInputKeys.Hash : return "Hash"; break;
            case CInputKeys.Help : return "Help"; break;
            case CInputKeys.Home : return "Home"; break;
            case CInputKeys.Insert : return "Insert"; break;
            case CInputKeys.LeftAlt : return "LeftAlt"; break;
            case CInputKeys.LeftApple : return "LeftApple"; break;
            case CInputKeys.LeftArrow : return "LeftArrow"; break;
            case CInputKeys.LeftBracket : return "LeftBracket"; break;
            case CInputKeys.LeftControl : return "LeftControl"; break;
            case CInputKeys.LeftParen : return "LeftParen"; break;
            case CInputKeys.LeftShift : return "LeftShift"; break;
            case CInputKeys.LeftWindows : return "LeftWindows"; break;
            case CInputKeys.Less : return "Less"; break;
            /// <summary>Alternative for and equivalent to Keys.Less</summary>
            case CInputKeys.LessThan : return "Less"; break;
            case CInputKeys.Menu : return "Menu"; break;
            case CInputKeys.Minus : return "Minus"; break;
            /// <summary>Alternative for and equivalent to Keys.Greater</summary>
            case CInputKeys.MoreThan : return "Greater"; break;
            /// <summary>Alternative for and equivalent to Keys.Hash</summary>
            case CInputKeys.NumberSign : return "Hash"; break;
            case CInputKeys.Numlock : return "Numlock"; break;
            case CInputKeys.PageDown : return "PageDown"; break;
            case CInputKeys.PageUp : return "PageUp"; break;
            case CInputKeys.Pause : return "Pause"; break;
            case CInputKeys.Period : return "Period"; break;
            case CInputKeys.Plus : return "Plus"; break;
            /// <summary>Alternative for and equivalent to Keys.Hash</summary>
            case CInputKeys.PoundSign : return "Hash"; break;
            case CInputKeys.Print : return "Print"; break;
            /// <summary>Alternative for and equivalent to Keys.Question</summary>
            case CInputKeys.QuestionMark : return "Question"; break;
            case CInputKeys.Question : return "Question"; break;
            /// <summary>This is a single quote (apostrophe). For double quotes; break; use Keys.DoubleQuote.</summary>
            case CInputKeys.Quote : return "Quote"; break;
            case CInputKeys.Return : return "Return"; break;
            case CInputKeys.RightAlt : return "RightAlt"; break;
            case CInputKeys.RightApple : return "RightApple"; break;
            case CInputKeys.RightArrow : return "RightArrow"; break;
            case CInputKeys.RightBracket : return "RightBracket"; break;
            case CInputKeys.RightControl : return "RightControl"; break;
            case CInputKeys.RightParen : return "RightParen"; break;
            case CInputKeys.RightShift : return "RightShift"; break;
            case CInputKeys.RightWindows : return "RightWindows"; break;
            case CInputKeys.ScrollLock : return "ScrollLock"; break;
            case CInputKeys.Semicolon : return "Semicolon"; break;
            case CInputKeys.Slash : return "Slash"; break;
            case CInputKeys.Space : return "Space"; break;
            case CInputKeys.SysReq : return "SysReq"; break;
            case CInputKeys.Tab : return "Tab"; break;
            case CInputKeys.Underscore : return "Underscore"; break;
            case CInputKeys.UpArrow : return "UpArrow"; break;

            #endregion //Other keys

            #endregion //Keyboard input values

            #region Mouse input values

            case CInputKeys.Mouse0 : return "Mouse0"; break;
            case CInputKeys.Mouse1 : return "Mouse1"; break;
            case CInputKeys.Mouse2 : return "Mouse2"; break;
            case CInputKeys.Mouse3 : return "Mouse3"; break;
            case CInputKeys.Mouse4 : return "Mouse4"; break;
            case CInputKeys.Mouse5 : return "Mouse5"; break;
            case CInputKeys.Mouse6 : return "Mouse6"; break;
            case CInputKeys.MouseUp : return "Mouse Up"; break;
            case CInputKeys.MouseDown : return "Mouse Down"; break;
            case CInputKeys.MouseLeft : return "Mouse Left"; break;
            case CInputKeys.MouseRight : return "Mouse Right"; break;
            case CInputKeys.MouseWheelUp : return "Mouse Wheel Up"; break;
            case CInputKeys.MouseWheelDown : return "Mouse Wheel Down"; break;

            #endregion //Mouse input values

            #region Gamepad values

            #region Gamepad buttons

            case CInputKeys.JoystickButton0 : return "JoystickButton0"; break;
            case CInputKeys.JoystickButton1 : return "JoystickButton1"; break;
            case CInputKeys.JoystickButton2 : return "JoystickButton2"; break;
            case CInputKeys.JoystickButton3 : return "JoystickButton3"; break;
            case CInputKeys.JoystickButton4 : return "JoystickButton4"; break;
            case CInputKeys.JoystickButton5 : return "JoystickButton5"; break;
            case CInputKeys.JoystickButton6 : return "JoystickButton6"; break;
            case CInputKeys.JoystickButton7 : return "JoystickButton7"; break;
            case CInputKeys.JoystickButton8 : return "JoystickButton8"; break;
            case CInputKeys.JoystickButton9 : return "JoystickButton9"; break;
            case CInputKeys.JoystickButton10 : return "JoystickButton10"; break;
            case CInputKeys.JoystickButton11 : return "JoystickButton11"; break;
            case CInputKeys.JoystickButton12 : return "JoystickButton12"; break;
            case CInputKeys.JoystickButton13 : return "JoystickButton13"; break;
            case CInputKeys.JoystickButton14 : return "JoystickButton14"; break;
            case CInputKeys.JoystickButton15 : return "JoystickButton15"; break;
            case CInputKeys.JoystickButton16 : return "JoystickButton16"; break;
            case CInputKeys.JoystickButton17 : return "JoystickButton17"; break;
            case CInputKeys.JoystickButton18 : return "JoystickButton18"; break;
            case CInputKeys.JoystickButton19 : return "JoystickButton19"; break;
            case CInputKeys.Joystick1Button0 : return "Joystick1Button0"; break;
            case CInputKeys.Joystick1Button1 : return "Joystick1Button1"; break;
            case CInputKeys.Joystick1Button2 : return "Joystick1Button2"; break;
            case CInputKeys.Joystick1Button3 : return "Joystick1Button3"; break;
            case CInputKeys.Joystick1Button4 : return "Joystick1Button4"; break;
            case CInputKeys.Joystick1Button5 : return "Joystick1Button5"; break;
            case CInputKeys.Joystick1Button6 : return "Joystick1Button6"; break;
            case CInputKeys.Joystick1Button7 : return "Joystick1Button7"; break;
            case CInputKeys.Joystick1Button8 : return "Joystick1Button8"; break;
            case CInputKeys.Joystick1Button9 : return "Joystick1Button9"; break;
            case CInputKeys.Joystick1Button10 : return "Joystick1Button10"; break;
            case CInputKeys.Joystick1Button11 : return "Joystick1Button11"; break;
            case CInputKeys.Joystick1Button12 : return "Joystick1Button12"; break;
            case CInputKeys.Joystick1Button13 : return "Joystick1Button13"; break;
            case CInputKeys.Joystick1Button14 : return "Joystick1Button14"; break;
            case CInputKeys.Joystick1Button15 : return "Joystick1Button15"; break;
            case CInputKeys.Joystick1Button16 : return "Joystick1Button16"; break;
            case CInputKeys.Joystick1Button17 : return "Joystick1Button17"; break;
            case CInputKeys.Joystick1Button18 : return "Joystick1Button18"; break;
            case CInputKeys.Joystick1Button19 : return "Joystick1Button19"; break;
            case CInputKeys.Joystick2Button0 : return "Joystick2Button0"; break;
            case CInputKeys.Joystick2Button1 : return "Joystick2Button1"; break;
            case CInputKeys.Joystick2Button2 : return "Joystick2Button2"; break;
            case CInputKeys.Joystick2Button3 : return "Joystick2Button3"; break;
            case CInputKeys.Joystick2Button4 : return "Joystick2Button4"; break;
            case CInputKeys.Joystick2Button5 : return "Joystick2Button5"; break;
            case CInputKeys.Joystick2Button6 : return "Joystick2Button6"; break;
            case CInputKeys.Joystick2Button7 : return "Joystick2Button7"; break;
            case CInputKeys.Joystick2Button8 : return "Joystick2Button8"; break;
            case CInputKeys.Joystick2Button9 : return "Joystick2Button9"; break;
            case CInputKeys.Joystick2Button10 : return "Joystick2Button10"; break;
            case CInputKeys.Joystick2Button11 : return "Joystick2Button11"; break;
            case CInputKeys.Joystick2Button12 : return "Joystick2Button12"; break;
            case CInputKeys.Joystick2Button13 : return "Joystick2Button13"; break;
            case CInputKeys.Joystick2Button14 : return "Joystick2Button14"; break;
            case CInputKeys.Joystick2Button15 : return "Joystick2Button15"; break;
            case CInputKeys.Joystick2Button16 : return "Joystick2Button16"; break;
            case CInputKeys.Joystick2Button17 : return "Joystick2Button17"; break;
            case CInputKeys.Joystick2Button18 : return "Joystick2Button18"; break;
            case CInputKeys.Joystick2Button19 : return "Joystick2Button19"; break;
            case CInputKeys.Joystick3Button0 : return "Joystick3Button0"; break;
            case CInputKeys.Joystick3Button1 : return "Joystick3Button1"; break;
            case CInputKeys.Joystick3Button2 : return "Joystick3Button2"; break;
            case CInputKeys.Joystick3Button3 : return "Joystick3Button3"; break;
            case CInputKeys.Joystick3Button4 : return "Joystick3Button4"; break;
            case CInputKeys.Joystick3Button5 : return "Joystick3Button5"; break;
            case CInputKeys.Joystick3Button6 : return "Joystick3Button6"; break;
            case CInputKeys.Joystick3Button7 : return "Joystick3Button7"; break;
            case CInputKeys.Joystick3Button8 : return "Joystick3Button8"; break;
            case CInputKeys.Joystick3Button9 : return "Joystick3Button9"; break;
            case CInputKeys.Joystick3Button10 : return "Joystick3Button10"; break;
            case CInputKeys.Joystick3Button11 : return "Joystick3Button11"; break;
            case CInputKeys.Joystick3Button12 : return "Joystick3Button12"; break;
            case CInputKeys.Joystick3Button13 : return "Joystick3Button13"; break;
            case CInputKeys.Joystick3Button14 : return "Joystick3Button14"; break;
            case CInputKeys.Joystick3Button15 : return "Joystick3Button15"; break;
            case CInputKeys.Joystick3Button16 : return "Joystick3Button16"; break;
            case CInputKeys.Joystick3Button17 : return "Joystick3Button17"; break;
            case CInputKeys.Joystick3Button18 : return "Joystick3Button18"; break;
            case CInputKeys.Joystick3Button19 : return "Joystick3Button19"; break;
            case CInputKeys.Joystick4Button0 : return "Joystick4Button0"; break;
            case CInputKeys.Joystick4Button1 : return "Joystick4Button1"; break;
            case CInputKeys.Joystick4Button2 : return "Joystick4Button2"; break;
            case CInputKeys.Joystick4Button3 : return "Joystick4Button3"; break;
            case CInputKeys.Joystick4Button4 : return "Joystick4Button4"; break;
            case CInputKeys.Joystick4Button5 : return "Joystick4Button5"; break;
            case CInputKeys.Joystick4Button6 : return "Joystick4Button6"; break;
            case CInputKeys.Joystick4Button7 : return "Joystick4Button7"; break;
            case CInputKeys.Joystick4Button8 : return "Joystick4Button8"; break;
            case CInputKeys.Joystick4Button9 : return "Joystick4Button9"; break;
            case CInputKeys.Joystick4Button10 : return "Joystick4Button10"; break;
            case CInputKeys.Joystick4Button11 : return "Joystick4Button11"; break;
            case CInputKeys.Joystick4Button12 : return "Joystick4Button12"; break;
            case CInputKeys.Joystick4Button13 : return "Joystick4Button13"; break;
            case CInputKeys.Joystick4Button14 : return "Joystick4Button14"; break;
            case CInputKeys.Joystick4Button15 : return "Joystick4Button15"; break;
            case CInputKeys.Joystick4Button16 : return "Joystick4Button16"; break;
            case CInputKeys.Joystick4Button17 : return "Joystick4Button17"; break;
            case CInputKeys.Joystick4Button18 : return "Joystick4Button18"; break;
            case CInputKeys.Joystick4Button19 : return "Joystick4Button19"; break;

            #endregion //Gamepad buttons

            #region Gamepad axes

            #region Xbox triggers

            /// <summary>This is the same as Joy1Axis9Positive</summary>
            case CInputKeys.Xbox1TriggerLeft : return "Joy1 Axis 9+"; break;
            /// <summary>This is the same as Joy1Axis10Positive</summary>
            case CInputKeys.Xbox1TriggerRight : return "Joy1 Axis 10+"; break;
            /// <summary>This is the same as Joy2Axis9Positive</summary>
            case CInputKeys.Xbox2TriggerLeft : return "Joy2 Axis 9+"; break;
            /// <summary>This is the same as Joy2Axis10Positive</summary>
            case CInputKeys.Xbox2TriggerRight : return "Joy2 Axis 10+"; break;
            /// <summary>This is the same as Joy3Axis9Positive</summary>
            case CInputKeys.Xbox3TriggerLeft : return "Joy3 Axis 9+"; break;
            /// <summary>This is the same as Joy3Axis10Positive</summary>
            case CInputKeys.Xbox3TriggerRight : return "Joy3 Axis 10+"; break;
            /// <summary>This is the same as Joy4Axis9Positive</summary>
            case CInputKeys.Xbox4TriggerLeft : return "Joy4 Axis 9+"; break;
            /// <summary>This is the same as Joy4Axis10Positive</summary>
            case CInputKeys.Xbox4TriggerRight : return "Joy4 Axis 10+"; break;

            #endregion //Xbox triggers

            case CInputKeys.Joy1Axis1Negative : return "Joy1 Axis 1-"; break;
            case CInputKeys.Joy1Axis1Positive : return "Joy1 Axis 1+"; break;
            case CInputKeys.Joy1Axis2Negative : return "Joy1 Axis 2-"; break;
            case CInputKeys.Joy1Axis2Positive : return "Joy1 Axis 2+"; break;
            case CInputKeys.Joy1Axis3Negative : return "Joy1 Axis 3-"; break;
            case CInputKeys.Joy1Axis3Positive : return "Joy1 Axis 3+"; break;
            case CInputKeys.Joy1Axis4Negative : return "Joy1 Axis 4-"; break;
            case CInputKeys.Joy1Axis4Positive : return "Joy1 Axis 4+"; break;
            case CInputKeys.Joy1Axis5Negative : return "Joy1 Axis 5-"; break;
            case CInputKeys.Joy1Axis5Positive : return "Joy1 Axis 5+"; break;
            case CInputKeys.Joy1Axis6Negative : return "Joy1 Axis 6-"; break;
            case CInputKeys.Joy1Axis6Positive : return "Joy1 Axis 6+"; break;
            case CInputKeys.Joy1Axis7Negative : return "Joy1 Axis 7-"; break;
            case CInputKeys.Joy1Axis7Positive : return "Joy1 Axis 7+"; break;
            case CInputKeys.Joy1Axis8Negative : return "Joy1 Axis 8-"; break;
            case CInputKeys.Joy1Axis8Positive : return "Joy1 Axis 8+"; break;
            case CInputKeys.Joy1Axis9Negative : return "Joy1 Axis 9-"; break;
            case CInputKeys.Joy1Axis9Positive : return "Joy1 Axis 9+"; break;
            case CInputKeys.Joy1Axis10Negative : return "Joy1 Axis 10-"; break;
            case CInputKeys.Joy1Axis10Positive : return "Joy1 Axis 10+"; break;
            case CInputKeys.Joy2Axis1Negative : return "Joy2 Axis 1-"; break;
            case CInputKeys.Joy2Axis1Positive : return "Joy2 Axis 1+"; break;
            case CInputKeys.Joy2Axis2Negative : return "Joy2 Axis 2-"; break;
            case CInputKeys.Joy2Axis2Positive : return "Joy2 Axis 2+"; break;
            case CInputKeys.Joy2Axis3Negative : return "Joy2 Axis 3-"; break;
            case CInputKeys.Joy2Axis3Positive : return "Joy2 Axis 3+"; break;
            case CInputKeys.Joy2Axis4Negative : return "Joy2 Axis 4-"; break;
            case CInputKeys.Joy2Axis4Positive : return "Joy2 Axis 4+"; break;
            case CInputKeys.Joy2Axis5Negative : return "Joy2 Axis 5-"; break;
            case CInputKeys.Joy2Axis5Positive : return "Joy2 Axis 5+"; break;
            case CInputKeys.Joy2Axis6Negative : return "Joy2 Axis 6-"; break;
            case CInputKeys.Joy2Axis6Positive : return "Joy2 Axis 6+"; break;
            case CInputKeys.Joy2Axis7Negative : return "Joy2 Axis 7-"; break;
            case CInputKeys.Joy2Axis7Positive : return "Joy2 Axis 7+"; break;
            case CInputKeys.Joy2Axis8Negative : return "Joy2 Axis 8-"; break;
            case CInputKeys.Joy2Axis8Positive : return "Joy2 Axis 8+"; break;
            case CInputKeys.Joy2Axis9Negative : return "Joy2 Axis 9-"; break;
            case CInputKeys.Joy2Axis9Positive : return "Joy2 Axis 9+"; break;
            case CInputKeys.Joy2Axis10Negative : return "Joy2 Axis 10-"; break;
            case CInputKeys.Joy2Axis10Positive : return "Joy2 Axis 10+"; break;
            case CInputKeys.Joy3Axis1Negative : return "Joy3 Axis 1-"; break;
            case CInputKeys.Joy3Axis1Positive : return "Joy3 Axis 1+"; break;
            case CInputKeys.Joy3Axis2Negative : return "Joy3 Axis 2-"; break;
            case CInputKeys.Joy3Axis2Positive : return "Joy3 Axis 2+"; break;
            case CInputKeys.Joy3Axis3Negative : return "Joy3 Axis 3-"; break;
            case CInputKeys.Joy3Axis3Positive : return "Joy3 Axis 3+"; break;
            case CInputKeys.Joy3Axis4Negative : return "Joy3 Axis 4-"; break;
            case CInputKeys.Joy3Axis4Positive : return "Joy3 Axis 4+"; break;
            case CInputKeys.Joy3Axis5Negative : return "Joy3 Axis 5-"; break;
            case CInputKeys.Joy3Axis5Positive : return "Joy3 Axis 5+"; break;
            case CInputKeys.Joy3Axis6Negative : return "Joy3 Axis 6-"; break;
            case CInputKeys.Joy3Axis6Positive : return "Joy3 Axis 6+"; break;
            case CInputKeys.Joy3Axis7Negative : return "Joy3 Axis 7-"; break;
            case CInputKeys.Joy3Axis7Positive : return "Joy3 Axis 7+"; break;
            case CInputKeys.Joy3Axis8Negative : return "Joy3 Axis 8-"; break;
            case CInputKeys.Joy3Axis8Positive : return "Joy3 Axis 8+"; break;
            case CInputKeys.Joy3Axis9Negative : return "Joy3 Axis 9-"; break;
            case CInputKeys.Joy3Axis9Positive : return "Joy3 Axis 9+"; break;
            case CInputKeys.Joy3Axis10Negative : return "Joy3 Axis 10-"; break;
            case CInputKeys.Joy3Axis10Positive : return "Joy3 Axis 10+"; break;
            case CInputKeys.Joy4Axis1Negative : return "Joy4 Axis 1-"; break;
            case CInputKeys.Joy4Axis1Positive : return "Joy4 Axis 1+"; break;
            case CInputKeys.Joy4Axis2Negative : return "Joy4 Axis 2-"; break;
            case CInputKeys.Joy4Axis2Positive : return "Joy4 Axis 2+"; break;
            case CInputKeys.Joy4Axis3Negative : return "Joy4 Axis 3-"; break;
            case CInputKeys.Joy4Axis3Positive : return "Joy4 Axis 3+"; break;
            case CInputKeys.Joy4Axis4Negative : return "Joy4 Axis 4-"; break;
            case CInputKeys.Joy4Axis4Positive : return "Joy4 Axis 4+"; break;
            case CInputKeys.Joy4Axis5Negative : return "Joy4 Axis 5-"; break;
            case CInputKeys.Joy4Axis5Positive : return "Joy4 Axis 5+"; break;
            case CInputKeys.Joy4Axis6Negative : return "Joy4 Axis 6-"; break;
            case CInputKeys.Joy4Axis6Positive : return "Joy4 Axis 6+"; break;
            case CInputKeys.Joy4Axis7Negative : return "Joy4 Axis 7-"; break;
            case CInputKeys.Joy4Axis7Positive : return "Joy4 Axis 7+"; break;
            case CInputKeys.Joy4Axis8Negative : return "Joy4 Axis 8-"; break;
            case CInputKeys.Joy4Axis8Positive : return "Joy4 Axis 8+"; break;
            case CInputKeys.Joy4Axis9Negative : return "Joy4 Axis 9-"; break;
            case CInputKeys.Joy4Axis9Positive : return "Joy4 Axis 9+"; break;
            case CInputKeys.Joy4Axis10Negative : return "Joy4 Axis 10-"; break;
            case CInputKeys.Joy4Axis10Positive : return "Joy4 Axis 10+"; break;

            default: return "None"; break;
            #endregion //Gamepad axes

            #endregion //Gamepad values
        }
    }

}
