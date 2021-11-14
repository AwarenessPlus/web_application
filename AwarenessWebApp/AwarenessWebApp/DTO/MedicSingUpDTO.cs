using System;
using System.ComponentModel.DataAnnotations;

namespace AwarenessWebApp.DTO
{
    public class MedicSignUpDTO
    {
        [Required]
        private string _firstName;
        [Required]
        private string _lastName;
        [Required]
        private DateTime _birthDate;
        [Required]
        private int _semester;
        [Required]
        private string _rotation;
        [Required]
        private AuthDTO authentication;

        public MedicSignUpDTO()
        {
            this.authentication = new();
        }

        public MedicSignUpDTO(string firstName, string lastName, DateTime birthDate, int semester, string rotation, AuthDTO authentication)
        {
            _firstName = firstName;
            _lastName = lastName;
            _birthDate = birthDate;
            _semester = semester;
            _rotation = rotation;
            this.authentication = authentication;
        }

        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public int Semester { get => _semester; set => _semester = value; }
        public string Rotation { get => _rotation; set => _rotation = value; }
        public AuthDTO Authentication { get => authentication; set => authentication = value; }
        public DateTime BirthDate { get => _birthDate; set => _birthDate = value; }
    }
}