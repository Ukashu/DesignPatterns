using System.Collections.Generic;
using System.Text;

namespace DesignPatternsExercises.Creational.Builder
{
    class Class
    {
        public string Name { get; set; }
        public string AccessModifier { get; set; }
 
        public readonly List<Field> fields = new List<Field>();

        private const int indentFieldSize = 2;

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"{AccessModifier} class {Name}");
            sb.AppendLine("{");

            foreach (var field in fields)
                sb.AppendLine(new string(' ', indentFieldSize) + field.ToString());

            sb.AppendLine("}");

            return sb.ToString();
        }
    }
}
