using System;
using System.Reflection;
using System.Linq;
using System.Runtime.Remoting;

namespace BitwiseInteraction
{
    class BitwiseMain
    {
        private static String[] forbiddenClasses = { "BitwiseMain", "<>c__DisplayClass1"};
        private static String assembly = "BitwiseInteraction";
        private static String currentNamespace = "BitwiseInteraction";
        private static String mainMethod = "Start";

        public static void Main(string[] args)
        {
            Type[] typelist = GetTypesInNamespace(Assembly.GetExecutingAssembly(), currentNamespace);
            String[] classArray = new String[typelist.Length];
            for (int i = 0; i < typelist.Length; i++)
            {
               
                classArray[i] = typelist[i].Name.ToString();
                if (!forbiddenClasses.Contains(classArray[i]))
                {
                    Console.WriteLine(typelist[i].Name);
                }
            }
            Console.WriteLine("Choose one of the above classes to start");
            String inputClass = Console.ReadLine();
            if (classArray.Contains(inputClass))
            {
                ObjectHandle handle = Activator.CreateInstance(assembly, currentNamespace+"."+inputClass);
                Object p = handle.Unwrap();
                Type t = p.GetType();
                MethodInfo myMethod = t.GetMethod(mainMethod);
                myMethod.Invoke(p, null);
            }
            
        }

        private static Type[] GetTypesInNamespace(Assembly assembly, string nameSpace)
        {
            return assembly.GetTypes().Where(t => String.Equals(t.Namespace, nameSpace, StringComparison.Ordinal)).ToArray();
        } 
    }
}
