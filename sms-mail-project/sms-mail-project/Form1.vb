﻿Imports System.Net.Mail


Public Class Form1
    ''' <summary>
    ''' An object that converts RTF to HTML
    ''' </summary>
    ''' <remarks>
    '''   Completed: 11/02/2006
    '''   Author: George H. Slaterpryce III
    '''   Modifications: none
    '''   *************************************************************************
    '''   *************************************************************************
    '''   License: This code is free to use in private or commercial 
    '''   applications, re-distribution of this code is allowed in whole 
    '''   or in part so long as this header remains intact. All modifications 
    '''   and further development to this code should be indicated by adding the 
    '''   name of the author and the modifications/improvements under the 
    '''   "Modifications:" section.
    '''   Modification Listings should be in the format of.
    '''   (#) Description of modification (Name, Date)
    '''   *************************************************************************
    '''   *************************************************************************
    ''' </remarks>
    Public Class RTFtoHTML

#Region "Private Members"

        ' A RichTextBox control to use to help with parsing.
        Private _rtfSource As New System.Windows.Forms.RichTextBox

#End Region

#Region "Read/Write Properties"

        ''' <summary>
        ''' Returns/Sets The RTF formatted text to parse
        ''' </summary>
        Public Property rtf() As String
            Get
                Return _rtfSource.Rtf
            End Get
            Set(ByVal value As String)
                _rtfSource.Rtf = value
            End Set
        End Property

#End Region

#Region "ReadOnly Properties"

        ''' <summary>
        ''' Returns the HTML code for the provided RTF
        ''' </summary>
        Public ReadOnly Property html() As String
            Get
                Return GetHtml()
            End Get
        End Property

#End Region

#Region "Private Functions"

        ''' <summary>
        ''' Returns an HTML Formated Color string for the style from a system.drawing.color
        ''' </summary>
        ''' <param name="clr">The color you wish to convert</param>
        Private Function HtmlColorFromColor(ByRef clr As System.Drawing.Color) As String
            Dim strReturn As String = ""
            If clr.IsNamedColor Then
                strReturn = clr.Name.ToLower
            Else
                strReturn = clr.Name
                If strReturn.Length > 6 Then
                    strReturn = strReturn.Substring(strReturn.Length - 6, 6)
                End If
                strReturn = "#" & strReturn
            End If
            Return strReturn
        End Function

        ''' <summary>
        ''' Provides the font style per given font
        ''' </summary>
        ''' <param name="fnt">The font you wish to convert</param>
        Private Function HtmlFontStyleFromFont(ByRef fnt As System.Drawing.Font) As String
            Dim strReturn As String = ""
            'style
            If fnt.Italic Then
                strReturn &= "italic "
            Else
                strReturn &= "normal "
            End If
            'variant
            strReturn &= "normal "
            'weight
            If fnt.Bold Then
                strReturn &= "bold "
            Else
                strReturn &= "normal "
            End If
            'size
            strReturn &= fnt.SizeInPoints & "pt/normal "
            'family
            strReturn &= fnt.FontFamily.Name
            Return strReturn
        End Function

        ''' <summary>
        ''' Parses the given rich text and returns the html.
        ''' </summary>
        Private Function GetHtml() As String
            Dim strReturn As String = "<div>"
            Dim clrForeColor As System.Drawing.Color = Color.Black
            Dim clrBackColor As System.Drawing.Color = Color.Black
            Dim fntCurrentFont As System.Drawing.Font = _rtfSource.Font
            Dim altCurrent As System.Windows.Forms.HorizontalAlignment = HorizontalAlignment.Left
            Dim intPos As Integer = 0
            For intPos = 0 To _rtfSource.Text.Length - 1
                _rtfSource.Select(intPos, 1)
                'Forecolor
                If intPos = 0 Then
                    strReturn &= "<span style=""color:" & HtmlColorFromColor(_rtfSource.SelectionColor) & """>"
                    clrForeColor = _rtfSource.SelectionColor
                Else
                    If _rtfSource.SelectionColor <> clrForeColor Then
                        strReturn &= "</span>"
                        strReturn &= "<span style=""color:" & HtmlColorFromColor(_rtfSource.SelectionColor) & """>"
                        clrForeColor = _rtfSource.SelectionColor
                    End If
                End If
                'Background color
                If intPos = 0 Then
                    strReturn &= "<span style=""background-color:" & HtmlColorFromColor(_rtfSource.SelectionBackColor) & """>"
                    clrBackColor = _rtfSource.SelectionBackColor
                Else
                    If _rtfSource.SelectionBackColor <> clrBackColor Then
                        strReturn &= "</span>"
                        strReturn &= "<span style=""background-color:" & HtmlColorFromColor(_rtfSource.SelectionBackColor) & """>"
                        clrBackColor = _rtfSource.SelectionBackColor
                    End If
                End If
                'Font
                If intPos = 0 Then
                    strReturn &= "<span style=""font:" & HtmlFontStyleFromFont(_rtfSource.SelectionFont) & """>"
                    fntCurrentFont = _rtfSource.SelectionFont
                Else
                    If _rtfSource.SelectionFont.GetHashCode <> fntCurrentFont.GetHashCode Then
                        strReturn &= "</span>"
                        strReturn &= "<span style=""font:" & HtmlFontStyleFromFont(_rtfSource.SelectionFont) & """>"
                        fntCurrentFont = _rtfSource.SelectionFont
                    End If
                End If
                'Alignment
                If intPos = 0 Then
                    strReturn &= "<p style=""text-align:" & _rtfSource.SelectionAlignment.ToString & """>"
                    altCurrent = _rtfSource.SelectionAlignment
                Else
                    If _rtfSource.SelectionAlignment <> altCurrent Then
                        strReturn &= "</p>"
                        strReturn &= "<p style=""text-align:" & _rtfSource.SelectionAlignment.ToString & """>"
                        altCurrent = _rtfSource.SelectionAlignment
                    End If
                End If
                strReturn &= _rtfSource.Text.Substring(intPos, 1)
            Next
            'close all the spans
            strReturn &= "</span>"
            strReturn &= "</span>"
            strReturn &= "</span>"
            strReturn &= "</p>"
            strReturn &= "</div>"
            strReturn = strReturn.Replace(Convert.ToChar(10), "<br />")
            Return strReturn
        End Function

#End Region

    End Class

    'public variables, used at multiple forms
    Public selectemailgroup As String
    Public selectemail As String
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click

        Dim answer As DialogResult
        answer = MessageBox.Show("Are you sure you want to exit?", "Form 1", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If answer = vbYes Then
            Application.Exit()
        End If
    End Sub



    Private Sub NewMessageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewMessageToolStripMenuItem.Click

        Dim newmsg As NewMessage
        newmsg = New NewMessage()
        newmsg.Show()
        newmsg.Location = New Point(Me.Left + (Me.Width / 2 - newmsg.Width / 2), Me.Top + (Me.Height / 2 - newmsg.Height / 2))


    End Sub

    Private Sub ManagerAccountToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManagerAccountToolStripMenuItem.Click

        Dim account_manager As Account_Manager
        account_manager = New Account_Manager()
        account_manager.StartPosition = FormStartPosition.CenterParent
        account_manager.ShowDialog()
        account_manager = Nothing

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ShowEmailGroupsForm.Show()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SMSAccountManager_menu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SMSAccountManager_menu.Click

        Dim sms_account_manager As SMS_Account_Manager
        sms_account_manager = New SMS_Account_Manager()
        sms_account_manager.StartPosition = FormStartPosition.CenterParent
        sms_account_manager.ShowDialog()
        sms_account_manager = Nothing

    End Sub
End Class
