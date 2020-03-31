//////////////////////////////////////////////////////////////////////////////
/////////// PBW Web Architects, LLC
/////////// Project:
/////////// Ver:
//////////////////////////////////////////////////////////////////////////////
/////////// Architect/ Analyst: Cesar L Diaz
//////////////////////////////////////////////////////////////////////////////
using Newtonsoft.Json;
using System;

namespace CleanArchitecture.Common
{
    public abstract partial class BaseLookEntity : ControlFields, ILookupEntity, IEquatable<BaseLookEntity>
    {
        public byte Id { get; set; }

        public override bool Equals(object obj)
        {
            return Equals(obj as BaseLookEntity);
        }

        private static bool IsTransient(BaseLookEntity obj)
        {
            return obj != null && Equals(obj.Id, default(byte));
        }

        private Type GetUnproxiedType()
        {
            return GetType();
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }

        public virtual bool Equals(BaseLookEntity other)
        {
            if (other == null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            if (!IsTransient(this) &&
                !IsTransient(other) &&
                Equals(Id, other.Id))
            {
                var otherType = other.GetUnproxiedType();
                var thisType = GetUnproxiedType();
                return thisType.IsAssignableFrom(otherType) ||
                        otherType.IsAssignableFrom(thisType);
            }

            return false;
        }

        public override int GetHashCode()
        {
            return Equals(Id, default(int)) ? base.GetHashCode() : Id.GetHashCode();
        }

        public static bool operator ==(BaseLookEntity x, BaseLookEntity y)
        {
            return Equals(x, y);
        }

        public static bool operator !=(BaseLookEntity x, BaseLookEntity y)
        {
            return !(x == y);
        }
    }
}