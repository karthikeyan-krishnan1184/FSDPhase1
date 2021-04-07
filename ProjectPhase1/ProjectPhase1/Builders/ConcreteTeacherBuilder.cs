using System;

namespace ProjectPhase1.Builders
{
    public class ConcreteTeacherBuilder : AbstractTeacherBuilder
    {
        protected override void BuildID(Teacher teacher)
        {
            Console.WriteLine("Enter an ID for the teacher");
            var idAsText = Console.ReadLine();
            teacher.ID = int.Parse(idAsText);
        }

        protected override void BuildFirstName(Teacher teacher)
        {
            Console.WriteLine("Enter teacher first name:");           
            teacher.FirstName = Console.ReadLine();
        }      

        protected override void BuildLastName(Teacher teacher)
        {
            Console.WriteLine("Enter teacher last name:");          
            teacher.LastName = Console.ReadLine();

        }
    }
}
