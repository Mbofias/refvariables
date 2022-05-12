using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using Reference;

[CustomPropertyDrawer(typeof(Reference.Float))]
public class FloatEditorDrawer : PropertyDrawer
{
    /// <summary>
    /// Opciones a seleccionar en el editor al tener una variable Float.
    /// </summary>
    private readonly string[] dropdownOptions = { "Constant", "Variable" };

    /// <summary>
    /// Aquí se almacena el aspecto que tendra el desplegable que veremos en las variables Float.
    /// </summary>
    private GUIStyle dropdown;

    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        if(dropdown == null)
        {
            dropdown = new GUIStyle(GUI.skin.GetStyle("PaneOptions"));
            dropdown.imagePosition = ImagePosition.ImageOnly;
        }

        label = EditorGUI.BeginProperty(position, label, property);
        position = EditorGUI.PrefixLabel(position, label);

        EditorGUI.BeginChangeCheck();

        // Aquí recogemos las variables que contiene un Float
        SerializedProperty isConstant = property.FindPropertyRelative("isConstant");
        SerializedProperty constantValue = property.FindPropertyRelative("constantValue");
        SerializedProperty variableValue = property.FindPropertyRelative("variableValue");

        // Calculamos la posición y aspecto que tendrá el botón
        Rect buttonRect = new Rect(position);
        buttonRect.yMin += dropdown.margin.top;
        buttonRect.width = dropdown.fixedWidth;
        position.xMin = buttonRect.xMax;

        int indent = EditorGUI.indentLevel;
        EditorGUI.indentLevel = 0;

        // Recogemos un valor según la opción seleccionada: 0 para la constante y 1 para la variable
        int result = EditorGUI.Popup(buttonRect, isConstant.boolValue ? 0 : 1, dropdownOptions, dropdown);

        // Asignamos el valor anterior al booleano del Float para definir el valor de isConstant
        isConstant.boolValue = result == 0;

        // Asignamos el espacio al botón seleccionando, mostrando así o bien la constante o bien la variable
        EditorGUI.PropertyField(position,
            isConstant.boolValue ? constantValue : variableValue,
            GUIContent.none);

        if (EditorGUI.EndChangeCheck())
            property.serializedObject.ApplyModifiedProperties();

        EditorGUI.indentLevel = indent;
        EditorGUI.EndProperty();
    }
}

[CustomPropertyDrawer(typeof(Reference.Int))]
public class IntEditorDrawer : PropertyDrawer
{
    /// <summary>
    /// Opciones a seleccionar en el editor al tener una variable Int.
    /// </summary>
    private readonly string[] dropdownOptions = { "Constant", "Variable" };

    /// <summary>
    /// Aquí se almacena el aspecto que tendra el desplegable que veremos en las variables Int.
    /// </summary>
    private GUIStyle dropdown;

    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        if (dropdown == null)
        {
            dropdown = new GUIStyle(GUI.skin.GetStyle("PaneOptions"));
            dropdown.imagePosition = ImagePosition.ImageOnly;
        }

        label = EditorGUI.BeginProperty(position, label, property);
        position = EditorGUI.PrefixLabel(position, label);

        EditorGUI.BeginChangeCheck();

        // Aquí recogemos las variables que contiene un Int
        SerializedProperty isConstant = property.FindPropertyRelative("isConstant");
        SerializedProperty constantValue = property.FindPropertyRelative("constantValue");
        SerializedProperty variableValue = property.FindPropertyRelative("variableValue");

        // Calculamos la posición y aspecto que tendrá el botón
        Rect buttonRect = new Rect(position);
        buttonRect.yMin += dropdown.margin.top;
        buttonRect.width = dropdown.fixedWidth;
        position.xMin = buttonRect.xMax;

        int indent = EditorGUI.indentLevel;
        EditorGUI.indentLevel = 0;

        // Recogemos un valor según la opción seleccionada: 0 para la constante y 1 para la variable
        int result = EditorGUI.Popup(buttonRect, isConstant.boolValue ? 0 : 1, dropdownOptions, dropdown);

        // Asignamos el valor anterior al booleano del Int para definir el valor de isConstant
        isConstant.boolValue = result == 0;

        // Asignamos el espacio al botón seleccionando, mostrando así o bien la constante o bien la variable
        EditorGUI.PropertyField(position,
            isConstant.boolValue ? constantValue : variableValue,
            GUIContent.none);

        if (EditorGUI.EndChangeCheck())
            property.serializedObject.ApplyModifiedProperties();

        EditorGUI.indentLevel = indent;
        EditorGUI.EndProperty();
    }
}

[CustomPropertyDrawer(typeof(Reference.Bool))]
public class BoolEditorDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {

        label = EditorGUI.BeginProperty(position, label, property);
        position = EditorGUI.PrefixLabel(position, label);

        EditorGUI.BeginChangeCheck();

        SerializedProperty value = property.FindPropertyRelative("value_");

