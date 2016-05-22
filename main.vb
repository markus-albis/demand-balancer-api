Imports Microsoft.Owin.Hosting
Module Main

    Sub Main(args As String())

        ' Specify the URI to use for the local host:
        Dim baseUri As String = "http://localhost:9090"
        Console.WriteLine("Starting web Server...")
        WebApp.Start(Of Startup)(baseUri)
        Console.WriteLine("Server running at {0} - press Enter to quit. ", baseUri)
        Console.ReadLine()

    End Sub

End Module
