using System;

namespace Attributes
{
    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Interface 
        | AttributeTargets.Enum | AttributeTargets.Method, AllowMultiple = true)]
    public class Version : Attribute
    {
        #region Fields

        private uint major;
        private uint minor;

        #endregion

        #region Constructors

        public Version(uint major, uint minor)
        {
            this.Major = major;
            this.Minor = minor;
        }

        #endregion

        #region Properties

        public uint Major
        {
            get { return this.major; }
            set { this.major = value; }
        }

        public uint Minor
        {
            get { return this.minor; }
            set { this.minor = value; }
        }

        #endregion

        #region Methods

        public override string ToString()
        {
            return string.Format("{0}.{1}", this.Major, this.Minor);
        }

        #endregion
    }
}
