Public Class Crew
    Public Property Name As String
    Public Property Dip As Integer
    Public Property Sci As Integer
    Public Property Eng As Integer
    Public Property Med As Integer
    Public Property Com As Integer
    Public Property Sec As Integer
    Public Property Accuracy As Integer
    Public Property CritBonus As Integer
    Public Property CritRating As Integer
    Public Property Evasion As Integer
    Public Property Traits As List(Of String)
    Public Property Groups As List(Of String)

    ' Use lists for stats and bonuses instead?

    Public Sub New()

    End Sub

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
                   ByVal nDip As Short,
                   ByVal nSci As Short,
                   ByRef nEng As Short,
                   ByVal nMed As Short,
                   ByVal nCom As Short,
                   ByVal nSec As Short,
                   ByVal nAccuracy As Short,
                   ByVal nCritbonus As Short,
                   ByVal nCritRating As Short,
                   ByVal nEvasion As Short,
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
    ''' Adds groups (human, alien, federation etc) to crew
    ''' </summary>
    ''' <param name="GroupsList">Groups to add as List(Of String)</param>
    Public Sub AddGroups(GroupsList)
        For Each g In GroupsList
            Groups.Add(g)
        Next
    End Sub



End Class
