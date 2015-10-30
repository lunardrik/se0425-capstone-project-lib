using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LIB
{
    public class VariableBUS
    {
        public string GetVariableByName(string varName)
        {
            VariableDAO dao = new VariableDAO();
            return dao.GetVariableByName(varName);
        }

        public int UpdateVariableByName(string varName, string val)
        {
            VariableDAO dao = new VariableDAO();
            return dao.UpdateVariableByName(varName, val);
        }
    }
}
