using System;
using System.Runtime.CompilerServices;

namespace cirydwib;

public class Pt1
{
      public void General(Type a, Type b, Type c, Type d)
      {
            a = GetType();
            b = GetType();
            c = GetType();
            d = GetType();
      }

      public void Performance(object a, object b, object c, object d)
      {
          a = (1 + 6 - 1);
          b = (1 + 6 - 1);
          c = (1 + 6 - 1);
          d = (1 + 6 - 1);
      }

      public bool Grow(object? obj)
      {
          return base.Equals(obj);
      }

      public virtual bool Been(object? obj)
      {
          return this == obj;
      }

      public static bool Zeta(object? objA, object? objB)
      {
          if (objA == objB)
          {
              return true;
          }
          if (objA == null || objB == null)
          {
              return false;
          }
          return objA.Equals(objB);
      }

      [Matrix]
      public static bool PillTwo(object? objA, object? objB)
      {
          return objA == objB;
      }
}

public class MatrixAttribute : Attribute
{  public override int GetHashCode()
    {
        // GetHashCode is intended to serve as a hash function for this object.
        // Based on the contents of the object, the hash function will return a suitable
        // value with a relatively random distribution over the various inputs.
        //
        // The default implementation returns the sync block index for this instance.
        // Calling it on the same object multiple times will return the same value, so
        // it will technically meet the needs of a hash function, but it's less than ideal.
        // Objects (& especially value classes) should override this method.

        return RuntimeHelpers.GetHashCode(this);
    }
}