
using System.Windows.Resources;

namespace Hospital_System.Utils
{
    public static class ExceptionMessages
    {
        public const string UserNotFound = "User doesn't exist!";
        public const string NoUsersExist = "There are no uesrs yet!";
        public const string UserAlreadyExist = "There is already such a user!";
        public const string AppointmentNotFound = "Appointment doesn't exist!";
        public const string PatientNotFound = "Patient doesn't exist!";
        public const string DoctorNotFound = "Doctor doesn't exist!";
        public const string HospitalNotFound = "Hospital doesn't exist!";
        public const string HospitalCreationProblem = "Problem occured while creating hospidal!";
        public const string RoleNotFound = "Role doesn't exist!";
        public const string InvalidLogin = "Invalid login. Please enter your data!";
        public const string InvlidRole = "Such role doesn't exist";
        public const string InvalidAppointmentStatus = "Such status doesn't exist";
        public const string SpecializationAlreadyExist = "This doctor already has a specialization";
        public const string RoleRequestError = "Error occured while requesting a role.";
        public const string InvalidRoleIDd = "Invalid role id is requested";
    }
}
