// Storm.cs
using System;

namespace MagicalInheritance
{
  class Storm {
    public string Essence { get; private set; }
    public bool IsStrong { get; private set; }
    public string Caster { get; private set; }

    public Storm(string essence, bool isStrong, string caster){
      this.Essence = essence;
      this.IsStrong = isStrong;
      this.Caster = caster;
    }

    public void Announce(){
      string strength;
      if (this.IsStrong == true){
        strength = "strong";
      } else {
        strength = "weak";
      }
      Console.WriteLine($"{Caster} cast a {strength} {Essence} storm!");
    }
  }
}
