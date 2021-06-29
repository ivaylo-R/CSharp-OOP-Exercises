using System.Text;
using System.Reflection;
using System.Linq;
using System;

namespace Stealer
{
    public class Spy
    {
        public string StealFieldInfo(string investigatedClass, params string[] requestedFields)
        {
            Type classType = Type.GetType(investigatedClass);
            FieldInfo[] classFields = classType.GetFields(BindingFlags.NonPublic
                | BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static);

            var sb = new StringBuilder();
            object classInstance = Activator.CreateInstance(classType, new object[] { });
            sb.AppendLine($"Class under investigation: {investigatedClass}");
            foreach (FieldInfo field in classFields.Where(f => requestedFields.Contains(f.Name)))
            {
                sb.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
            }

            return sb.ToString();

        }

        public string AnalyzeAcessModifiers(string className)
        {
            var sb = new StringBuilder();
            Type classType = Type.GetType(className);
            FieldInfo[] fields = classType.GetFields(BindingFlags.Public | BindingFlags.Static
                | BindingFlags.Instance);
            MethodInfo[] classPublicMethods = classType.GetMethods(BindingFlags.Public | BindingFlags.Instance);
            MethodInfo[] classNonPublicMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);
            object classInstance = Activator.CreateInstance(classType, new object[] { });
            foreach (FieldInfo field in fields)
            {
                sb.AppendLine($"{field.Name} must be private!");
            }
            foreach (MethodInfo nonPublicMethod in classNonPublicMethods.Where(m => m.Name.StartsWith("get")))
            {
                sb.AppendLine($"{nonPublicMethod.Name} have to be public!");
            }
            foreach (MethodInfo publicMethod in classPublicMethods.Where(m => m.Name.StartsWith("set")))
            {
                sb.AppendLine($"{publicMethod.Name} have to be private!");
            }

            return sb.ToString();
        }

        public string RevealPrivateMethods(string className)
        {
            var sb = new StringBuilder();
            Type classType = Type.GetType(className);
            sb.AppendLine($"All Private Methods of Class: {classType.FullName}");
            sb.AppendLine($"Base Class: {classType.BaseType.Name}");
            MethodInfo[] methods = classType.GetMethods( BindingFlags.Instance|BindingFlags.NonPublic
                |BindingFlags.Public|BindingFlags.Static);

            foreach (var method in methods.Where(m=>!m.IsPublic))
            {
                sb.AppendLine($"{method.Name}");
            }
            return sb.ToString();
        }
        
        public string CollectGettersAndSetters(string className)
        {
            var sb = new StringBuilder();
            Type classType = Type.GetType(className);
            MethodInfo[] methodGetters = classType.GetMethods(BindingFlags.Public | BindingFlags.NonPublic
                | BindingFlags.Static | BindingFlags.Instance).Where(m => m.Name.StartsWith("get")).ToArray();
            MethodInfo[] methodSetters = classType.GetMethods(BindingFlags.Public | BindingFlags.NonPublic
                | BindingFlags.Static | BindingFlags.Instance).Where(m => m.Name.StartsWith("set")).ToArray();
            foreach (MethodInfo methodGetter in methodGetters)
            {
                sb.AppendLine($"{methodGetter.Name} will return {methodGetter.ReturnType}");
            }

            foreach (MethodInfo methodSetter in methodSetters)
            {
                sb.AppendLine($"{methodSetter.Name} will set field of {methodSetter.GetParameters().First().ParameterType}");
            }

            return sb.ToString();
        }
    }
}
