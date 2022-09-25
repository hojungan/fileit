using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIT.Helpers
{
    public static class ActionTypes
    {
        public static readonly string DELETE = "Delete";
        public static readonly string COPY = "Copy";
        public static readonly string MOVE = "Move";
        public static readonly string SEARCH = "Search";
        public static readonly string SUCCESS = "SUCCESS";
        public static readonly string ERROR = "ERROR";
        public static readonly string NOMATCH = "NO-MATCH";
        public static readonly string OUTDATED = "OUTDATED";
    }
}
