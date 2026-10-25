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
        Raylib.DrawRectangle((int)x,(int)y,(int)width,(int)height,TopColor); // 100 x kordinatu 50 y kordinatı 200 genişlok 80 yukseklik
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
  int x { get; set; }
  int y { get; set; }

  //Button ScaleSettings
  int width { get; set; } = 60 ;
  int height { get; set; } = 60 ;
}
