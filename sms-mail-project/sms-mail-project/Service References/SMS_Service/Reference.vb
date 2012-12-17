﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.5420
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace SMS_Service
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute([Namespace]:="http://j2ee.netbeans.org/wsdl/sms", ConfigurationName:="SMS_Service.smsPortType")>  _
    Public Interface smsPortType
        
        'CODEGEN: Parameter 'to' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlArrayAttribute'.
        <System.ServiceModel.OperationContractAttribute(Action:="", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute()>  _
        Function send(ByVal request As SMS_Service.input1) As <System.ServiceModel.MessageParameterAttribute(Name:="id")> SMS_Service.output1
        
        <System.ServiceModel.OperationContractAttribute(Action:="", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(Style:=System.ServiceModel.OperationFormatStyle.Rpc)>  _
        Function query(ByVal username As String, ByVal password As String, ByVal message_id As String, ByVal recipient As String) As <System.ServiceModel.MessageParameterAttribute(Name:="status")> String
        
        'CODEGEN: Parameter 'status' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlArrayAttribute'.
        <System.ServiceModel.OperationContractAttribute(Action:="", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute()>  _
        Function multiple_query(ByVal request As SMS_Service.input3) As <System.ServiceModel.MessageParameterAttribute(Name:="status")> SMS_Service.output3
        
        <System.ServiceModel.OperationContractAttribute(Action:="", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(Style:=System.ServiceModel.OperationFormatStyle.Rpc)>  _
        Function credits(ByVal username As String, ByVal password As String) As <System.ServiceModel.MessageParameterAttribute(Name:="credits")> Decimal
        
        <System.ServiceModel.OperationContractAttribute(Action:="", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(Style:=System.ServiceModel.OperationFormatStyle.Rpc)>  _
        Function save_contact(ByVal username As String, ByVal password As String, ByVal name As String, ByVal surname As String, ByVal mobile As String, ByVal comments As String, ByVal extrafields As String) As <System.ServiceModel.MessageParameterAttribute(Name:="saved")> Boolean
        
        <System.ServiceModel.OperationContractAttribute(Action:="", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(Style:=System.ServiceModel.OperationFormatStyle.Rpc)>  _
        Function delete_contact(ByVal username As String, ByVal password As String, ByVal mobile As String) As <System.ServiceModel.MessageParameterAttribute(Name:="deleted")> Boolean
        
        <System.ServiceModel.OperationContractAttribute(Action:="", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(Style:=System.ServiceModel.OperationFormatStyle.Rpc)>  _
        Function delete_message(ByVal username As String, ByVal password As String, ByVal message_id As String) As <System.ServiceModel.MessageParameterAttribute(Name:="deleted")> Boolean
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0"),  _
     System.ServiceModel.MessageContractAttribute(WrapperName:="send", WrapperNamespace:="http://j2ee.netbeans.org/wsdl/sms", IsWrapped:=true)>  _
    Partial Public Class input1
        
        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="", Order:=0)>  _
        Public username As String
        
        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="", Order:=1)>  _
        Public password As String
        
        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="", Order:=2)>  _
        Public from As String
        
        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="", Order:=3),  _
         System.Xml.Serialization.XmlArrayAttribute(),  _
         System.Xml.Serialization.XmlArrayItemAttribute("recipients", Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable:=false)>  _
        Public [to]() As String
        
        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="", Order:=4)>  _
        Public text As String
        
        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="", Order:=5)>  _
        Public coding As String
        
        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="", Order:=6)>  _
        Public flash As Boolean
        
        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="", Order:=7)>  _
        Public schedule As String
        
        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="", Order:=8)>  _
        Public dlrUrl As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal username As String, ByVal password As String, ByVal from As String, ByVal [to]() As String, ByVal text As String, ByVal coding As String, ByVal flash As Boolean, ByVal schedule As String, ByVal dlrUrl As String)
            MyBase.New
            Me.username = username
            Me.password = password
            Me.from = from
            Me.[to] = [to]
            Me.text = text
            Me.coding = coding
            Me.flash = flash
            Me.schedule = schedule
            Me.dlrUrl = dlrUrl
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0"),  _
     System.ServiceModel.MessageContractAttribute(WrapperName:="sendResponse", WrapperNamespace:="http://j2ee.netbeans.org/wsdl/sms", IsWrapped:=true)>  _
    Partial Public Class output1
        
        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="", Order:=0)>  _
        Public id As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal id As String)
            MyBase.New
            Me.id = id
        End Sub
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5420"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://j2ee.netbeans.org/wsdl/sms")>  _
    Partial Public Class recipientStatus
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged
        
        Private recipientField As String
        
        Private statusField As String
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=0)>  _
        Public Property recipient() As String
            Get
                Return Me.recipientField
            End Get
            Set
                Me.recipientField = value
                Me.RaisePropertyChanged("recipient")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=1)>  _
        Public Property status() As String
            Get
                Return Me.statusField
            End Get
            Set
                Me.statusField = value
                Me.RaisePropertyChanged("status")
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0"),  _
     System.ServiceModel.MessageContractAttribute(WrapperName:="multiple_query", WrapperNamespace:="http://j2ee.netbeans.org/wsdl/sms", IsWrapped:=true)>  _
    Partial Public Class input3
        
        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="", Order:=0)>  _
        Public username As String
        
        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="", Order:=1)>  _
        Public password As String
        
        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="", Order:=2)>  _
        Public message_id As String
        
        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="", Order:=3),  _
         System.Xml.Serialization.XmlArrayAttribute(),  _
         System.Xml.Serialization.XmlArrayItemAttribute("recipients", Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable:=false)>  _
        Public recipients() As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal username As String, ByVal password As String, ByVal message_id As String, ByVal recipients() As String)
            MyBase.New
            Me.username = username
            Me.password = password
            Me.message_id = message_id
            Me.recipients = recipients
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0"),  _
     System.ServiceModel.MessageContractAttribute(WrapperName:="multiple_queryResponse", WrapperNamespace:="http://j2ee.netbeans.org/wsdl/sms", IsWrapped:=true)>  _
    Partial Public Class output3
        
        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="", Order:=0),  _
         System.Xml.Serialization.XmlArrayAttribute(),  _
         System.Xml.Serialization.XmlArrayItemAttribute("data", Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable:=false)>  _
        Public status() As recipientStatus
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal status() As recipientStatus)
            MyBase.New
            Me.status = status
        End Sub
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")>  _
    Public Interface smsPortTypeChannel
        Inherits SMS_Service.smsPortType, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")>  _
    Partial Public Class smsPortTypeClient
        Inherits System.ServiceModel.ClientBase(Of SMS_Service.smsPortType)
        Implements SMS_Service.smsPortType
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String)
            MyBase.New(endpointConfigurationName)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(binding, remoteAddress)
        End Sub
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function SMS_Service_smsPortType_send(ByVal request As SMS_Service.input1) As SMS_Service.output1 Implements SMS_Service.smsPortType.send
            Return MyBase.Channel.send(request)
        End Function
        
        Public Function send(ByVal username As String, ByVal password As String, ByVal from As String, ByVal [to]() As String, ByVal text As String, ByVal coding As String, ByVal flash As Boolean, ByVal schedule As String, ByVal dlrUrl As String) As String
            Dim inValue As SMS_Service.input1 = New SMS_Service.input1
            inValue.username = username
            inValue.password = password
            inValue.from = from
            inValue.[to] = [to]
            inValue.text = text
            inValue.coding = coding
            inValue.flash = flash
            inValue.schedule = schedule
            inValue.dlrUrl = dlrUrl
            Dim retVal As SMS_Service.output1 = CType(Me,SMS_Service.smsPortType).send(inValue)
            Return retVal.id
        End Function
        
        Public Function query(ByVal username As String, ByVal password As String, ByVal message_id As String, ByVal recipient As String) As String Implements SMS_Service.smsPortType.query
            Return MyBase.Channel.query(username, password, message_id, recipient)
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function SMS_Service_smsPortType_multiple_query(ByVal request As SMS_Service.input3) As SMS_Service.output3 Implements SMS_Service.smsPortType.multiple_query
            Return MyBase.Channel.multiple_query(request)
        End Function
        
        Public Function multiple_query(ByVal username As String, ByVal password As String, ByVal message_id As String, ByVal recipients() As String) As recipientStatus()
            Dim inValue As SMS_Service.input3 = New SMS_Service.input3
            inValue.username = username
            inValue.password = password
            inValue.message_id = message_id
            inValue.recipients = recipients
            Dim retVal As SMS_Service.output3 = CType(Me,SMS_Service.smsPortType).multiple_query(inValue)
            Return retVal.status
        End Function
        
        Public Function credits(ByVal username As String, ByVal password As String) As Decimal Implements SMS_Service.smsPortType.credits
            Return MyBase.Channel.credits(username, password)
        End Function
        
        Public Function save_contact(ByVal username As String, ByVal password As String, ByVal name As String, ByVal surname As String, ByVal mobile As String, ByVal comments As String, ByVal extrafields As String) As Boolean Implements SMS_Service.smsPortType.save_contact
            Return MyBase.Channel.save_contact(username, password, name, surname, mobile, comments, extrafields)
        End Function
        
        Public Function delete_contact(ByVal username As String, ByVal password As String, ByVal mobile As String) As Boolean Implements SMS_Service.smsPortType.delete_contact
            Return MyBase.Channel.delete_contact(username, password, mobile)
        End Function
        
        Public Function delete_message(ByVal username As String, ByVal password As String, ByVal message_id As String) As Boolean Implements SMS_Service.smsPortType.delete_message
            Return MyBase.Channel.delete_message(username, password, message_id)
        End Function
    End Class
End Namespace