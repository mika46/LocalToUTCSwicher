﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Ce code a été généré par un outil.
'     Version du runtime :4.0.30319.42000
'
'     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
'     le code est régénéré.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System


'Cette classe a été générée automatiquement par la classe StronglyTypedResourceBuilder
'à l'aide d'un outil, tel que ResGen ou Visual Studio.
'Pour ajouter ou supprimer un membre, modifiez votre fichier .ResX, puis réexécutez ResGen
'avec l'option /str ou régénérez votre projet VS.
'''<summary>
'''  Une classe de ressource fortement typée destinée, entre autres, à la consultation des chaînes localisées.
'''</summary>
<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0"),  _
 Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
 Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
Friend Class locale
    
    Private Shared resourceMan As Global.System.Resources.ResourceManager
    
    Private Shared resourceCulture As Global.System.Globalization.CultureInfo
    
    <Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")>  _
    Friend Sub New()
        MyBase.New
    End Sub
    
    '''<summary>
    '''  Retourne l'instance ResourceManager mise en cache utilisée par cette classe.
    '''</summary>
    <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Friend Shared ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
        Get
            If Object.ReferenceEquals(resourceMan, Nothing) Then
                Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("LocalToUTCSwitcher.locale", GetType(locale).Assembly)
                resourceMan = temp
            End If
            Return resourceMan
        End Get
    End Property
    
    '''<summary>
    '''  Remplace la propriété CurrentUICulture du thread actuel pour toutes
    '''  les recherches de ressources à l'aide de cette classe de ressource fortement typée.
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
    '''  Recherche une chaîne localisée semblable à Apply modifications.
    '''</summary>
    Friend Shared ReadOnly Property appmod() As String
        Get
            Return ResourceManager.GetString("appmod", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Recherche une chaîne localisée semblable à Do you want to set to {0} ({1}/{2}).
    '''</summary>
    Friend Shared ReadOnly Property askset() As String
        Get
            Return ResourceManager.GetString("askset", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Recherche une chaîne localisée semblable à Internal clock is set to {0}.
    '''</summary>
    Friend Shared ReadOnly Property ClockSet() As String
        Get
            Return ResourceManager.GetString("ClockSet", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Recherche une chaîne localisée semblable à Getting hour....
    '''</summary>
    Friend Shared ReadOnly Property gethour() As String
        Get
            Return ResourceManager.GetString("gethour", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Recherche une chaîne localisée semblable à {0} hour.
    '''</summary>
    Friend Shared ReadOnly Property htype() As String
        Get
            Return ResourceManager.GetString("htype", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Recherche une chaîne localisée semblable à locale.
    '''</summary>
    Friend Shared ReadOnly Property Locale() As String
        Get
            Return ResourceManager.GetString("Locale", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Recherche une chaîne localisée semblable à N.
    '''</summary>
    Friend Shared ReadOnly Property N() As String
        Get
            Return ResourceManager.GetString("N", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Recherche une chaîne localisée semblable à Press any key to continue....
    '''</summary>
    Friend Shared ReadOnly Property presstocont() As String
        Get
            Return ResourceManager.GetString("presstocont", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Recherche une chaîne localisée semblable à Restarting service {0}....
    '''</summary>
    Friend Shared ReadOnly Property srvreboot() As String
        Get
            Return ResourceManager.GetString("srvreboot", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Recherche une chaîne localisée semblable à Stopping service {0}....
    '''</summary>
    Friend Shared ReadOnly Property srvstop() As String
        Get
            Return ResourceManager.GetString("srvstop", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Recherche une chaîne localisée semblable à UTC.
    '''</summary>
    Friend Shared ReadOnly Property UTC() As String
        Get
            Return ResourceManager.GetString("UTC", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Recherche une chaîne localisée semblable à Y.
    '''</summary>
    Friend Shared ReadOnly Property Y() As String
        Get
            Return ResourceManager.GetString("Y", resourceCulture)
        End Get
    End Property
End Class
