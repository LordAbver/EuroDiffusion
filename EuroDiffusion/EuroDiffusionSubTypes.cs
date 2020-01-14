using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EuroDiffusion
{
  public enum MsgTypes
  {
     Error,
     Informational
  }
  
  public struct Captions
  {
      public const string ErrorCaption = "Error!";
      public const string InfoCaption = "Information";
  }

  public struct AppConsts
  {
      public const string OutputFileName = "output.txt";  
  }
}
