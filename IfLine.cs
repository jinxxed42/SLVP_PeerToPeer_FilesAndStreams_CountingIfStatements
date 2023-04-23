using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLVP_PeerToPeer_FilesAndStreams_CountingIfStatements
{
    public class IfLine
    {
        public int LineNumber { get; set; }
        public string LineText { get; set; }

        public IfLine(int lineNumber, string lineText)
        {
            LineNumber = lineNumber;
            LineText = lineText;
        }
    }
}
