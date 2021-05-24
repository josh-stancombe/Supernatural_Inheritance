// Pupil.cs
using System;

namespace MagicalInheritance
{
  class Pupil{
    public string Title { get; private set; }
    
    public Pupil(string Title){
      this.Title = Title;
    }

    public Storm CastWindStorm(){
      return new Storm("wind", false, Title);
    }
  }
}
