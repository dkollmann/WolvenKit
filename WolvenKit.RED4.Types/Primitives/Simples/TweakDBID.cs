using System;

namespace WolvenKit.RED4.Types
{
    public class TweakDBID : IRedPrimitive, IEquatable<TweakDBID>
    {
        public ulong Value { get; set; }

        public static implicit operator TweakDBID(ulong value) => new() { Value = value };
        public static implicit operator ulong(TweakDBID value) => value.Value;

        public bool Equals(TweakDBID other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return Value == other.Value;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj.GetType() != this.GetType())
            {
                return false;
            }

            return Equals((TweakDBID)obj);
        }

        public override int GetHashCode() => Value.GetHashCode();
    }
}
