using System.Diagnostics;
using copytovsclone;

// Here we have an value type array.

var intArray = new int[] { 1, 2, 3, 4 };
var intArrayCloned = (int[])intArray.Clone();
var intArrayCloned2 = (int[])intArray.Clone();

var intArrayToCopyInto = new int[8];

intArrayCloned.CopyTo(intArrayToCopyInto, 0);
intArrayCloned2.CopyTo(intArrayToCopyInto, 4);

Debug.Assert(String.Join(',', intArrayToCopyInto).Equals(
        String.Join(',', intArrayCloned) + "," + String.Join(',', intArrayCloned2)));

// Here we have an reference type array.

var objArray = new Planet[]
{
    new Planet { Name = "Mercury" },
    new Planet { Name = "Venus" },
    new Planet { Name = "Mars" },
    new Planet { Name = "HR 8799 e" }
};

var objArrayCloned = (Planet[])objArray.Clone();
var objArrayCloned2 = (Planet[])objArray.Clone();

var objArrayToCopyInto = new Planet[8];

objArrayCloned.CopyTo(objArrayToCopyInto, 0);
objArrayCloned2.CopyTo(objArrayToCopyInto, 4);

Debug.Assert(String.Join(',', objArrayToCopyInto.Select(obj => obj.ToString())).Equals(
    String.Join(',', objArrayCloned.Select(obj => obj.ToString()))+
    "," + String.Join(',', objArrayCloned2.Select(obj => obj.ToString()))));

for (int index = 0; index < 8; ++index)
{
    var planet = objArrayToCopyInto[index];
    var planetToCompare = (index < 4) ? objArrayCloned[index] : objArrayCloned2[index - 4];
    Debug.Assert(planet.Equals(planetToCompare));
}
