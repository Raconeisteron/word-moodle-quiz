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
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("MoodleQuestions.Resources", GetType(Resources).Assembly)
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
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to   &lt;question type=&quot;essay&quot;&gt;
        '''    &lt;name&gt;&lt;text&gt;&lt;/text&gt;
        '''&lt;/name&gt;
        '''    &lt;questiontext format=&quot;html&quot;&gt;
        '''&lt;text&gt;&lt;/text&gt;
        '''    &lt;/questiontext&gt;
        '''    &lt;image&gt;&lt;/image&gt;
        '''	&lt;image_base64&gt;&lt;/image_base64&gt;
        '''    &lt;generalfeedback&gt;
        '''&lt;text&gt;&lt;/text&gt;
        '''    &lt;/generalfeedback&gt;
        '''    &lt;defaultgrade&gt;&lt;/defaultgrade&gt;
        '''    &lt;penalty&gt;1&lt;/penalty&gt;
        '''    &lt;hidden&gt;&lt;/hidden&gt;
        '''    &lt;shuffleanswers&gt;&lt;/shuffleanswers&gt;
        '''&lt;answer fraction=&quot;0&quot;&gt;
        '''    &lt;feedback&gt;&lt;text&gt;&lt;/text&gt;
        '''&lt;/feedback&gt;
        '''&lt;/answer&gt;
        '''&lt;/question&gt;
        '''.
        '''</summary>
        Friend ReadOnly Property Essay_xml() As String
            Get
                Return ResourceManager.GetString("Essay_xml", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to   &lt;question type=&quot;truefalse&quot;&gt;
        '''    &lt;name&gt;
        '''    	&lt;text&gt;&lt;/text&gt;
        '''    &lt;/name&gt;
        '''
        '''    &lt;questiontext format=&quot;html&quot;&gt;
        '''			&lt;text&gt;&lt;/text&gt;
        '''	  &lt;/questiontext&gt;
        '''
        '''    &lt;image&gt;&lt;/image&gt;
        '''	  &lt;image_base64&gt;&lt;/image_base64&gt;
        '''
        '''    &lt;generalfeedback&gt;
        '''	&lt;text&gt;&lt;/text&gt;
        '''    &lt;/generalfeedback&gt;
        '''    &lt;penalty&gt;0.1&lt;/penalty&gt;
        '''    &lt;hidden&gt;0&lt;/hidden&gt;
        '''	 &lt;answer fraction=&quot;0&quot;&gt;
        '''      &lt;text&gt;true&lt;/text&gt;
        '''      &lt;feedback&gt;
        '''        &lt;text&gt;
        '''        &lt;/text&gt;
        '''      &lt;/feedback&gt;
        '''    &lt;/answer&gt;
        '''	&lt;answer fraction=&quot;100&quot;&gt;
        '''	&lt;text&gt;false&lt;/text&gt;
        '''		&lt;fee [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property False_xml() As String
            Get
                Return ResourceManager.GetString("False_xml", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &lt;xsl:stylesheet version=&quot;1.0&quot;
        '''  xmlns:xsl=&quot;http://www.w3.org/1999/XSL/Transform&quot;
        '''  xmlns:w=&quot;http://schemas.microsoft.com/office/word/2003/wordml&quot;
        '''	xmlns:wx=&quot;http://schemas.microsoft.com/office/word/2003/auxHint&quot;&gt;
        '''
        '''	&lt;xsl:output method=&quot;text&quot; /&gt; 
        '''
        '''	&lt;!-- remove all text --&gt;
        '''  &lt;xsl:template match=&quot;text()&quot;&gt;&lt;/xsl:template&gt; 
        '''
        '''
        '''
        '''  &lt;xsl:template match=&quot;w:p/w:r//node() [@w:val=&apos;preformatted&apos;]&quot;&gt;&amp;lt;pre&amp;gt;&lt;xsl:value-of select=&quot;../../w:t&quot;/&gt;&amp;lt;/pre&amp;gt;&lt;/xsl:template&gt;
        '''
        '''  &lt;xsl:template match=&quot;w:p/w:r//node( [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property FormattedText_xslt() As String
            Get
                Return ResourceManager.GetString("FormattedText_xslt", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to 	&lt;question type=&quot;matching&quot;&gt;
        '''	  &lt;name&gt;
        '''	  	&lt;text&gt;MatchingQ&lt;/text&gt;
        '''		&lt;/name&gt;
        '''
        '''	  &lt;questiontext format=&quot;html&quot;&gt;
        '''			&lt;text&gt;&lt;/text&gt;
        '''	  &lt;/questiontext&gt;
        '''
        '''	  &lt;image&gt;&lt;/image&gt;
        '''	  &lt;image_base64&gt;&lt;/image_base64&gt;
        '''
        '''    &lt;generalfeedback&gt;
        '''	&lt;text&gt;&lt;/text&gt;
        '''    &lt;/generalfeedback&gt;
        '''	  &lt;penalty&gt;0.1&lt;/penalty&gt;
        '''	  &lt;hidden&gt;0&lt;/hidden&gt;
        '''    &lt;shuffleanswers&gt;0&lt;/shuffleanswers&gt;
        '''
        '''		&lt;subquestion&gt;
        '''				&lt;text&gt;&lt;/text&gt;
        '''			&lt;answer&gt;
        '''				&lt;text&gt;&lt;/text&gt;
        '''			&lt;/answer&gt;
        '''		&lt;/subquestion&gt;
        '''
        '''	&lt;/question&gt;
        '''.
        '''</summary>
        Friend ReadOnly Property MatchingFix_xml() As String
            Get
                Return ResourceManager.GetString("MatchingFix_xml", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to 	&lt;question type=&quot;matching&quot;&gt;
        '''	  &lt;name&gt;
        '''	  	&lt;text&gt;MatchingQ&lt;/text&gt;
        '''		&lt;/name&gt;
        '''
        '''	  &lt;questiontext format=&quot;html&quot;&gt;
        '''			&lt;text&gt;&lt;/text&gt;
        '''	  &lt;/questiontext&gt;
        '''
        '''	  &lt;image&gt;&lt;/image&gt;
        '''	  &lt;image_base64&gt;&lt;/image_base64&gt;
        '''
        '''    &lt;generalfeedback&gt;
        '''	&lt;text&gt;&lt;/text&gt;
        '''    &lt;/generalfeedback&gt;
        '''	  &lt;penalty&gt;0.1&lt;/penalty&gt;
        '''	  &lt;hidden&gt;0&lt;/hidden&gt;
        '''    &lt;shuffleanswers&gt;1&lt;/shuffleanswers&gt;
        '''
        '''		&lt;subquestion&gt;
        '''				&lt;text&gt;&lt;/text&gt;
        '''			&lt;answer&gt;
        '''				&lt;text&gt;&lt;/text&gt;
        '''			&lt;/answer&gt;
        '''		&lt;/subquestion&gt;
        '''
        '''	&lt;/question&gt;
        '''.
        '''</summary>
        Friend ReadOnly Property MatchingVar_xml() As String
            Get
                Return ResourceManager.GetString("MatchingVar_xml", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to   &lt;question type=&quot;multichoice&quot;&gt;
        '''    &lt;name&gt;
        '''    	&lt;text&gt;&lt;/text&gt;
        '''		&lt;/name&gt;
        '''
        '''    &lt;questiontext format=&quot;html&quot;&gt;
        '''			&lt;text&gt;&lt;/text&gt;
        '''    &lt;/questiontext&gt;
        '''
        '''    &lt;image&gt;&lt;/image&gt;
        '''	  &lt;image_base64&gt;&lt;/image_base64&gt;
        '''
        '''    &lt;generalfeedback&gt;
        '''	&lt;text&gt;&lt;/text&gt;
        '''    &lt;/generalfeedback&gt;
        '''    &lt;penalty&gt;0.1&lt;/penalty&gt;
        '''    &lt;hidden&gt;0&lt;/hidden&gt;
        '''    &lt;single&gt;true&lt;/single&gt;
        '''    &lt;shuffleanswers&gt;false&lt;/shuffleanswers&gt;
        '''	&lt;answernumbering&gt;none&lt;/answernumbering&gt;
        '''
        '''
        '''    &lt;answer fraction=&quot;100&quot;&gt;
        '''        &lt;text&gt;&lt;/text&gt;
        '''      &lt;feedback&gt;
        ''' [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property MultiChoiceFix_xml() As String
            Get
                Return ResourceManager.GetString("MultiChoiceFix_xml", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to   &lt;question type=&quot;multichoice&quot;&gt;
        '''    &lt;name&gt;
        '''    	&lt;text&gt;&lt;/text&gt;
        '''		&lt;/name&gt;
        '''
        '''    &lt;questiontext format=&quot;html&quot;&gt;
        '''			&lt;text&gt;&lt;/text&gt;
        '''    &lt;/questiontext&gt;
        '''
        '''    &lt;image&gt;&lt;/image&gt;
        '''	  &lt;image_base64&gt;&lt;/image_base64&gt;
        '''
        '''    &lt;generalfeedback&gt;
        '''	&lt;text&gt;&lt;/text&gt;
        '''    &lt;/generalfeedback&gt;
        '''    &lt;penalty&gt;0.1&lt;/penalty&gt;
        '''    &lt;hidden&gt;0&lt;/hidden&gt;
        '''    &lt;single&gt;true&lt;/single&gt;
        '''    &lt;shuffleanswers&gt;true&lt;/shuffleanswers&gt;
        '''&lt;answernumbering&gt;none&lt;/answernumbering&gt;
        '''
        '''
        '''    &lt;answer fraction=&quot;100&quot;&gt;
        '''        &lt;text&gt;&lt;/text&gt;
        '''		 &lt;file name=&quot;image [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property MultiChoiceVar_xml() As String
            Get
                Return ResourceManager.GetString("MultiChoiceVar_xml", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to 	&lt;question type=&quot;numerical&quot;&gt;
        '''		&lt;name&gt;
        '''			&lt;text&gt;&lt;/text&gt;
        '''		&lt;/name&gt;
        '''
        '''		&lt;questiontext format=&quot;html&quot;&gt;
        '''			&lt;text&gt;&lt;/text&gt;
        '''		&lt;/questiontext&gt;
        '''
        '''    &lt;image&gt;&lt;/image&gt;
        '''	  &lt;image_base64&gt;&lt;/image_base64&gt;
        '''
        '''    &lt;generalfeedback&gt;
        '''	&lt;text&gt;&lt;/text&gt;
        '''    &lt;/generalfeedback&gt;
        '''    &lt;penalty&gt;0.1&lt;/penalty&gt;
        '''    &lt;hidden&gt;0&lt;/hidden&gt;
        '''
        '''    &lt;answer fraction=&quot;0&quot;&gt;
        '''      &lt;text&gt;&lt;/text&gt;
        '''      &lt;tolerance/&gt;
        '''      &lt;feedback&gt;
        '''        &lt;text&gt;&lt;/text&gt;
        '''      &lt;/feedback&gt;
        '''    &lt;/answer&gt;
        '''
        '''	&lt;/question&gt;
        '''.
        '''</summary>
        Friend ReadOnly Property Numerical_xml() As String
            Get
                Return ResourceManager.GetString("Numerical_xml", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &lt;xsl:stylesheet version=&quot;1.0&quot;
        '''  xmlns:xsl=&quot;http://www.w3.org/1999/XSL/Transform&quot;
        '''  xmlns:w=&quot;http://schemas.microsoft.com/office/word/2003/wordml&quot;
        '''	xmlns:wx=&quot;http://schemas.microsoft.com/office/word/2003/auxHint&quot;&gt;
        '''
        '''	&lt;xsl:output method=&quot;text&quot; /&gt; 
        '''
        '''	&lt;!-- remove all text --&gt;
        '''  &lt;xsl:template match=&quot;text()&quot;&gt;&lt;/xsl:template&gt; 
        '''
        '''	&lt;!-- processing --&gt;
        '''  &lt;xsl:template match=&quot;w:p/w:r/w:pict[1]&quot;&gt;&lt;xsl:value-of select=&quot;w:binData&quot;/&gt;&lt;/xsl:template&gt;
        '''
        '''&lt;/xsl:stylesheet&gt;.
        '''</summary>
        Friend ReadOnly Property Picture_xslt() As String
            Get
                Return ResourceManager.GetString("Picture_xslt", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &lt;xsl:stylesheet version=&quot;1.0&quot;
        '''  xmlns:xsl=&quot;http://www.w3.org/1999/XSL/Transform&quot;
        '''  xmlns:w=&quot;http://schemas.microsoft.com/office/word/2003/wordml&quot;
        '''	xmlns:wx=&quot;http://schemas.microsoft.com/office/word/2003/auxHint&quot;&gt;
        '''
        '''	&lt;xsl:output method=&quot;text&quot; /&gt; 
        '''
        '''	&lt;!-- remove all text --&gt;
        '''  &lt;xsl:template match=&quot;text()&quot;&gt;&lt;/xsl:template&gt; 
        '''
        '''
        '''  &lt;xsl:template match=&quot;w:p/w:r/w:pict&quot;&gt;&lt;xsl:value-of select=&quot;w:binData/@w:name&quot;/&gt;&lt;/xsl:template&gt;
        '''
        '''&lt;/xsl:stylesheet&gt;.
        '''</summary>
        Friend ReadOnly Property PictureName_xslt() As String
            Get
                Return ResourceManager.GetString("PictureName_xslt", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to 	&lt;question type=&quot;shortanswer&quot;&gt;
        '''		&lt;name&gt;
        '''			&lt;text&gt;&lt;/text&gt;
        '''		&lt;/name&gt;
        '''
        '''		&lt;questiontext format=&quot;html&quot;&gt;
        '''			&lt;text&gt;&lt;/text&gt;
        '''		&lt;/questiontext&gt;
        '''
        '''    &lt;image&gt;&lt;/image&gt;
        '''	  &lt;image_base64&gt;&lt;/image_base64&gt;
        '''
        '''    &lt;generalfeedback&gt;
        '''	&lt;text&gt;&lt;/text&gt;
        '''    &lt;/generalfeedback&gt;
        '''    &lt;penalty&gt;0.1&lt;/penalty&gt;
        '''    &lt;hidden&gt;0&lt;/hidden&gt;
        '''    &lt;usecase&gt;0&lt;/usecase&gt;
        '''
        '''    &lt;answer fraction=&quot;0&quot;&gt;
        '''      &lt;text&gt;&lt;/text&gt;
        '''      &lt;feedback&gt;
        '''        &lt;text&gt;&lt;/text&gt;
        '''      &lt;/feedback&gt;
        '''    &lt;/answer&gt;
        '''
        '''	&lt;/question&gt;
        '''.
        '''</summary>
        Friend ReadOnly Property Shortanswer_xml() As String
            Get
                Return ResourceManager.GetString("Shortanswer_xml", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to   &lt;question type=&quot;truefalse&quot;&gt;
        '''    &lt;name&gt;
        '''    	&lt;text&gt;&lt;/text&gt;
        '''    &lt;/name&gt;
        '''
        '''    &lt;questiontext format=&quot;html&quot;&gt;
        '''			&lt;text&gt;&lt;/text&gt;
        '''	  &lt;/questiontext&gt;
        '''
        '''    &lt;image&gt;&lt;/image&gt;
        '''	  &lt;image_base64&gt;&lt;/image_base64&gt;
        '''    &lt;generalfeedback&gt;
        '''	    &lt;text&gt;&lt;/text&gt;
        '''    &lt;/generalfeedback&gt;
        '''    &lt;penalty&gt;0.1&lt;/penalty&gt;
        '''    &lt;hidden&gt;0&lt;/hidden&gt;
        '''
        '''    &lt;answer fraction=&quot;100&quot;&gt;
        '''      &lt;text&gt;true&lt;/text&gt;
        '''      &lt;feedback&gt;
        '''        &lt;text&gt;
        '''        &lt;/text&gt;
        '''      &lt;/feedback&gt;
        '''    &lt;/answer&gt;
        '''    
        '''    &lt;answer fraction=&quot;0&quot;&gt;
        '''      &lt;text&gt; [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property True_xml() As String
            Get
                Return ResourceManager.GetString("True_xml", resourceCulture)
            End Get
        End Property
    End Module
End Namespace
