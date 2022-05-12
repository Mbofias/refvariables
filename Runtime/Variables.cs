using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Variable
{
    [CreateAssetMenu(menuName = "Variable/Int")]
    public class Int : ScriptableObject
    {
#if UNITY_EDITOR
        [Multiline]
        public string DeveloperDescription = "";
#endif

        [SerializeField]
        private int value_;

        public int Value { get { return value_; } set { value_ = value; } }
    }

    [CreateAssetMenu(menuName = "Variable/Float")]
    public class Float : ScriptableObject
    {
        #region editor variables

#if UNITY_EDITOR

        [Multiline]
        public string DeveloperDescription = "";

#endif

        #endregion

        #region private serialized fields

        [SerializeField]
        private float value_;

        #endregion

        #region getters & setters

        public float Value { get { return value_; } set { value_ = value; } }

        #endregion
    }

    [CreateAssetMenu(menuName = "Variable/Bool")]
    public class Bool : ScriptableObject
    {
        #region editor variables

#if UNITY_EDITOR

        [Multiline]
        public string DeveloperDescription = "";

#endif

        #endregion

        #region private serialized fields

        [SerializeField]
        private bool value_;

        #endregion

        #region getters & setters

        public bool Value { get { return value_; } set { value_ = value; } }

        #endregion
    }

    [CreateAssetMenu(menuName = "Variable/Char")]
    public class Char : ScriptableObject
    {
#if UNITY_EDITOR
        [Multiline]
        public string DeveloperDescription = "";
#endif
        [SerializeField]
        private char value_;

        public char Value { get { return value_; } set { value_ = value; } }
    }

    [CreateAssetMenu(menuName = "Variable/String")]
    public class String : ScriptableObject
    {
#if UNITY_EDITOR
        [Multiline]
        public string DeveloperDescription = "";
#endif
        [SerializeField]
        private string value_;

        public string Value { get { return value_; } set { value_ = value; } }
    }
}
