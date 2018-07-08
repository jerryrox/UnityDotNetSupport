# UnityTuple

UnityTuple is a tiny library with a single script file that allows using Tuple in Unity.
  Simply download the source code and extract the script file into your project.
  Currently, this script only includes Tuple type with up to 3 type parameters only. If you need more parameter count, see "Extending" section below.

### How to use
To declare Tuple types, simply include the "System" namespace to the script you wish to use in.

### Extending
This script was purely based on the mono project's Tuple script from [here](https://github.com/mono/mono/blob/ec78917e102e421e911d311b17f2412c11ab2859/mcs/class/referencesource/mscorlib/system/tuple.cs).
  Simply follow their implementation pattern then you're most likely good to go.
  However, some interfaces such as ITuple and IStructuralEquatable are not available in Unity's .Net version and therefore, this custom script is designed to provide a similar (but not the same) experience which may not fully meet your requirements.
