Imports GMap.NET
Imports GMap.NET.MapProviders
Imports GMap.NET.WindowsForms
Imports GMap.NET.WindowsForms.Markers
Public Class GPS
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GMapControl1.MapProvider = GoogleMapProvider.Instance
        GMaps.Instance.Mode = AccessMode.ServerAndCache
        GMapControl1.MapProvider = GoogleHybridMapProvider.Instance
        GMapControl1.Position = New GMap.NET.PointLatLng(TextBox1.Text.Trim(), TextBox2.Text.Trim())
        GMapControl1.ShowCenter = False

        Dim markers As GMapOverlay = New GMapOverlay("markers")
        Dim marker As GMapMarker = New GMarkerGoogle(New PointLatLng(TextBox1.Text.Trim(), TextBox2.Text.Trim()), GMarkerGoogleType.red)
        markers.Markers.Add(marker)
        GMapControl1.Overlays.Add(markers)

        GMapControl1.MinZoom = 5
        GMapControl1.MaxZoom = 100
        GMapControl1.Zoom = 20
        marker.ToolTipMode = MarkerTooltipMode.OnMouseOver

    End Sub

    Private Sub GMapControl1_Load(sender As Object, e As EventArgs) Handles GMapControl1.Load

    End Sub
End Class