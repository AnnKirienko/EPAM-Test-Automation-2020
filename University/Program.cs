using System;


namespace University
{
    class Program
    {
        static void Main(string[] args)
        {
          //const int arrayDepartaments = 10;
           
            Adress adres1 = new Adress ("Minsk, ","Nezavisimosti, ","6");
            Adress adres2 = new Adress ("Minsk, ","K. Marksa, ","13");
            Adress adres3 = new Adress ("Minsk, ","Kurchatova, ","5");
            Adress adres4 = new Adress ("Minsk, ","Nezavisimosti, ","8");
            Adress adres5 = new Adress ("Minsk, ","Sovetskaya, ","25");
            Adress adres6 = new Adress ("Minsk, ","Nezavisisti, ","9");
            Adress adres7 = new Adress ("Minsk, ","Druzhnaya, ","54");
            Adress adres8 = new Adress ("Minsk, ","Kovalevskoj, ","96");
            Adress adres9 = new Adress ("Minsk, ","Alibegova, ","4");
            Adress adres10 = new Adress ("Minsk, ","Kurchatova, ","15");
            Adress adres11 = new Adress ("Minsk, ","Nezavisimosti, ","1");

            University university = new University("BSU ", adres11);


            Dekan dekan1 = new Dekan("Ivanov ","Nicolay ",45,"PhD");
            Dekan dekan2 = new Dekan("Kovalev ", "Victor ",54, "Doctor");
            Dekan dekan3 = new Dekan("Antonenko", "Mihail",61, "PhD");

            Manager manager1 = new Manager("Ivanenko ", "Dmitry ",39, 56);
            Manager manager2 = new Manager("Astapenko", "Alla",44, 1589);
            Manager manager3 = new Manager("Tregyb ", "Alexey ",48, 112 );

            Head head1 = new Head("Ostapenko ", "Nikolay ",45, 15 );
            Head head2 = new Head("Gromova ", "Nadezhda ",62, 30 );
            Head head3 = new Head("Manilov ", "Alexandr ",54, 21 );
            Head head4 = new Head("Sorochenko ", "Andrey ",46, 12 );

            Student stud1 = new Student ("Biba","Pupkin", 20,new int[] {4, 4, 5} );
            Student stud2 = new Student("Boba", "Pupkin", 20, new int[] { 10, 4, 6 });
            Student stud3 = new Student("Boba", "Pupkin", 20, new int[] { 10, 4, 6 });

             
            Institute inst1 = new Institute("Institute of Business ",adres2,manager1);
            Institute inst2 = new Institute ("Institute of Teology",adres1,manager2);
            Institute inst3 = new Institute("Institute of Journalistic",adres4,manager3);

            Faculty facult1 = new Faculty("BIO",adres5,dekan1);
            facult1.AddStudent(stud1);
            facult1.AddStudent(stud2);
            facult1.AddStudent(stud3);
            Console.WriteLine(facult1);
            Faculty facult2 = new Faculty("Frfict",adres10,dekan2);
            Faculty facult3 = new Faculty("MMF",adres3,dekan3);

            Staff staff1 = new Staff("Security",adres6,head1);
            Staff staff2 = new Staff("Rectoracy",adres7,head2);
            Staff staff3 = new Staff("Accountantcy",adres8,head3);
            Staff staff4 = new Staff("Service",adres9,head4);

            university.AddDepartament(inst1);
            university.AddDepartament(inst2);
            university.AddDepartament(inst3);
            university.AddDepartament(facult1);
            university.AddDepartament(facult2);
            university.AddDepartament(facult3);
            university.AddDepartament(staff1);
            university.AddDepartament(staff2);
            university.AddDepartament(staff2);
            university.AddDepartament(staff2);
            university.AddDepartament(staff3);
            university.AddDepartament(staff4);

            Console.WriteLine(university);
            

        }
    }
}
