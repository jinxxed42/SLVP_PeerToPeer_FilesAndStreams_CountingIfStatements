using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;

namespace SLVP_PeerToPeer_FilesAndStreams_CountingIfStatements
{
    internal static class IfLineFinder
    {
        public static void FindIfLine(string text, Action<IfLine> ifLineFound)
        {
            // Pattern for finding if statements. Allows whitespace in front of and inbetween, then matches brackets and curly brackets
            // while allowing for whitespace in between those as well.
            string pattern = @"^\s*(if|else\s+if)\s*\(.+\)\s*({.*})?$";
            MatchCollection matches = Regex.Matches(text, pattern, RegexOptions.Multiline); // Stores all matches in the MatchCollection.                                                                                            
            foreach (Match match in matches)                                                // Multiline mode so we can handle input that consists
            {                                                                               // of multiple lines.
                string matchedString = match.Value.Trim();
                int lineNumber = text.Substring(0, match.Index).Count(c => c == '\n') + 1; // Index starts from 0 so + 1 for the actual line number.
                IfLine ifLine = new IfLine(lineNumber, matchedString);
                ifLineFound.Invoke(ifLine);
            }
        }
    }
}
