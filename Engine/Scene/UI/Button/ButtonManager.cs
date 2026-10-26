using System;
using Raylib_cs;
using GraphicWrapper;

public class ButtonManager
{
  public enum ButtonSignals
  {
    ChangeSceneSignal,
    OkaySignal,
    CancelSignal,
    QuitSignal,
  }

  bool ChangeSceneSignalistrue (ButtonSignals.ChangeSceneSignal) = false;
  bool OkaySingalistrue (ButtonSignals.OkaySignal) = false;
  bool CancelSignalistrue (ButtonSignal.CancelSignal) = false;
