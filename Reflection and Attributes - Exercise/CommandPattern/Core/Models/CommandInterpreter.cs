using System;
using System.Linq;
using System.Reflection;
using CommandPattern.Core.Contracts;
namespace CommandPattern.Core.Models
{
    public class CommandInterpreter : ICommandInterpreter
    {
        public string Read(string args)
        {
            var tokens = args.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var commandName = tokens[0] + "Command";

            var commandArgs = tokens
                .Skip(1)
                .ToArray();

            Assembly assembly = Assembly.GetCallingAssembly();

            Type commandType = assembly.GetTypes().FirstOrDefault(c => c.Name == commandName);

            if (commandType == null)
            {
                throw new ArgumentException("Command should be valid");
            }

            var commandInstance = (ICommand)Activator.CreateInstance(commandType);

            string result = commandInstance.Execute(commandArgs);

            return result;
        }
    }
}
