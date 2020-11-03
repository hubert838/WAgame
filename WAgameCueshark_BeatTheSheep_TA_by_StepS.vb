Imports System 'Domyślnie szukaj elementów w System
Imports System.Windows.Forms 'a także w System.Windows.Forms

Public Class PrzykladoweOkno
Inherits Form

   'Konstruktor z dziedziczeniem konstruktora macierzystego
   Sub New()
       MyBase.New()
   End Sub

   Public Shared Sub Main()
       Application.Run( New PrzykladoweOkno() );
   End Sub
End Class
