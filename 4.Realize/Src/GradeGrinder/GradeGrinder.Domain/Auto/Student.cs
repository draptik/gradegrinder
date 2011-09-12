using System;

namespace GradeGrinder.Domain.Auto
{
    [Serializable]
    public class Student : AbstractDomainObject<long?>
    {
        #region Konstanten mit den Namen der Klasse und aller Properties

        public const string CLASSNAME = "Student";
        public const string PROP_FIRSTNAME = "FirstName";
        public const string PROP_LASTNAME = "LastName";
        public const string PROP_CREATEDAT = "CreatedAt";
        public const string PROP_LASTCHANGED = "LastChanged";
        #endregion

        #region Konstruktoren

        /// ------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Default-Konstruktor.
        ///</summary>
        /// <remarks>
        /// Wird von Hibernate benötigt!
        ///</remarks>
        /// ------------------------------------------------------------------------------------------------------------
        public Student()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            CreatedAt = default(DateTime?);
            LastChanged = default(DateTime?);
        }

        #endregion

        /// ------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Liefert einen Hashcode für dieses User-Objekt.
        ///</summary>
        /// ------------------------------------------------------------------------------------------------------------
        public override int GetHashCode()
        {
            int result = GetType().FullName.GetHashCode();
            result = result + 29 * (FirstName == null ? 0 : FirstName.GetHashCode());
            result = result + 29 * (LastName == null ? 0 : LastName.GetHashCode());
            result = result + 29 * (!CreatedAt.HasValue ? 0 : CreatedAt.GetHashCode());
            result = result + 29 * (!LastChanged.HasValue ? 0 : LastChanged.GetHashCode());
            return result;
        }

        #region Properties

        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual DateTime? CreatedAt { get; set; }
        public virtual DateTime? LastChanged { get; set; }

        #endregion

        /// ------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Liefert eine String-Repäsentation des inneren Zustandes dieses Objektes.
        /// </summary>
        /// ------------------------------------------------------------------------------------------------------------
        public override string ToString()
        {
            return ToString(null);
        }

        public virtual string ToString(string info)
        {
            string result = GetType()
            + ", Hash = " + GetHashCode().ToString("X")
            + ", Id = " + ((!Id.HasValue) ? "NULL" : Id.ToString())
            + ((info == null) ? "" : ", " + info);

            return result;
        }

    }
}
