using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;
using Variable;

namespace Reference
{
    [Serializable]
    public class Int
    {
        [SerializeField]
        private bool isConstant;
        [SerializeField]
        private int constantValue;
        [SerializeField]
        private Variable.Int variableValue;

        public Int() { }

        public Int(int value)
        {
            isConstant = true;
            constantValue = value;
        }

        public Int(Variable.Int reference)
        {
            isConstant = false;
            variableValue = reference;
        }

        public int Value
        {
            get
            {
                return isConstant ? constantValue : variableValue.Value;
            }
            //set 
            //{
            //    if (!isConstant) 
            //        variableValue.Value = value; 
            //} 
        }

        public static implicit operator int(Int reference)
        {
            return reference.Value;
        }
    }

    [Serializable]
    public class Float
    {
        [SerializeField]
        private bool isConstant;
        [SerializeField]
        private float constantValue;
        [SerializeField]
        private Variable.Float variableValue;

        public Float() { }

        public Float(float value)
        {
            isConstant = true;
            constantValue = value;
        }

        public Float(Variable.Float reference)
        {
            isConstant = false;
            variableValue = reference;
        }

        public float Value
        {
            get
            {
                return isConstant ? constantValue : variableValue.Value;
            }
            //set 
            //{
            //    if (!isConstant) 
            //        variableValue.Value = value; 
            //} 
        }

        public static implicit operator float(Float reference)
        {
            return reference.Value;
        }
    }

    [Serializable]
    public class Bool
    {
        [SerializeField]
        private Variable.Bool value_;

        public Bool() { }

        public Bool(Variable.Bool value)
        {
            value_ = value;
        }

        public bool Value { get { return value_.Value; } set { value_.Value = value; } }

        public static implicit operator bool(Bool reference)
        {
            return reference.Value;
        }

    }

    [Serializable]
    public class Char
    {
        [SerializeField]
        private bool isConstant;
        [SerializeField]
        private char constantValue;
        [SerializeField]
        private Variable.Char variableValue;

        public Char() { }

        public Char(char value)
        {
            isConstant = true;
            constantValue = value;
        }

        public Char(Variable.Char reference)
        {
            isConstant = false;
            variableValue = reference;
        }

        public char Value
        {
            get
            {
                return isConstant ? constantValue : variableValue.Value;
            }
            //set 
            //{
            //    if (!isConstant) 
            //        variableValue.Value = value; 
            //} 
        }

        public static implicit operator char(Char reference)
        {
            return reference.Value;
        }
    }

    [Serializable]
    public class String
    {
        [SerializeField]
        private bool isConstant;
        [SerializeField]
        private string constantValue;
        [SerializeField]
        private Variable.String variableValue;

        public String() { }

        public String(string value)
        {
            isConstant = true;
            constantValue = value;
        }

        public String(Variable.String reference)
        {
            isConstant = false;
            variableValue = reference;
        }

        public string Value
        {
            get
            {
                return isConstant ? constantValue : variableValue.Value;
            }
            //set 
            //{
            //    if (!isConstant) 
            //        variableValue.Value = value; 
            //} 
        }

        public static implicit operator string(String reference)
        {
            return reference.Value;
        }
    }
}
