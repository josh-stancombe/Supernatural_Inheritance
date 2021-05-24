// Mage.cs
using System;

namespace MagicalInheritance
{
  class Mage : Pupil {
    public Mage(string arg) : base(arg){
    }
    public virtual Storm CastRainStorm(){
      return new Storm("rain", false, Title);
    }
  } 
}
