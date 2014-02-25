﻿Option Strict On
Option Explicit On
Option Infer On

'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by BBUIModelLibrary
'     Version:  2.94.1232.0
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------
''' <summary>
''' Represents the UI model for the 'Food Item Add Batch' data form
''' </summary>

Partial Public Class [FoodItemAddBatchFoodItemValidationUIModel]
	Inherits Global.Blackbaud.AppFx.UIModeling.Core.CustomUIModel

#Region "Extensibility methods"

    Partial Private Sub OnCreated()
    End Sub

#End Region

    Private WithEvents _weightrequired As Global.Blackbaud.AppFx.UIModeling.Core.BooleanField

	<System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "2.94.1232.0")> _
    Public Sub New()
        MyBase.New()

        _weightrequired = New Global.Blackbaud.AppFx.UIModeling.Core.BooleanField

        MyBase.UserInterfaceUrl = "browser/htmlforms/custom/blackbaud.customfx.foodbank/FoodItemAddBatchFoodItemValidation.html"

        '
        '_weightrequired
        '
        _weightrequired.Name = "WEIGHTREQUIRED"
        _weightrequired.Caption = "Weight must be greater than zero"
        _weightrequired.Description = "Weight Greater Than Zero"
        Me.Fields.Add(_weightrequired)

		OnCreated()

    End Sub
    
    ''' <summary>
    ''' Weight Greater Than Zero
    ''' </summary>
    <System.ComponentModel.Description("Weight Greater Than Zero")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "2.94.1232.0")> _
    Public ReadOnly Property [WEIGHTREQUIRED]() As Global.Blackbaud.AppFx.UIModeling.Core.BooleanField
        Get
            Return _weightrequired
        End Get
    End Property
    
End Class