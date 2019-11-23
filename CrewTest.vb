Imports Microsoft.VisualBasic
Imports System.Collections
Imports System.Collections.Generic

Public Class Crews
    Private Property Name As String
    Private Property Dip As Integer
    Private Property Sci As Integer
    Private Property Eng As Integer
    Private Property Med As Integer
    Private Property Com As Integer
    Private Property Sec As Integer
    Private Property Accuracy As Integer
    Private Property CritBonus As Integer
    Private Property CritRating As Integer
    Private Property Evasion As Integer
    Private Property Traits As List(Of String)
    Private Property Groups As List(Of String)

    ''' <summary>
    ''' Create object instance
    ''' </summary>
    ''' <param name="nName">Crew Name as string</param>
    ''' <param name="nDip">Diplomacy value as Integer</param>
    ''' <param name="nSci">Science value as Integer</param>
    ''' <param name="nEng">Engineering value as Integer</param>
    ''' <param name="nMed">Medicine value as Integer</param>
    ''' <param name="nCom">Command value as Integer</param>
    ''' <param name="nSec">Security value as Integer</param>
    ''' <param name="nAccuracy">Ship equipment Accuracy value as Integer</param>
    ''' <param name="nCritbonus">Ship equipment CritBonus value as Integer</param>
    ''' <param name="nCritRating">Ship equipment CritRating value as Integer</param>
    ''' <param name="nEvasion">Ship equipemnt Evation value as Integer</param>
    Public Sub New(ByVal nName As String,
                   ByVal nDip, nSci, nEng, nMed, nCom, nSec, nAccuracy, nCritbonus, nCritRating, nEvasion As Integer,
                   nTraits As List(Of String))
        _Name = nName
        _Dip = nDip
        _Sci = nSci
        _Eng = nEng
        _Med = nMed
        _Com = nCom
        _Sec = nSec
        _Accuracy = nAccuracy
        _CritBonus = nCritbonus
        _CritRating = nCritRating
        _Evasion = nEvasion
        _Traits = nTraits
    End Sub

    ''' <summary>
    ''' Returns lists with detailed crew information
    ''' </summary>
    ''' <returns>Name, Traits, Groups as lists of String and Stats and EquipmentBonus as list of Integer</returns>
    Public Function ToLists()
        Dim n As List(Of String)
        n.Add(Name)
        Dim Stats As List(Of Integer)
        Stats.Add(Com)
        Stats.Add(Dip)
        Stats.Add(Eng)
        Stats.Add(Med)
        Stats.Add(Sci)
        Stats.Add(Sec)
        Dim EquipmentBonus As List(Of Integer)
        EquipmentBonus.Add(Accuracy)
        EquipmentBonus.Add(CritBonus)
        EquipmentBonus.Add(CritRating)
        EquipmentBonus.Add(Evasion)
        Return (n, Traits, Groups, Stats, EquipmentBonus)
    End Function

    ''' <summary>
    ''' Adds traits to crew
    ''' </summary>
    ''' <param name="TraitsList">Traits to add as List(Of String)</param>
    Public Sub AddTraits(TraitsList)
        For Each t In TraitsList
            Traits.Add(t)
        Next
    End Sub

    ''' <summary>
    ''' Adds groups to crew
    ''' </summary>
    ''' <param name="GroupsList">Groups to add as List(Of String)</param>
    Public Sub AddGroups(GroupsList)
        For Each g In GroupsList
            Groups.Add(g)
        Next
    End Sub



End Class
