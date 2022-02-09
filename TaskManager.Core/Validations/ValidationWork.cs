using System;

namespace TaskManager.Core.Validations
{
   public static class ValidationWork
    {
        public static void ValidateTaskNameIfIsNull(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("задача не может быть пустой");
            }
        }
    }
}
