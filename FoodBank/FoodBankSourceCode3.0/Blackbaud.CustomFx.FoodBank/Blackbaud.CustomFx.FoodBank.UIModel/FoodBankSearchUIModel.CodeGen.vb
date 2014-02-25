﻿Option Strict On
Option Explicit On
Option Infer On

'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by BBUIModelLibrary
'     Version:  2.5.465.0
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------
''' <summary>
''' Represents the UI model for the 'Food Bank Search' data form
''' </summary>
<Global.Blackbaud.AppFx.UIModeling.Core.SearchListUIModelMetadata("3eceea4c-cf42-4938-9cf1-c7c77ebc7dc9", "Food Bank")> _
Partial Public Class [FoodBankSearchUIModel]
	Inherits Global.Blackbaud.AppFx.UIModeling.Core.SearchListUIModel

#Region "Extensibility methods"

    Partial Private Sub OnCreated()
    End Sub

#End Region

    Private WithEvents _name As Global.Blackbaud.AppFx.UIModeling.Core.StringField
    Private WithEvents _foodbanktype As Global.Blackbaud.AppFx.UIModeling.Core.CodeTableField

	<System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "2.5.465.0")> _
    Public Sub New()
        MyBase.New()

        _name = New Global.Blackbaud.AppFx.UIModeling.Core.StringField
        _foodbanktype = New Global.Blackbaud.AppFx.UIModeling.Core.CodeTableField

        MyBase.SearchListId = New Guid("3eceea4c-cf42-4938-9cf1-c7c77ebc7dc9")
        MyBase.SearchRecordType = "Food Bank"
        MyBase.FORMHEADER.Value = "Food Bank Search"
        MyBase.TranslationFunctionId = New Guid("66d00b36-8c81-4327-84fa-3265e9888b29")
        MyBase.UserInterfaceUrl = "browser/htmlforms/custom/blackbaud.customfx.foodbank/FoodBankSearch.html"

        '
        '_name
        '
        _name.Name = "NAME"
        _name.Caption = "Name"
        _name.MaxLength = 100
        Me.Fields.Add(_name)
        '
        '_foodbanktype
        '
        _foodbanktype.Name = "FOODBANKTYPE"
        _foodbanktype.Caption = "Name"
        _foodbanktype.CodeTableName = "USR_FOODBANKTYPECODE"
        Me.Fields.Add(_foodbanktype)

		OnCreated()

    End Sub
    
    ''' <summary>
    ''' Name
    ''' </summary>
    <System.ComponentModel.Description("Name")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "2.5.465.0")> _
    Public ReadOnly Property [NAME]() As Global.Blackbaud.AppFx.UIModeling.Core.StringField
        Get
            Return _name
        End Get
    End Property
    
    ''' <summary>
    ''' Name
    ''' </summary>
    <System.ComponentModel.Description("Name")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "2.5.465.0")> _
    Public ReadOnly Property [FOODBANKTYPE]() As Global.Blackbaud.AppFx.UIModeling.Core.CodeTableField
        Get
            Return _foodbanktype
        End Get
    End Property
    
End Class