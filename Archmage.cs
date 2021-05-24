// Archmage.cs
using System;

namespace MagicalInheritance
{
 class Archmage : Mage {
   public Archmage(string arg) : base(arg){}

    public override Storm CastRainStorm(){
      return new Storm("rain", true, Title);
    }

    public Storm CastLightningStorm(){
      return new Storm("lightning", true, Title);
    }
 }
}
