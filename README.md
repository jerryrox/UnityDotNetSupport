# UnityDotNetSupport

UnityDotNetSupport is a small library aimed to provide missing .Net classes in Unity's version.  
Simply download the source code and extract the script file into your project.  

### Included
* WeakReference<T> (in System.Collections.Generic)
* Tuple (in System)

### Limitations
A lot of classes and namespaces included in latest mono does not exist in Unity and therefore, these custom scripts are designed to provide a similar (but not the same) experience which may not fully meet your requirements.

#### WeakReference<T>
Apparently, there is a type-parameterless WeakReference class in System namespace so this custom implementation was made over that class instead of having it worked from scratch.  
Though it's unknown whether this method provides the same flawless experience compared to the original implementation.

#### Tuple
Currently, this script contains Tuples with upto 3 type parameters only.  
If you need more parameter count, simply refer to the mono's implementation from [here](https://github.com/mono/mono/blob/ec78917e102e421e911d311b17f2412c11ab2859/mcs/class/referencesource/mscorlib/system/tuple.cs).  
Just follow their implementation pattern then you're most likely good to go.  
