using System;
using Enumerations;

namespace LocationGPS
{
    public struct Location
    {
        #region Fields

        private const int LatitudeMinValue = -90;
        private const int LatitudeMaxValue = 90;
        private const int LongitudeMinvalue = -180;
        private const int LongitudeMaxValue = 180;

        private double latitude;
        private double longitude;
        private Planet planet;

        #endregion

        #region Constructors

        public Location(double latitude, double longitude, Planet planet)
        {
            this.latitude = 0;
            this.longitude = 0;
            this.planet = default(Planet);

            Latitude = latitude;
            Longitude = longitude;
            Planet = planet;
        }

        #endregion

        #region Properties

        public double Latitude
        {
            get { return latitude; }
            set
            {
                if (value < LatitudeMinValue || value > LatitudeMaxValue)
                {
                    throw new ArgumentOutOfRangeException(string.Format("The latitude should be int the range [{0}..{1}].", 
                        LatitudeMinValue, LatitudeMaxValue));
                }
                else
                {
                    latitude = value;
                }
            }
        }

        public double Longitude
        {
            get { return longitude; }
            set
            {
                if (value < LongitudeMinvalue || value > LongitudeMaxValue)
                {
                    throw new ArgumentOutOfRangeException(string.Format("The longitude should be in the range [{0}..{}1].",
                        LatitudeMinValue, LatitudeMaxValue));
                }
                else
                {
                    this.longitude = value;
                }
            }
        }

        public Planet Planet
        {
            get { return planet; }
            set { planet = value; }
        }

        #endregion

        #region Methods

        public override string ToString()
        {
            return string.Format("{0}, {1} - {2}", this.Latitude, this.Longitude, this.Planet);
        }

        #endregion
    }
}
