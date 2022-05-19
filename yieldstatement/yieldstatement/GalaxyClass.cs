using System;

namespace yieldstatement
{
    public static class GalaxyClass
    {
        public static void ShowGalaxies()
        {
            var theGalaxies = new Galaxies();
            foreach (Galaxy theGalaxy in theGalaxies.NextGalaxy)
            {
                Console.WriteLine(theGalaxy.Name + " - " + theGalaxy.SizeInLightYears.ToString("###,##0"));
            }
        }

        public class Galaxies
        {
            private Galaxy[] galaxies = new Galaxy[] {
                new Galaxy { Name = "Pegasus", SizeInLightYears = 77000 },
                new Galaxy { Name = "Pinwheel", SizeInLightYears = 170000 },    
                new Galaxy { Name = "Milky Way", SizeInLightYears = 200000 },
                new Galaxy { Name = "Andromeda", SizeInLightYears = 220000 } };

            private int counter = 0;

            public System.Collections.Generic.IEnumerable<Galaxy> NextGalaxy
            {
                get
                {
                    foreach (var galaxy in galaxies)
                    {
                        yield return galaxy;
                    }
                }
            }
        }

        public class Galaxy
        {
            public String Name { get; set; }
            public int SizeInLightYears { get; set; }
        }
    }
}
