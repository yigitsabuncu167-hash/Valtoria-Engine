namespace GraphicWrapper
{
  public class GraphicWrapper
  {
    
    //Image loading functions
    public static Image LoadImage( string filename)
    {
      return Raylib.LoadImage(string filename);
    }
    
    public static Image LoadImageRaw(string filename,int width,int height,int format,int headersize);
    {
      return  Raylib.LoadImageRaw(string string filename,width,height,format,headersize);
    }
    
    public static Image LoadImageAnim(string filename,int frames);
    {
      return  Raylib.LoadImageAnim(filename,frames);
    }
    
    public static Image LoadImageAnimFromMemory(string filetype,string filedata,int datasize,int frames);
    {
      return Raylib.LoadImageAnimFromMemory(filetype,filedata,datasize,frames);
    }

    public static Image LoadImageFromMemory(string filetype,string filedata,int datasize)
    {
      return Raylib.LoadImageFromMemory(filetype,filedata,datasize);
    }

    public static Image LoadImageFromTexture(Texture2D texture)
    {
      return Raylib.LoadImage(texture);
    }

    public static Image LoadImageFromScreen()
    {
      return Raylib.LoadImage();
    }

    public static bool IsImageValid(Image image)
    {
      return Raylib.LoadImage(image);
    }
    
    public static void UnloadImagee(Image image)
    {
      Raylib.LoadImage(image);
    }

    public void ExportImage(Image image,string filename)
    {
      return Raylib.LoadImage(filename,image);
    }
