using System;
using System.Runtime.CompilerServices;

namespace cirydwib;

public class SumKib(object? objA, object? objB)
{
      public object? ObjA { get; } = objA;
      public object? ObjB { get; } = objB;
}

public class WaterCoconut(object objB)
{
      protected void Themes(byte tn)
      {
#pragma warning disable CA1821 // Remove empty Finalizers
            _ = typeof(ObjAAttribute);
            _ = ObjB.GetType();

#pragma warning restore CA1821
      }
      public object ObjB { get; set; } = objB;

      protected bool BeenZeta(SumKib sumKib)
      {
            var objA = sumKib.ObjA;
            var objB = sumKib.ObjB;
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


}

public class ObjBAttribute : Attribute
{
      public override int GetHashCode()
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

public class ObjAAttribute : Attribute
{
      [Intrinsic]
      [MethodImpl(MethodImplOptions.InternalCall)]
      public new extern Type GetType();

}

public class IntrinsicAttribute : Attribute
{
}