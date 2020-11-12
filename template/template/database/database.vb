Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class database
    Private _MSQLConnection As MySqlConnection
    Private _MysqlCommand As MySqlCommand

    Public Function GetMSQLConnection() As MySqlConnection
        Return _MSQLConnection
    End Function

    Public Sub SetMSQLConnection(Value As MySqlConnection)
        _MSQLConnection = Value
    End Sub

    Public Function GetMysqlCommand() As MySqlCommand
        Return _MysqlCommand
    End Function

    Public Sub SetMysqlCommand(Value As MySqlCommand)
        _MysqlCommand = Value
    End Sub

    Public Property Host As String = "localhost"
    Public Property User As String = "root"
    Public Property Pass As String = ""
    Public Property Port As String = "3306"
    Public Property DatabaseName As String = "DatabaseName"

End Class