        int indent = EditorGUI.indentLevel;
        EditorGUI.indentLevel = 0;
        EditorGUI.PropertyField(position, value, GUIContent.none);

        if (EditorGUI.EndChangeCheck())
            property.serializedObject.ApplyModifiedProperties();

        EditorGUI.indentLevel = indent;
        EditorGUI.EndProperty();
    }
}

[CustomPropertyDrawer(typeof(Reference.String))]
public class StringEditorDrawer : PropertyDrawer
{
    /// <summary>
    /// Opciones a seleccionar en el editor al tener una variable String.
    /// </summary>
    private readonly string[] dropdownOptions = { "Constant", "Variable" };

    /// <summary>
    /// Aquí se almacena el aspecto que tendra el desplegable que veremos en las variables String.
    /// </summary>
    private GUIStyle dropdown;

    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        if (dropdown == null)
        {
            dropdown = new GUIStyle(GUI.skin.GetStyle("PaneOptions"));
            dropdown.imagePosition = ImagePosition.ImageOnly;
        }

        label = EditorGUI.BeginProperty(position, label, property);
        position = EditorGUI.PrefixLabel(position, label);

        EditorGUI.BeginChangeCheck();

        // Aquí recogemos las variables que contiene un String
        SerializedProperty isConstant = property.FindPropertyRelative("isConstant");
        SerializedProperty constantValue = property.FindPropertyRelative("constantValue");
        SerializedProperty variableValue = property.FindPropertyRelative("variableValue");

        // Calculamos la posición y aspecto que tendrá el botón
        Rect buttonRect = new Rect(position);
        buttonRect.yMin += dropdown.margin.top;
        buttonRect.width = dropdown.fixedWidth;
        position.xMin = buttonRect.xMax;

        int indent = EditorGUI.indentLevel;
        EditorGUI.indentLevel = 0;

        // Recogemos un valor según la opción seleccionada: 0 para la constante y 1 para la variable
        int result = EditorGUI.Popup(buttonRect, isConstant.boolValue ? 0 : 1, dropdownOptions, dropdown);

        // Asignamos el valor anterior al booleano del String para definir el valor de isConstant
        isConstant.boolValue = result == 0;

        // Asignamos el espacio al botón seleccionando, mostrando así o bien la constante o bien la variable
        EditorGUI.PropertyField(position,
            isConstant.boolValue ? constantValue : variableValue,
            GUIContent.none);

        if (EditorGUI.EndChangeCheck())
            property.serializedObject.ApplyModifiedProperties();

        EditorGUI.indentLevel = indent;
        EditorGUI.EndProperty();
    }
}

[CustomPropertyDrawer(typeof(Reference.Char))]
public class CharEditorDrawer : PropertyDrawer
{
    /// <summary>
    /// Opciones a seleccionar en el editor al tener una variable Char.
    /// </summary>
    private readonly string[] dropdownOptions = { "Constant", "Variable" };

    /// <summary>
    /// Aquí se almacena el aspecto que tendra el desplegable que veremos en las variables Char.
    /// </summary>
    private GUIStyle dropdown;

    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        if (dropdown == null)
        {
            dropdown = new GUIStyle(GUI.skin.GetStyle("PaneOptions"));
            dropdown.imagePosition = ImagePosition.ImageOnly;
        }

        label = EditorGUI.BeginProperty(position, label, property);
        position = EditorGUI.PrefixLabel(position, label);

        EditorGUI.BeginChangeCheck();

        // Aquí recogemos las variables que contiene un Char
        SerializedProperty isConstant = property.FindPropertyRelative("isConstant");
        SerializedProperty constantValue = property.FindPropertyRelative("constantValue");
        SerializedProperty variableValue = property.FindPropertyRelative("variableValue");

        // Calculamos la posición y aspecto que tendrá el botón
        Rect buttonRect = new Rect(position);
        buttonRect.yMin += dropdown.margin.top;
        buttonRect.width = dropdown.fixedWidth;
        position.xMin = buttonRect.xMax;

        int indent = EditorGUI.indentLevel;
        EditorGUI.indentLevel = 0;

        // Recogemos un valor según la opción seleccionada: 0 para la constante y 1 para la variable
        int result = EditorGUI.Popup(buttonRect, isConstant.boolValue ? 0 : 1, dropdownOptions, dropdown);

        // Asignamos el valor anterior al booleano del Char para definir el valor de isConstant
        isConstant.boolValue = result == 0;

        // Asignamos el espacio al botón seleccionando, mostrando así o bien la constante o bien la variable
        EditorGUI.PropertyField(position,
            isConstant.boolValue ? constantValue : variableValue,
            GUIContent.none);

        if (EditorGUI.EndChangeCheck())
            property.serializedObject.ApplyModifiedProperties();

        EditorGUI.indentLevel = indent;
        EditorGUI.EndProperty();
    }
}