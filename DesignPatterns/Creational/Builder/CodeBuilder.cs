namespace DesignPatternsExercises.Creational.Builder
{
    public class CodeBuilder
    {
        Class theClass = new Class();

        public CodeBuilder(string name, string accessModifier = "public")
        {
            theClass.Name = name;
            theClass.AccessModifier = accessModifier;
        }

        public CodeBuilder AddField(string name, string type, string accessModifier = "public")
        {
            var e = new Field { Name = name, Type = type, AccessModifier = accessModifier };
            theClass.fields.Add((e));
            return this;
        }

        public override string ToString() => theClass.ToString();
    }
}
