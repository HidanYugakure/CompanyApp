namespace CompanyApp.Helpers
{
    public class Class1
    {
        public class Helpers
        {
            public static void changeTextColor(string word, ConsoleColor consoleColor)
            {
                Console.ForegroundColor = consoleColor;
                Console.WriteLine(word);
                Console.ResetColor();
            }
        }
        public enum Menus
        {
            createStudent = 1,
            getAllStudents,
            getAllStudentsWithName,
            getStudentById,
            DeleteStudent,
            UpdateStudent,
            CreateGroup,
            getAllGroups,
            getAllStudentsWithGroupName,
            UpdateGroup,
            deleteGroup
        }
    }

}

