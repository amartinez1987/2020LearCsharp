using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace _2020LearCsharp
{
   public class _100CodeDoom
    {
        public static void executeTest()
        {
            CodeCompileUnit codeCompileUnit = new CodeCompileUnit();
            CodeNamespace personnelNameSpace = new CodeNamespace("Personnel");
            personnelNameSpace.Imports.Add(new CodeNamespaceImport("System"));
            CodeTypeDeclaration personClass = new CodeTypeDeclaration("Person");
            personClass.IsClass = true;
            personClass.TypeAttributes = System.Reflection.TypeAttributes.Public;
            personnelNameSpace.Types.Add(personClass);
            
            CodeMemberField nameField = new CodeMemberField("String", "Name");
            nameField.Attributes = MemberAttributes.Private;
            personClass.Members.Add(nameField);
            codeCompileUnit.Namespaces.Add(personnelNameSpace);

            CodeDomProvider provider = CodeDomProvider.CreateProvider("CSharp");
            StringWriter s = new StringWriter();
            CodeGeneratorOptions options = new CodeGeneratorOptions();


            provider.GenerateCodeFromCompileUnit(compileUnit:codeCompileUnit,writer:s,options:options);
            s.Close();
            Console.WriteLine(s.ToString());

            Console.ReadKey();

        }
        
    }
}
