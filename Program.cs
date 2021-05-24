using System;

namespace MagicalInheritance
{
  class Program
  {
    static void Main(string[] args)
    {
      // Storm Class Testing
      Storm June = new Storm("wind", false, "Radagast");
      June.Announce();

      // Pupil Class Testing
      Pupil Gandalf = new Pupil("Gandalf");
      Storm gandalf = Gandalf.CastWindStorm();
      gandalf.Announce();

      // Mage Class Testing
      Mage mage = new Mage("Sauroman");
      Storm sauroman = mage.CastRainStorm();
      sauroman.Announce();

      // Archmage Class Testing
      Archmage archmage = new Archmage("Sauron");
      Storm sauron1 = archmage.CastRainStorm();
      Storm sauron2 = archmage.CastLightningStorm();
      sauron1.Announce();
      sauron2.Announce();
      
    }
  }
}