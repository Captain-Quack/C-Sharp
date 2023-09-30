using System.Collections.Generic;
using System.Text;

namespace Algorithms.DataCompression
{
    /// <summary>
    ///  Translates text using a provided dictionary.
    /// </summary>
    public class Translator
    {
        /// <summary>
        /// Main method for translating text.
        /// </summary>
        /// <param name="text">Text to be translated.</param>
        /// <param name="translationKeys">This contains the translation data. <paramref name="text"/> should be the same language (or source equivalent) as the keys.</param>
        /// <returns>TODO. 4.</returns>
        public static string Translate(string text, Dictionary<string, string> translationKeys)
        {
            var sb = new StringBuilder();

            var start = 0;
            for (var i = 0; i < text.Length; i++)
            {
                var key = text.Substring(start, i - start + 1);
                if (translationKeys.ContainsKey(key))
                {
                    _ = sb.Append(translationKeys[key]);
                    start = i + 1;
                }
            }

            return sb.ToString();
        }
    }
}
