using EnvDTE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BitmapVisualizer_UnitTests
{
    class MockExpression : Expression
    {
        private readonly bool m_isValidValue;
        private readonly string m_type;
        private string m_value;

        internal MockExpression(bool isValidValue, string type, string value)
        {
            this.m_isValidValue = isValidValue;
            this.m_type = type;
            this.m_value = value;
        }

        public Expressions Collection
        {
            get { throw new NotImplementedException(); }
        }

        public DTE DTE
        {
            get { throw new NotImplementedException(); }
        }

        public Expressions DataMembers
        {
            get { throw new NotImplementedException(); }
        }

        public bool IsValidValue
        {
            get { return m_isValidValue; }
        }

        public string Name
        {
            get { throw new NotImplementedException(); }
        }

        public Debugger Parent
        {
            get { throw new NotImplementedException(); }
        }

        public string Type
        {
            get { return m_type; }
        }

        public string Value
        {
            get
            {
                return m_value;
            }
            set
            {
                m_value = value;
            }
        }
    }
}
