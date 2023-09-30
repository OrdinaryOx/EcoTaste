namespace Domain.Models {
    public class Student {
        private string name;
        private int studentNumber;
        private DateOnly dateOfBirth;
        private string email;
        private string city;
        private string phone;

        public Student(string name, int studentNumber, DateOnly dateOfBirth, string email, string city, string phone) {
            this.name = name;
            this.studentNumber = studentNumber;
            this.dateOfBirth = dateOfBirth;
            //Check dob not future, older than 16
            
            
            this.email = email;
            this.city = city;
            this.phone = phone;

        }
    }
}