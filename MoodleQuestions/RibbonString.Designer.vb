﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.34014
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Class RibbonString
        
        Private Shared resourceMan As Global.System.Resources.ResourceManager
        
        Private Shared resourceCulture As Global.System.Globalization.CultureInfo
        
        <Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")>  _
        Friend Sub New()
            MyBase.New
        End Sub
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Shared ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("MoodleQuestions.RibbonString", GetType(RibbonString).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Shared Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Question_Category/Question_Subcategory.
        '''</summary>
        Friend Shared ReadOnly Property CategoryQText() As String
            Get
                Return ResourceManager.GetString("CategoryQText", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Insert correct answer here.
        '''</summary>
        Friend Shared ReadOnly Property CorrectChoiceText() As String
            Get
                Return ResourceManager.GetString("CorrectChoiceText", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Insert An Essay question here (an Open Question). [This can not be the last question in the document.].
        '''</summary>
        Friend Shared ReadOnly Property EssayQText() As String
            Get
                Return ResourceManager.GetString("EssayQText", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Insert a FALSE statement here (not at the end of the document).
        '''</summary>
        Friend Shared ReadOnly Property FalseStatementText() As String
            Get
                Return ResourceManager.GetString("FalseStatementText", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to Insert feedback explaining why this is a correct answer here.
        '''</summary>
        Friend Shared ReadOnly Property FeedbackCorrectText() As String
            Get
                Return ResourceManager.GetString("FeedbackCorrectText", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to Insert feedback explaining why this is a False statement here.
        '''</summary>
        Friend Shared ReadOnly Property FeedbackFalseStatementFalseText() As String
            Get
                Return ResourceManager.GetString("FeedbackFalseStatementFalseText", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to Insert feedback explaining why this is not a True statement here.
        '''</summary>
        Friend Shared ReadOnly Property FeedbackFalseStatementTrueText() As String
            Get
                Return ResourceManager.GetString("FeedbackFalseStatementTrueText", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to Insert feedback explaining why this is an incorrect answer here.
        '''</summary>
        Friend Shared ReadOnly Property FeedbackIncorrectText() As String
            Get
                Return ResourceManager.GetString("FeedbackIncorrectText", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to Insert feedback explaining why this is a not False statement here.
        '''</summary>
        Friend Shared ReadOnly Property FeedbackTrueStatementFalseText() As String
            Get
                Return ResourceManager.GetString("FeedbackTrueStatementFalseText", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to Insert feedback explaining why this is a True statement here.
        '''</summary>
        Friend Shared ReadOnly Property FeedbackTrueStatementTrueText() As String
            Get
                Return ResourceManager.GetString("FeedbackTrueStatementTrueText", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to Insert incorrect answer here.
        '''</summary>
        Friend Shared ReadOnly Property IncorrectChoiceText() As String
            Get
                Return ResourceManager.GetString("IncorrectChoiceText", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to Insert the item to be match here.
        '''</summary>
        Friend Shared ReadOnly Property LeftMatchText() As String
            Get
                Return ResourceManager.GetString("LeftMatchText", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to Insert Matching Question.
        '''</summary>
        Friend Shared ReadOnly Property MatchingQText() As String
            Get
                Return ResourceManager.GetString("MatchingQText", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to Insert Missing Word Question. Then select the missing word!.
        '''</summary>
        Friend Shared ReadOnly Property MissingWordQText() As String
            Get
                Return ResourceManager.GetString("MissingWordQText", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to Insert Multiple Choice Question here.
        '''</summary>
        Friend Shared ReadOnly Property MultipleChoiceQuestionText() As String
            Get
                Return ResourceManager.GetString("MultipleChoiceQuestionText", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to Type numerical question here..
        '''</summary>
        Friend Shared ReadOnly Property NumericalQText() As String
            Get
                Return ResourceManager.GetString("NumericalQText", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to Add a question title..
        '''</summary>
        Friend Shared ReadOnly Property QuestionNameText() As String
            Get
                Return ResourceManager.GetString("QuestionNameText", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to Insert the matching here.
        '''</summary>
        Friend Shared ReadOnly Property RightMatchText() As String
            Get
                Return ResourceManager.GetString("RightMatchText", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to Type short answer here..
        '''</summary>
        Friend Shared ReadOnly Property ShortAnswerAText() As String
            Get
                Return ResourceManager.GetString("ShortAnswerAText", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to Type short-answer question here..
        '''</summary>
        Friend Shared ReadOnly Property ShortAnswerQText() As String
            Get
                Return ResourceManager.GetString("ShortAnswerQText", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to Insert a TRUE statement here (not at the end of the document).
        '''</summary>
        Friend Shared ReadOnly Property TrueStatementText() As String
            Get
                Return ResourceManager.GetString("TrueStatementText", resourceCulture)
            End Get
        End Property
    End Class
End Namespace
