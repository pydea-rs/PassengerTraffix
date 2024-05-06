using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BehComponents;

namespace PassengerTraffix
{
    class Passenger
    { 
        public Passenger(string firstname, string lastname, string nationalID, string phonenumber,
            string targetUnit, short closetNumber, string vehicleModel, Plate plate, PersianDateTime date,
            short hour, short minute, bool entering)
        {
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.NationalID = nationalID;
            this.Plate = plate;
            this.ClosetNumber = closetNumber;
            this.Time = new TimeSpan(hour, minute, 0);
            this.Entering = entering;
            this.Date = new PersianDateTime(date.Year, date.Month, date.Day);
            this.VehicleModel = vehicleModel;
            this.Phonenumber = phonenumber;
            this.TargetUnit = targetUnit;
            this.Id = 0;
        }

        public long Id { get; set; }
        public string TargetUnit { get; set; }

        public short ClosetNumber { get; set; }

        public string VehicleModel { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string NationalID { get; set; }

        public Plate Plate { get; set; }

        public PersianDateTime Date { get; set; }

        public TimeSpan Time { get; set; }

        public bool Entering { get; set; }

        public string Phonenumber { get; set; }

        public string ToString()
        {
            // TODO: complete this
            return this.VehicleModel != "" || this.Plate != null ? string.Format("{0} به شماره ملی {1} صاحب وسیله نقلیه {2} به پلاک {3}", 
                this.Fullname, this.NationalID, this.VehicleModel, this.Plate.ToString()) :
                string.Format("{0} به شماره ملی {1}", this.Fullname, this.NationalID);
        }

        public string Fullname
        {
            get
            {
                return string.Format("{0} {1}", this.Firstname.Trim(), this.Lastname.Trim());
            }
        }

    }
}
