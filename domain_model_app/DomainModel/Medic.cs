using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    [Table("Medic")]
    public class Medic
    {
        [Key]
        private int _medicID;

        [ForeignKey("User")]
        private int _userID;

        private User _medicData;

        [ForeignKey("Authentication")]
        private int _authenticationID;

        private Authentication _authenticationData;

        private string _rotation;

        private int _semester;



        public Medic()
        {

        }

        public int MedicID { get => _medicID; set => _medicID = value; }
        public User MedicData { get => _medicData; set => _medicData = value; }
        public Authentication AuthenticationData { get => _authenticationData; set => _authenticationData = value; }
        public string Rotation { get => _rotation; set => _rotation = value; }
        public int Semester { get => _semester; set => _semester = value; }
        public int UserID { get => _userID; set => _userID = value; }
        public int AuthenticationID { get => _authenticationID; set => _authenticationID = value; }
    }
}
