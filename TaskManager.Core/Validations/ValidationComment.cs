using System;

namespace TaskManager.Core.Validations
{
   public static class ValidationComment
    {
        public static void ValidateCommentTextIfIsNullOrEmpty(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                throw new ArgumentException("Комментарий не может бытиь пустым");
            }
        }
    }
}
