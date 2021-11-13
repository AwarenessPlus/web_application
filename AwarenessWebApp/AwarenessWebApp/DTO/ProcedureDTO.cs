using System;
using System.ComponentModel.DataAnnotations;

namespace AwarenessWebApp.DTO
{
    public class ProcedureDTO
    {
        private int _medicID;
        [Required]
        private string _procedureName;
        [Required]
        private string _patientStatus;
        [Required]
        private int _asa;
        [Required]
        private int _patientID;
        [Required]
        private int _patientAge;
        public PatientDTO PatientInfo;
        private DateTime _procedureDate;
        private int _procedureID;
        public string ProcedureName { get => _procedureName; set => _procedureName = value; }
        public string PatientStatus { get => _patientStatus; set => _patientStatus = value; }
        public int Asa { get => _asa; set => _asa = value; }
        public int PatientID { get => _patientID; set => _patientID = value; }
        public int MedicID { get => _medicID; set => _medicID = value; }
        public int PatientAge { get => _patientAge; set => _patientAge = value; }
        public DateTime ProcedureDate { get => _procedureDate; set => _procedureDate = value; }
        public int ProcedureID { get => _procedureID; set => _procedureID = value; }
        public ProcedureDTO()
        {
            this.PatientInfo = new();
        }

        public override string ToString()
        {
            return "[ProcedureName]: " + ProcedureName + " [PatientStatus]: " + PatientStatus + " [Asa]: " + Asa + " [PatientID]: " + PatientID + " [MedicID]: " + MedicID + " [PatientAge]: " + PatientAge + " [ProcedureDate]: " + ProcedureDate + " [Patient]: " + PatientInfo.ToString();
        }
    }
}