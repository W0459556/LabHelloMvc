namespace HelloMvc.Models
{
    public class Person
    {
        public required int PersonID { get; set; }
        /* you dont have 'required' but vscode was underlining it yellow
        and told me to do it. and i dont like when they have yellow
        underlines so i did it. lol */
        public required string FirstName { get; set; }
         public required string MiddleName { get; set; }
        public required string LastName { get; set; }
    }
}