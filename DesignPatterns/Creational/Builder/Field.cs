namespace DesignPatternsExercises.Creational.Builder
{
    public class Field
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string AccessModifier { get; set; }

        public override string ToString()
        {
            return $"{AccessModifier} {Type} {Name};";
        }
    }
}
