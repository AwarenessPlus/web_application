using System;
using System.ComponentModel.DataAnnotations;

namespace AwarenessWebApp.DTO
{
    public class PatientDTO
    {
        private int patientID;
        [Required]
        private string _firstName;
        [Required]
        private string _lastName;
        [Required]
        private DateTime _birthDate;
        [Required]
        private string _bloodGroup;
        [Required]
        private string _rh;
        [Required]
        private string _sex;
        [Required]
        private int? _documentID;
        private int _patientAge;

        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public string BloodGroup { get => _bloodGroup; set => _bloodGroup = value; }
        public string Rh { get => _rh; set => _rh = value; }
        public string Sex { get => _sex; set => _sex = value; }
        public int? DocumentID { get => _documentID; set => _documentID = value; }
        public int PatientID { get => patientID; set => patientID = value; }
        public DateTime BirthDate { get => _birthDate; set => _birthDate = value; }
        public int PatientAge { get => _patientAge; set => _patientAge = value; }

        public override string ToString()
        {
            return "ID: " + patientID.ToString() + " FirstName: " + FirstName + " LastName: " + LastName + " BloodGroup: " + BloodGroup + " RH: " + Rh + " Sex: " + Sex + " DocumentID: " + DocumentID.ToString() + " BirthDate: " + BirthDate.ToString() + " PatientAge: " + PatientAge.ToString();
        }
        public string getFullName()
        {
            return this.FirstName + " " + this.LastName;
        }
    }
}