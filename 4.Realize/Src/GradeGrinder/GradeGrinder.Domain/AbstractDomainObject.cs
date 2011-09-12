namespace GradeGrinder.Domain
{
    /// <summary>
    /// For a discussion of this object, see 
    /// http://devlicio.us/blogs/billy_mccafferty/archive/2007/04/25/using-equals-gethashcode-effectively.aspx
    /// </summary>
    public abstract class AbstractDomainObject<TId>
    {
        public const string PropertyNameId = "Id";
        private TId id = default(TId);

        /// <summary>
        /// Id kann von beliebigem Typ sein (int, string, custom type, ...).
        /// Die Setter-Methode ist protected, um Unit-Tests zu ermöglichen, die Property via Reflection zu setzen.
        /// </summary>
        public virtual TId Id
        {
            get { return id; }
            protected set { id = value; }
        }

        public static string GetPropertyId(string propertyName)
        {
            return propertyName + "." + PropertyNameId;
        }

        public virtual bool Equals(object obj)
        {
            AbstractDomainObject<TId> compareTo = obj as AbstractDomainObject<TId>;

            return (compareTo != null) &&
                   (HasSameNonDefaultIdAs(compareTo) ||
                // Since the Ids aren't the same, either of them must be transient to 
                // compare business value signatures
                    (((IsTransient()) || compareTo.IsTransient()) &&
                     HasSameBusinessSignatureAs(compareTo)));
        }

        /// <summary>
        /// Transiente Objekte sind nicht mit einem Datenbankobjekt verbunden.
        /// Beispiel: Ein Objekt mit einer Id vom Typ int ist transient, wenn seine Id 0 ist.
        /// </summary>
        public virtual bool IsTransient()
        {
            return Id == null || Id.Equals(default(TId));
        }

        /// <summary>
        /// Diese Methode muss von einem abgeleiteten Domain-Objekt implementiert werden, um zwei Objekte miteinandern
        /// vergleichen zu können.
        /// </summary>
        public abstract override int GetHashCode();

        private bool HasSameBusinessSignatureAs(AbstractDomainObject<TId> compareTo)
        {
            return this.GetHashCode().Equals(compareTo.GetHashCode());
        }

        /// <summary>
        /// Returns true if self and the provided persistent object have the same Id values 
        /// and the Ids are not of the default Id value
        /// </summary>
        private bool HasSameNonDefaultIdAs(AbstractDomainObject<TId> compareTo)
        {
            return (Id != null && !Id.Equals(default(TId))) &&
                   (compareTo.Id != null && !compareTo.Id.Equals(default(TId))) &&
                   Id.Equals(compareTo.Id);
        }
    }
}
