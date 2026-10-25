using System;
using System.Numerics;
using Raylib_cs;

public class ButtonCreator
{
  public ButtonCreator()
  {
    ButtonName = "onayla";
    ButtonsColorGardient = true;
    ButtonsColorNormal = false;
    TopColor = Color.Green;
    BottomColor = Color.Gray;
    BorderColor = Color.Black;
  } 
  
  public void Draw()
  {
  Raylib.DrawRectangle(100,50,200,80,Color.Blue);
  }
}
  //Button Name
  string ButtonName;

  //ButtonFont
  string ButtonFont { get; set; }
  int fontsize { get; set; }

  //Color Settings
  bool ButtonsColorGardient { get; set; } = true;
  bool ButtonsColorNormal { get; set; } = false;
  Color TopColor { get; set; }
  Color BottomColor { get; set; }
  Color BorderColor { get; set; }
  Color TextColor { get; set; }
  Color TextBorder { get; set; }

  //Locations
  float x { get; set; } = 30;
  float y { get; set; } = 30;

  //Button ScaleSettings
  float width { get; set; } = 60 ;
  float height { get; set; } = 60 ;
